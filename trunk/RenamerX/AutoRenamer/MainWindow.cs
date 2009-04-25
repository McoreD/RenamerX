using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;
using ZSS.Forms;
using System.Collections.Specialized;
using System.Runtime.InteropServices;

namespace RenamerX
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                lbDirs.Items.Add(@"E:\Diziler\Lost\Season " + i); //@"S:\TV\LOST\Season 0" + i);"
            }
            RefreshLists("Lost");
        }

        public void RefreshLists(string showName)
        {
            List<string> list = new List<string>();
            foreach (string str in lbDirs.Items)
            {
                list.Add(str);
            }
            if (list.Count > 0)
            {
                RefreshLists(showName, list);
            }
        }

        public void RefreshLists(string showName, string dir)
        {
            RefreshLists(showName, new List<string> { dir });
        }

        public void RefreshLists(string showName, List<string> dirs)
        {
            treeView1.Nodes.Clear();
            treeView2.Nodes.Clear();
            Show show = FindShow(showName);
            for (int i = 0; i < dirs.Count; i++)
            {
                if (Directory.Exists(dirs[i]))
                {
                    treeView1.Nodes.Add(GetLastPart(dirs[i]));
                    treeView2.Nodes.Add(GetLastPart(dirs[i]));
                    foreach (string file in Directory.GetFiles(dirs[i]))
                    {
                        string[] files = new string[4];
                        files[0] = GetLastPart(file); //Default file name
                        files[1] = file; //Default full file path
                        if (CheckFile(files[1], txtFileFilter.Text))
                        {
                            files[2] = Reformat(show, files[0]); //New file name
                            files[3] = ChangeFilePath(files[1], files[2]); //New full file path
                            TreeNode tn = treeView1.Nodes[i].Nodes.Add(files[0]);
                            tn.Tag = files;
                            tn.ToolTipText = files[1];
                            tn = treeView2.Nodes[i].Nodes.Add(files[2]);
                            tn.Tag = files;
                            tn.ToolTipText = files[3];
                        }
                    }
                }
            }
            treeView1.ExpandAll();
            treeView2.ExpandAll();
        }

        public string ChangeFilePath(string filePath, string fileName)
        {
            return filePath.Substring(0, filePath.LastIndexOf("\\") + 1) + fileName;
        }

        public string GetLastPart(string dir)
        {
            return dir.Remove(0, dir.LastIndexOf("\\") + 1);
        }

        public static bool CheckFile(string file, string pattern)
        {
            pattern = "^" + Regex.Escape(pattern).Replace("\\*", ".*").Replace("\\+", ".+").Replace("\\?", ".?").
                Replace("\\|", "|") + "$";
            return Regex.IsMatch(file, pattern);
        }

        public Show FindShow(string showName)
        {
            Show seasons = new Show(showName);
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("http://www.tvrage.com/feeds/episode_list.php?show=" + showName);
                XmlNode xmlNode = xmlDoc.DocumentElement.SelectSingleNode("Episodelist");

                foreach (XmlNode childs in xmlNode.ChildNodes) //Seasons
                {
                    Season season = new Season();
                    if (childs.Attributes.Count > 0)
                    {
                        season.SeasonNumber = childs.Attributes[0].Value.ToInt();
                    }
                    foreach (XmlNode childs2 in childs.ChildNodes) //Episodes
                    {
                        season.Episodes.Add(new Episode(childs2));
                    }
                    seasons.Seasons.Add(season);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return seasons;
        }

        public string Reformat(Show show, string filename)
        {
            if (show != null)
            {
                try
                {
                    string pattern = @"s(?<Season>\d+)e(?<Episode>\d+)|(?<Season>\d{2,})x(?<Episode>\d{2,})|(?<Season>\d+)(?<Episode>\d{2,})";
                    Match result = Regex.Match(filename, pattern, RegexOptions.IgnoreCase);
                    string s = result.Groups["Season"].Value;
                    string e = result.Groups["Episode"].Value;
                    if (s.ToInt() > 0 && e.ToInt() > 0)
                    {
                        pattern = txtNameFormat.Text;
                        string ext = filename.Remove(0, filename.LastIndexOf('.'));
                        return pattern.Replace("$N", show.ShowName).Replace("$S", s).Replace("$E", e).
                            Replace("$T", show.FindSeason(s.ToInt()).FindEpisode(e.ToInt()).Title) + ext;
                    }
                }
                catch { }
            }
            return filename;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputBox ib = new InputBox("Browse for TV Show...", "");
            ib.ShowDialog();
            if (ib.DialogResult == DialogResult.OK)
            {
                RefreshLists(ib.ShowName, ib.ShowLocation);
            }
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btnDirAdd_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                lbDirs.Items.Add(fbd.SelectedPath);
            }
        }

        private void btnDirRemove_Click(object sender, EventArgs e)
        {
            if (lbDirs.SelectedIndex > -1)
            {
                lbDirs.Items.RemoveAt(lbDirs.SelectedIndex);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtShowName.Text))
            {
                RefreshLists(txtShowName.Text);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ChangeNames();
        }

        public void ChangeNames()
        {
            foreach (TreeNode parents in treeView2.Nodes)
            {
                foreach (TreeNode childs in parents.Nodes)
                {
                    string[] files = (string[])childs.Tag;
                    try
                    {
                        File.Move(files[1], files[3]);
                    }
                    catch (ArgumentException ex)
                    {
                        if (!cbShowErrors.Checked) MessageBox.Show(ex.Message + "\n" + files[3]);
                    }
                }
            }
        }

        //private void treeView1_Scroll(object sender, ScrollEventArgs e)
        //{
        //    if (e.Type != ScrollEventType.EndScroll)
        //    {
        //        treeView2.VScrollPos = e.NewValue;
        //    }
        //}
    }

    public static class Extensions
    {
        public static int ToInt(this string str)
        {
            return Convert.ToInt32(str);
        }
    }

    public class Show : IEnumerable
    {
        public string ShowName;
        public List<Season> Seasons = new List<Season>();

        public Show(string showName)
        {
            ShowName = showName;
        }

        public Season FindSeason(int number)
        {
            foreach (Season season in Seasons)
            {
                if (season.SeasonNumber == number)
                {
                    return season;
                }
            }
            return null;
        }

        public IEnumerator GetEnumerator()
        {
            return Seasons.GetEnumerator();
        }
    }

    public class Season : IEnumerable
    {
        public int SeasonNumber;
        public List<Episode> Episodes = new List<Episode>();

        public Season() { }

        public Season(int seasonNumber)
        {
            SeasonNumber = seasonNumber;
        }

        public Episode FindEpisode(int number)
        {
            foreach (Episode episode in Episodes)
            {
                if (episode.EpisodeNumber.ToInt() == number)
                {
                    return episode;
                }
            }
            return null;
        }

        public IEnumerator GetEnumerator()
        {
            return Episodes.GetEnumerator();
        }
    }

    public class Episode
    {
        public string EpisodeNumber;
        public string SeasonEpisodeNumber;
        public string Title;

        public Episode(string episodeNumber, string seasonEpisodeNumber, string title)
        {
            EpisodeNumber = episodeNumber;
            SeasonEpisodeNumber = seasonEpisodeNumber;
            Title = title;
        }

        public Episode(XmlNode xmlNode)
        {
            XmlNode node;
            node = xmlNode.SelectSingleNode("seasonnum");
            if (node != null)
            {
                EpisodeNumber = node.InnerText;
            }
            node = xmlNode.SelectSingleNode("epnum");
            if (node != null)
            {
                SeasonEpisodeNumber = node.InnerText;
            }
            node = xmlNode.SelectSingleNode("title");
            if (node != null)
            {
                Title = node.InnerText;
            }
        }
    }

    public class TreeViewScroll : TreeView
    {
        private const int WM_HSCROLL = 0x114;
        private const int WM_VSCROLL = 0x115;
        private const int SB_HORZ = 0;
        private const int SB_VERT = 1;

        public event ScrollEventHandler Scroll;

        [DllImport("user32.dll")]
        public static extern int GetScrollPos(IntPtr hWnd, int nBar);

        [DllImport("user32.dll")]
        public static extern int SetScrollPos(IntPtr hWnd, int nBar, int nPos, bool bRedraw);

        public int HScrollPos
        {
            get { return GetScrollPos(Handle, SB_HORZ); }
            set { SetScrollPos(Handle, SB_HORZ, value, true); }
        }

        public int VScrollPos
        {
            get { return GetScrollPos(Handle, SB_VERT); }
            set { SetScrollPos(Handle, SB_VERT, value, true); }
        }

        //protected override void WndProc(ref Message m)
        //{
        //    if (Scroll != null && m.Msg == WM_HSCROLL || m.Msg == WM_VSCROLL)
        //    {
        //        ScrollEventType t = (ScrollEventType)Enum.Parse(typeof(ScrollEventType),
        //            (m.WParam.ToInt32() & 65535).ToString());
        //        Scroll(m.HWnd, new ScrollEventArgs(t, ((int)(m.WParam.ToInt64() >> 16)) & 255));
        //    }
        //    base.WndProc(ref m);
        //}
    }
}
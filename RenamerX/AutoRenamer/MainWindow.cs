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
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using RenamerX.Properties;

namespace RenamerX
{
    public partial class MainWindow : Form
    {
        public List<List<ShowInfo>> ShowList = new List<List<ShowInfo>>();
        public List<Show> Shows = new List<Show>();

        public MainWindow()
        {
            InitializeComponent();
        }

        #region Form Events

        private void Form1_Load(object sender, EventArgs e)
        {
            //for (int i = 1; i <= 5; i++)
            //{
            //    AddShow("Lost", @"E:\TV\Lost\Season " + i);
            //}
            //for (int i = 1; i <= 2; i++)
            //{
            //    AddShow("Heroes", @"E:\TV\Heroes\Season " + i);
            //}
            //AddShow("Knight Rider 2008", @"E:\TV\Knight Rider 2008\Knight Rider 2008");
            RefreshLists();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowseTvShow();
        }

        private void BrowseTvShow()
        {
            InputBox ib = new InputBox("Browse for TV Show...", "");
            ib.ShowDialog();
            if (ib.DialogResult == DialogResult.OK)
            {
                AddShow(ib.ShowName, ib.ShowLocation);
            }
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btnDirAdd_Click(object sender, EventArgs e)
        {
            BrowseTvShow();
        }

        private void btnDirRemove_Click(object sender, EventArgs e)
        {
            if (lvShows.SelectedItems.Count > -1)
            {
                lvShows.Items.RemoveAt(lvShows.SelectedIndices[0]);
            }
        }

        private void btnDirClear_Click(object sender, EventArgs e)
        {
            lvShows.Items.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowList = new List<List<ShowInfo>>();
            RefreshLists();
            RefreshSelected();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you really want to change file names?", this.Text, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                txtConsole.AppendText("Started.\r\n");
                ChangeNames();
                txtConsole.AppendText("Finished.\r\n");
            }
        }

        #endregion

        private void AddShow(string showName, string showFolder)
        {
            string[] info = { showName, showFolder };
            ListViewItem lvi = lvShows.Items.Add(showName + ": " + GetLastPart(showFolder));
            lvi.Tag = info;
        }

        public void RefreshLists()
        {
            lvList1.Items.Clear();
            lvList2.Items.Clear();
            for (int i = 0; i < lvShows.Items.Count; i++)
            {
                string[] info = (string[])lvShows.Items[i].Tag;
                Show show = new Show("");
                foreach (Show shows in Shows)
                {
                    if (shows.Contains(info[0]))
                    {
                        show = shows;
                        break;
                    }
                }
                if (string.IsNullOrEmpty(show.ShowName))
                {
                    show = FindShow(info[0]);
                    Shows.Add(show);
                }
                if (Directory.Exists(info[1]))
                {
                    List<ShowInfo> showInfos = new List<ShowInfo>();
                    foreach (string file in Directory.GetFiles(info[1]))
                    {
                        if (CheckFile(file, txtFileFilter.Text))
                        {
                            ShowInfo showInfo = new ShowInfo();
                            showInfo.DefaultFileName = GetLastPart(file);
                            showInfo.DefaultFilePath = file;
                            showInfo.NewFileName = Reformat(show, showInfo.DefaultFileName);
                            showInfo.NewFilePath = ChangeFilePath(showInfo.DefaultFilePath, showInfo.NewFileName);
                            showInfos.Add(showInfo);
                        }
                    }
                    ShowList.Add(showInfos);
                }
            }
        }

        public static string ChangeFilePath(string filePath, string fileName)
        {
            return filePath.Substring(0, filePath.LastIndexOf("\\") + 1) + fileName;
        }

        public static string GetLastPart(string dir)
        {
            return dir.Remove(0, dir.LastIndexOf("\\") + 1);
        }

        public static bool CheckFile(string file, string pattern)
        {
            if (string.IsNullOrEmpty(pattern)) return true;
            pattern = "^" + Regex.Escape(pattern).Replace("\\*", ".*").Replace("\\+", ".+").Replace("\\?", ".?").
                Replace("\\|", "|") + "$";
            return Regex.IsMatch(file, pattern, RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
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
                    filename.Replace(show.ShowName, "");
                    Match result = Regex.Match(filename, pattern, RegexOptions.IgnoreCase | RegexOptions.RightToLeft | RegexOptions.CultureInvariant);
                    int season = result.Groups["Season"].Value.ToInt();
                    int episode = result.Groups["Episode"].Value.ToInt();
                    if (season > 0 && episode > 0)
                    {
                        pattern = txtNameFormat.Text;
                        string extension = filename.Remove(0, filename.LastIndexOf('.')).ToLowerInvariant();
                        return pattern.Replace("$N", show.ShowName).Replace("$S2", season.ToString("d2")).
                            Replace("$S", season.ToString()).Replace("$E2", episode.ToString("d2")).
                            Replace("$E", episode.ToString()).
                            Replace("$T", show.FindEpisode(season, episode).Title) + extension;
                    }
                }
                catch { }
            }
            return filename;
        }

        public void ChangeNames()
        {
            foreach (List<ShowInfo> showInfos in ShowList)
            {
                foreach (ShowInfo showInfo in showInfos)
                {
                    try
                    {
                        if (showInfo.DefaultFilePath != showInfo.NewFilePath)
                        {
                            File.Move(showInfo.DefaultFilePath, showInfo.NewFilePath);
                            txtConsole.AppendText("Moved: " + showInfo.NewFilePath + "\r\n");
                        }
                    }
                    catch (Exception ex)
                    {
                        if (!cbShowErrors.Checked) MessageBox.Show(ex.Message + "\n" + showInfo.NewFilePath);
                        txtConsole.AppendText("Error: " + ex.Message + " = " + showInfo.NewFilePath + "\r\n");
                    }
                }
            }
        }

        private void lvShows_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshSelected();
        }

        private void RefreshSelected()
        {
            if (lvShows.SelectedItems.Count > 0 && ShowList.Count > 0)
            {
                if (ShowList.Count >= lvShows.Items.Count)
                {
                    lvList1.Items.Clear();
                    lvList2.Items.Clear();

                    foreach (ShowInfo showInfo in ShowList[lvShows.SelectedIndices[0]])
                    {
                        lvList1.Items.Add(showInfo.DefaultFilePath);
                        lvList2.Items.Add(showInfo.NewFilePath);
                    }

                }

            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
        }
    }

    public static class Extensions
    {
        public static int ToInt(this string str)
        {
            return Convert.ToInt32(str);
        }
    }

    public struct ShowInfo
    {
        public string DefaultFileName;
        public string DefaultFilePath;
        public string NewFileName;
        public string NewFilePath;
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

        public Episode FindEpisode(int season, int episode)
        {
            return FindSeason(season).FindEpisode(episode);
        }

        public IEnumerator GetEnumerator()
        {
            return Seasons.GetEnumerator();
        }

        public bool Contains(string showName)
        {
            return this.ShowName == showName;
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
}
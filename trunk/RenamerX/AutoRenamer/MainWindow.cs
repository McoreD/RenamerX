﻿using System;
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
        public List<Show> Shows = new List<Show>();

        public MainWindow()
        {
            InitializeComponent();
        }

        #region Form Events

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadJaex();
            ResizeListviewColumns();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowseTVShow();
        }

        private void BrowseTVShow()
        {
            InputBox ib = new InputBox("Browse for TV Show...", "");
            if (ib.ShowDialog() == DialogResult.OK)
            {
                AddShow(ib.ShowName, ib.ShowLocation);
            }
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            ResizeListviewColumns();
            this.Refresh();
        }

        private void btnDirAdd_Click(object sender, EventArgs e)
        {
            BrowseTVShow();
        }

        private void btnDirRemove_Click(object sender, EventArgs e)
        {
            if (lvShows.SelectedItems.Count > 0)
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
            btnRefresh.Enabled = false;
            Application.DoEvents();
            RefreshLists();
            btnRefresh.Enabled = true;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you really want to change file names?", this.Text, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                ConsoleWriteLine("Started.");
                if (ChangeNames())
                {
                    ConsoleWriteLine("Finished.");
                }
                else
                {
                    ConsoleWriteLine("Canceled.");
                }
                RefreshLists();
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
        }

        private void lvShows_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshSelected();
        }

        #endregion

        private void LoadJaex()
        {
            for (int i = 1; i <= 5; i++)
            {
                AddShow("Lost", @"E:\TV\Lost\Season " + i);
            }
            for (int i = 1; i <= 3; i++)
            {
                AddShow("Heroes", @"E:\TV\Heroes\Season " + i);
            }
            AddShow("Fringe", @"E:\TV\Fringe\Season 1");
            //AddShow("Knight Rider 2008", @"C:\Users\PC\Documents\Visual Studio 2008\Projects\RenamerX\AutoRenamer\Testers\Knight Rider 2008 - Season 01\Knight Rider 2008 - Season 01");
        }

        private void AddShow(string showName, string showFolder)
        {
            ShowItem si = new ShowItem(showName, showFolder);
            ListViewItem lvi = lvShows.Items.Add(si.ToString());
            lvi.Checked = true;
            lvi.Tag = si;
        }

        public void RefreshLists()
        {
            lvList.Items.Clear();
            for (int i = 0; i < lvShows.Items.Count; i++)
            {
                ShowItem si = (ShowItem)lvShows.Items[i].Tag;
                Show show = new Show("");
                foreach (Show shows in Shows)
                {
                    if (shows.Contains(si.ShowName))
                    {
                        show = shows;
                        break;
                    }
                }
                if (string.IsNullOrEmpty(show.ShowName))
                {
                    show = FindShow(si.ShowName);
                    Shows.Add(show);
                }
                if (Directory.Exists(si.ShowDirectory))
                {
                    si.ShowInfos.Clear();
                    foreach (string file in Directory.GetFiles(si.ShowDirectory))
                    {
                        if (CheckFile(file, txtFileFilter.Text))
                        {
                            ShowInfo showInfo = new ShowInfo();
                            showInfo.DefaultFileName = GetLastPart(file);
                            showInfo.DefaultFilePath = file;
                            showInfo.NewFileName = Reformat(show, showInfo.DefaultFileName);
                            showInfo.NewFilePath = ChangeFilePath(showInfo.DefaultFilePath, showInfo.NewFileName);
                            si.ShowInfos.Add(showInfo);
                        }
                    }
                }
            }
            RefreshSelected();
            UpdateItemsCount();
        }

        public void UpdateItemsCount()
        {
            int itemcount = 0, itemmaxcount = 0;
            foreach (ListViewItem lvi in lvShows.Items)
            {
                ShowItem showItem = (ShowItem)lvi.Tag;
                foreach (ShowInfo showInfo in showItem.ShowInfos)
                {
                    itemmaxcount++;
                    if (showInfo.DefaultFilePath == showInfo.NewFilePath)
                    {
                        itemcount++;
                    }
                }
            }
            if (itemcount == itemmaxcount)
            {
                lblItemsCount.ForeColor = Color.FromArgb(0, 255, 0);
            }
            else
            {
                lblItemsCount.ForeColor = Color.FromArgb(255 - (int)((float)itemcount / itemmaxcount * 255), 255, 0);
            }
            lblItemsCount.Text = itemcount + " / " + itemmaxcount;
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
                    string pattern = txtRegexpPattern.Text;
                    filename.Replace(show.ShowName, "");
                    Match result = Regex.Match(filename, pattern, RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
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

        public bool ChangeNames()
        {
            for (int i = 0; i < lvShows.Items.Count; i++)
            {
                ListViewItem lvi = lvShows.Items[i];
                if (lvi.Checked)
                {
                    if (cbShowActionMessages.Checked) ConsoleWriteLine("Started: " + lvi.Text);
                    foreach (ShowInfo showInfo in ((ShowItem)lvi.Tag).ShowInfos)
                    {
                        try
                        {
                            if (showInfo.DefaultFilePath != showInfo.NewFilePath)
                            {
                                File.Move(showInfo.DefaultFilePath, showInfo.NewFilePath);
                                ConsoleWriteLine("Renamed: \"" + showInfo.DefaultFilePath + "\" -> \"" + showInfo.NewFilePath + "\"");
                            }
                        }
                        catch (Exception ex)
                        {
                            ConsoleWriteLine("Error: " + ex.Message + " \"" + showInfo.DefaultFilePath + "\" -> \"" + showInfo.NewFilePath + "\"");
                            if (cbShowErrors.Checked)
                            {
                                if (MessageBox.Show(ex.Message + "\n" + showInfo.NewFilePath, this.Text, MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Cancel)
                                {
                                    return false;
                                }
                            }
                        }
                    }
                    if (cbShowActionMessages.Checked) ConsoleWriteLine("Finished: " + lvi.Text);
                }
            }
            return true;
        }

        private void RefreshSelected()
        {
            if (lvShows.SelectedItems.Count > 0)
            {
                lvList.BeginUpdate();
                lvList.Items.Clear();
                foreach (ShowInfo showInfo in ((ShowItem)lvShows.Items[lvShows.SelectedIndices[0]].Tag).ShowInfos)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = showInfo.DefaultFileName;
                    lvi.ToolTipText = showInfo.DefaultFilePath + "\r\n" + showInfo.NewFilePath;
                    lvi.SubItems.Add(showInfo.NewFileName);
                    lvList.Items.Add(lvi);
                }
                ResizeListviewColumns();
                lvList.EndUpdate();
            }
        }

        private void ConsoleWriteLine(string text)
        {
            txtConsole.AppendText(DateTime.Now.ToLongTimeString() + " - " + text + Environment.NewLine);
        }

        private void ResizeListviewColumns()
        {
            lvShows.Columns[0].Width = lvShows.ClientSize.Width;
            lvList.Columns[0].Width = lvList.ClientSize.Width / 2;
            lvList.Columns[1].Width = -2;
        }

        private void lvShows_DragDrop(object sender, DragEventArgs e)
        {


        }

        private void lvShows_DragEnter(object sender, DragEventArgs e)
        {
 
        }

        private void lvShows_DragEnter_1(object sender, DragEventArgs e)
        {
           if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lvShows_DragDrop_1(object sender, DragEventArgs e)
        {
            string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop, true);

            InputBox ib = new InputBox("Enter TV Show Name...", "");
            ib.txtLocation.Enabled = false;
            ib.btnBrowse.Enabled = false;

            if (paths.Length == 1)
            {
                // guess show name as this folder name
                ib.ShowName = Path.GetFileName(paths[0]);
            }
            else if (paths.Length > 1)
            {
                // guess show name as root folder name
                ib.ShowName = Path.GetFileName(Path.GetDirectoryName(paths[0]));
            }

            if (ib.ShowDialog() == DialogResult.OK)
            {
                foreach (string p in paths)
                {
                    if (Directory.Exists(p))
                    {
                        AddShow(ib.ShowName, p);
                    }
                }
            }
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

    public class ShowItem
    {
        public string ShowName;
        public string ShowDirectory;
        public List<ShowInfo> ShowInfos = new List<ShowInfo>();

        public ShowItem(string showName, string showDirectory)
        {
            ShowName = showName;
            ShowDirectory = showDirectory;
        }

        public override string ToString()
        {
            return ShowName + ": " + ShowDirectory.Remove(0, ShowDirectory.LastIndexOf("\\") + 1);
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
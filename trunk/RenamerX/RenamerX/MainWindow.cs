#region License Information (GPL v2)
/*
    RenamerX - Rename your files eXpressly
    Copyright (C) 2009  RenamerX Developers

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
    
    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/
#endregion

using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using RenamerX.Properties;
using System.Diagnostics;
using System.ComponentModel;
using System.Linq;
using System.Xml.Linq;
using TVRageLib;
using TVDBLib;

namespace RenamerX
{
    public partial class MainWindow : Form
    {
        public TVRage tvrage = new TVRage();
        private List<string> ExtractList = new List<string>();
        private bool IsExtracting;
        private BackgroundWorker bwExtract = new BackgroundWorker();
        private Show fakeShow;

        public MainWindow()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            // Rename
            lvShows.Items.Clear();
            foreach (ShowItem si in Program.Settings.ShowsList)
            {
                AddShow(si);
            }
            txtNameFormat.Text = Program.Settings.NameFormat;
            txtRenameFileFilter.Text = Program.Settings.RenameFileFilter;

            // Extract
            txtExtractPath.Text = Program.Settings.ExtractPath;
            txtUnRARPath.Text = Program.Settings.UnRARPath;
            txtExtractFileFilter.Text = Program.Settings.ExtractFileFilter;
            txtExtractFileSizeFilter.Text = Program.Settings.ExtractFileSizeFilter;
            cbSearchSubFolders.Checked = Program.Settings.SearchSubFolders;
            cbExtractOverwrite.Checked = Program.Settings.ExtractOverwrite;
            txtExtractPassword.Text = Program.Settings.ExtractPassword;

            // General Settings
            cbShowHelpTooltips.Checked = Program.Settings.ShowHelpTooltips;
            ttApp.Active = Program.Settings.ShowHelpTooltips;

            // Rename Settings
            txtRegexpPattern.Text = Program.Settings.RegexpPattern;
            cbShowActionMessages.Checked = Program.Settings.ShowActionMessages;
            cbGuessShowName.Checked = Program.Settings.GuessShowName;
            cbReplaceIllegalChars.Checked = Program.Settings.ReplaceIllegalChars;
            txtReplaceIllegalChars.Text = Program.Settings.ReplaceIllegalCharsWith;
            cbReplaceSpaces.Checked = Program.Settings.ReplaceSpaces;
            txtReplaceSpaces.Text = Program.Settings.ReplaceSpacesWith;
            cbShowErrors.Checked = Program.Settings.ShowErrors;

            // Series Info
            txtSeriesName.Text = Program.Settings.LastSeriesName;
            txtSeriesID.Text = Program.Settings.LastSeriesID;

            // Others
            bwExtract.DoWork += new DoWorkEventHandler(ExtractThread);
            bwExtract.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bwExtract.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            bwExtract.WorkerReportsProgress = true;
            bwExtract.WorkerSupportsCancellation = true;
            fakeShow = CreateFakeShow("Show Name", 2, 7, "Episode Title");
            UpdateNameFormatPreview();
            plvSettings.SelectedObject = Program.Settings;
        }

        #region Form Events

        private void MainWindow_Load(object sender, EventArgs e)
        {
            ResizeListviewColumns();
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            ResizeListviewColumns();
            this.Refresh();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Settings.Save();
        }

        #region Rename Tab Events

        private void lvShows_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshSelected();
        }

        private void lvShows_DragEnter(object sender, DragEventArgs e)
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

        private void lvShows_DragDrop(object sender, DragEventArgs e)
        {
            string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop, true);
            string showName = "", showLocation = "";

            if (cbGuessShowName.Checked)
            {
                showName = Path.GetFileName(Path.GetDirectoryName(paths[0]));
            }
            else
            {
                showName = Path.GetFileName(paths[0]);
            }

            if (paths.Length == 1)
            {
                showLocation = paths[0];
                InputBox ib = new InputBox("Enter TV Show Name...", showName, showLocation);
                if (ib.ShowDialog() == DialogResult.OK)
                {
                    AddShow(ib.ShowName, ib.ShowLocation);
                }
            }
            else if (paths.Length > 1)
            {
                InputBox ib = new InputBox("Enter TV Show Name...", showName, showLocation);
                ib.txtShowLocation.Enabled = false;
                ib.btnBrowse.Enabled = false;
                if (ib.ShowDialog() == DialogResult.OK)
                {
                    foreach (string path in paths)
                    {
                        if (Directory.Exists(path))
                        {
                            AddShow(ib.ShowName, path);
                        }
                    }
                }
            }

            SaveShowsList();
        }

        private void txtNameFormat_TextChanged(object sender, EventArgs e)
        {
            Program.Settings.NameFormat = txtNameFormat.Text;
            UpdateNameFormatPreview();
        }

        private void txtRenameFileFilter_TextChanged(object sender, EventArgs e)
        {
            Program.Settings.RenameFileFilter = txtRenameFileFilter.Text;
        }

        private void btnRenameAdd_Click(object sender, EventArgs e)
        {
            InputBox ib = new InputBox("Browse for TV Show...", "", "");
            if (ib.ShowDialog() == DialogResult.OK)
            {
                AddShow(ib.ShowName, ib.ShowLocation);
                SaveShowsList();
            }
        }

        private void btnRenameRemove_Click(object sender, EventArgs e)
        {
            if (lvShows.SelectedIndices.Count > 0)
            {
                lvShows.Items.RemoveAt(lvShows.SelectedIndices[0]);
                SaveShowsList();
            }
        }

        private void btnRenameClear_Click(object sender, EventArgs e)
        {
            lvShows.Items.Clear();
            SaveShowsList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            Application.DoEvents();
            RefreshLists();
            btnRefresh.Enabled = true;
        }

        private void btnRenameAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to rename these files?", this.Text, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                ConsoleWriteLine("Renaming started.");
                if (ChangeNames())
                {
                    ConsoleWriteLine("Renaming finished.");
                }
                else
                {
                    ConsoleWriteLine("Renaming canceled.");
                }
                RefreshLists();
            }
        }

        private void lvList_DoubleClick(object sender, EventArgs e)
        {
            if (lvList.SelectedItems.Count > 0)
            {
                //File rename inputbox
            }
        }

        #endregion

        #region Extract Tab Events

        #region Extract Tab Settings

        private void txtExtractPath_TextChanged(object sender, EventArgs e)
        {
            Program.Settings.ExtractPath = txtExtractPath.Text;
        }

        private void txtUnRARPath_TextChanged(object sender, EventArgs e)
        {
            Program.Settings.UnRARPath = txtUnRARPath.Text;
        }

        private void txtExtractFileFilter_TextChanged(object sender, EventArgs e)
        {
            Program.Settings.ExtractFileFilter = txtExtractFileFilter.Text;
        }

        private void txtExtractFileSizeFilter_TextChanged(object sender, EventArgs e)
        {
            Program.Settings.ExtractFileSizeFilter = txtExtractFileSizeFilter.Text;
        }

        private void cbSearchSubFolders_CheckedChanged(object sender, EventArgs e)
        {
            Program.Settings.SearchSubFolders = cbSearchSubFolders.Checked;
        }

        private void cbExtractOverwrite_CheckedChanged(object sender, EventArgs e)
        {
            Program.Settings.ExtractOverwrite = cbExtractOverwrite.Checked;
        }

        private void txtExtractPassword_TextChanged(object sender, EventArgs e)
        {
            Program.Settings.ExtractPassword = txtExtractPassword.Text;
        }

        private void txtExtractPath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.All;
        }

        private void txtExtractPath_DragDrop(object sender, DragEventArgs e)
        {
            txtExtractPath.Text = ((string[])e.Data.GetData(DataFormats.FileDrop, true))[0];
        }

        #endregion

        private void btnExtractBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (!string.IsNullOrEmpty(txtExtractPath.Text) && Directory.Exists(txtExtractPath.Text))
            {
                fbd.SelectedPath = txtExtractPath.Text;
            }
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtExtractPath.Text = fbd.SelectedPath;
            }
        }

        private void txtUnRARPath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.All;
        }

        private void txtUnRARPath_DragDrop(object sender, DragEventArgs e)
        {
            txtUnRARPath.Text = ((string[])e.Data.GetData(DataFormats.FileDrop, true))[0];
        }

        private void btnUnRARBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (!string.IsNullOrEmpty(txtUnRARPath.Text) && Directory.Exists(Path.GetDirectoryName(txtUnRARPath.Text)))
            {
                ofd.InitialDirectory = txtUnRARPath.Text;
            }
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtUnRARPath.Text = ofd.FileName;
            }
        }

        private void btnExtractAdd_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (!string.IsNullOrEmpty(Program.Settings.LastExtractFolder) && Directory.Exists(Program.Settings.LastExtractFolder))
            {
                fbd.SelectedPath = Program.Settings.LastExtractFolder;
            }
            else if (!string.IsNullOrEmpty(txtExtractPath.Text) && Directory.Exists(txtExtractPath.Text))
            {
                fbd.SelectedPath = txtExtractPath.Text;
            }
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Program.Settings.LastExtractFolder = fbd.SelectedPath;
                try
                {
                    FileSizeFilter filter = ParseFileSizeFilter(txtExtractFileSizeFilter.Text);
                    AddExtractList(fbd.SelectedPath, filter);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnExtractRemove_Click(object sender, EventArgs e)
        {
            if (lvExtractList.SelectedIndices.Count > 0)
            {
                lvExtractList.Items.RemoveAt(lvExtractList.SelectedIndices[0]);
                UpdateExtractFileCount();
            }
        }

        private void btnExtractClear_Click(object sender, EventArgs e)
        {
            lvExtractList.Items.Clear();
            UpdateExtractFileCount();
        }

        private void btnExtractAll_Click(object sender, EventArgs e)
        {
            if (IsExtracting)
            {
                bwExtract.CancelAsync();
                btnExtractAll.Text = "Stopping...";
            }
            else
            {
                if (MessageBox.Show("Are you sure you wish to extract these files?", this.Text, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    if (File.Exists(txtUnRARPath.Text))
                    {
                        btnExtractAll.Enabled = false;
                        IsExtracting = true;
                        btnExtractAll.Text = "Stop";
                        if (!Directory.Exists(txtExtractPath.Text))
                        {
                            Directory.CreateDirectory(txtExtractPath.Text);
                        }
                        ExtractList.Clear();
                        foreach (ListViewItem lvi in lvExtractList.Items)
                        {
                            ExtractList.Add(lvi.Text);
                        }
                        pbExtract.Maximum = ExtractList.Count;
                        bwExtract.RunWorkerAsync(bwExtract);
                        btnExtractAll.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("UnRAR.exe path not exist.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
            }
        }

        private void lvExtractList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.All;
        }

        private void lvExtractList_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] folders = (string[])e.Data.GetData(DataFormats.FileDrop, true);
                Array.Sort(folders);
                FileSizeFilter filter = ParseFileSizeFilter(txtExtractFileSizeFilter.Text);
                foreach (string folder in folders)
                {
                    if (Directory.Exists(folder))
                    {
                        AddExtractList(folder, filter);
                    }
                    else if (File.Exists(folder))
                    {
                        ListViewItem lvi = new ListViewItem(folder);
                        lvExtractList.Items.Add(lvi);
                        UpdateExtractFileCount();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region Settings Tab Events

        private void cbShowHelpTooltips_CheckedChanged(object sender, EventArgs e)
        {
            Program.Settings.ShowHelpTooltips = cbShowHelpTooltips.Checked;
            ttApp.Active = Program.Settings.ShowHelpTooltips;
        }

        private void txtRegexpPattern_TextChanged(object sender, EventArgs e)
        {
            Program.Settings.RegexpPattern = txtRegexpPattern.Text;
        }

        private void cbShowActionMessages_CheckedChanged(object sender, EventArgs e)
        {
            Program.Settings.ShowActionMessages = cbShowActionMessages.Checked;
        }

        private void cbGuessShowName_CheckedChanged(object sender, EventArgs e)
        {
            Program.Settings.GuessShowName = cbGuessShowName.Checked;
        }

        private void cbReplaceIllegalChars_CheckedChanged(object sender, EventArgs e)
        {
            Program.Settings.ReplaceIllegalChars = cbReplaceIllegalChars.Checked;
        }

        private void txtReplaceIllegalChars_TextChanged(object sender, EventArgs e)
        {
            Program.Settings.ReplaceIllegalCharsWith = txtReplaceIllegalChars.Text;
        }

        private void cbReplaceSpaces_CheckedChanged(object sender, EventArgs e)
        {
            Program.Settings.ReplaceSpaces = cbReplaceSpaces.Checked;
        }

        private void txtReplaceSpaces_TextChanged(object sender, EventArgs e)
        {
            Program.Settings.ReplaceSpacesWith = txtReplaceSpaces.Text;
        }

        private void cbShowErrors_CheckedChanged(object sender, EventArgs e)
        {
            Program.Settings.ShowErrors = cbShowErrors.Checked;
        }

        #endregion

        #region Series Info Tab Events

        private void txtSeriesName_TextChanged(object sender, EventArgs e)
        {
            Program.Settings.LastSeriesName = txtSeriesName.Text;
        }

        private void txtSeriesID_TextChanged(object sender, EventArgs e)
        {
            Program.Settings.LastSeriesID = txtSeriesID.Text;
        }

        private void btnSearchSeries_Click(object sender, EventArgs e)
        {
            SearchSeries search = new SearchSeries(txtSeriesName.Text);
            if (search.ShowDialog() == DialogResult.OK)
            {
                txtSeriesID.Text = search.SeriesID;
            }
        }

        private void btnQuickSearchSeries_Click(object sender, EventArgs e)
        {
            TVDBLib.Series series = Program.TVDB.GetFirstSeries(txtSeriesName.Text);
            if (series != null)
            {
                txtSeriesID.Text = series.ID;
            }
        }

        private void btnLoadSeries_Click(object sender, EventArgs e)
        {
            TVDBLib.SeriesFull series = Program.TVDB.GetSeriesFullInformation(txtSeriesID.Text, TVDBLib.FileType.ZIP);
            plvSeries.SelectedObject = series.Series;
            LoadBanner(series.Series);
            tvEpisodes.Tag = series.Episodes;
            FillEpisodes(series.Episodes);
            lvBanners.Tag = series.Series.ID;
            FillBanners(series.Banners);
            lvActors.Tag = series.Series.ID;
            FillActors(series.Actors);
        }

        private void tvEpisodes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvEpisodes.SelectedNode.Tag.GetType() == typeof(TVDBLib.Episode))
            {
                plvEpisodes.SelectedObject = (TVDBLib.Episode)tvEpisodes.SelectedNode.Tag;
            }
        }

        private void EpisodesFilterChanged(object sender, EventArgs e)
        {
            List<TVDBLib.Episode> episodes = (List<TVDBLib.Episode>)tvEpisodes.Tag;
            if (episodes != null)
            {
                FillEpisodes(episodes.SearchEpisode(txtEpisodeName.Text, txtSeasonNumber.Text, txtEpisodeNumber.Text));
            }
        }

        private void lvBanners_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBanners.SelectedItems.Count > 0)
            {
                Banner banner = (Banner)lvBanners.SelectedItems[0].Tag;
                plvBanners.SelectedObject = banner;
                pbBanner.SizeMode = PictureBoxSizeMode.CenterImage;
                pbBanner.Image = RenamerX.Properties.Resources.loading1;
                BackgroundWorker bw = new BackgroundWorker();
                bw.DoWork += new DoWorkEventHandler(Banners_DoWork);
                bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Banners_RunWorkerCompleted);
                bw.RunWorkerAsync(banner.BannerPath);
            }
        }

        private void lvActors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvActors.SelectedItems.Count > 0)
            {
                Actor actor = (Actor)lvActors.SelectedItems[0].Tag;
                plvBanners.SelectedObject = actor;
                pbBanner.SizeMode = PictureBoxSizeMode.CenterImage;
                pbBanner.Image = RenamerX.Properties.Resources.loading1;
                BackgroundWorker bw = new BackgroundWorker();
                bw.DoWork += new DoWorkEventHandler(Actors_DoWork);
                bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Actors_RunWorkerCompleted);
                bw.RunWorkerAsync(actor.Image);
            }
        }

        private void pbBanner_Click(object sender, EventArgs e)
        {
            if (File.Exists(pbBanner.ImageLocation))
            {
                Process.Start(pbBanner.ImageLocation);
            }
        }

        #endregion

        #endregion

        private void AddShow(ShowItem si)
        {
            AddShow(si.ShowName, si.ShowDirectory);
        }

        private void AddShow(string showName, string showDirectory)
        {
            ShowItem si = new ShowItem(showName, showDirectory);
            ListViewItem lvi = new ListViewItem(si.ToString()) { Checked = true, Tag = si, ToolTipText = si.ShowDirectory };
            lvShows.Items.Add(lvi);
        }

        private void RefreshLists()
        {
            lvList.Items.Clear();
            for (int i = 0; i < lvShows.Items.Count; i++)
            {
                ShowItem si = (ShowItem)lvShows.Items[i].Tag;
                Show show = tvrage.FindShow(si.ShowName);
                if (Directory.Exists(si.ShowDirectory))
                {
                    si.ShowInfos.Clear();
                    foreach (string file in Directory.GetFiles(si.ShowDirectory))
                    {
                        if (CheckFile(file, txtRenameFileFilter.Text))
                        {
                            PathInfo showInfo = new PathInfo();
                            showInfo.DefaultFileName = Path.GetFileName(file);
                            showInfo.DefaultFilePath = file;
                            showInfo.NewFileName = Reformat(show, showInfo.DefaultFileName);
                            if (cbReplaceIllegalChars.Checked)
                            {
                                showInfo.NewFileName = ReplaceInvalidFileNameChars(showInfo.NewFileName, txtReplaceIllegalChars.Text);
                            }
                            if (showInfo.Invalid = IsInvalidFileName(showInfo.NewFileName))
                            {
                                showInfo.NewFileName = "Illegal characters in file name: " + showInfo.NewFileName;
                            }
                            showInfo.NewFilePath = Path.Combine(Path.GetDirectoryName(showInfo.DefaultFilePath), showInfo.NewFileName);
                            si.ShowInfos.Add(showInfo);
                        }
                    }
                }
            }
            RefreshSelected();
            UpdateItemsCount();
        }

        private bool IsInvalidFileName(string filename)
        {
            char[] invalidchars = Path.GetInvalidFileNameChars();
            foreach (char c in filename)
            {
                foreach (char invalidchar in invalidchars)
                {
                    if (c == invalidchar) return true;
                }
            }
            return false;
        }

        private void UpdateItemsCount()
        {
            int itemcount = 0, itemmaxcount = 0;
            foreach (ListViewItem lvi in lvShows.Items)
            {
                ShowItem showItem = (ShowItem)lvi.Tag;
                foreach (PathInfo showInfo in showItem.ShowInfos)
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

        private bool CheckFile(string file, string pattern)
        {
            if (string.IsNullOrEmpty(pattern)) return true;
            pattern = "^" + Regex.Escape(pattern).Replace("\\*", ".*").Replace("\\+", ".+").Replace("\\?", ".?").Replace("\\|", "|") + "$";
            return Regex.IsMatch(file, pattern, RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
        }

        private string Reformat(Show show, string filename)
        {
            if (show != null)
            {
                try
                {
                    Match match = Regex.Match(filename, txtRegexpPattern.Text, RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
                    int season = int.Parse(match.Groups["Season"].Value);
                    int episode = int.Parse(match.Groups["Episode"].Value);
                    if (season > 0 && episode > 0)
                    {
                        string nameFormat = txtNameFormat.Text;
                        string extension = Path.GetExtension(filename).ToLowerInvariant();
                        string title = "";
                        TVRageLib.Episode findEpisode = show.FindEpisode(season, episode);
                        if (findEpisode != null)
                        {
                            title = findEpisode.Title;
                        }
                        string result = nameFormat.Replace("$N", show.Name).Replace("$S2", season.ToString("d2")).
                            Replace("$S", season.ToString()).Replace("$E2", episode.ToString("d2")).
                            Replace("$E", episode.ToString()).Replace("$T", title) + extension;
                        if (cbReplaceSpaces.Checked)
                        {
                            result = result.Replace(" ", txtReplaceSpaces.Text);
                        }
                        return result;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            return filename;
        }

        private bool ChangeNames()
        {
            for (int i = 0; i < lvShows.Items.Count; i++)
            {
                ListViewItem lvi = lvShows.Items[i];
                if (lvi.Checked)
                {
                    if (cbShowActionMessages.Checked) ConsoleWriteLine("Started: " + lvi.Text);
                    foreach (PathInfo showInfo in ((ShowItem)lvi.Tag).ShowInfos)
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
                foreach (PathInfo showInfo in ((ShowItem)lvShows.Items[lvShows.SelectedIndices[0]].Tag).ShowInfos)
                {
                    ListViewItem lvi = new ListViewItem();
                    if (showInfo.Invalid)
                    {
                        lvi.BackColor = Color.DarkRed;
                        lvi.ForeColor = Color.White;
                    }
                    lvi.Text = showInfo.DefaultFileName;
                    lvi.ToolTipText = "Default: " + showInfo.DefaultFilePath + "\r\nNew: " + showInfo.NewFilePath;
                    lvi.SubItems.Add(showInfo.NewFileName);
                    lvList.Items.Add(lvi);
                }
                ResizeListviewColumns();
                lvList.EndUpdate();
            }
        }

        private string ReplaceInvalidFileNameChars(string fileName, string replace)
        {
            List<char> chars = new List<char>();
            chars.AddRange(Path.GetInvalidFileNameChars());
            foreach (char c in chars)
            {
                fileName = fileName.Replace(c.ToString(), replace);
            }
            return fileName;
        }

        private void ConsoleWriteLine(string text)
        {
            txtConsole.AppendText(DateTime.Now.ToLongTimeString() + " - " + text + Environment.NewLine);
            txtConsole.ScrollToCaret();
        }

        private void ResizeListviewColumns()
        {
            lvShows.Columns[0].Width = lvShows.ClientSize.Width;
            lvList.Columns[0].Width = lvList.ClientSize.Width / 2;
            lvList.Columns[1].Width = -2;
            lvExtractList.Columns[0].Width = lvExtractList.ClientSize.Width;
        }

        private void AddExtractList(string folder, FileSizeFilter filter)
        {
            try
            {
                foreach (string file in Directory.GetFiles(folder))
                {
                    if (CheckFile(file, txtExtractFileFilter.Text) && CheckFileSize(file, filter))
                    {
                        ListViewItem lvi = new ListViewItem(file);
                        lvExtractList.Items.Add(lvi);
                        UpdateExtractFileCount();
                        break;
                    }
                }
                if (cbSearchSubFolders.Checked)
                {
                    foreach (string directory in Directory.GetDirectories(folder))
                    {
                        AddExtractList(directory, filter);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateExtractFileCount()
        {
            lblFileCount.Text = "File count: " + lvExtractList.Items.Count;
        }

        private bool CheckFileSize(string file, FileSizeFilter filter)
        {
            FileInfo fi = new FileInfo(file);
            if ((filter.MathOperator == '<' && fi.Length < filter.FileSize) || (filter.MathOperator == '>' && fi.Length > filter.FileSize))
            {
                return true;
            }
            return false;
        }

        private struct FileSizeFilter
        {
            public long FileSize { get; set; }
            public char MathOperator { get; set; }
        }

        private FileSizeFilter ParseFileSizeFilter(string filter)
        {
            filter = filter.Trim();
            if (!string.IsNullOrEmpty(filter) && (filter[0] == '<' || filter[0] == '>'))
            {
                FileSizeFilter result = new FileSizeFilter();
                result.MathOperator = filter[0];
                if (filter.Length > 1 && char.IsDigit(filter[1]))
                {
                    for (int i = 2; i < filter.Length; i++)
                    {
                        if (!char.IsDigit(filter[i]) && filter[i] != ' ')
                        {
                            long number = long.Parse(filter.Substring(1, i - 1));
                            switch (filter.Remove(0, i).ToLowerInvariant())
                            {
                                case "gigabyte":
                                case "gb":
                                    number *= 1000 * 1000 * 1000;
                                    break;
                                case "gibibyte":
                                case "gib":
                                    number *= 1024 * 1024 * 1024;
                                    break;
                                case "megabyte":
                                case "mb":
                                    number *= 1000 * 1000;
                                    break;
                                case "mebibyte":
                                case "mib":
                                    number *= 1024 * 1024;
                                    break;
                                case "kilobyte":
                                case "kb":
                                    number *= 1000;
                                    break;
                                case "kibibyte":
                                case "kib":
                                    number *= 1024;
                                    break;
                                case "byte":
                                case "b":
                                    break;
                                default:
                                    throw new Exception("File size filter not end with file size type. (B, KiB, MiB, GiB)");
                            }
                            result.FileSize = number;
                            return result;
                        }
                    }
                    throw new Exception("File size filter not end with file size type. (B, KiB, MiB, GiB)");
                }
                else
                {
                    throw new Exception("File size filter need to have number after math operator.");
                }
            }
            else
            {
                throw new Exception("File size filter not start with math operator. (< or >)");
            }
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string message = (string)e.UserState;
            ConsoleWriteLine(string.Format("({0}/{1}) {2}", e.ProgressPercentage, ExtractList.Count, message));
            pbExtract.Value = e.ProgressPercentage;
            lblFileCount.Text = string.Format("File count: {0}/{1}", e.ProgressPercentage, ExtractList.Count);
            if (lvExtractList.Items.Count > e.ProgressPercentage)
            {
                lvExtractList.Items[e.ProgressPercentage].Selected = true;
            }
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                pbExtract.Value = 0;
                ConsoleWriteLine("Extract cancelled.");
            }
            else
            {
                ConsoleWriteLine("Extract finished.");
            }
            btnExtractAll.Text = "Extract all";
            IsExtracting = false;
        }

        private void ExtractThread(object sender, DoWorkEventArgs e)
        {
            try
            {
                BackgroundWorker bw = (BackgroundWorker)e.Argument;
                string arguments;
                for (int i = 0; i < ExtractList.Count; i++)
                {
                    if (File.Exists(ExtractList[i]))
                    {
                        List<string> commands = new List<string>();
                        if (cbExtractOverwrite.Checked)
                        {
                            commands.Add("o+"); //Set the overwrite mode (true)
                        }
                        else
                        {
                            commands.Add("o-"); //Set the overwrite mode (false)
                        }
                        if (string.IsNullOrEmpty(txtExtractPassword.Text))
                        {
                            commands.Add("p-"); //Do not query password
                        }
                        else
                        {
                            commands.Add("p" + txtExtractPassword.Text); //Set password
                        }
                        string command = string.Join("", commands.Select(x => " -" + x).ToArray());
                        arguments = string.Format("x {0} \"{1}\" \"{2}\"", command, ExtractList[i], txtExtractPath.Text);
                        ProcessStartInfo psi = new ProcessStartInfo(txtUnRARPath.Text, arguments);
                        psi.CreateNoWindow = true;
                        psi.WindowStyle = ProcessWindowStyle.Hidden;
                        Process process = new Process();
                        process.StartInfo = psi;
                        bw.ReportProgress(i, "Started to extract: " + ExtractList[i] + " -> " + txtExtractPath.Text);
                        process.Start();
                        process.WaitForExit();
                        bw.ReportProgress(i + 1, "Extracted: " + ExtractList[i] + " -> " + txtExtractPath.Text);
                    }
                    if (bw.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Show CreateFakeShow(string showName, int seasonNumber, int episodeNumber, string episodeTitle)
        {
            List<TVRageLib.Episode> episodes = new List<TVRageLib.Episode>() { new TVRageLib.Episode(episodeNumber, episodeTitle) };
            List<Season> seasons = new List<Season>() { new Season(seasonNumber) { Episodes = episodes } };
            return new Show(showName) { Seasons = seasons };
        }

        private void UpdateNameFormatPreview()
        {
            lblNameFormatPreview.Text = Reformat(fakeShow, "S02E07.avi");
        }

        private void SaveShowsList()
        {
            Program.Settings.ShowsList.Clear();
            foreach (ListViewItem lvi in lvShows.Items)
            {
                ShowItem si = (ShowItem)lvi.Tag;
                Program.Settings.ShowsList.Add(new ShowItem(si.ShowName, si.ShowDirectory));
            }
        }

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
            for (int i = 1; i <= 3; i++)
            {
                AddShow("Prison Break", @"E:\TV\Prison Break\Season " + i);
            }
        }

        private void FillEpisodes(List<TVDBLib.Episode> episodes)
        {
            tvEpisodes.Nodes.Clear();
            bool found = false;
            foreach (TVDBLib.Episode episode in episodes)
            {
                foreach (TreeNode seasonNode in tvEpisodes.Nodes)
                {
                    if ((string)seasonNode.Tag == episode.SeasonNumber)
                    {
                        seasonNode.Nodes.Add(int.Parse(episode.EpisodeNumber).ToString("d2") + " - " + episode.EpisodeName).Tag = episode;
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    TreeNode seasonNode = tvEpisodes.Nodes.Add("Season " + episode.SeasonNumber);
                    seasonNode.Tag = episode.SeasonNumber;
                    seasonNode.Nodes.Add(int.Parse(episode.EpisodeNumber).ToString("d2") + " - " + episode.EpisodeName).Tag = episode;
                }
                found = false;
            }
            tvEpisodes.ExpandAll();
        }

        private void FillActors(List<Actor> actors)
        {
            lvActors.Items.Clear();
            foreach (Actor actor in actors)
            {
                ListViewItem lvi = new ListViewItem(actor.Name) { Tag = actor };
                lvi.SubItems.Add(actor.Role);
                lvActors.Items.Add(lvi);
            }
        }

        private void FillBanners(List<Banner> banners)
        {
            lvBanners.Items.Clear();
            foreach (Banner banner in banners)
            {
                lvBanners.Items.Add(banner.BannerPath).Tag = banner;
            }
        }

        private void LoadBanner(TVDBLib.Series series)
        {
            pbSeriesBanner.SizeMode = PictureBoxSizeMode.CenterImage;
            pbSeriesBanner.Image = RenamerX.Properties.Resources.loading1;
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += new DoWorkEventHandler(SeriesBanner_DoWork);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(SeriesBanner_RunWorkerCompleted);
            bw.RunWorkerAsync(series);
        }

        private void SeriesBanner_DoWork(object sender, DoWorkEventArgs e)
        {
            TVDBLib.Series series = (TVDBLib.Series)e.Argument;
            e.Result = Program.TVDB.GetImagePath(series.Banner, series.ID);
        }

        private void SeriesBanner_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pbSeriesBanner.Image = new Bitmap(1, 1);
            pbSeriesBanner.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSeriesBanner.ImageLocation = (string)e.Result;
        }

        private void Banners_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = Program.TVDB.GetImagePath((string)e.Argument, (string)lvBanners.Tag);
        }

        private void Banners_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pbBanner.Image = new Bitmap(1, 1);
            pbBanner.SizeMode = PictureBoxSizeMode.Zoom;
            pbBanner.ImageLocation = (string)e.Result;
        }

        private void Actors_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = Program.TVDB.GetImagePath((string)e.Argument, (string)lvBanners.Tag);
        }

        private void Actors_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pbBanner.Image = new Bitmap(1, 1);
            pbBanner.SizeMode = PictureBoxSizeMode.CenterImage;
            pbBanner.ImageLocation = (string)e.Result;
        }

        private void btnRefreshSettings_Click(object sender, EventArgs e)
        {
            plvSettings.SelectedObject = Program.Settings;
        }
    }
}
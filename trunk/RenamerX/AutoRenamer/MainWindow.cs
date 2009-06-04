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

namespace RenamerX
{
    public partial class MainWindow : Form
    {
        private List<Show> Shows = new List<Show>();
        private List<string> ExtractList = new List<string>();
        private bool IsExtracting;
        private BackgroundWorker bwExtract = new BackgroundWorker();

        public MainWindow()
        {
            InitializeComponent();
            bwExtract.DoWork += new DoWorkEventHandler(ExtractThread);
            bwExtract.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bwExtract.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            bwExtract.WorkerReportsProgress = true;
            bwExtract.WorkerSupportsCancellation = true;
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
        }

        #region Form Events

        private void MainWindow_Load(object sender, EventArgs e)
        {
            LoadJaex();
            ResizeListviewColumns();
            propertyGrid1.SelectedObject = Settings.Default;
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            ResizeListviewColumns();
            this.Refresh();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
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
        }

        private void btnRenameAdd_Click(object sender, EventArgs e)
        {
            BrowseTVShow();
        }

        private void btnRenameRemove_Click(object sender, EventArgs e)
        {
            if (lvShows.SelectedIndices.Count > 0)
            {
                lvShows.Items.RemoveAt(lvShows.SelectedIndices[0]);
            }
        }

        private void btnRenameClear_Click(object sender, EventArgs e)
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

        #endregion

        #region Extract Tab Events

        private void txtExtractPath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.All;
        }

        private void txtExtractPath_DragDrop(object sender, DragEventArgs e)
        {
            txtExtractPath.Text = ((string[])e.Data.GetData(DataFormats.FileDrop, true))[0];
        }

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
            if (!string.IsNullOrEmpty(Settings.Default.LastExtractFolder) && Directory.Exists(Settings.Default.LastExtractFolder))
            {
                fbd.SelectedPath = Settings.Default.LastExtractFolder;
            }
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Settings.Default.LastExtractFolder = fbd.SelectedPath;
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

        #endregion

        private void BrowseTVShow()
        {
            InputBox ib = new InputBox("Browse for TV Show...", "", "");
            if (ib.ShowDialog() == DialogResult.OK)
            {
                AddShow(ib.ShowName, ib.ShowLocation);
            }
        }

        private void AddShow(string showName, string showFolder)
        {
            ShowItem si = new ShowItem(showName, showFolder);
            ListViewItem lvi = new ListViewItem(si.ToString()) { Checked = true, Tag = si, ToolTipText = si.ShowDirectory };
            lvShows.Items.Add(lvi);
        }

        private void RefreshLists()
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
                        if (CheckFile(file, txtRenameFileFilter.Text))
                        {
                            ShowInfo showInfo = new ShowInfo();
                            showInfo.DefaultFileName = Path.GetFileName(file);
                            showInfo.DefaultFilePath = file;
                            showInfo.SetShowName(Reformat(show, showInfo.DefaultFileName));
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

        private bool CheckFile(string file, string pattern)
        {
            if (string.IsNullOrEmpty(pattern)) return true;
            pattern = "^" + Regex.Escape(pattern).Replace("\\*", ".*").Replace("\\+", ".+").Replace("\\?", ".?").Replace("\\|", "|") + "$";
            return Regex.IsMatch(file, pattern, RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
        }

        private Show FindShow(string showName)
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
                Console.WriteLine(ex.ToString());
            }
            return seasons;
        }

        private string Reformat(Show show, string filename)
        {
            if (show != null)
            {
                try
                {
                    Match match = Regex.Match(filename, txtRegexpPattern.Text, RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
                    int season = match.Groups["Season"].Value.ToInt();
                    int episode = match.Groups["Episode"].Value.ToInt();
                    if (season > 0 && episode > 0)
                    {
                        string nameFormat = txtNameFormat.Text;
                        string extension = Path.GetExtension(filename).ToLowerInvariant();
                        string title = "";
                        Episode findEpisode = show.FindEpisode(season, episode);
                        if (findEpisode != null) title = findEpisode.Title;
                        return nameFormat.Replace("$N", show.ShowName).Replace("$S2", season.ToString("d2")).
                            Replace("$S", season.ToString()).Replace("$E2", episode.ToString("d2")).
                            Replace("$E", episode.ToString()).Replace("$T", title) + extension;
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
                        if (!char.IsDigit(filter[i]))
                        {
                            long number = long.Parse(filter.Substring(1, i - 1));
                            switch (filter.Remove(0, i).ToLowerInvariant())
                            {
                                case "gigabyte":
                                case "gb":
                                case "gibibyte":
                                case "gib":
                                    number *= 1073741824;
                                    break;
                                case "megabyte":
                                case "mb":
                                case "mebibyte":
                                case "mib":
                                    number *= 1048576;
                                    break;
                                case "kilobyte":
                                case "kb":
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
    }
}
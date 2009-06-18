namespace RenamerX
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpMain = new System.Windows.Forms.TabPage();
            this.scRename = new System.Windows.Forms.SplitContainer();
            this.lblNameFormatPreview = new System.Windows.Forms.Label();
            this.lblItemsCount = new System.Windows.Forms.Label();
            this.lvShows = new System.Windows.Forms.ListView();
            this.lvShowsColumn1 = new System.Windows.Forms.ColumnHeader();
            this.btnRenameAll = new System.Windows.Forms.Button();
            this.btnRenameClear = new System.Windows.Forms.Button();
            this.lblRenameFileFilter = new System.Windows.Forms.Label();
            this.txtRenameFileFilter = new System.Windows.Forms.TextBox();
            this.lblNameFormat = new System.Windows.Forms.Label();
            this.btnRenameRemove = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtNameFormat = new System.Windows.Forms.TextBox();
            this.btnRenameAdd = new System.Windows.Forms.Button();
            this.lvList = new System.Windows.Forms.ListView();
            this.lvListColumn1 = new System.Windows.Forms.ColumnHeader();
            this.lvListColumn2 = new System.Windows.Forms.ColumnHeader();
            this.tpExtract = new System.Windows.Forms.TabPage();
            this.scExtract = new System.Windows.Forms.SplitContainer();
            this.txtExtractPassword = new System.Windows.Forms.TextBox();
            this.lblExtractPassword = new System.Windows.Forms.Label();
            this.cbExtractOverwrite = new System.Windows.Forms.CheckBox();
            this.pbExtract = new System.Windows.Forms.ProgressBar();
            this.lblFileCount = new System.Windows.Forms.Label();
            this.txtExtractFileSizeFilter = new System.Windows.Forms.TextBox();
            this.lblExtractFileSizeFilter = new System.Windows.Forms.Label();
            this.lblExtractPath = new System.Windows.Forms.Label();
            this.txtExtractFileFilter = new System.Windows.Forms.TextBox();
            this.txtExtractPath = new System.Windows.Forms.TextBox();
            this.lblExtractFileFilter = new System.Windows.Forms.Label();
            this.txtUnRARPath = new System.Windows.Forms.TextBox();
            this.btnExtractClear = new System.Windows.Forms.Button();
            this.cbSearchSubFolders = new System.Windows.Forms.CheckBox();
            this.btnExtractRemove = new System.Windows.Forms.Button();
            this.lblUnRARPath = new System.Windows.Forms.Label();
            this.btnExtractAdd = new System.Windows.Forms.Button();
            this.btnExtractBrowse = new System.Windows.Forms.Button();
            this.btnExtractAll = new System.Windows.Forms.Button();
            this.btnUnRARBrowse = new System.Windows.Forms.Button();
            this.lvExtractList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.tpSeriesInfo = new System.Windows.Forms.TabPage();
            this.tcSeriesInfo = new System.Windows.Forms.TabControl();
            this.tpSeries = new System.Windows.Forms.TabPage();
            this.pbSeriesBanner = new System.Windows.Forms.PictureBox();
            this.btnQuickSearchSeries = new System.Windows.Forms.Button();
            this.btnLoadSeries = new System.Windows.Forms.Button();
            this.btnSearchSeries = new System.Windows.Forms.Button();
            this.txtSeriesName = new System.Windows.Forms.TextBox();
            this.txtSeriesID = new System.Windows.Forms.TextBox();
            this.tpEpisodes = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEpisodeNumber = new System.Windows.Forms.TextBox();
            this.txtSeasonNumber = new System.Windows.Forms.TextBox();
            this.lblEpisodeNumber = new System.Windows.Forms.Label();
            this.lblSeasonNumber = new System.Windows.Forms.Label();
            this.txtEpisodeName = new System.Windows.Forms.TextBox();
            this.lblEpisodeName = new System.Windows.Forms.Label();
            this.tvEpisodes = new System.Windows.Forms.TreeView();
            this.tpSeriesImages = new System.Windows.Forms.TabPage();
            this.pbBanner = new System.Windows.Forms.PictureBox();
            this.tcSeriesImages = new System.Windows.Forms.TabControl();
            this.tpBanners = new System.Windows.Forms.TabPage();
            this.tpActors = new System.Windows.Forms.TabPage();
            this.tpConsole = new System.Windows.Forms.TabPage();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.btnRefreshSettings = new System.Windows.Forms.Button();
            this.gbGeneralSettings = new System.Windows.Forms.GroupBox();
            this.cbShowHelpTooltips = new System.Windows.Forms.CheckBox();
            this.gbRenameSettings = new System.Windows.Forms.GroupBox();
            this.txtReplaceSpaces = new System.Windows.Forms.TextBox();
            this.cbShowErrors = new System.Windows.Forms.CheckBox();
            this.cbReplaceSpaces = new System.Windows.Forms.CheckBox();
            this.txtReplaceIllegalChars = new System.Windows.Forms.TextBox();
            this.cbReplaceIllegalChars = new System.Windows.Forms.CheckBox();
            this.cbGuessShowName = new System.Windows.Forms.CheckBox();
            this.txtRegexpPattern = new System.Windows.Forms.TextBox();
            this.cbShowActionMessages = new System.Windows.Forms.CheckBox();
            this.lblRegexpPattern = new System.Windows.Forms.Label();
            this.ttApp = new System.Windows.Forms.ToolTip(this.components);
            this.plvSeries = new RenamerX.PropertyListView();
            this.plvEpisodes = new RenamerX.PropertyListView();
            this.lvBanners = new RenamerX.ListViewX();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.lvActors = new RenamerX.ListViewX();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.plvBanners = new RenamerX.PropertyListView();
            this.plvSettings = new RenamerX.PropertyListView();
            this.tcMain.SuspendLayout();
            this.tpMain.SuspendLayout();
            this.scRename.Panel1.SuspendLayout();
            this.scRename.Panel2.SuspendLayout();
            this.scRename.SuspendLayout();
            this.tpExtract.SuspendLayout();
            this.scExtract.Panel1.SuspendLayout();
            this.scExtract.Panel2.SuspendLayout();
            this.scExtract.SuspendLayout();
            this.tpSeriesInfo.SuspendLayout();
            this.tcSeriesInfo.SuspendLayout();
            this.tpSeries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeriesBanner)).BeginInit();
            this.tpEpisodes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpSeriesImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).BeginInit();
            this.tcSeriesImages.SuspendLayout();
            this.tpBanners.SuspendLayout();
            this.tpActors.SuspendLayout();
            this.tpConsole.SuspendLayout();
            this.tpSettings.SuspendLayout();
            this.gbGeneralSettings.SuspendLayout();
            this.gbRenameSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpMain);
            this.tcMain.Controls.Add(this.tpExtract);
            this.tcMain.Controls.Add(this.tpSeriesInfo);
            this.tcMain.Controls.Add(this.tpConsole);
            this.tcMain.Controls.Add(this.tpSettings);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(3, 3);
            this.tcMain.Name = "tcMain";
            this.tcMain.Padding = new System.Drawing.Point(15, 4);
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1004, 636);
            this.tcMain.TabIndex = 2;
            // 
            // tpMain
            // 
            this.tpMain.Controls.Add(this.scRename);
            this.tpMain.Location = new System.Drawing.Point(4, 24);
            this.tpMain.Name = "tpMain";
            this.tpMain.Padding = new System.Windows.Forms.Padding(3);
            this.tpMain.Size = new System.Drawing.Size(996, 608);
            this.tpMain.TabIndex = 0;
            this.tpMain.Text = "Rename";
            this.tpMain.UseVisualStyleBackColor = true;
            // 
            // scRename
            // 
            this.scRename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scRename.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scRename.IsSplitterFixed = true;
            this.scRename.Location = new System.Drawing.Point(3, 3);
            this.scRename.Name = "scRename";
            this.scRename.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scRename.Panel1
            // 
            this.scRename.Panel1.Controls.Add(this.lblNameFormatPreview);
            this.scRename.Panel1.Controls.Add(this.lblItemsCount);
            this.scRename.Panel1.Controls.Add(this.lvShows);
            this.scRename.Panel1.Controls.Add(this.btnRenameAll);
            this.scRename.Panel1.Controls.Add(this.btnRenameClear);
            this.scRename.Panel1.Controls.Add(this.lblRenameFileFilter);
            this.scRename.Panel1.Controls.Add(this.txtRenameFileFilter);
            this.scRename.Panel1.Controls.Add(this.lblNameFormat);
            this.scRename.Panel1.Controls.Add(this.btnRenameRemove);
            this.scRename.Panel1.Controls.Add(this.btnRefresh);
            this.scRename.Panel1.Controls.Add(this.txtNameFormat);
            this.scRename.Panel1.Controls.Add(this.btnRenameAdd);
            // 
            // scRename.Panel2
            // 
            this.scRename.Panel2.Controls.Add(this.lvList);
            this.scRename.Size = new System.Drawing.Size(990, 602);
            this.scRename.SplitterDistance = 130;
            this.scRename.SplitterWidth = 2;
            this.scRename.TabIndex = 3;
            // 
            // lblNameFormatPreview
            // 
            this.lblNameFormatPreview.AutoSize = true;
            this.lblNameFormatPreview.Location = new System.Drawing.Point(704, 20);
            this.lblNameFormatPreview.Name = "lblNameFormatPreview";
            this.lblNameFormatPreview.Size = new System.Drawing.Size(107, 13);
            this.lblNameFormatPreview.TabIndex = 16;
            this.lblNameFormatPreview.Text = "Name format preview";
            // 
            // lblItemsCount
            // 
            this.lblItemsCount.BackColor = System.Drawing.Color.Black;
            this.lblItemsCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblItemsCount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsCount.Location = new System.Drawing.Point(344, 96);
            this.lblItemsCount.Name = "lblItemsCount";
            this.lblItemsCount.Size = new System.Drawing.Size(72, 21);
            this.lblItemsCount.TabIndex = 15;
            this.lblItemsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvShows
            // 
            this.lvShows.AllowDrop = true;
            this.lvShows.CheckBoxes = true;
            this.lvShows.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvShowsColumn1});
            this.lvShows.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvShows.FullRowSelect = true;
            this.lvShows.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvShows.HideSelection = false;
            this.lvShows.Location = new System.Drawing.Point(0, 0);
            this.lvShows.Name = "lvShows";
            this.lvShows.ShowItemToolTips = true;
            this.lvShows.Size = new System.Drawing.Size(333, 130);
            this.lvShows.TabIndex = 14;
            this.lvShows.UseCompatibleStateImageBehavior = false;
            this.lvShows.View = System.Windows.Forms.View.Details;
            this.lvShows.SelectedIndexChanged += new System.EventHandler(this.lvShows_SelectedIndexChanged);
            this.lvShows.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvShows_DragDrop);
            this.lvShows.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvShows_DragEnter);
            // 
            // lvShowsColumn1
            // 
            this.lvShowsColumn1.Width = 329;
            // 
            // btnRenameAll
            // 
            this.btnRenameAll.Location = new System.Drawing.Point(528, 96);
            this.btnRenameAll.Name = "btnRenameAll";
            this.btnRenameAll.Size = new System.Drawing.Size(80, 24);
            this.btnRenameAll.TabIndex = 12;
            this.btnRenameAll.Text = "Rename all";
            this.btnRenameAll.UseVisualStyleBackColor = true;
            this.btnRenameAll.Click += new System.EventHandler(this.btnRenameAll_Click);
            // 
            // btnRenameClear
            // 
            this.btnRenameClear.Location = new System.Drawing.Point(344, 56);
            this.btnRenameClear.Name = "btnRenameClear";
            this.btnRenameClear.Size = new System.Drawing.Size(72, 24);
            this.btnRenameClear.TabIndex = 11;
            this.btnRenameClear.Text = "Clear";
            this.btnRenameClear.UseVisualStyleBackColor = true;
            this.btnRenameClear.Click += new System.EventHandler(this.btnRenameClear_Click);
            // 
            // lblRenameFileFilter
            // 
            this.lblRenameFileFilter.AutoSize = true;
            this.lblRenameFileFilter.Location = new System.Drawing.Point(437, 40);
            this.lblRenameFileFilter.Name = "lblRenameFileFilter";
            this.lblRenameFileFilter.Size = new System.Drawing.Size(48, 13);
            this.lblRenameFileFilter.TabIndex = 3;
            this.lblRenameFileFilter.Text = "File filter:";
            // 
            // txtRenameFileFilter
            // 
            this.txtRenameFileFilter.Location = new System.Drawing.Point(520, 40);
            this.txtRenameFileFilter.Name = "txtRenameFileFilter";
            this.txtRenameFileFilter.Size = new System.Drawing.Size(176, 20);
            this.txtRenameFileFilter.TabIndex = 2;
            this.ttApp.SetToolTip(this.txtRenameFileFilter, resources.GetString("txtRenameFileFilter.ToolTip"));
            this.txtRenameFileFilter.TextChanged += new System.EventHandler(this.txtRenameFileFilter_TextChanged);
            // 
            // lblNameFormat
            // 
            this.lblNameFormat.AutoSize = true;
            this.lblNameFormat.Location = new System.Drawing.Point(437, 16);
            this.lblNameFormat.Name = "lblNameFormat";
            this.lblNameFormat.Size = new System.Drawing.Size(70, 13);
            this.lblNameFormat.TabIndex = 4;
            this.lblNameFormat.Text = "Name format:";
            // 
            // btnRenameRemove
            // 
            this.btnRenameRemove.Location = new System.Drawing.Point(344, 32);
            this.btnRenameRemove.Name = "btnRenameRemove";
            this.btnRenameRemove.Size = new System.Drawing.Size(72, 24);
            this.btnRenameRemove.TabIndex = 8;
            this.btnRenameRemove.Text = "Remove";
            this.btnRenameRemove.UseVisualStyleBackColor = true;
            this.btnRenameRemove.Click += new System.EventHandler(this.btnRenameRemove_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(440, 96);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 24);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtNameFormat
            // 
            this.txtNameFormat.Location = new System.Drawing.Point(520, 16);
            this.txtNameFormat.Name = "txtNameFormat";
            this.txtNameFormat.Size = new System.Drawing.Size(176, 20);
            this.txtNameFormat.TabIndex = 0;
            this.ttApp.SetToolTip(this.txtNameFormat, resources.GetString("txtNameFormat.ToolTip"));
            this.txtNameFormat.TextChanged += new System.EventHandler(this.txtNameFormat_TextChanged);
            // 
            // btnRenameAdd
            // 
            this.btnRenameAdd.Location = new System.Drawing.Point(344, 8);
            this.btnRenameAdd.Name = "btnRenameAdd";
            this.btnRenameAdd.Size = new System.Drawing.Size(72, 24);
            this.btnRenameAdd.TabIndex = 7;
            this.btnRenameAdd.Text = "Add";
            this.btnRenameAdd.UseVisualStyleBackColor = true;
            this.btnRenameAdd.Click += new System.EventHandler(this.btnRenameAdd_Click);
            // 
            // lvList
            // 
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvListColumn1,
            this.lvListColumn2});
            this.lvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvList.FullRowSelect = true;
            this.lvList.GridLines = true;
            this.lvList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvList.HideSelection = false;
            this.lvList.Location = new System.Drawing.Point(0, 0);
            this.lvList.Name = "lvList";
            this.lvList.ShowItemToolTips = true;
            this.lvList.Size = new System.Drawing.Size(990, 470);
            this.lvList.TabIndex = 0;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            this.lvList.DoubleClick += new System.EventHandler(this.lvList_DoubleClick);
            // 
            // lvListColumn1
            // 
            this.lvListColumn1.Text = "Default filenames";
            this.lvListColumn1.Width = 450;
            // 
            // lvListColumn2
            // 
            this.lvListColumn2.Text = "New filenames";
            this.lvListColumn2.Width = 450;
            // 
            // tpExtract
            // 
            this.tpExtract.Controls.Add(this.scExtract);
            this.tpExtract.Location = new System.Drawing.Point(4, 24);
            this.tpExtract.Name = "tpExtract";
            this.tpExtract.Padding = new System.Windows.Forms.Padding(3);
            this.tpExtract.Size = new System.Drawing.Size(996, 608);
            this.tpExtract.TabIndex = 3;
            this.tpExtract.Text = "Extract";
            this.tpExtract.UseVisualStyleBackColor = true;
            // 
            // scExtract
            // 
            this.scExtract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scExtract.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scExtract.IsSplitterFixed = true;
            this.scExtract.Location = new System.Drawing.Point(3, 3);
            this.scExtract.Name = "scExtract";
            this.scExtract.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scExtract.Panel1
            // 
            this.scExtract.Panel1.Controls.Add(this.txtExtractPassword);
            this.scExtract.Panel1.Controls.Add(this.lblExtractPassword);
            this.scExtract.Panel1.Controls.Add(this.cbExtractOverwrite);
            this.scExtract.Panel1.Controls.Add(this.pbExtract);
            this.scExtract.Panel1.Controls.Add(this.lblFileCount);
            this.scExtract.Panel1.Controls.Add(this.txtExtractFileSizeFilter);
            this.scExtract.Panel1.Controls.Add(this.lblExtractFileSizeFilter);
            this.scExtract.Panel1.Controls.Add(this.lblExtractPath);
            this.scExtract.Panel1.Controls.Add(this.txtExtractFileFilter);
            this.scExtract.Panel1.Controls.Add(this.txtExtractPath);
            this.scExtract.Panel1.Controls.Add(this.lblExtractFileFilter);
            this.scExtract.Panel1.Controls.Add(this.txtUnRARPath);
            this.scExtract.Panel1.Controls.Add(this.btnExtractClear);
            this.scExtract.Panel1.Controls.Add(this.cbSearchSubFolders);
            this.scExtract.Panel1.Controls.Add(this.btnExtractRemove);
            this.scExtract.Panel1.Controls.Add(this.lblUnRARPath);
            this.scExtract.Panel1.Controls.Add(this.btnExtractAdd);
            this.scExtract.Panel1.Controls.Add(this.btnExtractBrowse);
            this.scExtract.Panel1.Controls.Add(this.btnExtractAll);
            this.scExtract.Panel1.Controls.Add(this.btnUnRARBrowse);
            // 
            // scExtract.Panel2
            // 
            this.scExtract.Panel2.Controls.Add(this.lvExtractList);
            this.scExtract.Size = new System.Drawing.Size(990, 602);
            this.scExtract.SplitterDistance = 130;
            this.scExtract.SplitterWidth = 2;
            this.scExtract.TabIndex = 12;
            // 
            // txtExtractPassword
            // 
            this.txtExtractPassword.Location = new System.Drawing.Point(360, 64);
            this.txtExtractPassword.Name = "txtExtractPassword";
            this.txtExtractPassword.Size = new System.Drawing.Size(192, 20);
            this.txtExtractPassword.TabIndex = 18;
            this.txtExtractPassword.TextChanged += new System.EventHandler(this.txtExtractPassword_TextChanged);
            // 
            // lblExtractPassword
            // 
            this.lblExtractPassword.AutoSize = true;
            this.lblExtractPassword.Location = new System.Drawing.Point(296, 67);
            this.lblExtractPassword.Name = "lblExtractPassword";
            this.lblExtractPassword.Size = new System.Drawing.Size(56, 13);
            this.lblExtractPassword.TabIndex = 17;
            this.lblExtractPassword.Text = "Password:";
            // 
            // cbExtractOverwrite
            // 
            this.cbExtractOverwrite.AutoSize = true;
            this.cbExtractOverwrite.Location = new System.Drawing.Point(152, 64);
            this.cbExtractOverwrite.Name = "cbExtractOverwrite";
            this.cbExtractOverwrite.Size = new System.Drawing.Size(125, 17);
            this.cbExtractOverwrite.TabIndex = 16;
            this.cbExtractOverwrite.Text = "Overwrite existing file";
            this.cbExtractOverwrite.UseVisualStyleBackColor = true;
            this.cbExtractOverwrite.CheckedChanged += new System.EventHandler(this.cbExtractOverwrite_CheckedChanged);
            // 
            // pbExtract
            // 
            this.pbExtract.Location = new System.Drawing.Point(352, 96);
            this.pbExtract.Name = "pbExtract";
            this.pbExtract.Size = new System.Drawing.Size(440, 23);
            this.pbExtract.TabIndex = 15;
            // 
            // lblFileCount
            // 
            this.lblFileCount.AutoSize = true;
            this.lblFileCount.Location = new System.Drawing.Point(864, 104);
            this.lblFileCount.Name = "lblFileCount";
            this.lblFileCount.Size = new System.Drawing.Size(65, 13);
            this.lblFileCount.TabIndex = 14;
            this.lblFileCount.Text = "File count: 0";
            // 
            // txtExtractFileSizeFilter
            // 
            this.txtExtractFileSizeFilter.Location = new System.Drawing.Point(776, 40);
            this.txtExtractFileSizeFilter.Name = "txtExtractFileSizeFilter";
            this.txtExtractFileSizeFilter.Size = new System.Drawing.Size(176, 20);
            this.txtExtractFileSizeFilter.TabIndex = 13;
            this.ttApp.SetToolTip(this.txtExtractFileSizeFilter, resources.GetString("txtExtractFileSizeFilter.ToolTip"));
            this.txtExtractFileSizeFilter.TextChanged += new System.EventHandler(this.txtExtractFileSizeFilter_TextChanged);
            // 
            // lblExtractFileSizeFilter
            // 
            this.lblExtractFileSizeFilter.AutoSize = true;
            this.lblExtractFileSizeFilter.Location = new System.Drawing.Point(696, 44);
            this.lblExtractFileSizeFilter.Name = "lblExtractFileSizeFilter";
            this.lblExtractFileSizeFilter.Size = new System.Drawing.Size(69, 13);
            this.lblExtractFileSizeFilter.TabIndex = 12;
            this.lblExtractFileSizeFilter.Text = "File size filter:";
            // 
            // lblExtractPath
            // 
            this.lblExtractPath.AutoSize = true;
            this.lblExtractPath.Location = new System.Drawing.Point(16, 16);
            this.lblExtractPath.Name = "lblExtractPath";
            this.lblExtractPath.Size = new System.Drawing.Size(55, 13);
            this.lblExtractPath.TabIndex = 2;
            this.lblExtractPath.Text = "Extract to:";
            // 
            // txtExtractFileFilter
            // 
            this.txtExtractFileFilter.Location = new System.Drawing.Point(776, 16);
            this.txtExtractFileFilter.Name = "txtExtractFileFilter";
            this.txtExtractFileFilter.Size = new System.Drawing.Size(176, 20);
            this.txtExtractFileFilter.TabIndex = 1;
            this.ttApp.SetToolTip(this.txtExtractFileFilter, resources.GetString("txtExtractFileFilter.ToolTip"));
            this.txtExtractFileFilter.TextChanged += new System.EventHandler(this.txtExtractFileFilter_TextChanged);
            // 
            // txtExtractPath
            // 
            this.txtExtractPath.AllowDrop = true;
            this.txtExtractPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtExtractPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtExtractPath.Location = new System.Drawing.Point(112, 12);
            this.txtExtractPath.Name = "txtExtractPath";
            this.txtExtractPath.Size = new System.Drawing.Size(472, 20);
            this.txtExtractPath.TabIndex = 1;
            this.ttApp.SetToolTip(this.txtExtractPath, "Where are you want to extract all files?");
            this.txtExtractPath.TextChanged += new System.EventHandler(this.txtExtractPath_TextChanged);
            this.txtExtractPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtExtractPath_DragDrop);
            this.txtExtractPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtExtractPath_DragEnter);
            // 
            // lblExtractFileFilter
            // 
            this.lblExtractFileFilter.AutoSize = true;
            this.lblExtractFileFilter.Location = new System.Drawing.Point(696, 20);
            this.lblExtractFileFilter.Name = "lblExtractFileFilter";
            this.lblExtractFileFilter.Size = new System.Drawing.Size(48, 13);
            this.lblExtractFileFilter.TabIndex = 0;
            this.lblExtractFileFilter.Text = "File filter:";
            // 
            // txtUnRARPath
            // 
            this.txtUnRARPath.AllowDrop = true;
            this.txtUnRARPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUnRARPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtUnRARPath.Location = new System.Drawing.Point(112, 36);
            this.txtUnRARPath.Name = "txtUnRARPath";
            this.txtUnRARPath.Size = new System.Drawing.Size(472, 20);
            this.txtUnRARPath.TabIndex = 4;
            this.ttApp.SetToolTip(this.txtUnRARPath, "Using WinRAR for extract files. If you have WinRAR then you will find UnRAR.exe i" +
                    "n WinRAR folder.");
            this.txtUnRARPath.TextChanged += new System.EventHandler(this.txtUnRARPath_TextChanged);
            this.txtUnRARPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtUnRARPath_DragDrop);
            this.txtUnRARPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtUnRARPath_DragEnter);
            // 
            // btnExtractClear
            // 
            this.btnExtractClear.Location = new System.Drawing.Point(176, 96);
            this.btnExtractClear.Name = "btnExtractClear";
            this.btnExtractClear.Size = new System.Drawing.Size(72, 24);
            this.btnExtractClear.TabIndex = 11;
            this.btnExtractClear.Text = "Clear";
            this.btnExtractClear.UseVisualStyleBackColor = true;
            this.btnExtractClear.Click += new System.EventHandler(this.btnExtractClear_Click);
            // 
            // cbSearchSubFolders
            // 
            this.cbSearchSubFolders.AutoSize = true;
            this.cbSearchSubFolders.Checked = true;
            this.cbSearchSubFolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSearchSubFolders.Location = new System.Drawing.Point(16, 64);
            this.cbSearchSubFolders.Name = "cbSearchSubFolders";
            this.cbSearchSubFolders.Size = new System.Drawing.Size(114, 17);
            this.cbSearchSubFolders.TabIndex = 7;
            this.cbSearchSubFolders.Text = "Search sub folders";
            this.ttApp.SetToolTip(this.cbSearchSubFolders, "Example if you added this folder: E:\\TV\\Lost\r\nThen will be search sub folders too" +
                    " (Season 1, Season 2...)");
            this.cbSearchSubFolders.UseVisualStyleBackColor = true;
            this.cbSearchSubFolders.CheckedChanged += new System.EventHandler(this.cbSearchSubFolders_CheckedChanged);
            // 
            // btnExtractRemove
            // 
            this.btnExtractRemove.Location = new System.Drawing.Point(96, 96);
            this.btnExtractRemove.Name = "btnExtractRemove";
            this.btnExtractRemove.Size = new System.Drawing.Size(72, 24);
            this.btnExtractRemove.TabIndex = 10;
            this.btnExtractRemove.Text = "Remove";
            this.btnExtractRemove.UseVisualStyleBackColor = true;
            this.btnExtractRemove.Click += new System.EventHandler(this.btnExtractRemove_Click);
            // 
            // lblUnRARPath
            // 
            this.lblUnRARPath.AutoSize = true;
            this.lblUnRARPath.Location = new System.Drawing.Point(16, 40);
            this.lblUnRARPath.Name = "lblUnRARPath";
            this.lblUnRARPath.Size = new System.Drawing.Size(91, 13);
            this.lblUnRARPath.TabIndex = 3;
            this.lblUnRARPath.Text = "UnRAR.exe path:";
            // 
            // btnExtractAdd
            // 
            this.btnExtractAdd.Location = new System.Drawing.Point(16, 96);
            this.btnExtractAdd.Name = "btnExtractAdd";
            this.btnExtractAdd.Size = new System.Drawing.Size(72, 24);
            this.btnExtractAdd.TabIndex = 9;
            this.btnExtractAdd.Text = "Add";
            this.btnExtractAdd.UseVisualStyleBackColor = true;
            this.btnExtractAdd.Click += new System.EventHandler(this.btnExtractAdd_Click);
            // 
            // btnExtractBrowse
            // 
            this.btnExtractBrowse.Location = new System.Drawing.Point(592, 12);
            this.btnExtractBrowse.Name = "btnExtractBrowse";
            this.btnExtractBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnExtractBrowse.TabIndex = 5;
            this.btnExtractBrowse.Text = "Browse...";
            this.btnExtractBrowse.UseVisualStyleBackColor = true;
            this.btnExtractBrowse.Click += new System.EventHandler(this.btnExtractBrowse_Click);
            // 
            // btnExtractAll
            // 
            this.btnExtractAll.Location = new System.Drawing.Point(256, 96);
            this.btnExtractAll.Name = "btnExtractAll";
            this.btnExtractAll.Size = new System.Drawing.Size(88, 24);
            this.btnExtractAll.TabIndex = 8;
            this.btnExtractAll.Text = "Extract all";
            this.btnExtractAll.UseVisualStyleBackColor = true;
            this.btnExtractAll.Click += new System.EventHandler(this.btnExtractAll_Click);
            // 
            // btnUnRARBrowse
            // 
            this.btnUnRARBrowse.Location = new System.Drawing.Point(592, 36);
            this.btnUnRARBrowse.Name = "btnUnRARBrowse";
            this.btnUnRARBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnUnRARBrowse.TabIndex = 6;
            this.btnUnRARBrowse.Text = "Browse...";
            this.btnUnRARBrowse.UseVisualStyleBackColor = true;
            this.btnUnRARBrowse.Click += new System.EventHandler(this.btnUnRARBrowse_Click);
            // 
            // lvExtractList
            // 
            this.lvExtractList.AllowDrop = true;
            this.lvExtractList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvExtractList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvExtractList.FullRowSelect = true;
            this.lvExtractList.HideSelection = false;
            this.lvExtractList.Location = new System.Drawing.Point(0, 0);
            this.lvExtractList.MultiSelect = false;
            this.lvExtractList.Name = "lvExtractList";
            this.lvExtractList.Size = new System.Drawing.Size(990, 470);
            this.lvExtractList.TabIndex = 0;
            this.lvExtractList.UseCompatibleStateImageBehavior = false;
            this.lvExtractList.View = System.Windows.Forms.View.Details;
            this.lvExtractList.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvExtractList_DragDrop);
            this.lvExtractList.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvExtractList_DragEnter);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Files";
            this.columnHeader1.Width = 972;
            // 
            // tpSeriesInfo
            // 
            this.tpSeriesInfo.Controls.Add(this.tcSeriesInfo);
            this.tpSeriesInfo.Location = new System.Drawing.Point(4, 24);
            this.tpSeriesInfo.Name = "tpSeriesInfo";
            this.tpSeriesInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpSeriesInfo.Size = new System.Drawing.Size(996, 608);
            this.tpSeriesInfo.TabIndex = 4;
            this.tpSeriesInfo.Text = "Database";
            this.tpSeriesInfo.UseVisualStyleBackColor = true;
            // 
            // tcSeriesInfo
            // 
            this.tcSeriesInfo.Controls.Add(this.tpSeries);
            this.tcSeriesInfo.Controls.Add(this.tpEpisodes);
            this.tcSeriesInfo.Controls.Add(this.tpSeriesImages);
            this.tcSeriesInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSeriesInfo.Location = new System.Drawing.Point(3, 3);
            this.tcSeriesInfo.Name = "tcSeriesInfo";
            this.tcSeriesInfo.SelectedIndex = 0;
            this.tcSeriesInfo.Size = new System.Drawing.Size(990, 602);
            this.tcSeriesInfo.TabIndex = 0;
            // 
            // tpSeries
            // 
            this.tpSeries.Controls.Add(this.pbSeriesBanner);
            this.tpSeries.Controls.Add(this.btnQuickSearchSeries);
            this.tpSeries.Controls.Add(this.btnLoadSeries);
            this.tpSeries.Controls.Add(this.btnSearchSeries);
            this.tpSeries.Controls.Add(this.txtSeriesName);
            this.tpSeries.Controls.Add(this.txtSeriesID);
            this.tpSeries.Controls.Add(this.plvSeries);
            this.tpSeries.Location = new System.Drawing.Point(4, 22);
            this.tpSeries.Name = "tpSeries";
            this.tpSeries.Padding = new System.Windows.Forms.Padding(3);
            this.tpSeries.Size = new System.Drawing.Size(982, 576);
            this.tpSeries.TabIndex = 0;
            this.tpSeries.Text = "Series";
            this.tpSeries.UseVisualStyleBackColor = true;
            // 
            // pbSeriesBanner
            // 
            this.pbSeriesBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSeriesBanner.Location = new System.Drawing.Point(8, 40);
            this.pbSeriesBanner.Name = "pbSeriesBanner";
            this.pbSeriesBanner.Size = new System.Drawing.Size(496, 80);
            this.pbSeriesBanner.TabIndex = 6;
            this.pbSeriesBanner.TabStop = false;
            // 
            // btnQuickSearchSeries
            // 
            this.btnQuickSearchSeries.Location = new System.Drawing.Point(312, 8);
            this.btnQuickSearchSeries.Name = "btnQuickSearchSeries";
            this.btnQuickSearchSeries.Size = new System.Drawing.Size(96, 23);
            this.btnQuickSearchSeries.TabIndex = 5;
            this.btnQuickSearchSeries.Text = "Quick Search";
            this.btnQuickSearchSeries.UseVisualStyleBackColor = true;
            this.btnQuickSearchSeries.Click += new System.EventHandler(this.btnQuickSearchSeries_Click);
            // 
            // btnLoadSeries
            // 
            this.btnLoadSeries.Location = new System.Drawing.Point(520, 8);
            this.btnLoadSeries.Name = "btnLoadSeries";
            this.btnLoadSeries.Size = new System.Drawing.Size(64, 24);
            this.btnLoadSeries.TabIndex = 4;
            this.btnLoadSeries.Text = "Load";
            this.btnLoadSeries.UseVisualStyleBackColor = true;
            this.btnLoadSeries.Click += new System.EventHandler(this.btnLoadSeries_Click);
            // 
            // btnSearchSeries
            // 
            this.btnSearchSeries.Location = new System.Drawing.Point(232, 8);
            this.btnSearchSeries.Name = "btnSearchSeries";
            this.btnSearchSeries.Size = new System.Drawing.Size(75, 23);
            this.btnSearchSeries.TabIndex = 3;
            this.btnSearchSeries.Text = "Search";
            this.btnSearchSeries.UseVisualStyleBackColor = true;
            this.btnSearchSeries.Click += new System.EventHandler(this.btnSearchSeries_Click);
            // 
            // txtSeriesName
            // 
            this.txtSeriesName.Location = new System.Drawing.Point(8, 8);
            this.txtSeriesName.Name = "txtSeriesName";
            this.txtSeriesName.Size = new System.Drawing.Size(216, 20);
            this.txtSeriesName.TabIndex = 2;
            this.txtSeriesName.TextChanged += new System.EventHandler(this.txtSeriesName_TextChanged);
            // 
            // txtSeriesID
            // 
            this.txtSeriesID.Location = new System.Drawing.Point(416, 8);
            this.txtSeriesID.Name = "txtSeriesID";
            this.txtSeriesID.Size = new System.Drawing.Size(100, 20);
            this.txtSeriesID.TabIndex = 1;
            this.txtSeriesID.TextChanged += new System.EventHandler(this.txtSeriesID_TextChanged);
            // 
            // tpEpisodes
            // 
            this.tpEpisodes.Controls.Add(this.groupBox1);
            this.tpEpisodes.Controls.Add(this.tvEpisodes);
            this.tpEpisodes.Controls.Add(this.plvEpisodes);
            this.tpEpisodes.Location = new System.Drawing.Point(4, 22);
            this.tpEpisodes.Name = "tpEpisodes";
            this.tpEpisodes.Padding = new System.Windows.Forms.Padding(3);
            this.tpEpisodes.Size = new System.Drawing.Size(982, 576);
            this.tpEpisodes.TabIndex = 1;
            this.tpEpisodes.Text = "Episodes";
            this.tpEpisodes.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEpisodeNumber);
            this.groupBox1.Controls.Add(this.txtSeasonNumber);
            this.groupBox1.Controls.Add(this.lblEpisodeNumber);
            this.groupBox1.Controls.Add(this.lblSeasonNumber);
            this.groupBox1.Controls.Add(this.txtEpisodeName);
            this.groupBox1.Controls.Add(this.lblEpisodeName);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 48);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter episodes:";
            // 
            // txtEpisodeNumber
            // 
            this.txtEpisodeNumber.Location = new System.Drawing.Point(520, 20);
            this.txtEpisodeNumber.Name = "txtEpisodeNumber";
            this.txtEpisodeNumber.Size = new System.Drawing.Size(24, 20);
            this.txtEpisodeNumber.TabIndex = 5;
            this.txtEpisodeNumber.TextChanged += new System.EventHandler(this.EpisodesFilterChanged);
            // 
            // txtSeasonNumber
            // 
            this.txtSeasonNumber.Location = new System.Drawing.Point(400, 20);
            this.txtSeasonNumber.Name = "txtSeasonNumber";
            this.txtSeasonNumber.Size = new System.Drawing.Size(24, 20);
            this.txtSeasonNumber.TabIndex = 4;
            this.txtSeasonNumber.TextChanged += new System.EventHandler(this.EpisodesFilterChanged);
            // 
            // lblEpisodeNumber
            // 
            this.lblEpisodeNumber.AutoSize = true;
            this.lblEpisodeNumber.Location = new System.Drawing.Point(432, 24);
            this.lblEpisodeNumber.Name = "lblEpisodeNumber";
            this.lblEpisodeNumber.Size = new System.Drawing.Size(86, 13);
            this.lblEpisodeNumber.TabIndex = 3;
            this.lblEpisodeNumber.Text = "Episode number:";
            // 
            // lblSeasonNumber
            // 
            this.lblSeasonNumber.AutoSize = true;
            this.lblSeasonNumber.Location = new System.Drawing.Point(312, 24);
            this.lblSeasonNumber.Name = "lblSeasonNumber";
            this.lblSeasonNumber.Size = new System.Drawing.Size(84, 13);
            this.lblSeasonNumber.TabIndex = 2;
            this.lblSeasonNumber.Text = "Season number:";
            // 
            // txtEpisodeName
            // 
            this.txtEpisodeName.Location = new System.Drawing.Point(104, 20);
            this.txtEpisodeName.Name = "txtEpisodeName";
            this.txtEpisodeName.Size = new System.Drawing.Size(200, 20);
            this.txtEpisodeName.TabIndex = 1;
            this.txtEpisodeName.TextChanged += new System.EventHandler(this.EpisodesFilterChanged);
            // 
            // lblEpisodeName
            // 
            this.lblEpisodeName.AutoSize = true;
            this.lblEpisodeName.Location = new System.Drawing.Point(16, 24);
            this.lblEpisodeName.Name = "lblEpisodeName";
            this.lblEpisodeName.Size = new System.Drawing.Size(77, 13);
            this.lblEpisodeName.TabIndex = 0;
            this.lblEpisodeName.Text = "Episode name:";
            // 
            // tvEpisodes
            // 
            this.tvEpisodes.Location = new System.Drawing.Point(8, 64);
            this.tvEpisodes.Name = "tvEpisodes";
            this.tvEpisodes.Size = new System.Drawing.Size(504, 504);
            this.tvEpisodes.TabIndex = 0;
            this.tvEpisodes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvEpisodes_AfterSelect);
            // 
            // tpSeriesImages
            // 
            this.tpSeriesImages.Controls.Add(this.pbBanner);
            this.tpSeriesImages.Controls.Add(this.tcSeriesImages);
            this.tpSeriesImages.Controls.Add(this.plvBanners);
            this.tpSeriesImages.Location = new System.Drawing.Point(4, 22);
            this.tpSeriesImages.Name = "tpSeriesImages";
            this.tpSeriesImages.Size = new System.Drawing.Size(982, 576);
            this.tpSeriesImages.TabIndex = 2;
            this.tpSeriesImages.Text = "Images";
            this.tpSeriesImages.UseVisualStyleBackColor = true;
            // 
            // pbBanner
            // 
            this.pbBanner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBanner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBanner.Location = new System.Drawing.Point(408, 8);
            this.pbBanner.Name = "pbBanner";
            this.pbBanner.Size = new System.Drawing.Size(560, 552);
            this.pbBanner.TabIndex = 6;
            this.pbBanner.TabStop = false;
            this.pbBanner.Click += new System.EventHandler(this.pbBanner_Click);
            // 
            // tcSeriesImages
            // 
            this.tcSeriesImages.Controls.Add(this.tpBanners);
            this.tcSeriesImages.Controls.Add(this.tpActors);
            this.tcSeriesImages.Location = new System.Drawing.Point(8, 8);
            this.tcSeriesImages.Name = "tcSeriesImages";
            this.tcSeriesImages.SelectedIndex = 0;
            this.tcSeriesImages.Size = new System.Drawing.Size(392, 376);
            this.tcSeriesImages.TabIndex = 4;
            // 
            // tpBanners
            // 
            this.tpBanners.Controls.Add(this.lvBanners);
            this.tpBanners.Location = new System.Drawing.Point(4, 22);
            this.tpBanners.Name = "tpBanners";
            this.tpBanners.Padding = new System.Windows.Forms.Padding(3);
            this.tpBanners.Size = new System.Drawing.Size(384, 350);
            this.tpBanners.TabIndex = 0;
            this.tpBanners.Text = "Banners";
            this.tpBanners.UseVisualStyleBackColor = true;
            // 
            // tpActors
            // 
            this.tpActors.Controls.Add(this.lvActors);
            this.tpActors.Location = new System.Drawing.Point(4, 22);
            this.tpActors.Name = "tpActors";
            this.tpActors.Padding = new System.Windows.Forms.Padding(3);
            this.tpActors.Size = new System.Drawing.Size(384, 350);
            this.tpActors.TabIndex = 1;
            this.tpActors.Text = "Actors";
            this.tpActors.UseVisualStyleBackColor = true;
            // 
            // tpConsole
            // 
            this.tpConsole.Controls.Add(this.txtConsole);
            this.tpConsole.Location = new System.Drawing.Point(4, 24);
            this.tpConsole.Name = "tpConsole";
            this.tpConsole.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsole.Size = new System.Drawing.Size(996, 608);
            this.tpConsole.TabIndex = 1;
            this.tpConsole.Text = "Console";
            this.tpConsole.UseVisualStyleBackColor = true;
            // 
            // txtConsole
            // 
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsole.Location = new System.Drawing.Point(3, 3);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConsole.Size = new System.Drawing.Size(990, 602);
            this.txtConsole.TabIndex = 0;
            this.txtConsole.WordWrap = false;
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.btnRefreshSettings);
            this.tpSettings.Controls.Add(this.plvSettings);
            this.tpSettings.Controls.Add(this.gbGeneralSettings);
            this.tpSettings.Controls.Add(this.gbRenameSettings);
            this.tpSettings.Location = new System.Drawing.Point(4, 24);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(996, 608);
            this.tpSettings.TabIndex = 2;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // btnRefreshSettings
            // 
            this.btnRefreshSettings.Location = new System.Drawing.Point(880, 568);
            this.btnRefreshSettings.Name = "btnRefreshSettings";
            this.btnRefreshSettings.Size = new System.Drawing.Size(72, 24);
            this.btnRefreshSettings.TabIndex = 6;
            this.btnRefreshSettings.Text = "Refresh";
            this.btnRefreshSettings.UseVisualStyleBackColor = true;
            this.btnRefreshSettings.Click += new System.EventHandler(this.btnRefreshSettings_Click);
            // 
            // gbGeneralSettings
            // 
            this.gbGeneralSettings.Controls.Add(this.cbShowHelpTooltips);
            this.gbGeneralSettings.Location = new System.Drawing.Point(8, 8);
            this.gbGeneralSettings.Name = "gbGeneralSettings";
            this.gbGeneralSettings.Size = new System.Drawing.Size(976, 56);
            this.gbGeneralSettings.TabIndex = 4;
            this.gbGeneralSettings.TabStop = false;
            this.gbGeneralSettings.Text = "General Settings";
            // 
            // cbShowHelpTooltips
            // 
            this.cbShowHelpTooltips.AutoSize = true;
            this.cbShowHelpTooltips.Location = new System.Drawing.Point(16, 24);
            this.cbShowHelpTooltips.Name = "cbShowHelpTooltips";
            this.cbShowHelpTooltips.Size = new System.Drawing.Size(112, 17);
            this.cbShowHelpTooltips.TabIndex = 0;
            this.cbShowHelpTooltips.Text = "Show help tooltips";
            this.cbShowHelpTooltips.UseVisualStyleBackColor = true;
            this.cbShowHelpTooltips.CheckedChanged += new System.EventHandler(this.cbShowHelpTooltips_CheckedChanged);
            // 
            // gbRenameSettings
            // 
            this.gbRenameSettings.Controls.Add(this.txtReplaceSpaces);
            this.gbRenameSettings.Controls.Add(this.cbShowErrors);
            this.gbRenameSettings.Controls.Add(this.cbReplaceSpaces);
            this.gbRenameSettings.Controls.Add(this.txtReplaceIllegalChars);
            this.gbRenameSettings.Controls.Add(this.cbReplaceIllegalChars);
            this.gbRenameSettings.Controls.Add(this.cbGuessShowName);
            this.gbRenameSettings.Controls.Add(this.txtRegexpPattern);
            this.gbRenameSettings.Controls.Add(this.cbShowActionMessages);
            this.gbRenameSettings.Controls.Add(this.lblRegexpPattern);
            this.gbRenameSettings.Location = new System.Drawing.Point(8, 64);
            this.gbRenameSettings.Name = "gbRenameSettings";
            this.gbRenameSettings.Size = new System.Drawing.Size(976, 208);
            this.gbRenameSettings.TabIndex = 3;
            this.gbRenameSettings.TabStop = false;
            this.gbRenameSettings.Text = "Rename settings";
            // 
            // txtReplaceSpaces
            // 
            this.txtReplaceSpaces.Location = new System.Drawing.Point(200, 152);
            this.txtReplaceSpaces.Name = "txtReplaceSpaces";
            this.txtReplaceSpaces.Size = new System.Drawing.Size(40, 20);
            this.txtReplaceSpaces.TabIndex = 8;
            this.txtReplaceSpaces.TextChanged += new System.EventHandler(this.txtReplaceSpaces_TextChanged);
            // 
            // cbShowErrors
            // 
            this.cbShowErrors.AutoSize = true;
            this.cbShowErrors.Location = new System.Drawing.Point(16, 176);
            this.cbShowErrors.Name = "cbShowErrors";
            this.cbShowErrors.Size = new System.Drawing.Size(278, 17);
            this.cbShowErrors.TabIndex = 13;
            this.cbShowErrors.Text = "Show error message dialog boxes while renaming files";
            this.ttApp.SetToolTip(this.cbShowErrors, "Example if a filename contains illegal characters then \"Illegal characters in pat" +
                    "h\" error will be shown.\r\nIf you press cancel button in this message box then wil" +
                    "l be stop renaming.");
            this.cbShowErrors.UseVisualStyleBackColor = true;
            this.cbShowErrors.CheckedChanged += new System.EventHandler(this.cbShowErrors_CheckedChanged);
            // 
            // cbReplaceSpaces
            // 
            this.cbReplaceSpaces.AutoSize = true;
            this.cbReplaceSpaces.Location = new System.Drawing.Point(16, 152);
            this.cbReplaceSpaces.Name = "cbReplaceSpaces";
            this.cbReplaceSpaces.Size = new System.Drawing.Size(181, 17);
            this.cbReplaceSpaces.TabIndex = 7;
            this.cbReplaceSpaces.Text = "Replace spaces in filename with:";
            this.cbReplaceSpaces.UseVisualStyleBackColor = true;
            this.cbReplaceSpaces.CheckedChanged += new System.EventHandler(this.cbReplaceSpaces_CheckedChanged);
            // 
            // txtReplaceIllegalChars
            // 
            this.txtReplaceIllegalChars.Location = new System.Drawing.Point(288, 128);
            this.txtReplaceIllegalChars.Name = "txtReplaceIllegalChars";
            this.txtReplaceIllegalChars.Size = new System.Drawing.Size(40, 20);
            this.txtReplaceIllegalChars.TabIndex = 6;
            this.txtReplaceIllegalChars.TextChanged += new System.EventHandler(this.txtReplaceIllegalChars_TextChanged);
            // 
            // cbReplaceIllegalChars
            // 
            this.cbReplaceIllegalChars.AutoSize = true;
            this.cbReplaceIllegalChars.Location = new System.Drawing.Point(16, 128);
            this.cbReplaceIllegalChars.Name = "cbReplaceIllegalChars";
            this.cbReplaceIllegalChars.Size = new System.Drawing.Size(270, 17);
            this.cbReplaceIllegalChars.TabIndex = 5;
            this.cbReplaceIllegalChars.Text = "If filename have illegal characters then replace with:";
            this.cbReplaceIllegalChars.UseVisualStyleBackColor = true;
            this.cbReplaceIllegalChars.CheckedChanged += new System.EventHandler(this.cbReplaceIllegalChars_CheckedChanged);
            // 
            // cbGuessShowName
            // 
            this.cbGuessShowName.AutoSize = true;
            this.cbGuessShowName.Location = new System.Drawing.Point(16, 104);
            this.cbGuessShowName.Name = "cbGuessShowName";
            this.cbGuessShowName.Size = new System.Drawing.Size(301, 17);
            this.cbGuessShowName.TabIndex = 4;
            this.cbGuessShowName.Text = "Guess show name as root folder name instead folder name";
            this.ttApp.SetToolTip(this.cbGuessShowName, resources.GetString("cbGuessShowName.ToolTip"));
            this.cbGuessShowName.UseVisualStyleBackColor = true;
            this.cbGuessShowName.CheckedChanged += new System.EventHandler(this.cbGuessShowName_CheckedChanged);
            // 
            // txtRegexpPattern
            // 
            this.txtRegexpPattern.Location = new System.Drawing.Point(16, 48);
            this.txtRegexpPattern.Name = "txtRegexpPattern";
            this.txtRegexpPattern.Size = new System.Drawing.Size(944, 20);
            this.txtRegexpPattern.TabIndex = 0;
            this.ttApp.SetToolTip(this.txtRegexpPattern, "For find episode name need to know show and episode numbers.\r\nFor find this numbe" +
                    "rs using regular expression with this pattern.");
            this.txtRegexpPattern.TextChanged += new System.EventHandler(this.txtRegexpPattern_TextChanged);
            // 
            // cbShowActionMessages
            // 
            this.cbShowActionMessages.AutoSize = true;
            this.cbShowActionMessages.Location = new System.Drawing.Point(16, 80);
            this.cbShowActionMessages.Name = "cbShowActionMessages";
            this.cbShowActionMessages.Size = new System.Drawing.Size(447, 17);
            this.cbShowActionMessages.TabIndex = 2;
            this.cbShowActionMessages.Text = "Add important debug information (start and finish messages) for every show to the" +
                " console";
            this.ttApp.SetToolTip(this.cbShowActionMessages, resources.GetString("cbShowActionMessages.ToolTip"));
            this.cbShowActionMessages.UseVisualStyleBackColor = true;
            this.cbShowActionMessages.CheckedChanged += new System.EventHandler(this.cbShowActionMessages_CheckedChanged);
            // 
            // lblRegexpPattern
            // 
            this.lblRegexpPattern.AutoSize = true;
            this.lblRegexpPattern.Location = new System.Drawing.Point(16, 24);
            this.lblRegexpPattern.Name = "lblRegexpPattern";
            this.lblRegexpPattern.Size = new System.Drawing.Size(273, 13);
            this.lblRegexpPattern.TabIndex = 1;
            this.lblRegexpPattern.Text = "Regexp pattern for finding season and episode numbers:";
            // 
            // ttApp
            // 
            this.ttApp.AutomaticDelay = 100;
            this.ttApp.AutoPopDelay = 10000;
            this.ttApp.InitialDelay = 750;
            this.ttApp.IsBalloon = true;
            this.ttApp.ReshowDelay = 0;
            this.ttApp.UseFading = false;
            // 
            // plvSeries
            // 
            this.plvSeries.AllowEmptyObjects = false;
            this.plvSeries.ConstantColumnSize = true;
            this.plvSeries.FullRowSelect = true;
            this.plvSeries.GridLines = true;
            this.plvSeries.HideSelection = false;
            this.plvSeries.Location = new System.Drawing.Point(8, 128);
            this.plvSeries.MultiSelect = false;
            this.plvSeries.Name = "plvSeries";
            this.plvSeries.NameColumnSize = 150;
            this.plvSeries.SetObjectType = RenamerX.PropertyListView.ObjectType.Properties;
            this.plvSeries.Size = new System.Drawing.Size(968, 438);
            this.plvSeries.TabIndex = 0;
            this.plvSeries.UseCompatibleStateImageBehavior = false;
            this.plvSeries.View = System.Windows.Forms.View.Details;
            // 
            // plvEpisodes
            // 
            this.plvEpisodes.AllowEmptyObjects = false;
            this.plvEpisodes.ConstantColumnSize = true;
            this.plvEpisodes.FullRowSelect = true;
            this.plvEpisodes.GridLines = true;
            this.plvEpisodes.HideSelection = false;
            this.plvEpisodes.Location = new System.Drawing.Point(520, 64);
            this.plvEpisodes.MultiSelect = false;
            this.plvEpisodes.Name = "plvEpisodes";
            this.plvEpisodes.NameColumnSize = 150;
            this.plvEpisodes.SetObjectType = RenamerX.PropertyListView.ObjectType.Properties;
            this.plvEpisodes.Size = new System.Drawing.Size(456, 504);
            this.plvEpisodes.TabIndex = 1;
            this.plvEpisodes.UseCompatibleStateImageBehavior = false;
            this.plvEpisodes.View = System.Windows.Forms.View.Details;
            // 
            // lvBanners
            // 
            this.lvBanners.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9});
            this.lvBanners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBanners.FullRowSelect = true;
            this.lvBanners.HideSelection = false;
            this.lvBanners.Location = new System.Drawing.Point(3, 3);
            this.lvBanners.MultiSelect = false;
            this.lvBanners.Name = "lvBanners";
            this.lvBanners.Size = new System.Drawing.Size(378, 344);
            this.lvBanners.TabIndex = 0;
            this.lvBanners.UseCompatibleStateImageBehavior = false;
            this.lvBanners.View = System.Windows.Forms.View.Details;
            this.lvBanners.SelectedIndexChanged += new System.EventHandler(this.lvBanners_SelectedIndexChanged);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Banner Path";
            this.columnHeader9.Width = 350;
            // 
            // lvActors
            // 
            this.lvActors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11});
            this.lvActors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvActors.FullRowSelect = true;
            this.lvActors.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvActors.HideSelection = false;
            this.lvActors.Location = new System.Drawing.Point(3, 3);
            this.lvActors.MultiSelect = false;
            this.lvActors.Name = "lvActors";
            this.lvActors.Size = new System.Drawing.Size(378, 344);
            this.lvActors.TabIndex = 0;
            this.lvActors.UseCompatibleStateImageBehavior = false;
            this.lvActors.View = System.Windows.Forms.View.Details;
            this.lvActors.SelectedIndexChanged += new System.EventHandler(this.lvActors_SelectedIndexChanged);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Name";
            this.columnHeader10.Width = 175;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Role";
            this.columnHeader11.Width = 175;
            // 
            // plvBanners
            // 
            this.plvBanners.AllowEmptyObjects = false;
            this.plvBanners.ConstantColumnSize = true;
            this.plvBanners.FullRowSelect = true;
            this.plvBanners.GridLines = true;
            this.plvBanners.HideSelection = false;
            this.plvBanners.Location = new System.Drawing.Point(8, 392);
            this.plvBanners.MultiSelect = false;
            this.plvBanners.Name = "plvBanners";
            this.plvBanners.NameColumnSize = 150;
            this.plvBanners.SetObjectType = RenamerX.PropertyListView.ObjectType.Properties;
            this.plvBanners.Size = new System.Drawing.Size(392, 168);
            this.plvBanners.TabIndex = 5;
            this.plvBanners.UseCompatibleStateImageBehavior = false;
            this.plvBanners.View = System.Windows.Forms.View.Details;
            // 
            // plvSettings
            // 
            this.plvSettings.AllowEmptyObjects = true;
            this.plvSettings.ConstantColumnSize = true;
            this.plvSettings.FullRowSelect = true;
            this.plvSettings.GridLines = true;
            this.plvSettings.HideSelection = false;
            this.plvSettings.Location = new System.Drawing.Point(8, 280);
            this.plvSettings.MultiSelect = false;
            this.plvSettings.Name = "plvSettings";
            this.plvSettings.NameColumnSize = 150;
            this.plvSettings.SetObjectType = RenamerX.PropertyListView.ObjectType.Fields;
            this.plvSettings.Size = new System.Drawing.Size(976, 320);
            this.plvSettings.TabIndex = 5;
            this.plvSettings.UseCompatibleStateImageBehavior = false;
            this.plvSettings.View = System.Windows.Forms.View.Details;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 642);
            this.Controls.Add(this.tcMain);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RenamerX - Rename your files eXpressly";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.tcMain.ResumeLayout(false);
            this.tpMain.ResumeLayout(false);
            this.scRename.Panel1.ResumeLayout(false);
            this.scRename.Panel1.PerformLayout();
            this.scRename.Panel2.ResumeLayout(false);
            this.scRename.ResumeLayout(false);
            this.tpExtract.ResumeLayout(false);
            this.scExtract.Panel1.ResumeLayout(false);
            this.scExtract.Panel1.PerformLayout();
            this.scExtract.Panel2.ResumeLayout(false);
            this.scExtract.ResumeLayout(false);
            this.tpSeriesInfo.ResumeLayout(false);
            this.tcSeriesInfo.ResumeLayout(false);
            this.tpSeries.ResumeLayout(false);
            this.tpSeries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeriesBanner)).EndInit();
            this.tpEpisodes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpSeriesImages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).EndInit();
            this.tcSeriesImages.ResumeLayout(false);
            this.tpBanners.ResumeLayout(false);
            this.tpActors.ResumeLayout(false);
            this.tpConsole.ResumeLayout(false);
            this.tpConsole.PerformLayout();
            this.tpSettings.ResumeLayout(false);
            this.gbGeneralSettings.ResumeLayout(false);
            this.gbGeneralSettings.PerformLayout();
            this.gbRenameSettings.ResumeLayout(false);
            this.gbRenameSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpMain;
        private System.Windows.Forms.TabPage tpConsole;
        private System.Windows.Forms.TextBox txtNameFormat;
        private System.Windows.Forms.TextBox txtRenameFileFilter;
        private System.Windows.Forms.Label lblNameFormat;
        private System.Windows.Forms.Label lblRenameFileFilter;
        private System.Windows.Forms.Button btnRenameAdd;
        private System.Windows.Forms.Button btnRenameRemove;
        private System.Windows.Forms.SplitContainer scRename;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRenameClear;
        private System.Windows.Forms.ToolTip ttApp;
        private System.Windows.Forms.Button btnRenameAll;
        private System.Windows.Forms.CheckBox cbShowErrors;
        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.ListView lvShows;
        private System.Windows.Forms.ColumnHeader lvListColumn1;
        private System.Windows.Forms.ColumnHeader lvShowsColumn1;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.Label lblRegexpPattern;
        private System.Windows.Forms.TextBox txtRegexpPattern;
        private System.Windows.Forms.ColumnHeader lvListColumn2;
        private System.Windows.Forms.CheckBox cbShowActionMessages;
        private System.Windows.Forms.Label lblItemsCount;
        private System.Windows.Forms.TabPage tpExtract;
        private System.Windows.Forms.Label lblExtractPath;
        private System.Windows.Forms.TextBox txtExtractPath;
        private System.Windows.Forms.ListView lvExtractList;
        private System.Windows.Forms.TextBox txtUnRARPath;
        private System.Windows.Forms.Label lblUnRARPath;
        private System.Windows.Forms.GroupBox gbRenameSettings;
        private System.Windows.Forms.Button btnExtractAdd;
        private System.Windows.Forms.Button btnExtractAll;
        private System.Windows.Forms.CheckBox cbSearchSubFolders;
        private System.Windows.Forms.Button btnUnRARBrowse;
        private System.Windows.Forms.Button btnExtractBrowse;
        private System.Windows.Forms.Button btnExtractClear;
        private System.Windows.Forms.Button btnExtractRemove;
        private System.Windows.Forms.Label lblExtractFileFilter;
        private System.Windows.Forms.TextBox txtExtractFileFilter;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.SplitContainer scExtract;
        private System.Windows.Forms.TextBox txtExtractFileSizeFilter;
        private System.Windows.Forms.Label lblExtractFileSizeFilter;
        private System.Windows.Forms.Label lblFileCount;
        private System.Windows.Forms.CheckBox cbGuessShowName;
        private System.Windows.Forms.ProgressBar pbExtract;
        private System.Windows.Forms.CheckBox cbExtractOverwrite;
        private System.Windows.Forms.TextBox txtExtractPassword;
        private System.Windows.Forms.Label lblExtractPassword;
        private System.Windows.Forms.TextBox txtReplaceIllegalChars;
        private System.Windows.Forms.CheckBox cbReplaceIllegalChars;
        private System.Windows.Forms.TextBox txtReplaceSpaces;
        private System.Windows.Forms.CheckBox cbReplaceSpaces;
        private System.Windows.Forms.Label lblNameFormatPreview;
        private System.Windows.Forms.GroupBox gbGeneralSettings;
        private System.Windows.Forms.CheckBox cbShowHelpTooltips;
        private System.Windows.Forms.TabPage tpSeriesInfo;
        private System.Windows.Forms.TabControl tcSeriesInfo;
        private System.Windows.Forms.TabPage tpSeries;
        private PropertyListView plvSeries;
        private System.Windows.Forms.TabPage tpEpisodes;
        private System.Windows.Forms.Button btnLoadSeries;
        private System.Windows.Forms.Button btnSearchSeries;
        private System.Windows.Forms.TextBox txtSeriesName;
        private System.Windows.Forms.TextBox txtSeriesID;
        private System.Windows.Forms.Button btnQuickSearchSeries;
        private System.Windows.Forms.TabPage tpSeriesImages;
        private System.Windows.Forms.PictureBox pbSeriesBanner;
        private System.Windows.Forms.TreeView tvEpisodes;
        private PropertyListView plvEpisodes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEpisodeNumber;
        private System.Windows.Forms.TextBox txtSeasonNumber;
        private System.Windows.Forms.Label lblEpisodeNumber;
        private System.Windows.Forms.Label lblSeasonNumber;
        private System.Windows.Forms.TextBox txtEpisodeName;
        private System.Windows.Forms.Label lblEpisodeName;
        private System.Windows.Forms.PictureBox pbBanner;
        private PropertyListView plvBanners;
        private System.Windows.Forms.TabControl tcSeriesImages;
        private System.Windows.Forms.TabPage tpBanners;
        private ListViewX lvBanners;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TabPage tpActors;
        private ListViewX lvActors;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private PropertyListView plvSettings;
        private System.Windows.Forms.Button btnRefreshSettings;
    }
}
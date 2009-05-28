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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblItemsCount = new System.Windows.Forms.Label();
            this.lvShows = new System.Windows.Forms.ListView();
            this.lvShowsColumn1 = new System.Windows.Forms.ColumnHeader();
            this.btnRenameAll = new System.Windows.Forms.Button();
            this.btnRenameClear = new System.Windows.Forms.Button();
            this.lblRenameFileFilter = new System.Windows.Forms.Label();
            this.lblNameFormat = new System.Windows.Forms.Label();
            this.btnRenameRemove = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRenameAdd = new System.Windows.Forms.Button();
            this.lvList = new System.Windows.Forms.ListView();
            this.lvListColumn1 = new System.Windows.Forms.ColumnHeader();
            this.lvListColumn2 = new System.Windows.Forms.ColumnHeader();
            this.tpExtract = new System.Windows.Forms.TabPage();
            this.btnExtractClear = new System.Windows.Forms.Button();
            this.btnExtractRemove = new System.Windows.Forms.Button();
            this.btnExtractAdd = new System.Windows.Forms.Button();
            this.btnExtractAll = new System.Windows.Forms.Button();
            this.btnUnRARBrowse = new System.Windows.Forms.Button();
            this.btnExtractBrowse = new System.Windows.Forms.Button();
            this.lblUnRARPath = new System.Windows.Forms.Label();
            this.lblExtractPath = new System.Windows.Forms.Label();
            this.lvExtractList = new System.Windows.Forms.ListView();
            this.tpConsole = new System.Windows.Forms.TabPage();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.gbExtract = new System.Windows.Forms.GroupBox();
            this.lblExtractFileFilter = new System.Windows.Forms.Label();
            this.gbRename = new System.Windows.Forms.GroupBox();
            this.lblRegexpPattern = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.cbShowErrors = new System.Windows.Forms.CheckBox();
            this.txtRenameFileFilter = new System.Windows.Forms.TextBox();
            this.txtNameFormat = new System.Windows.Forms.TextBox();
            this.cbSearchSubFolders = new System.Windows.Forms.CheckBox();
            this.txtUnRARPath = new System.Windows.Forms.TextBox();
            this.txtExtractPath = new System.Windows.Forms.TextBox();
            this.txtExtractFileFilter = new System.Windows.Forms.TextBox();
            this.txtRegexpPattern = new System.Windows.Forms.TextBox();
            this.cbShowActionMessages = new System.Windows.Forms.CheckBox();
            this.tcMain.SuspendLayout();
            this.tpMain.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tpExtract.SuspendLayout();
            this.tpConsole.SuspendLayout();
            this.tpSettings.SuspendLayout();
            this.gbExtract.SuspendLayout();
            this.gbRename.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpMain);
            this.tcMain.Controls.Add(this.tpExtract);
            this.tcMain.Controls.Add(this.tpConsole);
            this.tcMain.Controls.Add(this.tpSettings);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(3, 3);
            this.tcMain.Name = "tcMain";
            this.tcMain.Padding = new System.Drawing.Point(15, 4);
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1002, 636);
            this.tcMain.TabIndex = 2;
            // 
            // tpMain
            // 
            this.tpMain.Controls.Add(this.splitContainer1);
            this.tpMain.Location = new System.Drawing.Point(4, 24);
            this.tpMain.Name = "tpMain";
            this.tpMain.Padding = new System.Windows.Forms.Padding(3);
            this.tpMain.Size = new System.Drawing.Size(994, 608);
            this.tpMain.TabIndex = 0;
            this.tpMain.Text = "Rename";
            this.tpMain.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblItemsCount);
            this.splitContainer1.Panel1.Controls.Add(this.lvShows);
            this.splitContainer1.Panel1.Controls.Add(this.cbShowErrors);
            this.splitContainer1.Panel1.Controls.Add(this.btnRenameAll);
            this.splitContainer1.Panel1.Controls.Add(this.btnRenameClear);
            this.splitContainer1.Panel1.Controls.Add(this.lblRenameFileFilter);
            this.splitContainer1.Panel1.Controls.Add(this.txtRenameFileFilter);
            this.splitContainer1.Panel1.Controls.Add(this.lblNameFormat);
            this.splitContainer1.Panel1.Controls.Add(this.btnRenameRemove);
            this.splitContainer1.Panel1.Controls.Add(this.btnRefresh);
            this.splitContainer1.Panel1.Controls.Add(this.txtNameFormat);
            this.splitContainer1.Panel1.Controls.Add(this.btnRenameAdd);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvList);
            this.splitContainer1.Size = new System.Drawing.Size(988, 602);
            this.splitContainer1.SplitterDistance = 130;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 3;
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
            this.btnRenameAll.Text = "&Rename all";
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
            this.btnRenameClear.Click += new System.EventHandler(this.btnDirClear_Click);
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
            this.btnRenameRemove.Click += new System.EventHandler(this.btnDirRemove_Click);
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
            // btnRenameAdd
            // 
            this.btnRenameAdd.Location = new System.Drawing.Point(344, 8);
            this.btnRenameAdd.Name = "btnRenameAdd";
            this.btnRenameAdd.Size = new System.Drawing.Size(72, 24);
            this.btnRenameAdd.TabIndex = 7;
            this.btnRenameAdd.Text = "Add";
            this.btnRenameAdd.UseVisualStyleBackColor = true;
            this.btnRenameAdd.Click += new System.EventHandler(this.btnDirAdd_Click);
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
            this.lvList.Size = new System.Drawing.Size(988, 470);
            this.lvList.TabIndex = 0;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
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
            this.tpExtract.Controls.Add(this.btnExtractClear);
            this.tpExtract.Controls.Add(this.btnExtractRemove);
            this.tpExtract.Controls.Add(this.btnExtractAdd);
            this.tpExtract.Controls.Add(this.btnExtractAll);
            this.tpExtract.Controls.Add(this.btnUnRARBrowse);
            this.tpExtract.Controls.Add(this.btnExtractBrowse);
            this.tpExtract.Controls.Add(this.lblUnRARPath);
            this.tpExtract.Controls.Add(this.lblExtractPath);
            this.tpExtract.Controls.Add(this.cbSearchSubFolders);
            this.tpExtract.Controls.Add(this.txtUnRARPath);
            this.tpExtract.Controls.Add(this.txtExtractPath);
            this.tpExtract.Controls.Add(this.lvExtractList);
            this.tpExtract.Location = new System.Drawing.Point(4, 24);
            this.tpExtract.Name = "tpExtract";
            this.tpExtract.Padding = new System.Windows.Forms.Padding(3);
            this.tpExtract.Size = new System.Drawing.Size(994, 608);
            this.tpExtract.TabIndex = 3;
            this.tpExtract.Text = "Extract";
            this.tpExtract.UseVisualStyleBackColor = true;
            // 
            // btnExtractClear
            // 
            this.btnExtractClear.Location = new System.Drawing.Point(176, 88);
            this.btnExtractClear.Name = "btnExtractClear";
            this.btnExtractClear.Size = new System.Drawing.Size(72, 24);
            this.btnExtractClear.TabIndex = 11;
            this.btnExtractClear.Text = "Clear";
            this.btnExtractClear.UseVisualStyleBackColor = true;
            this.btnExtractClear.Click += new System.EventHandler(this.btnExtractClear_Click);
            // 
            // btnExtractRemove
            // 
            this.btnExtractRemove.Location = new System.Drawing.Point(96, 88);
            this.btnExtractRemove.Name = "btnExtractRemove";
            this.btnExtractRemove.Size = new System.Drawing.Size(72, 24);
            this.btnExtractRemove.TabIndex = 10;
            this.btnExtractRemove.Text = "Remove";
            this.btnExtractRemove.UseVisualStyleBackColor = true;
            this.btnExtractRemove.Click += new System.EventHandler(this.btnExtractRemove_Click);
            // 
            // btnExtractAdd
            // 
            this.btnExtractAdd.Location = new System.Drawing.Point(16, 88);
            this.btnExtractAdd.Name = "btnExtractAdd";
            this.btnExtractAdd.Size = new System.Drawing.Size(72, 24);
            this.btnExtractAdd.TabIndex = 9;
            this.btnExtractAdd.Text = "Add";
            this.btnExtractAdd.UseVisualStyleBackColor = true;
            this.btnExtractAdd.Click += new System.EventHandler(this.btnExtractAdd_Click);
            // 
            // btnExtractAll
            // 
            this.btnExtractAll.Location = new System.Drawing.Point(256, 88);
            this.btnExtractAll.Name = "btnExtractAll";
            this.btnExtractAll.Size = new System.Drawing.Size(88, 24);
            this.btnExtractAll.TabIndex = 8;
            this.btnExtractAll.Text = "Extract all";
            this.btnExtractAll.UseVisualStyleBackColor = true;
            // 
            // btnUnRARBrowse
            // 
            this.btnUnRARBrowse.Location = new System.Drawing.Point(584, 32);
            this.btnUnRARBrowse.Name = "btnUnRARBrowse";
            this.btnUnRARBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnUnRARBrowse.TabIndex = 6;
            this.btnUnRARBrowse.Text = "Browse...";
            this.btnUnRARBrowse.UseVisualStyleBackColor = true;
            this.btnUnRARBrowse.Click += new System.EventHandler(this.btnUnRARBrowse_Click);
            // 
            // btnExtractBrowse
            // 
            this.btnExtractBrowse.Location = new System.Drawing.Point(584, 8);
            this.btnExtractBrowse.Name = "btnExtractBrowse";
            this.btnExtractBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnExtractBrowse.TabIndex = 5;
            this.btnExtractBrowse.Text = "Browse...";
            this.btnExtractBrowse.UseVisualStyleBackColor = true;
            this.btnExtractBrowse.Click += new System.EventHandler(this.btnExtractBrowse_Click);
            // 
            // lblUnRARPath
            // 
            this.lblUnRARPath.AutoSize = true;
            this.lblUnRARPath.Location = new System.Drawing.Point(8, 36);
            this.lblUnRARPath.Name = "lblUnRARPath";
            this.lblUnRARPath.Size = new System.Drawing.Size(91, 13);
            this.lblUnRARPath.TabIndex = 3;
            this.lblUnRARPath.Text = "UnRAR.exe path:";
            // 
            // lblExtractPath
            // 
            this.lblExtractPath.AutoSize = true;
            this.lblExtractPath.Location = new System.Drawing.Point(8, 12);
            this.lblExtractPath.Name = "lblExtractPath";
            this.lblExtractPath.Size = new System.Drawing.Size(55, 13);
            this.lblExtractPath.TabIndex = 2;
            this.lblExtractPath.Text = "Extract to:";
            // 
            // lvExtractList
            // 
            this.lvExtractList.AllowDrop = true;
            this.lvExtractList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvExtractList.Location = new System.Drawing.Point(8, 120);
            this.lvExtractList.Name = "lvExtractList";
            this.lvExtractList.Size = new System.Drawing.Size(976, 272);
            this.lvExtractList.TabIndex = 0;
            this.lvExtractList.UseCompatibleStateImageBehavior = false;
            this.lvExtractList.View = System.Windows.Forms.View.Details;
            this.lvExtractList.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvExtractList_DragDrop);
            this.lvExtractList.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvExtractList_DragEnter);
            // 
            // tpConsole
            // 
            this.tpConsole.Controls.Add(this.txtConsole);
            this.tpConsole.Location = new System.Drawing.Point(4, 24);
            this.tpConsole.Name = "tpConsole";
            this.tpConsole.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsole.Size = new System.Drawing.Size(994, 608);
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
            this.txtConsole.Size = new System.Drawing.Size(988, 602);
            this.txtConsole.TabIndex = 0;
            this.txtConsole.WordWrap = false;
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.gbExtract);
            this.tpSettings.Controls.Add(this.gbRename);
            this.tpSettings.Location = new System.Drawing.Point(4, 24);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(994, 608);
            this.tpSettings.TabIndex = 2;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // gbExtract
            // 
            this.gbExtract.Controls.Add(this.txtExtractFileFilter);
            this.gbExtract.Controls.Add(this.lblExtractFileFilter);
            this.gbExtract.Location = new System.Drawing.Point(8, 128);
            this.gbExtract.Name = "gbExtract";
            this.gbExtract.Size = new System.Drawing.Size(976, 200);
            this.gbExtract.TabIndex = 4;
            this.gbExtract.TabStop = false;
            this.gbExtract.Text = "Extract settings";
            // 
            // lblExtractFileFilter
            // 
            this.lblExtractFileFilter.AutoSize = true;
            this.lblExtractFileFilter.Location = new System.Drawing.Point(16, 24);
            this.lblExtractFileFilter.Name = "lblExtractFileFilter";
            this.lblExtractFileFilter.Size = new System.Drawing.Size(48, 13);
            this.lblExtractFileFilter.TabIndex = 0;
            this.lblExtractFileFilter.Text = "File filter:";
            // 
            // gbRename
            // 
            this.gbRename.Controls.Add(this.txtRegexpPattern);
            this.gbRename.Controls.Add(this.cbShowActionMessages);
            this.gbRename.Controls.Add(this.lblRegexpPattern);
            this.gbRename.Location = new System.Drawing.Point(8, 8);
            this.gbRename.Name = "gbRename";
            this.gbRename.Size = new System.Drawing.Size(976, 112);
            this.gbRename.TabIndex = 3;
            this.gbRename.TabStop = false;
            this.gbRename.Text = "Rename settings";
            // 
            // lblRegexpPattern
            // 
            this.lblRegexpPattern.AutoSize = true;
            this.lblRegexpPattern.Location = new System.Drawing.Point(16, 24);
            this.lblRegexpPattern.Name = "lblRegexpPattern";
            this.lblRegexpPattern.Size = new System.Drawing.Size(259, 13);
            this.lblRegexpPattern.TabIndex = 1;
            this.lblRegexpPattern.Text = "Regexp pattern for find season and episode numbers:";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Files";
            this.columnHeader1.Width = 972;
            // 
            // cbShowErrors
            // 
            this.cbShowErrors.AutoSize = true;
            this.cbShowErrors.Checked = global::RenamerX.Properties.Settings.Default.ShowErrors;
            this.cbShowErrors.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RenamerX.Properties.Settings.Default, "ShowErrors", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbShowErrors.Location = new System.Drawing.Point(440, 72);
            this.cbShowErrors.Name = "cbShowErrors";
            this.cbShowErrors.Size = new System.Drawing.Size(261, 17);
            this.cbShowErrors.TabIndex = 13;
            this.cbShowErrors.Text = "Show error message boxes while changing names";
            this.toolTip1.SetToolTip(this.cbShowErrors, "If file name have illegal filename chars then giving this error : Illegal charact" +
                    "ers in path");
            this.cbShowErrors.UseVisualStyleBackColor = true;
            // 
            // txtRenameFileFilter
            // 
            this.txtRenameFileFilter.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RenamerX.Properties.Settings.Default, "RenameFileFilter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRenameFileFilter.Location = new System.Drawing.Point(520, 40);
            this.txtRenameFileFilter.Name = "txtRenameFileFilter";
            this.txtRenameFileFilter.Size = new System.Drawing.Size(176, 20);
            this.txtRenameFileFilter.TabIndex = 2;
            this.txtRenameFileFilter.Text = global::RenamerX.Properties.Settings.Default.RenameFileFilter;
            this.toolTip1.SetToolTip(this.txtRenameFileFilter, resources.GetString("txtRenameFileFilter.ToolTip"));
            // 
            // txtNameFormat
            // 
            this.txtNameFormat.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RenamerX.Properties.Settings.Default, "NameFormat", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNameFormat.Location = new System.Drawing.Point(520, 16);
            this.txtNameFormat.Name = "txtNameFormat";
            this.txtNameFormat.Size = new System.Drawing.Size(176, 20);
            this.txtNameFormat.TabIndex = 0;
            this.txtNameFormat.Text = global::RenamerX.Properties.Settings.Default.NameFormat;
            this.toolTip1.SetToolTip(this.txtNameFormat, resources.GetString("txtNameFormat.ToolTip"));
            // 
            // cbSearchSubFolders
            // 
            this.cbSearchSubFolders.AutoSize = true;
            this.cbSearchSubFolders.Checked = global::RenamerX.Properties.Settings.Default.SearchSubFolders;
            this.cbSearchSubFolders.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RenamerX.Properties.Settings.Default, "SearchSubFolders", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbSearchSubFolders.Location = new System.Drawing.Point(16, 64);
            this.cbSearchSubFolders.Name = "cbSearchSubFolders";
            this.cbSearchSubFolders.Size = new System.Drawing.Size(132, 17);
            this.cbSearchSubFolders.TabIndex = 7;
            this.cbSearchSubFolders.Text = "Search sub folders too";
            this.cbSearchSubFolders.UseVisualStyleBackColor = true;
            // 
            // txtUnRARPath
            // 
            this.txtUnRARPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RenamerX.Properties.Settings.Default, "UnRARPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtUnRARPath.Location = new System.Drawing.Point(104, 32);
            this.txtUnRARPath.Name = "txtUnRARPath";
            this.txtUnRARPath.Size = new System.Drawing.Size(472, 20);
            this.txtUnRARPath.TabIndex = 4;
            this.txtUnRARPath.Text = global::RenamerX.Properties.Settings.Default.UnRARPath;
            // 
            // txtExtractPath
            // 
            this.txtExtractPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RenamerX.Properties.Settings.Default, "ExtractPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtExtractPath.Location = new System.Drawing.Point(104, 8);
            this.txtExtractPath.Name = "txtExtractPath";
            this.txtExtractPath.Size = new System.Drawing.Size(472, 20);
            this.txtExtractPath.TabIndex = 1;
            this.txtExtractPath.Text = global::RenamerX.Properties.Settings.Default.ExtractPath;
            // 
            // txtExtractFileFilter
            // 
            this.txtExtractFileFilter.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RenamerX.Properties.Settings.Default, "ExtractFileFilter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtExtractFileFilter.Location = new System.Drawing.Point(72, 24);
            this.txtExtractFileFilter.Name = "txtExtractFileFilter";
            this.txtExtractFileFilter.Size = new System.Drawing.Size(176, 20);
            this.txtExtractFileFilter.TabIndex = 1;
            this.txtExtractFileFilter.Text = global::RenamerX.Properties.Settings.Default.ExtractFileFilter;
            // 
            // txtRegexpPattern
            // 
            this.txtRegexpPattern.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RenamerX.Properties.Settings.Default, "RegexpPattern", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRegexpPattern.Location = new System.Drawing.Point(16, 48);
            this.txtRegexpPattern.Name = "txtRegexpPattern";
            this.txtRegexpPattern.Size = new System.Drawing.Size(944, 20);
            this.txtRegexpPattern.TabIndex = 0;
            this.txtRegexpPattern.Text = global::RenamerX.Properties.Settings.Default.RegexpPattern;
            // 
            // cbShowActionMessages
            // 
            this.cbShowActionMessages.AutoSize = true;
            this.cbShowActionMessages.Checked = global::RenamerX.Properties.Settings.Default.ShowActionMessages;
            this.cbShowActionMessages.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RenamerX.Properties.Settings.Default, "ShowActionMessages", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbShowActionMessages.Location = new System.Drawing.Point(16, 80);
            this.cbShowActionMessages.Name = "cbShowActionMessages";
            this.cbShowActionMessages.Size = new System.Drawing.Size(264, 17);
            this.cbShowActionMessages.TabIndex = 2;
            this.cbShowActionMessages.Text = "Show shows started, finished messages in console";
            this.cbShowActionMessages.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 642);
            this.Controls.Add(this.tcMain);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "RenamerX - Rename your files eXpressly";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.tcMain.ResumeLayout(false);
            this.tpMain.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tpExtract.ResumeLayout(false);
            this.tpExtract.PerformLayout();
            this.tpConsole.ResumeLayout(false);
            this.tpConsole.PerformLayout();
            this.tpSettings.ResumeLayout(false);
            this.gbExtract.ResumeLayout(false);
            this.gbExtract.PerformLayout();
            this.gbRename.ResumeLayout(false);
            this.gbRename.PerformLayout();
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRenameClear;
        private System.Windows.Forms.ToolTip toolTip1;
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
        private System.Windows.Forms.GroupBox gbRename;
        private System.Windows.Forms.Button btnExtractAdd;
        private System.Windows.Forms.Button btnExtractAll;
        private System.Windows.Forms.CheckBox cbSearchSubFolders;
        private System.Windows.Forms.Button btnUnRARBrowse;
        private System.Windows.Forms.Button btnExtractBrowse;
        private System.Windows.Forms.Button btnExtractClear;
        private System.Windows.Forms.Button btnExtractRemove;
        private System.Windows.Forms.GroupBox gbExtract;
        private System.Windows.Forms.Label lblExtractFileFilter;
        private System.Windows.Forms.TextBox txtExtractFileFilter;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}
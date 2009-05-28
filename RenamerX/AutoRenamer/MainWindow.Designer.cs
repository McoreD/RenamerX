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
            this.lblFileFilter = new System.Windows.Forms.Label();
            this.lblNameFormat = new System.Windows.Forms.Label();
            this.btnRenameRemove = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRenameAdd = new System.Windows.Forms.Button();
            this.lvList = new System.Windows.Forms.ListView();
            this.lvListColumn1 = new System.Windows.Forms.ColumnHeader();
            this.lvListColumn2 = new System.Windows.Forms.ColumnHeader();
            this.tpConsole = new System.Windows.Forms.TabPage();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.lblRegexpPattern = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbShowErrors = new System.Windows.Forms.CheckBox();
            this.txtFileFilter = new System.Windows.Forms.TextBox();
            this.txtNameFormat = new System.Windows.Forms.TextBox();
            this.cbShowActionMessages = new System.Windows.Forms.CheckBox();
            this.txtRegexpPattern = new System.Windows.Forms.TextBox();
            this.tpExtract = new System.Windows.Forms.TabPage();
            this.lvExtractList = new System.Windows.Forms.ListView();
            this.txtExtractPath = new System.Windows.Forms.TextBox();
            this.lblExtractPath = new System.Windows.Forms.Label();
            this.lblUnRARPath = new System.Windows.Forms.Label();
            this.txtUnRARPath = new System.Windows.Forms.TextBox();
            this.gbRename = new System.Windows.Forms.GroupBox();
            this.btnExtractBrowse = new System.Windows.Forms.Button();
            this.btnUnRARBrowse = new System.Windows.Forms.Button();
            this.cbSearchSubFolders = new System.Windows.Forms.CheckBox();
            this.btnExtractAll = new System.Windows.Forms.Button();
            this.btnExtractAdd = new System.Windows.Forms.Button();
            this.btnExtractRemove = new System.Windows.Forms.Button();
            this.btnExtractClear = new System.Windows.Forms.Button();
            this.tcMain.SuspendLayout();
            this.tpMain.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tpConsole.SuspendLayout();
            this.tpSettings.SuspendLayout();
            this.tpExtract.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.lblFileFilter);
            this.splitContainer1.Panel1.Controls.Add(this.txtFileFilter);
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
            // lblFileFilter
            // 
            this.lblFileFilter.AutoSize = true;
            this.lblFileFilter.Location = new System.Drawing.Point(437, 40);
            this.lblFileFilter.Name = "lblFileFilter";
            this.lblFileFilter.Size = new System.Drawing.Size(51, 13);
            this.lblFileFilter.TabIndex = 3;
            this.lblFileFilter.Text = "File Filter:";
            // 
            // lblNameFormat
            // 
            this.lblNameFormat.AutoSize = true;
            this.lblNameFormat.Location = new System.Drawing.Point(437, 16);
            this.lblNameFormat.Name = "lblNameFormat";
            this.lblNameFormat.Size = new System.Drawing.Size(73, 13);
            this.lblNameFormat.TabIndex = 4;
            this.lblNameFormat.Text = "Name Format:";
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
            this.tpSettings.Controls.Add(this.gbRename);
            this.tpSettings.Location = new System.Drawing.Point(4, 24);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(994, 608);
            this.tpSettings.TabIndex = 2;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
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
            // txtFileFilter
            // 
            this.txtFileFilter.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RenamerX.Properties.Settings.Default, "FileFilter", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtFileFilter.Location = new System.Drawing.Point(520, 40);
            this.txtFileFilter.Name = "txtFileFilter";
            this.txtFileFilter.Size = new System.Drawing.Size(176, 20);
            this.txtFileFilter.TabIndex = 2;
            this.txtFileFilter.Text = global::RenamerX.Properties.Settings.Default.FileFilter;
            this.toolTip1.SetToolTip(this.txtFileFilter, resources.GetString("txtFileFilter.ToolTip"));
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
            // txtRegexpPattern
            // 
            this.txtRegexpPattern.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RenamerX.Properties.Settings.Default, "RegexpPattern", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRegexpPattern.Location = new System.Drawing.Point(16, 48);
            this.txtRegexpPattern.Name = "txtRegexpPattern";
            this.txtRegexpPattern.Size = new System.Drawing.Size(944, 20);
            this.txtRegexpPattern.TabIndex = 0;
            this.txtRegexpPattern.Text = global::RenamerX.Properties.Settings.Default.RegexpPattern;
            // 
            // tpExtract
            // 
            this.tpExtract.Controls.Add(this.btnExtractClear);
            this.tpExtract.Controls.Add(this.btnExtractRemove);
            this.tpExtract.Controls.Add(this.btnExtractAdd);
            this.tpExtract.Controls.Add(this.btnExtractAll);
            this.tpExtract.Controls.Add(this.cbSearchSubFolders);
            this.tpExtract.Controls.Add(this.btnUnRARBrowse);
            this.tpExtract.Controls.Add(this.btnExtractBrowse);
            this.tpExtract.Controls.Add(this.txtUnRARPath);
            this.tpExtract.Controls.Add(this.lblUnRARPath);
            this.tpExtract.Controls.Add(this.lblExtractPath);
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
            // lvExtractList
            // 
            this.lvExtractList.Location = new System.Drawing.Point(8, 120);
            this.lvExtractList.Name = "lvExtractList";
            this.lvExtractList.Size = new System.Drawing.Size(976, 272);
            this.lvExtractList.TabIndex = 0;
            this.lvExtractList.UseCompatibleStateImageBehavior = false;
            // 
            // txtExtractPath
            // 
            this.txtExtractPath.Location = new System.Drawing.Point(104, 8);
            this.txtExtractPath.Name = "txtExtractPath";
            this.txtExtractPath.Size = new System.Drawing.Size(472, 20);
            this.txtExtractPath.TabIndex = 1;
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
            // lblUnRARPath
            // 
            this.lblUnRARPath.AutoSize = true;
            this.lblUnRARPath.Location = new System.Drawing.Point(8, 36);
            this.lblUnRARPath.Name = "lblUnRARPath";
            this.lblUnRARPath.Size = new System.Drawing.Size(91, 13);
            this.lblUnRARPath.TabIndex = 3;
            this.lblUnRARPath.Text = "UnRAR.exe path:";
            // 
            // txtUnRARPath
            // 
            this.txtUnRARPath.Location = new System.Drawing.Point(104, 32);
            this.txtUnRARPath.Name = "txtUnRARPath";
            this.txtUnRARPath.Size = new System.Drawing.Size(472, 20);
            this.txtUnRARPath.TabIndex = 4;
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
            this.gbRename.Text = "Rename";
            // 
            // btnExtractBrowse
            // 
            this.btnExtractBrowse.Location = new System.Drawing.Point(584, 8);
            this.btnExtractBrowse.Name = "btnExtractBrowse";
            this.btnExtractBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnExtractBrowse.TabIndex = 5;
            this.btnExtractBrowse.Text = "Browse...";
            this.btnExtractBrowse.UseVisualStyleBackColor = true;
            // 
            // btnUnRARBrowse
            // 
            this.btnUnRARBrowse.Location = new System.Drawing.Point(584, 32);
            this.btnUnRARBrowse.Name = "btnUnRARBrowse";
            this.btnUnRARBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnUnRARBrowse.TabIndex = 6;
            this.btnUnRARBrowse.Text = "Browse...";
            this.btnUnRARBrowse.UseVisualStyleBackColor = true;
            // 
            // cbSearchSubFolders
            // 
            this.cbSearchSubFolders.AutoSize = true;
            this.cbSearchSubFolders.Location = new System.Drawing.Point(16, 64);
            this.cbSearchSubFolders.Name = "cbSearchSubFolders";
            this.cbSearchSubFolders.Size = new System.Drawing.Size(132, 17);
            this.cbSearchSubFolders.TabIndex = 7;
            this.cbSearchSubFolders.Text = "Search sub folders too";
            this.cbSearchSubFolders.UseVisualStyleBackColor = true;
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
            // btnExtractAdd
            // 
            this.btnExtractAdd.Location = new System.Drawing.Point(16, 88);
            this.btnExtractAdd.Name = "btnExtractAdd";
            this.btnExtractAdd.Size = new System.Drawing.Size(72, 24);
            this.btnExtractAdd.TabIndex = 9;
            this.btnExtractAdd.Text = "Add";
            this.btnExtractAdd.UseVisualStyleBackColor = true;
            // 
            // btnExtractRemove
            // 
            this.btnExtractRemove.Location = new System.Drawing.Point(96, 88);
            this.btnExtractRemove.Name = "btnExtractRemove";
            this.btnExtractRemove.Size = new System.Drawing.Size(72, 24);
            this.btnExtractRemove.TabIndex = 10;
            this.btnExtractRemove.Text = "Remove";
            this.btnExtractRemove.UseVisualStyleBackColor = true;
            // 
            // btnExtractClear
            // 
            this.btnExtractClear.Location = new System.Drawing.Point(176, 88);
            this.btnExtractClear.Name = "btnExtractClear";
            this.btnExtractClear.Size = new System.Drawing.Size(72, 24);
            this.btnExtractClear.TabIndex = 11;
            this.btnExtractClear.Text = "Clear";
            this.btnExtractClear.UseVisualStyleBackColor = true;
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
            this.tpConsole.ResumeLayout(false);
            this.tpConsole.PerformLayout();
            this.tpSettings.ResumeLayout(false);
            this.tpExtract.ResumeLayout(false);
            this.tpExtract.PerformLayout();
            this.gbRename.ResumeLayout(false);
            this.gbRename.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpMain;
        private System.Windows.Forms.TabPage tpConsole;
        private System.Windows.Forms.TextBox txtNameFormat;
        private System.Windows.Forms.TextBox txtFileFilter;
        private System.Windows.Forms.Label lblNameFormat;
        private System.Windows.Forms.Label lblFileFilter;
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
    }
}
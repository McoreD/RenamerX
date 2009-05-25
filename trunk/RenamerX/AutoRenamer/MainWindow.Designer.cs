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
            this.cbShowErrors = new System.Windows.Forms.CheckBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDirClear = new System.Windows.Forms.Button();
            this.lblFileFilter = new System.Windows.Forms.Label();
            this.txtFileFilter = new System.Windows.Forms.TextBox();
            this.lblNameFormat = new System.Windows.Forms.Label();
            this.btnDirRemove = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtNameFormat = new System.Windows.Forms.TextBox();
            this.btnDirAdd = new System.Windows.Forms.Button();
            this.lvList = new System.Windows.Forms.ListView();
            this.lvListColumn1 = new System.Windows.Forms.ColumnHeader();
            this.lvListColumn2 = new System.Windows.Forms.ColumnHeader();
            this.tpConsole = new System.Windows.Forms.TabPage();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.cbShowActionMessages = new System.Windows.Forms.CheckBox();
            this.lblRegexpPattern = new System.Windows.Forms.Label();
            this.txtRegexpPattern = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tcMain.SuspendLayout();
            this.tpMain.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tpConsole.SuspendLayout();
            this.tpSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpMain);
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
            this.tpMain.Text = "Main";
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
            this.splitContainer1.Panel1.Controls.Add(this.btnChange);
            this.splitContainer1.Panel1.Controls.Add(this.btnDirClear);
            this.splitContainer1.Panel1.Controls.Add(this.lblFileFilter);
            this.splitContainer1.Panel1.Controls.Add(this.txtFileFilter);
            this.splitContainer1.Panel1.Controls.Add(this.lblNameFormat);
            this.splitContainer1.Panel1.Controls.Add(this.btnDirRemove);
            this.splitContainer1.Panel1.Controls.Add(this.btnRefresh);
            this.splitContainer1.Panel1.Controls.Add(this.txtNameFormat);
            this.splitContainer1.Panel1.Controls.Add(this.btnDirAdd);
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
            this.lblItemsCount.Location = new System.Drawing.Point(344, 96);
            this.lblItemsCount.Name = "lblItemsCount";
            this.lblItemsCount.Size = new System.Drawing.Size(70, 21);
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
            this.lvShows.Size = new System.Drawing.Size(333, 130);
            this.lvShows.TabIndex = 14;
            this.lvShows.UseCompatibleStateImageBehavior = false;
            this.lvShows.View = System.Windows.Forms.View.Details;
            this.lvShows.SelectedIndexChanged += new System.EventHandler(this.lvShows_SelectedIndexChanged);
            // 
            // lvShowsColumn1
            // 
            this.lvShowsColumn1.Width = 329;
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
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(528, 96);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(80, 24);
            this.btnChange.TabIndex = 12;
            this.btnChange.Text = "&Rename";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDirClear
            // 
            this.btnDirClear.Location = new System.Drawing.Point(344, 56);
            this.btnDirClear.Name = "btnDirClear";
            this.btnDirClear.Size = new System.Drawing.Size(72, 24);
            this.btnDirClear.TabIndex = 11;
            this.btnDirClear.Text = "Clear";
            this.btnDirClear.UseVisualStyleBackColor = true;
            this.btnDirClear.Click += new System.EventHandler(this.btnDirClear_Click);
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
            // lblNameFormat
            // 
            this.lblNameFormat.AutoSize = true;
            this.lblNameFormat.Location = new System.Drawing.Point(437, 16);
            this.lblNameFormat.Name = "lblNameFormat";
            this.lblNameFormat.Size = new System.Drawing.Size(73, 13);
            this.lblNameFormat.TabIndex = 4;
            this.lblNameFormat.Text = "Name Format:";
            // 
            // btnDirRemove
            // 
            this.btnDirRemove.Location = new System.Drawing.Point(344, 32);
            this.btnDirRemove.Name = "btnDirRemove";
            this.btnDirRemove.Size = new System.Drawing.Size(72, 24);
            this.btnDirRemove.TabIndex = 8;
            this.btnDirRemove.Text = "Remove";
            this.btnDirRemove.UseVisualStyleBackColor = true;
            this.btnDirRemove.Click += new System.EventHandler(this.btnDirRemove_Click);
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
            this.txtNameFormat.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RenamerX.Properties.Settings.Default, "NameFormat", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNameFormat.Location = new System.Drawing.Point(520, 16);
            this.txtNameFormat.Name = "txtNameFormat";
            this.txtNameFormat.Size = new System.Drawing.Size(176, 20);
            this.txtNameFormat.TabIndex = 0;
            this.txtNameFormat.Text = global::RenamerX.Properties.Settings.Default.NameFormat;
            this.toolTip1.SetToolTip(this.txtNameFormat, resources.GetString("txtNameFormat.ToolTip"));
            // 
            // btnDirAdd
            // 
            this.btnDirAdd.Location = new System.Drawing.Point(344, 8);
            this.btnDirAdd.Name = "btnDirAdd";
            this.btnDirAdd.Size = new System.Drawing.Size(72, 24);
            this.btnDirAdd.TabIndex = 7;
            this.btnDirAdd.Text = "Add";
            this.btnDirAdd.UseVisualStyleBackColor = true;
            this.btnDirAdd.Click += new System.EventHandler(this.btnDirAdd_Click);
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
            this.lvListColumn1.Text = "Default Filenames";
            this.lvListColumn1.Width = 450;
            // 
            // lvListColumn2
            // 
            this.lvListColumn2.Text = "New Filenames";
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
            this.txtConsole.Size = new System.Drawing.Size(988, 602);
            this.txtConsole.TabIndex = 0;
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.cbShowActionMessages);
            this.tpSettings.Controls.Add(this.lblRegexpPattern);
            this.tpSettings.Controls.Add(this.txtRegexpPattern);
            this.tpSettings.Location = new System.Drawing.Point(4, 24);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(994, 608);
            this.tpSettings.TabIndex = 2;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // cbShowActionMessages
            // 
            this.cbShowActionMessages.AutoSize = true;
            this.cbShowActionMessages.Checked = global::RenamerX.Properties.Settings.Default.ShowActionMessages;
            this.cbShowActionMessages.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RenamerX.Properties.Settings.Default, "ShowActionMessages", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbShowActionMessages.Location = new System.Drawing.Point(16, 72);
            this.cbShowActionMessages.Name = "cbShowActionMessages";
            this.cbShowActionMessages.Size = new System.Drawing.Size(264, 17);
            this.cbShowActionMessages.TabIndex = 2;
            this.cbShowActionMessages.Text = "Show shows started, finished messages in console";
            this.cbShowActionMessages.UseVisualStyleBackColor = true;
            // 
            // lblRegexpPattern
            // 
            this.lblRegexpPattern.AutoSize = true;
            this.lblRegexpPattern.Location = new System.Drawing.Point(16, 16);
            this.lblRegexpPattern.Name = "lblRegexpPattern";
            this.lblRegexpPattern.Size = new System.Drawing.Size(259, 13);
            this.lblRegexpPattern.TabIndex = 1;
            this.lblRegexpPattern.Text = "Regexp pattern for find season and episode numbers:";
            // 
            // txtRegexpPattern
            // 
            this.txtRegexpPattern.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RenamerX.Properties.Settings.Default, "RegexpPattern", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtRegexpPattern.Location = new System.Drawing.Point(16, 40);
            this.txtRegexpPattern.Name = "txtRegexpPattern";
            this.txtRegexpPattern.Size = new System.Drawing.Size(968, 20);
            this.txtRegexpPattern.TabIndex = 0;
            this.txtRegexpPattern.Text = global::RenamerX.Properties.Settings.Default.RegexpPattern;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
            this.tpSettings.PerformLayout();
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
        private System.Windows.Forms.Button btnDirAdd;
        private System.Windows.Forms.Button btnDirRemove;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDirClear;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnChange;
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
    }
}
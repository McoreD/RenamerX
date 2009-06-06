namespace TVDBLibTest
{
    partial class MainForm
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
            this.lvLanguages = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.lvMirrors = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.lvSeries = new System.Windows.Forms.ListView();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.btnSearchSeries = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.plvSeries = new TVDBLibTest.PropertyListView();
            this.tvEpisodes = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpSeries = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbEpisodeName = new System.Windows.Forms.Label();
            this.lblEpisodeNumber = new System.Windows.Forms.Label();
            this.lblSeasonNumber = new System.Windows.Forms.Label();
            this.txtEpisodeNumber = new System.Windows.Forms.TextBox();
            this.txtSeasonNumber = new System.Windows.Forms.TextBox();
            this.txtEpisodeName = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.plvEpisodes = new TVDBLibTest.PropertyListView();
            this.tpImages = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvBanners = new System.Windows.Forms.ListView();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvActors = new System.Windows.Forms.ListView();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.pbBanner = new System.Windows.Forms.PictureBox();
            this.plvBanners = new TVDBLibTest.PropertyListView();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.propertyGridApp = new System.Windows.Forms.PropertyGrid();
            this.tpConsole = new System.Windows.Forms.TabPage();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.txtLoadSeries = new System.Windows.Forms.TextBox();
            this.btnLoadSeries = new System.Windows.Forms.Button();
            this.lblLoadSeriesID = new System.Windows.Forms.Label();
            this.lblSearchSeriesName = new System.Windows.Forms.Label();
            this.txtSearchSeries = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpSeries.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tpImages.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).BeginInit();
            this.tpSettings.SuspendLayout();
            this.tpConsole.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvLanguages
            // 
            this.lvLanguages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvLanguages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLanguages.FullRowSelect = true;
            this.lvLanguages.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvLanguages.HideSelection = false;
            this.lvLanguages.Location = new System.Drawing.Point(3, 16);
            this.lvLanguages.MultiSelect = false;
            this.lvLanguages.Name = "lvLanguages";
            this.lvLanguages.Size = new System.Drawing.Size(578, 213);
            this.lvLanguages.TabIndex = 0;
            this.lvLanguages.UseCompatibleStateImageBehavior = false;
            this.lvLanguages.View = System.Windows.Forms.View.Details;
            this.lvLanguages.SelectedIndexChanged += new System.EventHandler(this.lvLanguages_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 178;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Abbreviation";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            this.columnHeader6.Width = 30;
            // 
            // lvMirrors
            // 
            this.lvMirrors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvMirrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMirrors.FullRowSelect = true;
            this.lvMirrors.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvMirrors.HideSelection = false;
            this.lvMirrors.Location = new System.Drawing.Point(3, 16);
            this.lvMirrors.MultiSelect = false;
            this.lvMirrors.Name = "lvMirrors";
            this.lvMirrors.Size = new System.Drawing.Size(578, 213);
            this.lvMirrors.TabIndex = 1;
            this.lvMirrors.UseCompatibleStateImageBehavior = false;
            this.lvMirrors.View = System.Windows.Forms.View.Details;
            this.lvMirrors.SelectedIndexChanged += new System.EventHandler(this.lvMirrors_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mirror Path";
            this.columnHeader2.Width = 230;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type Mask";
            this.columnHeader3.Width = 83;
            // 
            // lvSeries
            // 
            this.lvSeries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvSeries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.lvSeries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSeries.FullRowSelect = true;
            this.lvSeries.GridLines = true;
            this.lvSeries.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSeries.HideSelection = false;
            this.lvSeries.Location = new System.Drawing.Point(0, 0);
            this.lvSeries.MultiSelect = false;
            this.lvSeries.Name = "lvSeries";
            this.lvSeries.Size = new System.Drawing.Size(607, 280);
            this.lvSeries.TabIndex = 4;
            this.lvSeries.UseCompatibleStateImageBehavior = false;
            this.lvSeries.View = System.Windows.Forms.View.Details;
            this.lvSeries.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvSeries_MouseDoubleClick);
            this.lvSeries.SelectedIndexChanged += new System.EventHandler(this.lvSeries_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Series Name";
            this.columnHeader7.Width = 475;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "First Aired";
            this.columnHeader8.Width = 132;
            // 
            // btnSearchSeries
            // 
            this.btnSearchSeries.Location = new System.Drawing.Point(336, 16);
            this.btnSearchSeries.Name = "btnSearchSeries";
            this.btnSearchSeries.Size = new System.Drawing.Size(72, 24);
            this.btnSearchSeries.TabIndex = 7;
            this.btnSearchSeries.Text = "Search";
            this.btnSearchSeries.UseVisualStyleBackColor = true;
            this.btnSearchSeries.Click += new System.EventHandler(this.btnSearchSeries_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvLanguages);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 232);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Languages.xml";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvMirrors);
            this.groupBox2.Location = new System.Drawing.Point(600, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 232);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mirrors.xml";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSearchSeriesName);
            this.groupBox3.Controls.Add(this.lblLoadSeriesID);
            this.groupBox3.Controls.Add(this.btnLoadSeries);
            this.groupBox3.Controls.Add(this.txtLoadSeries);
            this.groupBox3.Controls.Add(this.splitContainer1);
            this.groupBox3.Controls.Add(this.txtSearchSeries);
            this.groupBox3.Controls.Add(this.btnSearchSeries);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(613, 733);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Series list";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(3, 48);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvSeries);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.plvSeries);
            this.splitContainer1.Size = new System.Drawing.Size(607, 682);
            this.splitContainer1.SplitterDistance = 280;
            this.splitContainer1.TabIndex = 15;
            // 
            // plvSeries
            // 
            this.plvSeries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plvSeries.Location = new System.Drawing.Point(0, 0);
            this.plvSeries.Name = "plvSeries";
            this.plvSeries.Size = new System.Drawing.Size(607, 398);
            this.plvSeries.TabIndex = 0;
            // 
            // tvEpisodes
            // 
            this.tvEpisodes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvEpisodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvEpisodes.Location = new System.Drawing.Point(0, 0);
            this.tvEpisodes.Name = "tvEpisodes";
            this.tvEpisodes.Size = new System.Drawing.Size(562, 298);
            this.tvEpisodes.TabIndex = 12;
            this.tvEpisodes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvEpisodes_AfterSelect);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpSeries);
            this.tabControl1.Controls.Add(this.tpImages);
            this.tabControl1.Controls.Add(this.tpSettings);
            this.tabControl1.Controls.Add(this.tpConsole);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1203, 765);
            this.tabControl1.TabIndex = 13;
            // 
            // tpSeries
            // 
            this.tpSeries.Controls.Add(this.groupBox4);
            this.tpSeries.Controls.Add(this.groupBox3);
            this.tpSeries.Location = new System.Drawing.Point(4, 22);
            this.tpSeries.Name = "tpSeries";
            this.tpSeries.Padding = new System.Windows.Forms.Padding(3);
            this.tpSeries.Size = new System.Drawing.Size(1195, 739);
            this.tpSeries.TabIndex = 0;
            this.tpSeries.Text = "Series";
            this.tpSeries.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbEpisodeName);
            this.groupBox4.Controls.Add(this.lblEpisodeNumber);
            this.groupBox4.Controls.Add(this.lblSeasonNumber);
            this.groupBox4.Controls.Add(this.txtEpisodeNumber);
            this.groupBox4.Controls.Add(this.txtSeasonNumber);
            this.groupBox4.Controls.Add(this.txtEpisodeName);
            this.groupBox4.Controls.Add(this.splitContainer2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Location = new System.Drawing.Point(624, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(568, 733);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Episodes List";
            // 
            // lbEpisodeName
            // 
            this.lbEpisodeName.AutoSize = true;
            this.lbEpisodeName.Location = new System.Drawing.Point(8, 24);
            this.lbEpisodeName.Name = "lbEpisodeName";
            this.lbEpisodeName.Size = new System.Drawing.Size(77, 13);
            this.lbEpisodeName.TabIndex = 21;
            this.lbEpisodeName.Text = "Episode name:";
            // 
            // lblEpisodeNumber
            // 
            this.lblEpisodeNumber.AutoSize = true;
            this.lblEpisodeNumber.Location = new System.Drawing.Point(407, 24);
            this.lblEpisodeNumber.Name = "lblEpisodeNumber";
            this.lblEpisodeNumber.Size = new System.Drawing.Size(48, 13);
            this.lblEpisodeNumber.TabIndex = 20;
            this.lblEpisodeNumber.Text = "Episode:";
            // 
            // lblSeasonNumber
            // 
            this.lblSeasonNumber.AutoSize = true;
            this.lblSeasonNumber.Location = new System.Drawing.Point(319, 24);
            this.lblSeasonNumber.Name = "lblSeasonNumber";
            this.lblSeasonNumber.Size = new System.Drawing.Size(46, 13);
            this.lblSeasonNumber.TabIndex = 19;
            this.lblSeasonNumber.Text = "Season:";
            // 
            // txtEpisodeNumber
            // 
            this.txtEpisodeNumber.Location = new System.Drawing.Point(464, 20);
            this.txtEpisodeNumber.Name = "txtEpisodeNumber";
            this.txtEpisodeNumber.Size = new System.Drawing.Size(24, 20);
            this.txtEpisodeNumber.TabIndex = 18;
            this.txtEpisodeNumber.TextChanged += new System.EventHandler(this.Number_TextChanged);
            // 
            // txtSeasonNumber
            // 
            this.txtSeasonNumber.Location = new System.Drawing.Point(374, 20);
            this.txtSeasonNumber.Name = "txtSeasonNumber";
            this.txtSeasonNumber.Size = new System.Drawing.Size(24, 20);
            this.txtSeasonNumber.TabIndex = 17;
            this.txtSeasonNumber.TextChanged += new System.EventHandler(this.Number_TextChanged);
            // 
            // txtEpisodeName
            // 
            this.txtEpisodeName.Location = new System.Drawing.Point(94, 20);
            this.txtEpisodeName.Name = "txtEpisodeName";
            this.txtEpisodeName.Size = new System.Drawing.Size(216, 20);
            this.txtEpisodeName.TabIndex = 15;
            this.txtEpisodeName.TextChanged += new System.EventHandler(this.Number_TextChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer2.Location = new System.Drawing.Point(3, 48);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tvEpisodes);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.plvEpisodes);
            this.splitContainer2.Size = new System.Drawing.Size(562, 682);
            this.splitContainer2.SplitterDistance = 298;
            this.splitContainer2.TabIndex = 14;
            // 
            // plvEpisodes
            // 
            this.plvEpisodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plvEpisodes.Location = new System.Drawing.Point(0, 0);
            this.plvEpisodes.Name = "plvEpisodes";
            this.plvEpisodes.Size = new System.Drawing.Size(562, 380);
            this.plvEpisodes.TabIndex = 0;
            // 
            // tpImages
            // 
            this.tpImages.Controls.Add(this.tabControl2);
            this.tpImages.Controls.Add(this.pbBanner);
            this.tpImages.Controls.Add(this.plvBanners);
            this.tpImages.Location = new System.Drawing.Point(4, 22);
            this.tpImages.Name = "tpImages";
            this.tpImages.Padding = new System.Windows.Forms.Padding(3);
            this.tpImages.Size = new System.Drawing.Size(1195, 739);
            this.tpImages.TabIndex = 3;
            this.tpImages.Text = "Images";
            this.tpImages.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(8, 8);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(392, 480);
            this.tabControl2.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvBanners);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(384, 454);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Banners";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvBanners
            // 
            this.lvBanners.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9});
            this.lvBanners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBanners.FullRowSelect = true;
            this.lvBanners.Location = new System.Drawing.Point(3, 3);
            this.lvBanners.Name = "lvBanners";
            this.lvBanners.Size = new System.Drawing.Size(378, 448);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvActors);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(384, 454);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Actors";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.lvActors.Size = new System.Drawing.Size(378, 448);
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
            // pbBanner
            // 
            this.pbBanner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBanner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBanner.Location = new System.Drawing.Point(408, 8);
            this.pbBanner.Name = "pbBanner";
            this.pbBanner.Size = new System.Drawing.Size(776, 720);
            this.pbBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBanner.TabIndex = 2;
            this.pbBanner.TabStop = false;
            this.pbBanner.Click += new System.EventHandler(this.pbBanner_Click);
            // 
            // plvBanners
            // 
            this.plvBanners.Location = new System.Drawing.Point(8, 496);
            this.plvBanners.Name = "plvBanners";
            this.plvBanners.Size = new System.Drawing.Size(392, 232);
            this.plvBanners.TabIndex = 1;
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.propertyGridApp);
            this.tpSettings.Controls.Add(this.groupBox1);
            this.tpSettings.Controls.Add(this.groupBox2);
            this.tpSettings.Location = new System.Drawing.Point(4, 22);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(1195, 739);
            this.tpSettings.TabIndex = 1;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // propertyGridApp
            // 
            this.propertyGridApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGridApp.HelpVisible = false;
            this.propertyGridApp.Location = new System.Drawing.Point(8, 248);
            this.propertyGridApp.Name = "propertyGridApp";
            this.propertyGridApp.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.propertyGridApp.Size = new System.Drawing.Size(1176, 480);
            this.propertyGridApp.TabIndex = 13;
            this.propertyGridApp.ToolbarVisible = false;
            // 
            // tpConsole
            // 
            this.tpConsole.Controls.Add(this.txtConsole);
            this.tpConsole.Location = new System.Drawing.Point(4, 22);
            this.tpConsole.Name = "tpConsole";
            this.tpConsole.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsole.Size = new System.Drawing.Size(1195, 739);
            this.tpConsole.TabIndex = 2;
            this.tpConsole.Text = "Console";
            this.tpConsole.UseVisualStyleBackColor = true;
            // 
            // txtConsole
            // 
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.Location = new System.Drawing.Point(3, 3);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(1189, 733);
            this.txtConsole.TabIndex = 0;
            // 
            // txtLoadSeries
            // 
            this.txtLoadSeries.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TVDBLibTest.Properties.Settings.Default, "LastSeriesID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtLoadSeries.Location = new System.Drawing.Point(472, 16);
            this.txtLoadSeries.Name = "txtLoadSeries";
            this.txtLoadSeries.Size = new System.Drawing.Size(48, 20);
            this.txtLoadSeries.TabIndex = 16;
            this.txtLoadSeries.Text = global::TVDBLibTest.Properties.Settings.Default.LastSeriesID;
            // 
            // btnLoadSeries
            // 
            this.btnLoadSeries.Location = new System.Drawing.Point(528, 16);
            this.btnLoadSeries.Name = "btnLoadSeries";
            this.btnLoadSeries.Size = new System.Drawing.Size(72, 24);
            this.btnLoadSeries.TabIndex = 17;
            this.btnLoadSeries.Text = "Load";
            this.btnLoadSeries.UseVisualStyleBackColor = true;
            this.btnLoadSeries.Click += new System.EventHandler(this.btnLoadSeries_Click);
            // 
            // lblLoadSeriesID
            // 
            this.lblLoadSeriesID.AutoSize = true;
            this.lblLoadSeriesID.Location = new System.Drawing.Point(416, 21);
            this.lblLoadSeriesID.Name = "lblLoadSeriesID";
            this.lblLoadSeriesID.Size = new System.Drawing.Size(53, 13);
            this.lblLoadSeriesID.TabIndex = 18;
            this.lblLoadSeriesID.Text = "Series ID:";
            // 
            // lblSearchSeriesName
            // 
            this.lblSearchSeriesName.AutoSize = true;
            this.lblSearchSeriesName.Location = new System.Drawing.Point(11, 21);
            this.lblSearchSeriesName.Name = "lblSearchSeriesName";
            this.lblSearchSeriesName.Size = new System.Drawing.Size(68, 13);
            this.lblSearchSeriesName.TabIndex = 19;
            this.lblSearchSeriesName.Text = "Series name:";
            // 
            // txtSearchSeries
            // 
            this.txtSearchSeries.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TVDBLibTest.Properties.Settings.Default, "LastSeriesName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtSearchSeries.Location = new System.Drawing.Point(80, 18);
            this.txtSearchSeries.Name = "txtSearchSeries";
            this.txtSearchSeries.Size = new System.Drawing.Size(248, 20);
            this.txtSearchSeries.TabIndex = 6;
            this.txtSearchSeries.Text = global::TVDBLibTest.Properties.Settings.Default.LastSeriesName;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnSearchSeries;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 765);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "TVDBLib Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpSeries.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.tpImages.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).EndInit();
            this.tpSettings.ResumeLayout(false);
            this.tpConsole.ResumeLayout(false);
            this.tpConsole.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvLanguages;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lvMirrors;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lvSeries;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox txtSearchSeries;
        private System.Windows.Forms.Button btnSearchSeries;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TreeView tvEpisodes;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpSeries;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private PropertyListView plvSeries;
        private PropertyListView plvEpisodes;
        private System.Windows.Forms.Label lblEpisodeNumber;
        private System.Windows.Forms.Label lblSeasonNumber;
        private System.Windows.Forms.TextBox txtEpisodeNumber;
        private System.Windows.Forms.TextBox txtSeasonNumber;
        private System.Windows.Forms.TextBox txtEpisodeName;
        private System.Windows.Forms.Label lbEpisodeName;
        private System.Windows.Forms.TabPage tpConsole;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.TabPage tpImages;
        private System.Windows.Forms.ListView lvBanners;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.PictureBox pbBanner;
        private PropertyListView plvBanners;
        private System.Windows.Forms.ListView lvActors;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PropertyGrid propertyGridApp;
        private System.Windows.Forms.Button btnLoadSeries;
        private System.Windows.Forms.TextBox txtLoadSeries;
        private System.Windows.Forms.Label lblSearchSeriesName;
        private System.Windows.Forms.Label lblLoadSeriesID;
    }
}


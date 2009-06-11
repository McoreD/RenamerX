using System.Windows.Forms;
using System.ComponentModel;
namespace TVRenamer
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
            this.lblFolder = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lvwCurrent = new System.Windows.Forms.ListView();
            this.FileName = new System.Windows.Forms.ColumnHeader();
            this.lvwTobe = new System.Windows.Forms.ListView();
            this.FileName1 = new System.Windows.Forms.ColumnHeader();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.lblStyle = new System.Windows.Forms.Label();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.lblShowName = new System.Windows.Forms.Label();
            this.txtShowname = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbSeparator = new System.Windows.Forms.ComboBox();
            this.cmbNamingStyle = new System.Windows.Forms.ComboBox();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tssLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.ssStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(12, 37);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(36, 13);
            this.lblFolder.TabIndex = 0;
            this.lblFolder.Text = "Folder";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(361, 33);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lvwCurrent
            // 
            this.lvwCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwCurrent.CheckBoxes = true;
            this.lvwCurrent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName});
            this.lvwCurrent.Location = new System.Drawing.Point(12, 131);
            this.lvwCurrent.Name = "lvwCurrent";
            this.lvwCurrent.Size = new System.Drawing.Size(449, 416);
            this.lvwCurrent.TabIndex = 3;
            this.lvwCurrent.UseCompatibleStateImageBehavior = false;
            this.lvwCurrent.View = System.Windows.Forms.View.Details;
            // 
            // FileName
            // 
            this.FileName.Text = "File Name";
            this.FileName.Width = 444;
            // 
            // lvwTobe
            // 
            this.lvwTobe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwTobe.CheckBoxes = true;
            this.lvwTobe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName1});
            this.lvwTobe.Location = new System.Drawing.Point(467, 131);
            this.lvwTobe.Name = "lvwTobe";
            this.lvwTobe.Size = new System.Drawing.Size(415, 416);
            this.lvwTobe.TabIndex = 4;
            this.lvwTobe.UseCompatibleStateImageBehavior = false;
            this.lvwTobe.View = System.Windows.Forms.View.Details;
            // 
            // FileName1
            // 
            this.FileName1.Text = "File Name";
            this.FileName1.Width = 409;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(89, 69);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(266, 20);
            this.txtFilter.TabIndex = 5;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(12, 69);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(29, 13);
            this.lblFilter.TabIndex = 6;
            this.lblFilter.Text = "Filter";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(684, 97);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(64, 32);
            this.btnGo.TabIndex = 7;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(614, 97);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(64, 32);
            this.btnPreview.TabIndex = 8;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.Location = new System.Drawing.Point(221, 107);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(30, 13);
            this.lblStyle.TabIndex = 10;
            this.lblStyle.Text = "Style";
            // 
            // lblSeparator
            // 
            this.lblSeparator.AutoSize = true;
            this.lblSeparator.Location = new System.Drawing.Point(12, 104);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(53, 13);
            this.lblSeparator.TabIndex = 11;
            this.lblSeparator.Text = "Separator";
            // 
            // lblShowName
            // 
            this.lblShowName.AutoSize = true;
            this.lblShowName.Location = new System.Drawing.Point(388, 76);
            this.lblShowName.Name = "lblShowName";
            this.lblShowName.Size = new System.Drawing.Size(65, 13);
            this.lblShowName.TabIndex = 14;
            this.lblShowName.Text = "Show Name";
            // 
            // txtShowname
            // 
            this.txtShowname.Location = new System.Drawing.Point(454, 73);
            this.txtShowname.Name = "txtShowname";
            this.txtShowname.Size = new System.Drawing.Size(147, 20);
            this.txtShowname.TabIndex = 15;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(442, 33);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(894, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // cmbSeparator
            // 
            this.cmbSeparator.FormattingEnabled = true;
            this.cmbSeparator.Items.AddRange(new object[] {
            ".<Dot>",
            "-<Dash>",
            " <Space>",
            "_<Underscore>"});
            this.cmbSeparator.Location = new System.Drawing.Point(89, 104);
            this.cmbSeparator.Name = "cmbSeparator";
            this.cmbSeparator.Size = new System.Drawing.Size(121, 21);
            this.cmbSeparator.TabIndex = 12;
            this.cmbSeparator.Tag = "-";
            this.cmbSeparator.SelectedIndexChanged += new System.EventHandler(this.cmbSeparator_SelectedIndexChanged);
            // 
            // cmbNamingStyle
            // 
            this.cmbNamingStyle.FormattingEnabled = true;
            this.cmbNamingStyle.Items.AddRange(new object[] {
            "Show.Name<Separator>S<SS>E<EE>",
            "Show.Name<Separator>e<SS>e<EE>",
            "Show.Name<Separator><SS>x<EE>"});
            this.cmbNamingStyle.Location = new System.Drawing.Point(258, 104);
            this.cmbNamingStyle.Name = "cmbNamingStyle";
            this.cmbNamingStyle.Size = new System.Drawing.Size(237, 21);
            this.cmbNamingStyle.TabIndex = 9;
            this.cmbNamingStyle.SelectedIndexChanged += new System.EventHandler(this.cmbNamingStyle_SelectedIndexChanged);
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(89, 36);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(266, 20);
            this.txtFolder.TabIndex = 2;
            this.txtFolder.TextChanged += new System.EventHandler(this.txtFolder_TextChanged);
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLabel});
            this.ssStatus.Location = new System.Drawing.Point(0, 537);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(894, 22);
            this.ssStatus.TabIndex = 18;
            this.ssStatus.Text = "statusStrip1";
            // 
            // tssLabel
            // 
            this.tssLabel.Name = "tssLabel";
            this.tssLabel.Size = new System.Drawing.Size(80, 17);
            this.tssLabel.Text = "Status: Ready.";
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(894, 559);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtShowname);
            this.Controls.Add(this.lblShowName);
            this.Controls.Add(this.cmbSeparator);
            this.Controls.Add(this.lblSeparator);
            this.Controls.Add(this.lblStyle);
            this.Controls.Add(this.cmbNamingStyle);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lvwTobe);
            this.Controls.Add(this.lvwCurrent);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "TVRenamer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private char[] AllDigits = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private Button btnBrowse;
        private Button btnGo;
        private Button btnPreview;
        private Button btnRefresh;
        private ComboBox cmbNamingStyle;
        private ComboBox cmbSeparator;
        private ColumnHeader FileName;
        private ColumnHeader FileName1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private Label lblFilter;
        private Label lblFolder;
        private Label lblSeparator;
        private Label lblShowName;
        private Label lblStyle;
        private ListView lvwCurrent;
        private ListView lvwTobe;
        private MenuStrip menuStrip1;
        private TextBox txtFilter;
        private TextBox txtFolder;
        private TextBox txtShowname;
        private StatusStrip ssStatus;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripStatusLabel tssLabel;
    }
}


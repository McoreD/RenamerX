namespace RenamerX
{
    partial class SearchSeries
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
            this.lblSeriesName = new System.Windows.Forms.Label();
            this.txtSeriesName = new System.Windows.Forms.TextBox();
            this.btnSearchSeries = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtSeriesID = new System.Windows.Forms.TextBox();
            this.lblSeriesID = new System.Windows.Forms.Label();
            this.tnCancel = new System.Windows.Forms.Button();
            this.pbSeriesBanner = new System.Windows.Forms.PictureBox();
            this.plvSeriesInfo = new RenamerX.PropertyListView();
            this.lvSeriesList = new RenamerX.ListViewX();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeriesBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeriesName
            // 
            this.lblSeriesName.AutoSize = true;
            this.lblSeriesName.Location = new System.Drawing.Point(8, 13);
            this.lblSeriesName.Name = "lblSeriesName";
            this.lblSeriesName.Size = new System.Drawing.Size(68, 13);
            this.lblSeriesName.TabIndex = 1;
            this.lblSeriesName.Text = "Series name:";
            // 
            // txtSeriesName
            // 
            this.txtSeriesName.Location = new System.Drawing.Point(80, 9);
            this.txtSeriesName.Name = "txtSeriesName";
            this.txtSeriesName.Size = new System.Drawing.Size(312, 20);
            this.txtSeriesName.TabIndex = 2;
            this.txtSeriesName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeriesName_KeyPress);
            // 
            // btnSearchSeries
            // 
            this.btnSearchSeries.Location = new System.Drawing.Point(400, 8);
            this.btnSearchSeries.Name = "btnSearchSeries";
            this.btnSearchSeries.Size = new System.Drawing.Size(75, 23);
            this.btnSearchSeries.TabIndex = 3;
            this.btnSearchSeries.Text = "Search";
            this.btnSearchSeries.UseVisualStyleBackColor = true;
            this.btnSearchSeries.Click += new System.EventHandler(this.btnSearchSeries_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(320, 512);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtSeriesID
            // 
            this.txtSeriesID.Location = new System.Drawing.Point(248, 512);
            this.txtSeriesID.Name = "txtSeriesID";
            this.txtSeriesID.Size = new System.Drawing.Size(64, 20);
            this.txtSeriesID.TabIndex = 6;
            // 
            // lblSeriesID
            // 
            this.lblSeriesID.AutoSize = true;
            this.lblSeriesID.Location = new System.Drawing.Point(224, 516);
            this.lblSeriesID.Name = "lblSeriesID";
            this.lblSeriesID.Size = new System.Drawing.Size(21, 13);
            this.lblSeriesID.TabIndex = 7;
            this.lblSeriesID.Text = "ID:";
            // 
            // tnCancel
            // 
            this.tnCancel.Location = new System.Drawing.Point(400, 512);
            this.tnCancel.Name = "tnCancel";
            this.tnCancel.Size = new System.Drawing.Size(75, 23);
            this.tnCancel.TabIndex = 8;
            this.tnCancel.Text = "Cancel";
            this.tnCancel.UseVisualStyleBackColor = true;
            this.tnCancel.Click += new System.EventHandler(this.tnCancel_Click);
            // 
            // pbSeriesBanner
            // 
            this.pbSeriesBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSeriesBanner.Location = new System.Drawing.Point(8, 240);
            this.pbSeriesBanner.Name = "pbSeriesBanner";
            this.pbSeriesBanner.Size = new System.Drawing.Size(464, 80);
            this.pbSeriesBanner.TabIndex = 9;
            this.pbSeriesBanner.TabStop = false;
            // 
            // plvSeriesInfo
            // 
            this.plvSeriesInfo.Location = new System.Drawing.Point(8, 328);
            this.plvSeriesInfo.Name = "plvSeriesInfo";
            this.plvSeriesInfo.Size = new System.Drawing.Size(464, 176);
            this.plvSeriesInfo.TabIndex = 4;
            // 
            // lvSeriesList
            // 
            this.lvSeriesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.lvSeriesList.FullRowSelect = true;
            this.lvSeriesList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSeriesList.HideSelection = false;
            this.lvSeriesList.Location = new System.Drawing.Point(8, 40);
            this.lvSeriesList.MultiSelect = false;
            this.lvSeriesList.Name = "lvSeriesList";
            this.lvSeriesList.Size = new System.Drawing.Size(464, 192);
            this.lvSeriesList.TabIndex = 0;
            this.lvSeriesList.UseCompatibleStateImageBehavior = false;
            this.lvSeriesList.View = System.Windows.Forms.View.Details;
            this.lvSeriesList.SelectedIndexChanged += new System.EventHandler(this.lvSeriesList_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Series Name";
            this.columnHeader2.Width = 318;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "First Aired";
            this.columnHeader3.Width = 124;
            // 
            // SearchSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 543);
            this.Controls.Add(this.pbSeriesBanner);
            this.Controls.Add(this.tnCancel);
            this.Controls.Add(this.lblSeriesID);
            this.Controls.Add(this.txtSeriesID);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.plvSeriesInfo);
            this.Controls.Add(this.btnSearchSeries);
            this.Controls.Add(this.txtSeriesName);
            this.Controls.Add(this.lblSeriesName);
            this.Controls.Add(this.lvSeriesList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SearchSeries";
            this.Text = "Search Series";
            ((System.ComponentModel.ISupportInitialize)(this.pbSeriesBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListViewX lvSeriesList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lblSeriesName;
        private System.Windows.Forms.TextBox txtSeriesName;
        private System.Windows.Forms.Button btnSearchSeries;
        private PropertyListView plvSeriesInfo;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtSeriesID;
        private System.Windows.Forms.Label lblSeriesID;
        private System.Windows.Forms.Button tnCancel;
        private System.Windows.Forms.PictureBox pbSeriesBanner;
    }
}
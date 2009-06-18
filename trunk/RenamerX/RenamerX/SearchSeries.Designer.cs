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
            this.txtSeriesID = new System.Windows.Forms.TextBox();
            this.lblSeriesID = new System.Windows.Forms.Label();
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
            this.lblSeriesName.Size = new System.Drawing.Size(70, 13);
            this.lblSeriesName.TabIndex = 1;
            this.lblSeriesName.Text = "Series Name:";
            // 
            // txtSeriesName
            // 
            this.txtSeriesName.Location = new System.Drawing.Point(80, 9);
            this.txtSeriesName.Name = "txtSeriesName";
            this.txtSeriesName.Size = new System.Drawing.Size(216, 20);
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
            // txtSeriesID
            // 
            this.txtSeriesID.Location = new System.Drawing.Point(328, 8);
            this.txtSeriesID.Name = "txtSeriesID";
            this.txtSeriesID.Size = new System.Drawing.Size(64, 20);
            this.txtSeriesID.TabIndex = 6;
            // 
            // lblSeriesID
            // 
            this.lblSeriesID.AutoSize = true;
            this.lblSeriesID.Location = new System.Drawing.Point(304, 12);
            this.lblSeriesID.Name = "lblSeriesID";
            this.lblSeriesID.Size = new System.Drawing.Size(21, 13);
            this.lblSeriesID.TabIndex = 7;
            this.lblSeriesID.Text = "ID:";
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
            this.plvSeriesInfo.AllowEmptyObjects = false;
            this.plvSeriesInfo.ConstantColumnSize = true;
            this.plvSeriesInfo.FullRowSelect = true;
            this.plvSeriesInfo.GridLines = true;
            this.plvSeriesInfo.HideSelection = false;
            this.plvSeriesInfo.Location = new System.Drawing.Point(8, 328);
            this.plvSeriesInfo.MultiSelect = false;
            this.plvSeriesInfo.Name = "plvSeriesInfo";
            this.plvSeriesInfo.NameColumnSize = 125;
            this.plvSeriesInfo.SetObjectType = RenamerX.PropertyListView.ObjectType.Properties;
            this.plvSeriesInfo.Size = new System.Drawing.Size(464, 176);
            this.plvSeriesInfo.TabIndex = 4;
            this.plvSeriesInfo.UseCompatibleStateImageBehavior = false;
            this.plvSeriesInfo.View = System.Windows.Forms.View.Details;
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
            this.Controls.Add(this.pbSeriesBanner);
            this.Controls.Add(this.lblSeriesID);
            this.Controls.Add(this.txtSeriesID);
            this.Controls.Add(this.plvSeriesInfo);
            this.Controls.Add(this.btnSearchSeries);
            this.Controls.Add(this.txtSeriesName);
            this.Controls.Add(this.lblSeriesName);
            this.Controls.Add(this.lvSeriesList);
            this.Name = "SearchSeries";
            this.Size = new System.Drawing.Size(482, 517);
            ((System.ComponentModel.ISupportInitialize)(this.pbSeriesBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListViewX lvSeriesList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lblSeriesName;
        internal System.Windows.Forms.TextBox txtSeriesName;
        internal System.Windows.Forms.Button btnSearchSeries;
        private PropertyListView plvSeriesInfo;
        private System.Windows.Forms.TextBox txtSeriesID;
        private System.Windows.Forms.Label lblSeriesID;
        private System.Windows.Forms.PictureBox pbSeriesBanner;
    }
}
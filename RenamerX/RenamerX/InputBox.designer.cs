namespace RenamerX
{
    partial class InputBox
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblShowLocation = new System.Windows.Forms.Label();
            this.txtShowLocation = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.searchResults = new RenamerX.SearchSeries();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(312, 568);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(400, 568);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblShowLocation
            // 
            this.lblShowLocation.AutoSize = true;
            this.lblShowLocation.Location = new System.Drawing.Point(16, 16);
            this.lblShowLocation.Name = "lblShowLocation";
            this.lblShowLocation.Size = new System.Drawing.Size(51, 13);
            this.lblShowLocation.TabIndex = 4;
            this.lblShowLocation.Text = "Location:";
            // 
            // txtShowLocation
            // 
            this.txtShowLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtShowLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtShowLocation.Location = new System.Drawing.Point(88, 12);
            this.txtShowLocation.Name = "txtShowLocation";
            this.txtShowLocation.Size = new System.Drawing.Size(312, 20);
            this.txtShowLocation.TabIndex = 5;
            this.txtShowLocation.TextChanged += new System.EventHandler(this.txtShowLocation_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(408, 8);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(72, 23);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "&Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // searchResults
            // 
            this.searchResults.Location = new System.Drawing.Point(8, 40);
            this.searchResults.Name = "searchResults";
            this.searchResults.SeriesID = null;
            this.searchResults.SeriesName = null;
            this.searchResults.Size = new System.Drawing.Size(482, 517);
            this.searchResults.TabIndex = 7;
            // 
            // InputBox
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 603);
            this.Controls.Add(this.searchResults);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtShowLocation);
            this.Controls.Add(this.lblShowLocation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputBox";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.InputBox_Load);
            this.Shown += new System.EventHandler(this.InputBox_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblShowLocation;
        internal System.Windows.Forms.TextBox txtShowLocation;
        internal System.Windows.Forms.Button btnBrowse;
        internal SearchSeries searchResults;
    }
}
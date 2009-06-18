namespace RenamerX
{
    partial class SeriesFinder
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
            this.tnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.searchResults = new RenamerX.SearchSeries();
            this.SuspendLayout();
            // 
            // tnCancel
            // 
            this.tnCancel.Location = new System.Drawing.Point(408, 528);
            this.tnCancel.Name = "tnCancel";
            this.tnCancel.Size = new System.Drawing.Size(75, 23);
            this.tnCancel.TabIndex = 10;
            this.tnCancel.Text = "Cancel";
            this.tnCancel.UseVisualStyleBackColor = true;
            this.tnCancel.Click += new System.EventHandler(this.tnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(328, 528);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // searchResults
            // 
            this.searchResults.Location = new System.Drawing.Point(8, 8);
            this.searchResults.Name = "searchResults";
            this.searchResults.SeriesID = null;
            this.searchResults.SeriesName = null;
            this.searchResults.Size = new System.Drawing.Size(482, 512);
            this.searchResults.TabIndex = 11;
            this.searchResults.Load += new System.EventHandler(this.searchResults_Load);
            // 
            // SeriesFinder
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 562);
            this.Controls.Add(this.searchResults);
            this.Controls.Add(this.tnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "SeriesFinder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Series";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tnCancel;
        private System.Windows.Forms.Button btnOK;
        internal SearchSeries searchResults;
    }
}
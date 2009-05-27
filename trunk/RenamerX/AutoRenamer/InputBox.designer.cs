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
            this.txtShowName = new System.Windows.Forms.TextBox();
            this.lblShowName = new System.Windows.Forms.Label();
            this.lblShowLocation = new System.Windows.Forms.Label();
            this.txtShowLocation = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(200, 64);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(288, 64);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtShowName
            // 
            this.txtShowName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RenamerX.Properties.Settings.Default, "ShowName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtShowName.Location = new System.Drawing.Point(80, 8);
            this.txtShowName.Name = "txtShowName";
            this.txtShowName.Size = new System.Drawing.Size(200, 20);
            this.txtShowName.TabIndex = 2;
            this.txtShowName.Text = global::RenamerX.Properties.Settings.Default.ShowName;
            // 
            // lblShowName
            // 
            this.lblShowName.AutoSize = true;
            this.lblShowName.Location = new System.Drawing.Point(8, 12);
            this.lblShowName.Name = "lblShowName";
            this.lblShowName.Size = new System.Drawing.Size(68, 13);
            this.lblShowName.TabIndex = 3;
            this.lblShowName.Text = "Show Name:";
            // 
            // lblShowLocation
            // 
            this.lblShowLocation.AutoSize = true;
            this.lblShowLocation.Location = new System.Drawing.Point(8, 36);
            this.lblShowLocation.Name = "lblShowLocation";
            this.lblShowLocation.Size = new System.Drawing.Size(51, 13);
            this.lblShowLocation.TabIndex = 4;
            this.lblShowLocation.Text = "Location:";
            // 
            // txtShowLocation
            // 
            this.txtShowLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtShowLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtShowLocation.Location = new System.Drawing.Point(80, 32);
            this.txtShowLocation.Name = "txtShowLocation";
            this.txtShowLocation.Size = new System.Drawing.Size(200, 20);
            this.txtShowLocation.TabIndex = 5;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(288, 32);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(83, 23);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "&Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // InputBox
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 97);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtShowLocation);
            this.Controls.Add(this.lblShowLocation);
            this.Controls.Add(this.lblShowName);
            this.Controls.Add(this.txtShowName);
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
        internal System.Windows.Forms.TextBox txtShowName;
        internal System.Windows.Forms.Label lblShowName;
        private System.Windows.Forms.Label lblShowLocation;
        internal System.Windows.Forms.TextBox txtShowLocation;
        internal System.Windows.Forms.Button btnBrowse;
    }
}
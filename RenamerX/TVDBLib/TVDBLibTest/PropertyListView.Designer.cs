namespace TVDBLibTest
{
    partial class PropertyListView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvProperty = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lvProperty
            // 
            this.lvProperty.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvProperty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvProperty.FullRowSelect = true;
            this.lvProperty.GridLines = true;
            this.lvProperty.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvProperty.HideSelection = false;
            this.lvProperty.Location = new System.Drawing.Point(0, 0);
            this.lvProperty.MultiSelect = false;
            this.lvProperty.Name = "lvProperty";
            this.lvProperty.Size = new System.Drawing.Size(312, 286);
            this.lvProperty.TabIndex = 0;
            this.lvProperty.UseCompatibleStateImageBehavior = false;
            this.lvProperty.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 125;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 187;
            // 
            // PropertyListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvProperty);
            this.Name = "PropertyListView";
            this.Size = new System.Drawing.Size(312, 286);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvProperty;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;

namespace TVRenamer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            this.InitializeComponent();

            SetupScreen();
        }

        private void SetupScreen()
        {
            txtFolder.Text = Program.conf.lastDir;
            cmbSeparator.SelectedItem = Program.conf.separator;
            cmbNamingStyle.SelectedItem = Program.conf.style;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (this.txtFolder.Text != "")
            {
                dialog.SelectedPath = this.txtFolder.Text;
            }
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.txtFolder.Text = dialog.SelectedPath;
                this.RefreshView();
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.Preview();
            this.RenameFiles();
            this.tssLabel.Text = "Status: Renaming completed.";
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            this.Preview();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshView();
        }

        private void cmbSeparator_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbSeparator.Tag = this.cmbSeparator.SelectedItem.ToString().Substring(0, 1);

            Program.conf.separator = cmbSeparator.SelectedItem.ToString();
        }

        private void RenameFiles()
        {
            foreach (ListViewItem item in this.lvwTobe.Items)
            {
                if (File.Exists(this.txtFolder.Text + @"\" + item.Text))
                {
                    item.Checked = true;
                }
                else
                {
                    File.Move(this.txtFolder.Text + @"\" + item.Name, this.txtFolder.Text + @"\" + item.Text);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.conf.Save();
        }

        private string GetModifiedName(string name)
        {
            FileInfo info = new FileInfo(name);

            int season = 0;
            int episode = 0;
            
            Match m;
            
            if ((m = Regex.Match(name, @"\d{2}x\d{2}", RegexOptions.IgnoreCase)).Success)
            {
                Int32.TryParse(m.Value.Substring(0, 2), out season);
                Int32.TryParse(m.Value.Substring(3, 2), out episode);
            }
            else if ((m = Regex.Match(name, @"\dx\d{2}",RegexOptions.IgnoreCase)).Success)
            {
                Int32.TryParse(m.Value.Substring(0, 1), out season);
                Int32.TryParse(m.Value.Substring(2, 2), out episode);
            }
            else if ((m = Regex.Match(name, @"s\d{2}e\d{2}", RegexOptions.IgnoreCase)).Success)
            {
                Int32.TryParse(m.Value.Substring(1, 2), out season);
                Int32.TryParse(m.Value.Substring(4, 2), out episode);
            }
            else if ((m = Regex.Match(name, @"\d{4}")).Success)
            {
                Int32.TryParse(m.Value.Substring(0, 2), out season);
                Int32.TryParse(m.Value.Substring(2, 2), out episode);
            }
            else if ((m = Regex.Match(name, @"\d{3}")).Success)
            {
                Int32.TryParse(m.Value.Substring(0, 1), out season);
                Int32.TryParse(m.Value.Substring(1, 2), out episode);
            }

            return (this.cmbNamingStyle.Text.Replace("Show.Name", this.txtShowname.Text).Replace("<Separator>", this.cmbSeparator.Tag.ToString()).Replace("<SS>", season.ToString("00")).Replace("<EE>", episode.ToString("00")) + info.Extension);
        }

        private void Preview()
        {
            this.tssLabel.Text = "Status: Showing Preview.";
            this.lvwTobe.Items.Clear();
            foreach (ListViewItem item in this.lvwCurrent.Items)
            {
                if(item.Checked)
                    this.lvwTobe.Items.Add(this.GetModifiedName(item.Text)).Name = item.Text;
            }
        }

        private void RefreshView()
        {
            if (Directory.Exists(txtFolder.Text))
            {
                string[] files = Directory.GetFiles(this.txtFolder.Text);
                this.lvwCurrent.Items.Clear();
                foreach (string str in files)
                {
                    FileInfo info = new FileInfo(str);
                    if (info.Name.ToUpper().Contains(this.txtFilter.Text.ToUpper()))
                    {
                        this.lvwCurrent.Items.Add(info.Name).Checked = true;
                    }
                }
                if (this.lvwCurrent.Items.Count > 0)
                {
                    string text = GetShowName(this.lvwCurrent.Items[0].Text);

                    if (text != null)
                        this.txtShowname.Text = text;
                }
            }
            else
            {
                this.lvwCurrent.Items.Clear();
            }
        }

        private string GetShowName(string text)
        {
            //Assume show name is before the last dot of the first digit found    
            int firstDigit = text.IndexOfAny(this.AllDigits);

            if (text.Length > 0 && firstDigit >= 0)
            {
                string str = text.Substring(0, firstDigit);

                int i = str.LastIndexOf('.');

                if (i != -1)
                {
                    str = str.Substring(0, i);
                    if (str.Length > 0)
                    {
                         return str.Replace(" ", ".");
                    }
                }
            }

            return null;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            this.RefreshView();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void txtFolder_TextChanged(object sender, EventArgs e)
        {
            Program.conf.lastDir = txtFolder.Text;
        }

        private void cmbNamingStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.conf.style = cmbNamingStyle.SelectedItem.ToString();
        }
    }
}

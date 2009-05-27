using System;
using System.Windows.Forms;

namespace RenamerX
{
    public partial class InputBox : Form
    {
        public string ShowName { get; set; }
        public string ShowLocation { get; set; }

        public InputBox(string title, string showName, string showLocation)
            : this()
        {
            this.Text = title;
            ShowName = showName;
            ShowLocation = showLocation;
        }

        public InputBox()
        {
            InitializeComponent();
        }

        private void InputBox_Load(object sender, EventArgs e)
        {
            txtShowName.Text = ShowName;
            txtShowLocation.Text = ShowLocation;
        }

        private void InputBox_Shown(object sender, EventArgs e)
        {
            txtShowName.Focus();
            txtShowName.SelectionLength = txtShowName.Text.Length;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ShowLocation = dlg.SelectedPath;
                txtShowLocation.Text = ShowLocation;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtShowName.Text))
            {
                ShowName = txtShowName.Text;
                ShowLocation = txtShowLocation.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
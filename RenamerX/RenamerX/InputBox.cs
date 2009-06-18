#region License Information (GPL v2)
/*
    RenamerX - Rename your files eXpressly
    Copyright (C) 2009  RenamerX Developers

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
    
    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/
#endregion
using System;
using System.Windows.Forms;
using System.IO;

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
            if (string.IsNullOrEmpty(showLocation))
            {
                ShowLocation = Program.Settings.LastRenameFolder;
            }
            else
            {
                ShowLocation = showLocation;
            }
        }

        public InputBox()
        {
            InitializeComponent();
        }

        private void InputBox_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ShowName))
            {
               searchSeries1.txtSeriesName.Text = ShowName;
            }
            if (!string.IsNullOrEmpty(ShowLocation))
            {
                txtShowLocation.Text = ShowLocation;
            }
        }

        private void InputBox_Shown(object sender, EventArgs e)
        {
            searchSeries1.txtSeriesName.Focus();
            searchSeries1.txtSeriesName.SelectionLength = searchSeries1.txtSeriesName.Text.Length;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (!string.IsNullOrEmpty(txtShowLocation.Text) && Directory.Exists(txtShowLocation.Text))
            {
                dlg.SelectedPath = txtShowLocation.Text;
            }
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ShowLocation = dlg.SelectedPath;
                txtShowLocation.Text = ShowLocation;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.ShowName = searchSeries1.SeriesName;
            this.ShowLocation = txtShowLocation.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtShowLocation_TextChanged(object sender, EventArgs e)
        {
            Program.Settings.LastRenameFolder = txtShowLocation.Text;
        }
    }
}
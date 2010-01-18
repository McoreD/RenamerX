using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RenamerX
{
    public partial class SeriesFinder : Form
    {
        public SeriesFinder()
        {
            InitializeComponent();
        }

        public SeriesFinder(string showname)
            : this()
        {
            this.Search(showname);
        }

        private void Search(string showname)
        {
            if (!string.IsNullOrEmpty(showname))
            {
                searchResults.txtSeriesName.Text = showname;
                searchResults.Search(showname);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchResults.txtSeriesName.Text))
            {
                this.Search(searchResults.txtSeriesName.Text);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void tnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}

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
                SearchResults.txtSeriesName.Text = showname;
                SearchResults.Search(showname);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchResults.txtSeriesName.Text))
            {
                this.Search(SearchResults.txtSeriesName.Text);
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
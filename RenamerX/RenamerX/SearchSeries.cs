using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TVDBLib;

namespace RenamerX
{
    public partial class SearchSeries : Form
    {
        public string SeriesID;

        public SearchSeries()
        {
            InitializeComponent();
        }

        public SearchSeries(string showname)
            : this()
        {
            if (!string.IsNullOrEmpty(showname))
            {
                txtSeriesName.Text = showname;
                Search(showname);
            }
        }

        private void btnSearchSeries_Click(object sender, EventArgs e)
        {
            Search(txtSeriesName.Text);
        }

        private void Search(string showname)
        {
            List<Series> series = Program.TVDB.GetSeriesList(showname);
            lvSeriesList.Items.Clear();
            foreach (Series serie in series)
            {
                ListViewItem lvi = new ListViewItem(serie.SeriesName);
                lvi.SubItems.Add(serie.FirstAired);
                lvi.Tag = serie;
                lvSeriesList.Items.Add(lvi);
            }
            if (lvSeriesList.Items.Count > 0)
            {
                lvSeriesList.Items[0].Selected = true;
            }
        }

        private void lvSeriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSeriesList.SelectedItems.Count > 0)
            {
                Series series = (Series)lvSeriesList.SelectedItems[0].Tag;
                plvSeriesInfo.SelectedObject = series;
                LoadBanner(series);
                SeriesID = series.ID;
                txtSeriesID.Text = SeriesID;
            }
        }

        private void LoadBanner(Series series)
        {
            pbSeriesBanner.SizeMode = PictureBoxSizeMode.CenterImage;
            pbSeriesBanner.Image = RenamerX.Properties.Resources.loading1;
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += new DoWorkEventHandler(Banners_DoWork);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Banners_RunWorkerCompleted);
            bw.RunWorkerAsync(series);
        }

        private void Banners_DoWork(object sender, DoWorkEventArgs e)
        {
            Series series = (Series)e.Argument;
            e.Result = Program.TVDB.GetImagePath(series.Banner, series.ID);
        }

        private void Banners_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pbSeriesBanner.Image = new Bitmap(1, 1);
            pbSeriesBanner.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSeriesBanner.ImageLocation = (string)e.Result;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void tnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtSeriesName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                Search(txtSeriesName.Text);
            }
        }
    }
}

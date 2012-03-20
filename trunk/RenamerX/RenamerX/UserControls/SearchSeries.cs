using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TVDBLib;

namespace RenamerX
{
    public partial class SearchSeries : UserControl
    {
        public SeriesInfo Info = new SeriesInfo();

        public SearchSeries()
        {
            InitializeComponent();
        }

        public void Search(string showname)
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

        private void btnSearchSeries_Click(object sender, EventArgs e)
        {
            Search(txtSeriesName.Text);
        }

        private void lvSeriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSeriesList.SelectedItems.Count > 0)
            {
                Series series = (Series)lvSeriesList.SelectedItems[0].Tag;
                plvSeriesInfo.SelectedObject = series;
                LoadBanner(series);
                Info.SeriesID = series.ID;
                Info.SeriesName = series.SeriesName;
                txtSeriesID.Text = Info.SeriesID;
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

        private void txtSeriesName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                Search(txtSeriesName.Text);
            }
        }
    }
}
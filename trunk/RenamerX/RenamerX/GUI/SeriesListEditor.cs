using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RenamerX.GUI
{
    public partial class SeriesListEditor : Form
    {
        public SeriesListEditor()
        {
            InitializeComponent();
        }

        public SeriesListEditor(List<SeriesInfo> list)
            : this()
        {
            foreach (SeriesInfo info in list)
            {
                lvSeriesList.Items.Add(info.SeriesID).SubItems.Add(info.SeriesName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SeriesFinder seriesFinder = new SeriesFinder())
            {
                if (seriesFinder.ShowDialog() == DialogResult.OK)
                {
                    SeriesInfo info = seriesFinder.SearchResults.Info;
                    if (!string.IsNullOrEmpty(info.SeriesID) && !string.IsNullOrEmpty(info.SeriesName) &&
                        !Program.Settings.CalenderList.Exists(x => x.SeriesID == info.SeriesID))
                    {
                        Program.Settings.CalenderList.Add(info);
                        lvSeriesList.Items.Add(info.SeriesID).SubItems.Add(info.SeriesName);
                    }
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (int index in lvSeriesList.SelectedIndices)
            {
                if (Program.Settings.CalenderList.Count > index)
                {
                    Program.Settings.CalenderList.RemoveAt(index);
                }

                lvSeriesList.Items.RemoveAt(index);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Program.Settings.CalenderList.Clear();
            lvSeriesList.Items.Clear();
        }
    }
}
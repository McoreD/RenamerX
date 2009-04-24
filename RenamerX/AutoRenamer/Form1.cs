using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;

namespace RenamerX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshLists("Lost", @"E:\Diziler\Lost\Season 4"); //@"S:\TV\LOST\Season 04);"
        }

        public void RefreshLists(string showName, string dir)
        {
            if (Directory.Exists(dir))
            {
                List<string> Files = new List<string>();
                foreach (string file in Directory.GetFiles(dir, "*.avi"))
                {
                    Files.Add(file.Remove(0, file.LastIndexOf("\\") + 1));
                }
                Show show = FindShow(showName);
                foreach (string file in Files)
                {
                    listView1.Items.Add(file);
                    listView2.Items.Add(Reformat(show, file));
                }
            }
        }

        public Show FindShow(string showName)
        {
            Show seasons = new Show(showName);
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("http://www.tvrage.com/feeds/episode_list.php?show=" + showName);
                XmlNode xmlNode = xmlDoc.DocumentElement.SelectSingleNode("Episodelist");

                foreach (XmlNode childs in xmlNode.ChildNodes) //Seasons
                {
                    Season season = new Season();
                    if (childs.Attributes.Count > 0)
                    {
                        season.SeasonNumber = childs.Attributes[0].Value.ToInt();
                    }
                    foreach (XmlNode childs2 in childs.ChildNodes) //Episodes
                    {
                        season.Episodes.Add(new Episode(childs2));
                    }
                    seasons.Seasons.Add(season);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return seasons;
        }

        public string Reformat(Show show, string filename)
        {
            if (show != null)
            {
                string pattern = @"s(?<Season>\d+)e(?<Episode>\d+)|(?<Season>\d+)(?<Episode>\d{2,})|(?<Season>\d{2,})x(?<Episode>\d{2,})";
                Match result = Regex.Match(filename, pattern, RegexOptions.IgnoreCase);
                string s = result.Groups["Season"].Value;
                string e = result.Groups["Episode"].Value;
                if (s.ToInt() > 0 && e.ToInt() > 0)
                {
                    pattern = txtNameFormat.Text;
                    return pattern.Replace("$N", show.ShowName).Replace("$S", s).Replace("$E", e).
                        Replace("$T", show.FindSeason(s.ToInt()).FindEpisode(e.ToInt()).Title);
                }
            }
            return filename;
        }
    }

    public static class Extensions
    {
        public static int ToInt(this string str)
        {
            return Convert.ToInt32(str);
        }
    }

    public class Show : IEnumerable
    {
        public string ShowName;
        public List<Season> Seasons = new List<Season>();

        public Show(string showName)
        {
            ShowName = showName;
        }

        public Season FindSeason(int number)
        {
            foreach (Season season in Seasons)
            {
                if (season.SeasonNumber == number)
                {
                    return season;
                }
            }
            return null;
        }

        public IEnumerator GetEnumerator()
        {
            return Seasons.GetEnumerator();
        }
    }

    public class Season : IEnumerable
    {
        public int SeasonNumber;
        public List<Episode> Episodes = new List<Episode>();

        public Season() { }

        public Season(int seasonNumber)
        {
            SeasonNumber = seasonNumber;
        }

        public Episode FindEpisode(int number)
        {
            foreach (Episode episode in Episodes)
            {
                if (episode.EpisodeNumber.ToInt() == number)
                {
                    return episode;
                }
            }
            return null;
        }

        public IEnumerator GetEnumerator()
        {
            return Episodes.GetEnumerator();
        }
    }

    public class Episode
    {
        public string EpisodeNumber;
        public string SeasonEpisodeNumber;
        public string Title;

        public Episode(string episodeNumber, string seasonEpisodeNumber, string title)
        {
            EpisodeNumber = episodeNumber;
            SeasonEpisodeNumber = seasonEpisodeNumber;
            Title = title;
        }

        public Episode(XmlNode xmlNode)
        {
            XmlNode node;
            node = xmlNode.SelectSingleNode("seasonnum");
            if (node != null)
            {
                EpisodeNumber = node.InnerText;
            }
            node = xmlNode.SelectSingleNode("epnum");
            if (node != null)
            {
                SeasonEpisodeNumber = node.InnerText;
            }
            node = xmlNode.SelectSingleNode("title");
            if (node != null)
            {
                Title = node.InnerText;
            }
        }
    }
}
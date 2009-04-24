﻿using System;
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
        Show Lost;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lost = FindEpisodeNames("Lost");
            List<string> Files = new List<string>();
            string dir = @"S:\TV\LOST\Season 04";
            //string dir = @"E:\Diziler\Lost\Season 2";            
            if (Directory.Exists(dir))
            {
                foreach (string file in Directory.GetFiles(dir, "*.avi"))                
                {
                    Files.Add(file.Remove(0, file.LastIndexOf("\\") + 1));
                }
                foreach (string file in Files)
                {
                    listView1.Items.Add(file);
                    listView2.Items.Add(Reformat(file));
                }
            }
        }

        public Show FindEpisodeNames(string showName)
        {
            Show seasons = new Show();
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("http://www.tvrage.com/feeds/episode_list.php?show=" + showName);
                XmlNode xmlNode = xmlDoc.DocumentElement.SelectSingleNode("Episodelist");

                foreach (XmlNode childs in xmlNode.ChildNodes) //Seasons
                {
                    Season season = new Season();
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

        public string Reformat(string filename)
        {
            if (Lost != null)
            {

                string pattern = @"S(?<Season>\d+)E(?<Episode>\d+)|(?<Season>\d+)(?<Episode>\d{2,})|(?<Season>\d{2,})x(?<Episode>\d{2,})";
                Match result = Regex.Match(filename, pattern, RegexOptions.IgnoreCase);
                string s = result.Groups[1].Value;
                string e = result.Groups[2].Value;
                if (s.ToInt() > 0 && e.ToInt() > 0)
                {
                    return "Lost - S" + s + "E" + e + " - " + Lost.Seasons[s.ToInt() - 1].Episodes[e.ToInt() - 1].Title;
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
        public List<Season> Seasons = new List<Season>();

        public IEnumerator GetEnumerator()
        {
            return Seasons.GetEnumerator();
        }
    }

    public class Season : IEnumerable
    {
        public int SeasonNumber;
        public List<Episode> Episodes = new List<Episode>();

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
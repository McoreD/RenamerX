using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.IO;

namespace RenamerX
{
    public class ShowItem
    {
        public string ShowName;
        public string ShowDirectory;
        public List<ShowInfo> ShowInfos = new List<ShowInfo>();

        public ShowItem(string showName, string showDirectory)
        {
            ShowName = showName;
            ShowDirectory = showDirectory;
        }

        public override string ToString()
        {
            return ShowName + ": " + ShowDirectory.Remove(0, ShowDirectory.LastIndexOf("\\") + 1);
        }
    }

    public struct ShowInfo
    {
        public string DefaultFileName { get; set; }
        public string DefaultFilePath { get; set; }
        public string NewFileName { get; private set; }
        public string NewFilePath { get; set; }
        public bool Invalid { get; set; }

        public void SetShowName(string name)
        {
            List<char> dirty = new List<char>();
            dirty.AddRange(Path.GetInvalidFileNameChars());
            dirty.AddRange(Path.GetInvalidPathChars());
            dirty.Add('?'); // for some reason the above methods dont add question mark

            foreach (char c in dirty)
            {
                name  = name.Replace(c, '_');
                System.Console.WriteLine(c.ToString());
            }
           
            this.NewFileName = name;
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

        public Episode FindEpisode(int season, int episode)
        {
            Season findSeason = FindSeason(season);
            if (findSeason != null)
            {
                return findSeason.FindEpisode(episode);
            }
            return null;
        }

        public IEnumerator GetEnumerator()
        {
            return Seasons.GetEnumerator();
        }

        public bool Contains(string showName)
        {
            return this.ShowName == showName;
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
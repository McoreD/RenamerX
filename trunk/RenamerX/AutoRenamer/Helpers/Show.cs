using System.Collections.Generic;
using System.Collections;

namespace RenamerX
{
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
}
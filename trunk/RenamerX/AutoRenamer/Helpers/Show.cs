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
#region License Information (GPL v2)

/*
    TVRageLib - C# Library for TVRage Services
    Copyright (C) 2009  TVRage Developers

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

#endregion License Information (GPL v2)

using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace TVRageLib
{
    public class TVRage
    {
        private List<Show> Cache = new List<Show>();

        public Show FindShow(string showName)
        {
            return FindShow(showName, true);
        }

        //http://www.tvrage.com/feeds/episode_list.php?show=Lost
        public Show FindShow(string showName, bool checkCache)
        {
            if (checkCache)
            {
                foreach (Show shows in Cache)
                {
                    if (shows.Name.ToLowerInvariant() == showName.ToLowerInvariant())
                    {
                        return shows;
                    }
                }
            }

            Show show = new Show(showName);
            try
            {
                XElement xml = XDocument.Load("http://www.tvrage.com/feeds/episode_list.php?show=" + showName).Element("Show");
                show.Name = xml.Element("name").Value;
                show.TotalSeasons = xml.Element("totalseasons").Value;

                foreach (XElement seasons in xml.Element("Episodelist").Elements())
                {
                    Season season = new Season();
                    if (seasons.Attribute("no") != null)
                    {
                        season.SeasonNumber = int.Parse(seasons.Attribute("no").Value);
                    }
                    foreach (XElement episodes in seasons.Elements("episode"))
                    {
                        season.Episodes.Add(new Episode(episodes));
                    }
                    show.Seasons.Add(season);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Cache.Add(show);
            return show;
        }
    }
}
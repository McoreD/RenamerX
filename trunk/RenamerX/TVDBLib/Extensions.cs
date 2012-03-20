#region License Information (GPL v2)

/*
    TVDBLib - C# Library for TVDB Services
    Copyright (C) 2009  TVDBLib Developers

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

namespace TVDBLib
{
    public static class Extensions
    {
        public static List<Episode> SearchEpisode(this List<Episode> Episodes, string episodeName, string seasonNumber, string episodeNumber)
        {
            List<Episode> episodes = new List<Episode>();
            foreach (Episode episode in Episodes)
            {
                if ((string.IsNullOrEmpty(seasonNumber) || episode.SeasonNumber == seasonNumber) &&
                    (string.IsNullOrEmpty(episodeNumber) || episode.EpisodeNumber == episodeNumber) &&
                    (string.IsNullOrEmpty(episodeName) || episode.EpisodeName.IndexOf(episodeName, StringComparison.InvariantCultureIgnoreCase) != -1))
                {
                    episodes.Add(episode);
                }
            }
            return episodes;
        }

        public static List<Episode> SearchEpisode(this List<Episode> Episodes, string episodeName)
        {
            return SearchEpisode(Episodes, episodeName, null, null);
        }

        public static List<Episode> SearchEpisode(this List<Episode> Episodes, string seasonNumber, string episodeNumber)
        {
            return SearchEpisode(Episodes, null, seasonNumber, episodeNumber);
        }

        public static string ToString(this XElement xe, string name)
        {
            XElement xeItem = xe.Element(name);
            if (xeItem != null)
            {
                return xeItem.Value;
            }
            else
            {
                return "";
            }
        }

        public static int ToInt(this XElement xe, string name)
        {
            XElement xeItem = xe.Element(name);
            if (xeItem != null)
            {
                int number;
                bool result = int.TryParse(xeItem.Value, out number);
                if (result)
                {
                    return number;
                }
            }
            return -1;
        }
    }
}
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
#endregion

using System.Collections;
using System.Collections.Generic;

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
            if (int.Parse(episode.SeasonNumber) == number)
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
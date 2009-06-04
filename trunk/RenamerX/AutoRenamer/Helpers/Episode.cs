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
using System.Xml;

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
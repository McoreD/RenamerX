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
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace TVDBLib
{
    public class Language
    {
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public string ID { get; set; }
    }

    public class Mirror
    {
        public string ID { get; set; }
        public string MirrorPath { get; set; }
        public string TypeMask { get; set; }
    }

    #region Series
    /*
    <Series>
        <id>73739</id>

        <Actors>|Matthew Fox|Evangeline Lilly|Naveen Andrews|Elizabeth Mitchell|Michael Emerson|Terry O'Quinn|Daniel Dae Kim|Yunjin Kim|Josh Holloway|Andrew Divoff|Sam Anderson|L. Scott Caldwell|Nestor Carbonell|Kevin Durand|Jeff Fahey|Tania Raymonde|Mira Furlan|Alan Dale|Sonya Walger|Rebecca Mader|Ken Leung|Jeremy Davies|Kiele Sanchez|Rodrigo Santoro|Cynthia Watros|Adewale Akinnuoye-Agbaje|Henry Ian Cusick|Michelle Rodriguez|Dominic Monaghan|Emilie de Ravin|Harold Perrineau Jr.|Ian Somerhalder|Maggie Grace|Jorge Garcia|Malcolm David Kelley|M.C. Gainey|Zuleikha Robinson|</Actors>
        <Airs_DayOfWeek>Wednesday</Airs_DayOfWeek>
        <Airs_Time>9:00 PM</Airs_Time>
        <ContentRating>TV-14</ContentRating>
        <FirstAired>2004-09-22</FirstAired>
        <Genre>|Action and Adventure|Drama|Science-Fiction|</Genre>
        <IMDB_ID>tt0411008</IMDB_ID>
        <Language>en</Language>
        <Network>ABC</Network>
        <NetworkID></NetworkID>
        <Overview>After their plane, Oceanic Air flight 815, tore apart whilst thousands of miles off course, the survivors find themselves on a mysterious deserted island where they soon find out they are not alone.</Overview>
        <Rating>9.1</Rating>
        <Runtime>60</Runtime>
        <SeriesID>24313</SeriesID>
        <SeriesName>Lost</SeriesName>
        <Status>Continuing</Status>

        <added></added>
        <addedBy></addedBy>
        <banner>graphical/73739-g4.jpg</banner>
        <fanart>fanart/original/73739-32.jpg</fanart>
        <lastupdated>1243775077</lastupdated>
        <poster>posters/73739-7.jpg</poster>
        <zap2it_id>SH672362</zap2it_id>
    </Series>
    */
    #endregion

    public class Series
    {
        public string ID { get; set; }
        public string Actors { get; set; }
        public string AirsDayOfWeek { get; set; }
        public string AirsTime { get; set; }
        public string ContentRating { get; set; }
        public string FirstAired { get; set; }
        public string Genre { get; set; }
        public string IMDB_ID { get; set; }
        public string Language { get; set; }
        public string Network { get; set; }
        public string NetworkID { get; set; }
        public string Overview { get; set; }
        public string Rating { get; set; }
        public string Runtime { get; set; }
        public string SeriesID { get; set; }
        public string SeriesName { get; set; }
        public string Status { get; set; }
        public string Added { get; set; }
        public string AddedBy { get; set; }
        public string Banner { get; set; }
        public string Fanart { get; set; }
        public string LastUpdated { get; set; }
        public string Poster { get; set; }
        public string Zap2ItID { get; set; }
    }

    #region Episode
    /*
    <Episode>
        <id>127151</id>
        
        <Combined_episodenumber>1</Combined_episodenumber>
        <Combined_season>0</Combined_season>
        <DVD_chapter></DVD_chapter>
        <DVD_discid></DVD_discid>
        <DVD_episodenumber></DVD_episodenumber>
        <DVD_season></DVD_season>
        <Director></Director>
        <EpImgFlag>1</EpImgFlag>
        <EpisodeName>The Journey</EpisodeName>
        <EpisodeNumber>1</EpisodeNumber>
        <FirstAired>2005-04-27</FirstAired>
        <GuestStars>|Brian Cox|</GuestStars>
        <IMDB_ID></IMDB_ID>
        <Language>en</Language>
        <Overview>Flashbacks of the core characters illustrating who they were and what they were doing before the crash, a look at the island itself, and a preview of the big season finale.</Overview>
        <ProductionCode>120</ProductionCode>
        <Rating></Rating>
        <SeasonNumber>0</SeasonNumber>
        <Writer></Writer>
        
        <absolute_number></absolute_number>
        <airsafter_season></airsafter_season>
        <airsbefore_episode>21</airsbefore_episode>
        <airsbefore_season>1</airsbefore_season>
        <filename>episodes/73739/127151.jpg</filename>
        <lastupdated>1243531710</lastupdated>
        <seasonid>21201</seasonid>
        <seriesid>73739</seriesid>
    </Episode>
     */
    #endregion

    public class Episode
    {
        public string ID { get; set; }
        public string Combined_EpisodeNumber { get; set; }
        public string Combined_Season { get; set; }
        public string DVD_Chapter { get; set; }
        public string DVD_DiscID { get; set; }
        public string DVD_EpisodeNumber { get; set; }
        public string DVD_Season { get; set; }
        public string Director { get; set; }
        public string EpImgFlag { get; set; }
        public string EpisodeName { get; set; }
        public string EpisodeNumber { get; set; }
        public string FirstAired { get; set; }
        public string GuestStars { get; set; }
        public string IMDB_ID { get; set; }
        public string Language { get; set; }
        public string Overview { get; set; }
        public string ProductionCode { get; set; }
        public string Rating { get; set; }
        public string SeasonNumber { get; set; }
        public string Writer { get; set; }
        public string AbsoluteNumber { get; set; }
        public string AirsAfterSeason { get; set; }
        public string AirsBeforeEpisode { get; set; }
        public string AirsBeforeSeason { get; set; }
        public string Filename { get; set; }
        public string LastUpdated { get; set; }
        public string SeasonID { get; set; }
        public string SeriesID { get; set; }
    }

    #region Banner
    /*
    <Banner>
        <id>23089</id>
        <BannerPath>fanart/original/73739-15.jpg</BannerPath>
        <BannerType>fanart</BannerType>
        <BannerType2>1920x1080</BannerType2>
        <Colors>|255,255,255|0,0,0|181,199,209|</Colors>

        <Language>en</Language>
        <SeriesName>false</SeriesName>
        <ThumbnailPath>_cache/fanart/original/73739-15.jpg</ThumbnailPath>
        <VignettePath>fanart/vignette/73739-15.jpg</VignettePath>
    </Banner>
    */
    #endregion

    public class Banner
    {
        public string ID { get; set; }
        public string BannerPath { get; set; }
        public string BannerType { get; set; }
        public string BannerType2 { get; set; }
        public string Colors { get; set; }
        public string Language { get; set; }
        public string SeriesName { get; set; }
        public string ThumbnailPath { get; set; }
        public string VignettePath { get; set; }
    }

    public class SeriesFull
    {
        public Series Series = new Series();
        public List<Episode> Episodes = new List<Episode>();
        public List<Banner> Banners = new List<Banner>();

        public SeriesFull() { }

        public SeriesFull(Series series, List<Episode> episodes)
        {
            this.Series = series;
            this.Episodes = episodes;
        }

        public SeriesFull(Series series, List<Episode> episodes, List<Banner> banners)
        {
            this.Series = series;
            this.Episodes = episodes;
            this.Banners = banners;
        }
    }

    public class Updates
    {
        public string Time;
        public List<string> Series = new List<string>();
        public List<string> Episodes = new List<string>();
    }

    public class SeriesPacket
    {
        public string Filename;
        public XDocument Data;

        public SeriesPacket(string filename, byte[] data)
        {
            this.Filename = filename;
            this.Data = XDocument.Parse(Encoding.UTF8.GetString(data));
        }

        public SeriesPacket(string filename, XDocument data)
        {
            this.Filename = filename;
            this.Data = data;
        }
    }
}
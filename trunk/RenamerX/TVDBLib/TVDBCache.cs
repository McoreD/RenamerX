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
using System.IO;
using System.Xml.Linq;
using System.Xml;
using System.Net;
using ICSharpCode.SharpZipLib.Zip;

namespace TVDBLib
{
    public class TVDBCache
    {
        public string CachePath;
        public bool CacheLoad, CacheSave;

        public TVDBCache(string path)
        {
            CachePath = path;
            CacheLoad = CacheSave = true;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        public string LoadTime()
        {
            string path = Path.Combine(CachePath, "time.xml");
            if (File.Exists(path))
            {
                return XDocument.Load(path).Element("Time").Value;
            }
            return null;
        }

        public bool SaveTime(string time)
        {
            XDocument xml = new XDocument(new XElement("Time", time));
            xml.Save(Path.Combine(CachePath, "time.xml"));
            return true;
        }

        public XDocument CheckSeries(string path, string seriesid, string language)
        {
            return Check(path, string.Format(@"series\{0}\{1}.xml", seriesid, language));
        }

        public XDocument CheckActors(string path, string seriesid)
        {
            return Check(path, string.Format(@"series\{0}\actors.xml", seriesid));
        }

        public XDocument CheckBanners(string path, string seriesid)
        {
            return Check(path, string.Format(@"series\{0}\banners.xml", seriesid));
        }

        public bool SeriesExist(string seriesid, string language)
        {
            return Directory.Exists(Path.Combine(CachePath, @"series\" + seriesid));
        }

        public XDocument CheckSeriesFull(string path, string seriesid, string language)
        {
            return Check(path, string.Format(@"series\{0}\all\{1}.xml", seriesid, language));
        }

        public List<SeriesPacket> CheckSeriesFullZIP(string path, string seriesid, string language)
        {
            return CheckZIP(path, string.Format(@"series\{0}\all", seriesid), language);
        }

        public XDocument CheckLanguages(string path)
        {
            return Check(path, "languages.xml");
        }

        public XDocument CheckMirrors(string path)
        {
            return Check(path, "mirrors.xml");
        }

        private XDocument Check(string path, string localPath)
        {
            localPath = Path.Combine(CachePath, localPath);
            XDocument xml = null;
            if (CacheLoad)
            {
                xml = Load(localPath);
            }
            if (xml == null)
            {
                xml = XDocument.Load(path);
                if (CacheSave)
                {
                    Save(xml, localPath);
                }
            }
            return xml;
        }

        private List<SeriesPacket> CheckZIP(string path, string path2, string language)
        {
            string localPath = Path.Combine(CachePath, path2);
            List<SeriesPacket> seriesPackets = new List<SeriesPacket>();
            if (CacheLoad)
            {
                string[] filenames = new[] { language + ".xml", "actors.xml", "banners.xml" };
                foreach (string filename in filenames)
                {
                    string localPath2 = Path.Combine(localPath, filename);
                    XDocument load = Load(localPath2);
                    if (load != null)
                    {
                        seriesPackets.Add(new SeriesPacket(filename, load));
                    }
                }
            }
            if (seriesPackets.Count != 3)
            {
                seriesPackets = DownloadZIP(path);
                foreach (SeriesPacket series in seriesPackets)
                {
                    if (CacheSave)
                    {
                        Save(series.Data, Path.Combine(localPath, series.Filename));
                    }
                }
            }
            return seriesPackets;
        }

        private XDocument Load(string path)
        {
            if (File.Exists(path))
            {
                return XDocument.Load(path);
            }
            return null;
        }

        private bool Save(XDocument xml, string path)
        {
            string directory = Path.GetDirectoryName(path);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            xml.Save(path);
            return true;
        }

        private List<SeriesPacket> DownloadZIP(string path)
        {
            List<SeriesPacket> seriesPackets = new List<SeriesPacket>();
            byte[] data = new WebClient().DownloadData(path);
            ZipInputStream zip = new ZipInputStream(new MemoryStream(data));
            ZipEntry entry;
            while ((entry = zip.GetNextEntry()) != null)
            {
                byte[] buffer = new byte[zip.Length];
                int count = zip.Read(buffer, 0, (int)zip.Length);
                seriesPackets.Add(new SeriesPacket(entry.Name, buffer));
            }
            zip.Close();
            return seriesPackets;
        }
    }
}
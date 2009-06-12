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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace RenamerX
{
    [XmlRoot("Settings")]
    public class XMLSettings
    {
        #region Settings

        // Rename
        public List<ShowItem> ShowsList = new List<ShowItem>();
        public string NameFormat = "$N - S$S2E$E2 - $T";
        public string RenameFileFilter = "*.avi|*.mkv|*.srt|*.sub";

        // Extract
        public string ExtractPath = "";
        public string UnRARPath = "";
        public string ExtractFileFilter = "*.rar|*.r00";
        public string ExtractFileSizeFilter = ">10 MiB";
        public bool SearchSubFolders = true;
        public bool ExtractOverwrite = false;
        public string ExtractPassword = "";

        // General Settings
        public bool ShowHelpTooltips = true;

        // Rename Settings
        public string RegexpPattern = @"s(?<Season>\d+)e(?<Episode>\d+)|(?<Season>\d+)x(?<Episode>\d+)|(?<Season>(?<!2)[01]?\d)(?<Episode>\d{2}(?!\d))";
        public bool ShowActionMessages = false;
        public bool GuessShowName = false;
        public bool ReplaceIllegalChars = false;
        public string ReplaceIllegalCharsWith = "";
        public bool ReplaceSpaces = false;
        public string ReplaceSpacesWith = "";
        public bool ShowErrors = false;

        // Series Info
        public string LastSeriesName = "";
        public string LastSeriesID = "";

        // Others
        public string LastRenameFolder = "";
        public string LastExtractFolder = "";

        #endregion

        #region I/O Methods

        public void Save()
        {
            Save(Program.XMLSettingsFile);
        }

        public void Save(string filePath)
        {
            try
            {
                if (!Directory.Exists(Path.GetDirectoryName(filePath)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                }

                XmlSerializer xs = new XmlSerializer(typeof(XMLSettings));
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    xs.Serialize(fs, this);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static XMLSettings Read()
        {
            return Read(Program.XMLSettingsFile);
        }

        public static XMLSettings Read(string filePath)
        {
            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            }

            if (File.Exists(filePath))
            {
                try
                {
                    XmlSerializer xs = new XmlSerializer(typeof(XMLSettings));
                    using (FileStream fs = new FileStream(filePath, FileMode.Open))
                    {
                        return (XMLSettings)xs.Deserialize(fs);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            return new XMLSettings();
        }

        #endregion
    }
}
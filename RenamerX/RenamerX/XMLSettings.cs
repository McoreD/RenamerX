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
using System.ComponentModel;

namespace RenamerX
{
    [XmlRoot("Settings")]
    public class XMLSettings
    {
        #region Settings

        // Rename
        [Category("Options / Shows"), DefaultValue(true), Description("Remember TV Show List.")]
        public bool RememberList { get; set; }
        public List<ShowItem> ShowsList = new List<ShowItem>();
        public string NameFormat = "$N - S$S2E$E2 - $T";
        public string RenameFileFilter = "*.avi|*.mkv|*.srt|*.sub";

        // Extract
        public string ExtractPath = string.Empty;
        public string UnRARPath = string.Empty;
        public string ExtractFileFilter = "*.rar|*.r00";
        public string ExtractFileSizeFilter = ">10 MiB";
        public bool SearchSubFolders = true;
        public bool ExtractOverwrite = false;
        public string ExtractPassword = string.Empty;
        [Category("Options / Extract"), DefaultValue(false), Description("Append file name as a folder")]
        public bool AppendFileNameAsFolder { get; set; }

        // General Settings
        public bool ShowHelpTooltips = true;

        // Rename Settings
        public string RegexpPattern = @"s(?<Season>\d+)e(?<Episode>\d+)|(?<Season>\d+)x(?<Episode>\d+)|(?<Season>(?<!2)[01]?\d)(?<Episode>\d{2}(?!\d))";
        public bool ShowActionMessages = false;
        public bool GuessShowName = false;
        public bool ReplaceIllegalChars = true;
        public string ReplaceIllegalCharsWith = string.Empty;
        public bool ReplaceSpaces = false;
        public string ReplaceSpacesWith = string.Empty;
        public bool ShowErrors = false;

        // Series Info
        public string LastSeriesName = string.Empty;
        public string LastSeriesID = string.Empty;

        // Others
        public string LastRenameFolder = string.Empty;
        public string LastExtractFolder = string.Empty;

        // Calender
        public List<SeriesInfo> CalenderList = new List<SeriesInfo>();
        public int CalendarMinDays = 0;
        public int CalendarMaxDays = 30;

        #endregion

        #region I/O Methods

        /// <summary>
        /// Default Settings
        /// </summary>
        public XMLSettings()
        {
            ApplyDefaultValues(this);
        }

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

        public static void ApplyDefaultValues(object self)
        {
            foreach (PropertyDescriptor prop in TypeDescriptor.GetProperties(self))
            {
                DefaultValueAttribute attr = prop.Attributes[typeof(DefaultValueAttribute)] as DefaultValueAttribute;
                if (attr == null) continue;
                prop.SetValue(self, attr.Value);
            }
        }
    }
}
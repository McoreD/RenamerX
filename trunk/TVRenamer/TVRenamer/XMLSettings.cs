#region License Information (GPL v2)
/*
    ZScreen - A program that allows you to upload screenshots in one keystroke.
    Copyright (C) 2008  Brandon Zimmerman

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
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace TVRenamer
{

    [XmlRoot("Settings")]
    public class XMLSettings
    {
        //*********************
        //* Misc Settings
        //*********************
        public string lastDir = @"C:\";
        public string separator = ".<Dot>";
        public string style = "Show.Name<Separator>S<SS>E<EE>";
        public bool truncateEnd = false;

        #region I/O Methods
        public void Save(string filePath)
        {
            try
            {
                if (!Directory.Exists(Path.GetDirectoryName(filePath)))
                    Directory.CreateDirectory(Path.GetDirectoryName(filePath));

                //Write XML file
                XmlSerializer serial = new XmlSerializer(typeof(XMLSettings));
                FileStream fs = new FileStream(filePath, FileMode.Create);
                serial.Serialize(fs, this);
                fs.Close();

                serial = null;
                fs = null;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }

        public void Save()
        {
            Save(Program.XMLSettingsFile);
        }

        public static XMLSettings Read(string filePath)
        {
            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));


            if (File.Exists(filePath))
            {
                try
                {
                    //Read XML file
                    XmlSerializer serial = new XmlSerializer(typeof(XMLSettings));
                    FileStream fs = new FileStream(filePath, FileMode.Open);
                    XMLSettings set = (XMLSettings)serial.Deserialize(fs);
                    fs.Close();

                    serial = null;
                    fs = null;

                    return set;
                }
                catch
                {
                    //just return blank settings
                }
            }

            return new XMLSettings();
        }

        public static XMLSettings Read()
        {
            return Read(Program.XMLSettingsFile);
        }
        #endregion


    }
}
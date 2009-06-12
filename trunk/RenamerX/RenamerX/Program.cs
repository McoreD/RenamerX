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
using System.Windows.Forms;
using System.IO;

namespace RenamerX
{
    static class Program
    {
        private static string RootAppFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), Application.ProductName);
        private static string SettingsDir;
        private const string XMLFileName = "Settings.xml";
        private static string XMLFilePath;

        public static string XMLSettingsFile
        {
            get
            {
                if (!Directory.Exists(SettingsDir))
                {
                    Directory.CreateDirectory(SettingsDir);
                }
                return XMLFilePath;
            }
        }

        public static XMLSettings Settings;

        [STAThread]
        static void Main()
        {
            InitializeDefaultFolderPaths();
            Settings = XMLSettings.Read();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }

        /// <summary>
        /// Function to update Default Folder Paths based on Root folder
        /// </summary>
        public static void InitializeDefaultFolderPaths()
        {
            SettingsDir = Path.Combine(RootAppFolder, "Settings");
            XMLFilePath = Path.Combine(SettingsDir, XMLFileName);
        }
    }
}
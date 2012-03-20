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

#endregion License Information (GPL v2)

using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace RenamerX
{
    internal static class Program
    {
        private static string RootAppFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), Application.ProductName);
        private static string SettingsDir;
        private static string CacheDir;
        private const string XMLFileName = "Settings.xml";
        private static string XMLFilePath;

        public static TVDBLib.TVDB TVDB;

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
        public static Mutex mAppMutex;

        [STAThread]
        private static void Main()
        {
            InitializeDefaultFolderPaths();
            Settings = XMLSettings.Read();
            TVDB = new TVDBLib.TVDB(CacheDir);
            TVDB.CacheWorking = true;
            TVDB.CheckUpdates();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool bGrantedOwnership;
            try
            {
                Guid assemblyGuid = Guid.Empty;
                object[] assemblyObjects = System.Reflection.Assembly.GetEntryAssembly().GetCustomAttributes(typeof(System.Runtime.InteropServices.GuidAttribute), true);
                if (assemblyObjects.Length > 0)
                {
                    assemblyGuid = new Guid(((System.Runtime.InteropServices.GuidAttribute)assemblyObjects[0]).Value);
                }
                mAppMutex = new Mutex(true, assemblyGuid.ToString(), out bGrantedOwnership);
            }
            catch (UnauthorizedAccessException)
            {
                bGrantedOwnership = false;
            }

            Application.Run(new MainWindow());
        }

        /// <summary>
        /// Function to update Default Folder Paths based on Root folder
        /// </summary>
        public static void InitializeDefaultFolderPaths()
        {
            SettingsDir = Path.Combine(RootAppFolder, "Settings");
            CacheDir = Path.Combine(RootAppFolder, "TVDB Cache");
            XMLFilePath = Path.Combine(SettingsDir, XMLFileName);
        }
    }
}
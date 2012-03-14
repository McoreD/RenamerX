
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.Win32;
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

namespace RenamerX
{

    public class Extract
    {
        public bool AppendFileNameAsFolder { get; set; }
        public string ApplicationPath { get; set; }
        public ExtratorType ApplicationType { get; set; }

        public void ExtractFile(string filePath, string extractPath)
        {
            if (!string.IsNullOrEmpty(ApplicationPath))
            {
                if (AppendFileNameAsFolder)
                {
                    extractPath = Path.Combine(extractPath, Path.GetFileName(Path.GetDirectoryName(filePath)));
                }

                string arguments = string.Empty;

                if (ApplicationType == ExtratorType.SevenZip)
                {
                    arguments = Get7zCommands(filePath, extractPath);
                }
                else if (ApplicationType == ExtratorType.WinRAR)
                {
                    arguments = GetUnRARCommands(filePath, extractPath);
                }

                ProcessStartInfo psi = new ProcessStartInfo(ApplicationPath, arguments);
                psi.CreateNoWindow = true;
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                //psi.RedirectStandardOutput = true;
                psi.UseShellExecute = false;

                using (Process process = new Process())
                {
                    process.StartInfo = psi;
                    process.Start();
                    process.WaitForExit();
                    //DebugLog.WriteLine(process.StandardOutput.ReadToEnd());
                }
            }
            else
            {
                //throw new Exception("7-Zip or WinRAR required.");
            }
        }

        public bool FindApplication()
        {
            if (!string.IsNullOrEmpty(ApplicationPath) && File.Exists(ApplicationPath))
            {
                return true;
            }

            ApplicationPath = SearchPath("7zFM.exe", "7z.exe");
            if (!string.IsNullOrEmpty(ApplicationPath))
            {
                ApplicationType = ExtratorType.SevenZip;
                return true;
            }

            ApplicationPath = SearchPath("WinRAR.exe", "UnRAR.exe");
            if (!string.IsNullOrEmpty(ApplicationPath))
            {
                ApplicationType = ExtratorType.WinRAR;
                return true;
            }

            return false;
        }

        private string Get7zCommands(string path, string destination)
        {
            return Get7zCommands(path, destination, string.Empty);
        }

        private string Get7zCommands(string path, string destination, string password)
        {
            List<string> listSwitches = new List<string>();

            // -p{Password}: set Password
            if (!string.IsNullOrEmpty(password))
            {
                listSwitches.Add("-p" + password);
            }

            // -o{Directory}: set Output directory
            listSwitches.Add("-o\"" + destination + "\"");

            // -y: assume Yes on all queries
            listSwitches.Add("-y");

            string switches = string.Join(" ", listSwitches.ToArray());

            // e: Extract files from archive (without using directory names)
            // Usage: 7z <command> [<switches>...] <archive_name> [<file_names>...] [<@listfiles...>]
            return string.Format("e {0} \"{1}\"", switches, path);
        }

        private string GetUnRARCommands(string path, string destination)
        {
            return GetUnRARCommands(path, destination, string.Empty, true);
        }

        private string GetUnRARCommands(string path, string destination, string password, bool overwrite)
        {
            List<string> listSwitches = new List<string>();

            // o[+|-]: Set the overwrite mode
            if (overwrite)
            {
                listSwitches.Add("o+");
            }
            else
            {
                listSwitches.Add("o-");
            }

            if (string.IsNullOrEmpty(password))
            {
                // p-: Do not query password
                listSwitches.Add("p-");
            }
            else
            {
                // p[password]: Set password
                listSwitches.Add("p" + password);
            }

            string commands = string.Join(" ", listSwitches.Select(x => "-" + x).ToArray());

            // x: Extract files with full path
            // Usage: unrar <command> -<switch 1> -<switch N> <archive> <files...> <@listfiles...> <path_to_extract\>
            return string.Format("x {0} \"{1}\" \"{2}\"", commands, path, destination);
        }

        private string SearchPath(string registryName, string executableName)
        {
            RegistryKey registry = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\" + registryName);
            string path;

            if (registry != null && !string.IsNullOrEmpty(path = registry.GetValue("Path").ToString()))
            {
                path = Path.Combine(path, executableName);

                if (File.Exists(path))
                {
                    return path;
                }
            }

            return string.Empty;
        }
    }
    public enum ExtratorType
    {
        [Description("7-Zip")]
        SevenZip,
        [Description("WinRAR")]
        WinRAR
    }
}

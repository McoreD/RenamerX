using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TVRenamer
{
    static class Program
    {
        public static readonly string LocalAppDataFolder = System.IO.Path.Combine(
                       System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData),
                       System.Windows.Forms.Application.ProductName);

        public static readonly string XMLSettingsFile = LocalAppDataFolder + "\\Settings.xml";

        public static XMLSettings conf = XMLSettings.Read();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}

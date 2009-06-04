using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.IO;

namespace RenamerX
{   

    public struct ShowInfo
    {
        public string DefaultFileName { get; set; }
        public string DefaultFilePath { get; set; }
        public string NewFileName { get; private set; }
        public string NewFilePath { get; set; }
        public bool Invalid { get; set; }

        public void SetShowName(string name)
        {
            List<char> dirty = new List<char>();
            dirty.AddRange(Path.GetInvalidFileNameChars());
            dirty.AddRange(Path.GetInvalidPathChars());
            dirty.Add('?'); // for some reason the above methods dont add question mark

            foreach (char c in dirty)
            {
                name  = name.Replace(c, '_');
                System.Console.WriteLine(c.ToString());
            }
           
            this.NewFileName = name;
        }

    }


}
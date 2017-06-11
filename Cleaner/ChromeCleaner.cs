using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cleaner
{
    class ChromeCleaner : IBrowserCleaner
    {
        private const string name = "Chrome";

        readonly string path = Path.Combine(@"C:\Users", Environment.UserName, @"AppData\Local\Google\Chrome\User Data");

        public override string ToString()
        {
            return name;
        }

        public void Clear()
        {
            if (Directory.Exists(path))
                Directory.Delete(path, true);
        }

        string[] pathList;

        public string[] FilesToRemove()
        {
            if (pathList == null || pathList.Length == 0)
            {
                if (Directory.Exists(path))
                    pathList = new string[] { path };
                else
                    pathList = new string[] { };
            }
            return pathList;
        }
    }
}

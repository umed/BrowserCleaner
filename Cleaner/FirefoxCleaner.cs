using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cleaner
{
    class FirefoxCleaner : IBrowserCleaner
    {
        private const string name = "Firefox";

        readonly string localPath = Path.Combine(@"C:\Users", Environment.UserName, @"AppData\Local\Mozilla\Firefox\Profiles");
        readonly string roamingPath = Path.Combine(@"C:\Users", Environment.UserName, @"AppData\Roaming\Mozilla\Firefox\Profiles");

        public override string ToString()
        {
            return name;
        }

        public void Clear()
        {
            ClearLocal();
            ClearRoaming();
        }

        string[] pathList;

        public string[] FilesToRemove()
        {
            if (pathList == null || pathList.Length == 0)
            {
                List<string> paths = new List<string>();

                if (Directory.Exists(localPath))
                {
                    paths.Add(localPath);
                }

                if (Directory.Exists(roamingPath))
                {
                    string[] files = Directory.GetFiles(roamingPath, ".sqlite", SearchOption.AllDirectories);
                    paths.AddRange(files);
                }

                pathList = paths.ToArray();
            }
            return pathList;
        }

        private void ClearLocal()
        {
            if (Directory.Exists(localPath))
                Directory.Delete(localPath, true);
        }

        private void ClearRoaming()
        {
            if (!Directory.Exists(roamingPath))
                return;

            string[] files = Directory.GetFiles(roamingPath, ".sqlite", SearchOption.AllDirectories);
            foreach (var file in files)
                File.Delete(file);
        }
    }
}

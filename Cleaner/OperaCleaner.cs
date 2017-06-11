using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner
{
    class OperaCleaner : IBrowserCleaner
    {
        private const string name = "Opera";

        readonly string localPath = Path.Combine(@"C:\Users", Environment.UserName, @"AppData\Local\Opera\Opera");
        readonly string roamingPath = Path.Combine(@"C:\Users", Environment.UserName, @"AppData\Roaming\Opera\Opera");

        public override string ToString()
        {
            return name;
        }

        public void Clear()
        {
            if (Directory.Exists(localPath))
                Directory.Delete(localPath, true);

            if (Directory.Exists(roamingPath))
                Directory.Delete(roamingPath, true);
        }

        string[] pathList;

        public string[] FilesToRemove()
        {
            if (pathList == null || pathList.Length == 0)
                pathList = new string[] { localPath, roamingPath };

            return pathList;
        }
    }
}

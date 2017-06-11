using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner
{
    class InternetExplorerCleaner : IBrowserCleaner
    {
        private const string name = "Internet Explorer";

        readonly string localPath = Path.Combine(@"C:\Users", Environment.UserName, @"AppData\Local\Microsoft\Internet Explorer");
        readonly string localHistoryPath = Path.Combine(@"C:\Users", Environment.UserName, @"AppData\Local\Microsoft\Windows\History");
        readonly string cookiesPath = Path.Combine(@"C:\Users", Environment.UserName, @"AppData\Roaming\Microsoft\Windows\Cookies");
        readonly string temporaryPath = Path.Combine(@"C:\Users", Environment.UserName, @"AppData\Local\Microsoft\Windows\Temporary Internet Files");

        readonly string regKey = @"Software\Microsoft\Internet Explorer\TypedURLs";

        public override string ToString()
        {
            return name;
        }

        public void Clear()
        {
            DeleteDirectory(localPath);
            DeleteDirectory(localHistoryPath);
            DeleteDirectory(cookiesPath);
            DeleteDirectory(temporaryPath);

            ClearRegistry();
        }

        string[] pathList;

        public string[] FilesToRemove()
        {
            if (pathList == null || pathList.Length == 0)
                pathList = new string[] { localPath, localHistoryPath, cookiesPath, temporaryPath, regKey };

            return pathList;
        }

        private void DeleteDirectory(string path)
        {
            if (Directory.Exists(path))
                Directory.Delete(path);
        }

        private void ClearRegistry()
        {
            try
            {
                Registry.CurrentUser.DeleteSubKeyTree(regKey, false);
            }
            catch(Exception e)
            {
                // TODO: ???
            }
        }
    }
}

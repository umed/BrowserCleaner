using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner
{
    class Worker
    {
        IBrowserCleaner[] cleaners = new IBrowserCleaner[]
        {
            new InternetExplorerCleaner(),
            new OperaCleaner(),
            new ChromeCleaner(),
            new FirefoxCleaner()
        };

        public IBrowserCleaner[] Cleaners
        {
            get
            {
                return cleaners;
            }
        }

        public IBrowserCleaner GetByName(string name)
        {
            return cleaners.First(c => c.ToString() == name);
        }
    }
}

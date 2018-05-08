using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtpSyncTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var ftp = new FtpSyncLib.FTP("10.211.55.24", "mac", "mmac");
            ftp.Backup("/", "C:\\ftplocal");
            ftp.Sync("/", "C:\\ftplocal");
            Console.ReadKey();
        }
    }
}

using FtpSyncLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace FtpSyncService
{
    public partial class FtpSyncService : ServiceBase
    {
        Timer syncTimer;

        public FtpSyncService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            var config = new Config();
            syncTimer = new Timer();
            syncTimer.Interval = TimeSpan.FromMinutes(1).TotalMilliseconds;
            syncTimer.Elapsed += (s, e) =>
            {
                var ftp = new FTP(config.ReadValue("Host"), config.ReadValue("User"), config.ReadValue("Pwd"));
                var mode = config.ReadValue("Mode");
                var isDel = config.ReadValue("IsDeleteFile") == "true" ? true : false;
                if (mode == "sync")
                {
                    ftp.Sync(config.ReadValue("RemotePath"), config.ReadValue("LocalPath"), isDel);
                }
                else
                {
                    ftp.Backup(config.ReadValue("RemotePath"), config.ReadValue("LocalPath"), isDel);
                }
            };
            syncTimer.Enabled = true;
        }

        protected override void OnStop()
        {
            if (syncTimer != null)
            {
                syncTimer.Enabled = false;
            }
        }
    }
}

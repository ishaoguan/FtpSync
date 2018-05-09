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
using System.Threading;

namespace FtpSyncService
{
    public partial class FtpSyncService : ServiceBase
    {
        Timer _syncTimer;

        public FtpSyncService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            var config = new Config();
            var hour = int.Parse(config.ReadValue("Interval", "6"));
            _syncTimer = new Timer(state =>
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
            }, null, TimeSpan.FromSeconds(10), TimeSpan.FromHours(hour));
        }

        protected override void OnStop()
        {
            _syncTimer?.Dispose();
        }
    }
}

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
            syncTimer = new Timer();
            syncTimer.Interval = 10000;
            syncTimer.Elapsed += (s, e) =>
            {
                FTP.TestLog();
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

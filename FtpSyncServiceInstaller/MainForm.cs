using FtpSyncLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FtpSyncServiceInstaller
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var config = new Config();
            textBoxHost.Text = config.ReadValue("Host");
            textBoxUser.Text = config.ReadValue("User");
            textBoxPwd.Text = config.ReadValue("Pwd");
            textBoxRemote.Text = config.ReadValue("RemotePath");
            textBoxLocal.Text = config.ReadValue("LocalPath");
            textBoxInterval.Text = config.ReadValue("Interval");
            var mode = config.ReadValue("Mode");
            if (mode == "sync")
            {
                radioButtonSync.Checked = true;
            }
            var isDeleteFile = config.ReadValue("IsDeleteFile");
            if (isDeleteFile == "true")
            {
                checkBoxDel.Checked = true;
            }
        }

        private readonly string _serviceFilePath = $"{Application.StartupPath}\\FtpSyncService.exe";
        string serviceName = "FtpSyncService";

        private void buttonInstall_Click(object sender, EventArgs e)
        {
            var config = new Config();
            config.WriteValue("Host", textBoxHost.Text);
            config.WriteValue("User", textBoxUser.Text);
            config.WriteValue("Pwd", textBoxPwd.Text);
            config.WriteValue("RemotePath", textBoxRemote.Text);
            config.WriteValue("LocalPath", textBoxLocal.Text);
            config.WriteValue("Interval", textBoxInterval.Text);
            config.WriteValue("Mode", radioButtonBackup.Checked ? "backup" : "sync");
            config.WriteValue("IsDeleteFile", checkBoxDel.Checked ? "true" : "false");
            if (IsServiceExisted(serviceName))
            {
                UninstallService(serviceName);
            }
            InstallService(_serviceFilePath);
            ServiceStart(serviceName);
            MessageBox.Show("安装完成");
        }

        private void buttonUninstall_Click(object sender, EventArgs e)
        {
            if (IsServiceExisted(serviceName))
            {
                ServiceStop(serviceName);
                UninstallService(_serviceFilePath);
            }
            MessageBox.Show("卸载完成");
        }

        private bool IsServiceExisted(string serviceName)
        {
            ServiceController[] services = ServiceController.GetServices();
            foreach (ServiceController sc in services)
            {
                if (sc.ServiceName.ToLower() == serviceName.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        
        private void InstallService(string serviceFilePath)
        {
            using (AssemblyInstaller installer = new AssemblyInstaller())
            {
                installer.UseNewContext = true;
                installer.Path = serviceFilePath;
                IDictionary savedState = new Hashtable();
                installer.Install(savedState);
                installer.Commit(savedState);
            }
        }
        
        private void UninstallService(string serviceFilePath)
        {
            using (AssemblyInstaller installer = new AssemblyInstaller())
            {
                installer.UseNewContext = true;
                installer.Path = serviceFilePath;
                installer.Uninstall(null);
            }
        }

        private void ServiceStart(string serviceName)
        {
            using (ServiceController control = new ServiceController(serviceName))
            {
                if (control.Status == ServiceControllerStatus.Stopped)
                {
                    control.Start();
                }
            }
        }
        
        private void ServiceStop(string serviceName)
        {
            using (ServiceController control = new ServiceController(serviceName))
            {
                if (control.Status == ServiceControllerStatus.Running)
                {
                    control.Stop();
                }
            }
        }

        private void textBoxLocal_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxLocal.Text = dialog.SelectedPath;
            }
        }

        private void textBoxInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                {
                    e.Handled = true;
                }
            }
        }
    }
}

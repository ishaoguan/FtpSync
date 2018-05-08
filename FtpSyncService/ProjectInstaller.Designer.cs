namespace FtpSyncService
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.syncServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.syncServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // syncServiceProcessInstaller
            // 
            this.syncServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.syncServiceProcessInstaller.Password = null;
            this.syncServiceProcessInstaller.Username = null;
            // 
            // syncServiceInstaller
            // 
            this.syncServiceInstaller.Description = "FTP同步服务";
            this.syncServiceInstaller.DisplayName = "FtpSyncService";
            this.syncServiceInstaller.ServiceName = "FtpSyncService";
            this.syncServiceInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.syncServiceProcessInstaller,
            this.syncServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller syncServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller syncServiceInstaller;
    }
}
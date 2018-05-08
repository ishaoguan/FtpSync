using FluentFTP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FtpSyncLib
{
    public class FTP
    {
        public static NLog.ILogger Logger = NLog.LogManager.GetCurrentClassLogger();

        private string Host { get; set; }
        private string User { get; set; }
        private string Pwd { get; set; }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="host">域名或IP</param>
        /// <param name="user">用户名</param>
        /// <param name="pwd">密码</param>
        public FTP(string host,string user,string pwd)
        {
            this.Host = host;
            this.User = user;
            this.Pwd = pwd;
        }

        private FTP() { }

        /// <summary>
        /// 远程FTP备份到本地
        /// </summary>
        /// <param name="remotePath">远程路径</param>
        /// <param name="localPath">本地路径</param>
        /// <param name="isDel" default="false">是否删除远程已不存在的本地文件</param>
        public void Backup(string remotePath, string localPath, bool isDel = false)
        {
            Logger.Info("BackUp===>begin");
            var client = new FtpClient(Host)
            {
                Credentials = new NetworkCredential(User, Pwd)
            };
            client.Connect();

            BackupDirectory(client, remotePath, localPath, isDel);

            client.Disconnect();
            Logger.Info("BackUp===>end");
        }

        public void Sync()
        {

        }

        private void BackupDirectory(IFtpClient client, string remotePath, string localPath, bool isDel)
        {
            var items = client.GetListing(remotePath);
            foreach (var item in items)
            {
                if (!client.IsConnected)
                {
                    client.Connect();
                }
                if (item.Type == FtpFileSystemObjectType.File)
                {
                    var size = client.GetFileSize(item.FullName);
                    
                    var localFile = Path.Combine(localPath, item.Name);

                    if (!File.Exists(localFile) || new FileInfo(localFile).Length != size)
                    {
                        client.DownloadFile(localFile, item.FullName);

                        Logger.Info($"Downloaded==>{item.FullName}");
                    }
                }
                else if (item.Type == FtpFileSystemObjectType.Directory)
                {
                    if (!Directory.Exists(item.FullName))
                    {
                        Directory.CreateDirectory(item.FullName);

                        Logger.Info($"CreateDirectory==>{item.FullName}");
                    }
                    BackupDirectory(client, item.FullName, Path.Combine(localPath, item.Name), isDel);
                }
            }

            if (isDel)
            {
                var localFolder = new DirectoryInfo(localPath);
                var infos = localFolder.GetFileSystemInfos();
                foreach (var info in infos)
                {
                    if (items.All(item => item.Name != info.Name))
                    {
                        if(info is DirectoryInfo)
                        {
                            (info as DirectoryInfo).Delete(true);
                        }
                        else
                        {
                            info.Delete();
                        }

                        Logger.Info($"Deleted==>{info.FullName}");
                    }
                }
            }
        }
    }
}

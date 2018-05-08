using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FtpSyncLib
{
    public class Config
    {
        public Config()
        {
            if (!File.Exists(Inipath))
            {
                File.CreateText(Inipath).Close();
                WriteValue("Host", "");
                WriteValue("User", "");
                WriteValue("Pwd", "");
                WriteValue("RemotePath", "/");
                WriteValue("LocalPath", "");
                WriteValue("Mode", "backup");
                WriteValue("IsDeleteFile", "false");
            }
        }

        private string Inipath { get; set; } = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.ini");

        /// <summary>
        /// 写入INI文件
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        public void WriteValue(string key, string value)
        {
            WritePrivateProfileString("sync", key, value, Inipath);
        }

        /// <summary>
        /// 读出INI文件
        /// </summary>
        /// <param name="key">键</param>
        public string ReadValue(string key, string value = "")
        {
            StringBuilder temp = new StringBuilder(500);
            int i = GetPrivateProfileString("sync", key, value, temp, 500, this.Inipath);
            return temp.ToString();
        }

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

    }
}

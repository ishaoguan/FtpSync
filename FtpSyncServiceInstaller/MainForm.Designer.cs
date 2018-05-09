namespace FtpSyncServiceInstaller
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonInstall = new System.Windows.Forms.Button();
            this.buttonUninstall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRemote = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLocal = new System.Windows.Forms.TextBox();
            this.checkBoxDel = new System.Windows.Forms.CheckBox();
            this.radioButtonBackup = new System.Windows.Forms.RadioButton();
            this.radioButtonSync = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxInterval = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonInstall
            // 
            this.buttonInstall.Location = new System.Drawing.Point(12, 91);
            this.buttonInstall.Name = "buttonInstall";
            this.buttonInstall.Size = new System.Drawing.Size(65, 23);
            this.buttonInstall.TabIndex = 0;
            this.buttonInstall.Text = "安装服务";
            this.buttonInstall.UseVisualStyleBackColor = true;
            this.buttonInstall.Click += new System.EventHandler(this.buttonInstall_Click);
            // 
            // buttonUninstall
            // 
            this.buttonUninstall.Location = new System.Drawing.Point(82, 91);
            this.buttonUninstall.Name = "buttonUninstall";
            this.buttonUninstall.Size = new System.Drawing.Size(65, 23);
            this.buttonUninstall.TabIndex = 1;
            this.buttonUninstall.Text = "卸载服务";
            this.buttonUninstall.UseVisualStyleBackColor = true;
            this.buttonUninstall.Click += new System.EventHandler(this.buttonUninstall_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Host:";
            // 
            // textBoxHost
            // 
            this.textBoxHost.Location = new System.Drawing.Point(47, 10);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(100, 21);
            this.textBoxHost.TabIndex = 3;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(47, 37);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(100, 21);
            this.textBoxUser.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "User:";
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Location = new System.Drawing.Point(47, 64);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.Size = new System.Drawing.Size(100, 21);
            this.textBoxPwd.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pwd:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "LocalPath:";
            // 
            // textBoxRemote
            // 
            this.textBoxRemote.Location = new System.Drawing.Point(233, 10);
            this.textBoxRemote.Name = "textBoxRemote";
            this.textBoxRemote.Size = new System.Drawing.Size(100, 21);
            this.textBoxRemote.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "RemotePath:";
            // 
            // textBoxLocal
            // 
            this.textBoxLocal.Location = new System.Drawing.Point(233, 37);
            this.textBoxLocal.Name = "textBoxLocal";
            this.textBoxLocal.Size = new System.Drawing.Size(100, 21);
            this.textBoxLocal.TabIndex = 11;
            this.textBoxLocal.Click += new System.EventHandler(this.textBoxLocal_Click);
            // 
            // checkBoxDel
            // 
            this.checkBoxDel.AutoSize = true;
            this.checkBoxDel.Location = new System.Drawing.Point(280, 95);
            this.checkBoxDel.Name = "checkBoxDel";
            this.checkBoxDel.Size = new System.Drawing.Size(54, 16);
            this.checkBoxDel.TabIndex = 13;
            this.checkBoxDel.Text = "IsDel";
            this.checkBoxDel.UseVisualStyleBackColor = true;
            // 
            // radioButtonBackup
            // 
            this.radioButtonBackup.AutoSize = true;
            this.radioButtonBackup.Checked = true;
            this.radioButtonBackup.Location = new System.Drawing.Point(221, 65);
            this.radioButtonBackup.Name = "radioButtonBackup";
            this.radioButtonBackup.Size = new System.Drawing.Size(59, 16);
            this.radioButtonBackup.TabIndex = 14;
            this.radioButtonBackup.TabStop = true;
            this.radioButtonBackup.Text = "Backup";
            this.radioButtonBackup.UseVisualStyleBackColor = true;
            // 
            // radioButtonSync
            // 
            this.radioButtonSync.AutoSize = true;
            this.radioButtonSync.Location = new System.Drawing.Point(286, 65);
            this.radioButtonSync.Name = "radioButtonSync";
            this.radioButtonSync.Size = new System.Drawing.Size(47, 16);
            this.radioButtonSync.TabIndex = 15;
            this.radioButtonSync.TabStop = true;
            this.radioButtonSync.Text = "Sync";
            this.radioButtonSync.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mode:";
            // 
            // textBoxInterval
            // 
            this.textBoxInterval.Location = new System.Drawing.Point(221, 93);
            this.textBoxInterval.Name = "textBoxInterval";
            this.textBoxInterval.Size = new System.Drawing.Size(34, 21);
            this.textBoxInterval.TabIndex = 18;
            this.textBoxInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInterval_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "Interval:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "h";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 122);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxInterval);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButtonSync);
            this.Controls.Add(this.radioButtonBackup);
            this.Controls.Add(this.checkBoxDel);
            this.Controls.Add(this.textBoxLocal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxRemote);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxHost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUninstall);
            this.Controls.Add(this.buttonInstall);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(362, 161);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(362, 161);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Installer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInstall;
        private System.Windows.Forms.Button buttonUninstall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHost;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRemote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLocal;
        private System.Windows.Forms.CheckBox checkBoxDel;
        private System.Windows.Forms.RadioButton radioButtonBackup;
        private System.Windows.Forms.RadioButton radioButtonSync;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxInterval;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}


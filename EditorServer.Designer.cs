namespace Editor_de_Texto___Server
{
    partial class EditorServer
    {

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorServer));
            this.lbl_Title_Server = new System.Windows.Forms.Label();
            this.lnklbl_ServerStatus = new System.Windows.Forms.LinkLabel();
            this.notifyIcon_Server = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // lbl_Title_Server
            // 
            this.lbl_Title_Server.AutoSize = true;
            this.lbl_Title_Server.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Title_Server.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title_Server.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Title_Server.Location = new System.Drawing.Point(65, 30);
            this.lbl_Title_Server.Name = "lbl_Title_Server";
            this.lbl_Title_Server.Size = new System.Drawing.Size(156, 27);
            this.lbl_Title_Server.TabIndex = 0;
            this.lbl_Title_Server.Text = "Servidor UDP";
            // 
            // lnklbl_ServerStatus
            // 
            this.lnklbl_ServerStatus.AutoSize = true;
            this.lnklbl_ServerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklbl_ServerStatus.LinkColor = System.Drawing.Color.Lime;
            this.lnklbl_ServerStatus.Location = new System.Drawing.Point(83, 78);
            this.lnklbl_ServerStatus.Name = "lnklbl_ServerStatus";
            this.lnklbl_ServerStatus.Size = new System.Drawing.Size(119, 20);
            this.lnklbl_ServerStatus.TabIndex = 1;
            this.lnklbl_ServerStatus.TabStop = true;
            this.lnklbl_ServerStatus.Text = "Server is active!";
            // 
            // notifyIcon_Server
            // 
            this.notifyIcon_Server.Text = "notifyIcon1";
            this.notifyIcon_Server.Visible = true;
            // 
            // EditorServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(284, 140);
            this.Controls.Add(this.lnklbl_ServerStatus);
            this.Controls.Add(this.lbl_Title_Server);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditorServer";
            this.Text = "Editor de Texto - Server";
            this.Load += new System.EventHandler(this.EditorServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label lbl_Title_Server;
        private System.Windows.Forms.LinkLabel lnklbl_ServerStatus;
        private System.Windows.Forms.NotifyIcon notifyIcon_Server;
        private System.ComponentModel.IContainer components;
    }
}


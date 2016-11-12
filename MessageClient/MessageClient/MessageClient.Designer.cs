namespace MessageClient
{
    partial class MessageClient
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_connect = new System.Windows.Forms.Button();
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.textBox_Ip = new System.Windows.Forms.TextBox();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.linkLabel_closeServer = new System.Windows.Forms.LinkLabel();
            this.checkBox_isCmd = new System.Windows.Forms.CheckBox();
            this.textBox_showing = new System.Windows.Forms.RichTextBox();
            this.linkLabel_Echo = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(3, 7);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(75, 23);
            this.button_connect.TabIndex = 11;
            this.button_connect.Text = "连接服务器";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // textBox_send
            // 
            this.textBox_send.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_send.Location = new System.Drawing.Point(3, 263);
            this.textBox_send.Multiline = true;
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_send.Size = new System.Drawing.Size(289, 37);
            this.textBox_send.TabIndex = 10;
            // 
            // button_send
            // 
            this.button_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_send.Location = new System.Drawing.Point(217, 302);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 23);
            this.button_send.TabIndex = 9;
            this.button_send.Text = "发送信息";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // textBox_Ip
            // 
            this.textBox_Ip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Ip.Location = new System.Drawing.Point(84, 7);
            this.textBox_Ip.Name = "textBox_Ip";
            this.textBox_Ip.Size = new System.Drawing.Size(153, 21);
            this.textBox_Ip.TabIndex = 12;
            this.textBox_Ip.Text = "127.0.0.1";
            // 
            // textBox_Port
            // 
            this.textBox_Port.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Port.Location = new System.Drawing.Point(243, 7);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(49, 21);
            this.textBox_Port.TabIndex = 13;
            this.textBox_Port.Text = "37280";
            // 
            // linkLabel_closeServer
            // 
            this.linkLabel_closeServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel_closeServer.AutoSize = true;
            this.linkLabel_closeServer.Location = new System.Drawing.Point(1, 306);
            this.linkLabel_closeServer.Name = "linkLabel_closeServer";
            this.linkLabel_closeServer.Size = new System.Drawing.Size(65, 12);
            this.linkLabel_closeServer.TabIndex = 14;
            this.linkLabel_closeServer.TabStop = true;
            this.linkLabel_closeServer.Text = "关闭服务器";
            this.linkLabel_closeServer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_closeServer_LinkClicked);
            // 
            // checkBox_isCmd
            // 
            this.checkBox_isCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_isCmd.AutoSize = true;
            this.checkBox_isCmd.Location = new System.Drawing.Point(109, 306);
            this.checkBox_isCmd.Name = "checkBox_isCmd";
            this.checkBox_isCmd.Size = new System.Drawing.Size(102, 16);
            this.checkBox_isCmd.TabIndex = 15;
            this.checkBox_isCmd.Text = "以cmd格式发送";
            this.checkBox_isCmd.UseVisualStyleBackColor = true;
            // 
            // textBox_showing
            // 
            this.textBox_showing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_showing.Location = new System.Drawing.Point(4, 31);
            this.textBox_showing.Name = "textBox_showing";
            this.textBox_showing.Size = new System.Drawing.Size(287, 230);
            this.textBox_showing.TabIndex = 16;
            this.textBox_showing.Text = "";
            // 
            // linkLabel_Echo
            // 
            this.linkLabel_Echo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel_Echo.AutoSize = true;
            this.linkLabel_Echo.Location = new System.Drawing.Point(2, 248);
            this.linkLabel_Echo.Name = "linkLabel_Echo";
            this.linkLabel_Echo.Size = new System.Drawing.Size(65, 12);
            this.linkLabel_Echo.TabIndex = 17;
            this.linkLabel_Echo.TabStop = true;
            this.linkLabel_Echo.Text = "服务器输出";
            this.linkLabel_Echo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Echo_LinkClicked);
            // 
            // MessageClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 327);
            this.Controls.Add(this.linkLabel_Echo);
            this.Controls.Add(this.textBox_showing);
            this.Controls.Add(this.checkBox_isCmd);
            this.Controls.Add(this.linkLabel_closeServer);
            this.Controls.Add(this.textBox_Port);
            this.Controls.Add(this.textBox_Ip);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.textBox_send);
            this.Controls.Add(this.button_send);
            this.Name = "MessageClient";
            this.Text = "客户端";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MessageClient_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.TextBox textBox_send;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox textBox_Ip;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.LinkLabel linkLabel_closeServer;
        private System.Windows.Forms.CheckBox checkBox_isCmd;
        private System.Windows.Forms.RichTextBox textBox_showing;
        private System.Windows.Forms.LinkLabel linkLabel_Echo;
    }
}


﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageClient
{
    public partial class MessageClient : Form
    {
        Client client;    // 客户端实例

        public MessageClient()
        {
            InitializeComponent();
        }

        // 连接服务器
        private void button_connect_Click(object sender, EventArgs e)
        {
            if (client == null) client = new Client(ClientPrint, textBox_Ip.Text, textBox_Port.Text);
            if (!client.connected) client.start();
            if (client != null) this.Text = "客户端 " + client.localIpPort;
        }

        // 客户端输出信息
        private void ClientPrint(string info)
        {
            if (textBox_showing.InvokeRequired)
            {
                Client.Print F = new Client.Print(ClientPrint);
                this.Invoke(F, new object[] { info });
            }
            else
            {
                if (info != null)
                {
                    textBox_showing.SelectionColor = Color.Green;
                    textBox_showing.AppendText(info);
                    textBox_showing.AppendText(Environment.NewLine);
                    textBox_showing.ScrollToCaret();
                }
            }
        }

        // 发送信息到服务器
        private void button_send_Click(object sender, EventArgs e)
        {
            if (client != null && client.connected)
            {
                string info = textBox_send.Text;
                if (checkBox_isCmd.Checked && !info.StartsWith("[.RunCmd]"))    // 添加cmd串头信息
                    info = "[.RunCmd]" + info;

                client.Send(info);
            }
        }

        // 关闭界面停止服务运行
        private void MessageClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (client != null && client.connected)
                client.stop();
        }

        private void linkLabel_closeServer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (client != null && client.connected)
                client.Send("[.Shutdown]");
        }

        private void linkLabel_Echo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (client != null && client.connected)
                client.Send("[.Echo]");
        }
    }
}

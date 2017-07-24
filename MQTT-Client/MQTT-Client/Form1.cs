﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace MQTT_Client
{
    public partial class Form1 : Form
    {
        private delegate void myUICallBack(string myStr, TextBox ctl);
        static MqttClient client;
        private void myUI(string myStr, TextBox ctl)
        {
            if (this.InvokeRequired)
            {
                myUICallBack myUpdate = new myUICallBack(myUI);
                this.Invoke(myUpdate, myStr, ctl);
            }
            else
            {
                ctl.AppendText(myStr + Environment.NewLine);
            }
        }

        private void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            myUI(System.Text.Encoding.UTF8.GetString(e.Message), MessageTextBox);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.ConnectButton;
            QosComboBox.SelectedIndex = 0;
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            if (client != null && client.IsConnected) client.Disconnect();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            int port;
            if (HostTextBox.Text.Length == 0)
            {
                label4.Text = "Invild host";
            }
            else if (!Int32.TryParse(PortTextBox.Text, out port))
            {
                label4.Text = "Invild port";
            }
            else
            {                
                try
                {
                    client = new MqttClient(HostTextBox.Text, port, false, null);
                    client.Connect(Guid.NewGuid().ToString());
                    client.MqttMsgPublishReceived += new MqttClient.MqttMsgPublishEventHandler(client_MqttMsgPublishReceived);
                }
                catch
                {
                    label4.Text = "Can't connect to server";
                }
                if (client != null && client.IsConnected)
                {
                    this.AcceptButton = this.PublishButton;
                    label4.Text = "";
                    MessageTextBox.Clear();
                    SubscribeButton.Enabled = true;
                    PublishButton.Enabled = true;
                    UnsubscribeButton.Enabled = true;
                    DisconnectButton.Enabled = true;
                    ConnectButton.Enabled = false;
                    HostTextBox.Enabled = false;
                    PortTextBox.Enabled = false;

                    btJSON.Enabled = true;
                }
            }
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            if (client != null && client.IsConnected) client.Disconnect();
            SubscribeButton.Enabled = false;
            PublishButton.Enabled = false;
            UnsubscribeButton.Enabled = false;
            DisconnectButton.Enabled = false;
            ConnectButton.Enabled = true;            
            HostTextBox.Enabled = true;
            PortTextBox.Enabled = true;
            SubListBox.Items.Clear();
        }

        private void SubscribeButton_Click(object sender, EventArgs e)
        {
            if (SubTopicTextBox.Text.Length == 0)
            {
                label4.Text = "Subscribe topic can't be empty";
            }
            else
            {
                label4.Text = "";
                client.Subscribe(new string[] { SubTopicTextBox.Text }, new byte[] { (byte)QosComboBox.SelectedIndex });
                SubListBox.Items.Add(SubTopicTextBox.Text);
            }
        }

        private void PublishButton_Click(object sender, EventArgs e)
        {
            if (PubMessageTextBox.Text.Length == 0)
            {
                label4.Text = "No message to send";
            }
            else if (PubTopicTextBox.Text.Length == 0)
            {
                label4.Text = "Publish topic can't be empty";
            }
            else if (PubTopicTextBox.Text.IndexOf('#') != -1 || PubTopicTextBox.Text.IndexOf('+') != -1)
            {
                label4.Text = "Publish topic can't include wildcard(# , +)";
            }
            else
            {
                label4.Text = "";
                client.Publish(PubTopicTextBox.Text, Encoding.UTF8.GetBytes(PubMessageTextBox.Text), (byte)QosComboBox.SelectedIndex, RetainCheckBox.Checked);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            MessageTextBox.Clear();
        }

        private void UnsubscribeButton_Click(object sender, EventArgs e)
        {
            if (SubListBox.SelectedItem == null)
            {
                label4.Text = "Select topic to unscribe";
            }
            else
            {
                label4.Text = "";
                client.Unsubscribe(new string[] { SubListBox.SelectedItem.ToString() });
                SubListBox.Items.Remove(SubListBox.SelectedItem);
            }
        }

        private void btJSON_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("window");
            FormJSON fj = new FormJSON(client);
            fj.Show();
            
        }
    }
}

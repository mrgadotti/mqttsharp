using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;

namespace MQTT_Client
{
    public partial class FormJSON : Form
    {
        MqttClient cli;
        public FormJSON(MqttClient c)
        {
            InitializeComponent();
            this.cli = c;
        }

        private void btPublishJSON_Click(object sender, EventArgs e)
        {
            if (textBoxJsonTopic.Text.Length == 0)
            {
                labelPayLoadError.Text = "Publish topic can't be empty";
            }
            else if(textBoxJSON.Text.Length == 0)
            {
                labelPayLoadError.Text = "No message to send";
            }
            else
            {
                labelPayLoadError.Text = "";
                //client.Publish(PubTopicTextBox.Text, Encoding.UTF8.GetBytes(PubMessageTextBox.Text), (byte)QosComboBox.SelectedIndex, RetainCheckBox.Checked);
                cli.Publish(textBoxJsonTopic.Text, 
                            Encoding.UTF8.GetBytes(textBoxJSON.Text), 
                            (byte)QosComboBoxJson.SelectedIndex, 
                            checkBoxRetainJson.Checked);


            }

        }

        private void FormJSON_Load(object sender, EventArgs e)
        {
            // sleciona texbox topic
            textBoxJsonTopic.Select();
            QosComboBoxJson.SelectedIndex = 0;

        }

        private void buttonClearJson_Click(object sender, EventArgs e)
        {
            textBoxJSON.Text = "";
            textBoxJSON.Select();
        }
    }
}

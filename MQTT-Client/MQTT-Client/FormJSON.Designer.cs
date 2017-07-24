namespace MQTT_Client
{
    partial class FormJSON
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btPublishJSON = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxJsonTopic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxJSON = new System.Windows.Forms.TextBox();
            this.labelPayLoadError = new System.Windows.Forms.Label();
            this.checkBoxRetainJson = new System.Windows.Forms.CheckBox();
            this.QosComboBoxJson = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonClearJson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btPublishJSON
            // 
            this.btPublishJSON.Font = new System.Drawing.Font("Verdana", 9F);
            this.btPublishJSON.Location = new System.Drawing.Point(441, 358);
            this.btPublishJSON.Name = "btPublishJSON";
            this.btPublishJSON.Size = new System.Drawing.Size(130, 35);
            this.btPublishJSON.TabIndex = 2;
            this.btPublishJSON.Text = "Publish JSON";
            this.btPublishJSON.UseVisualStyleBackColor = true;
            this.btPublishJSON.Click += new System.EventHandler(this.btPublishJSON_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Payload:";
            // 
            // textBoxJsonTopic
            // 
            this.textBoxJsonTopic.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJsonTopic.Location = new System.Drawing.Point(87, 19);
            this.textBoxJsonTopic.MaxLength = 128;
            this.textBoxJsonTopic.Name = "textBoxJsonTopic";
            this.textBoxJsonTopic.Size = new System.Drawing.Size(480, 29);
            this.textBoxJsonTopic.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Topic:";
            // 
            // textBoxJSON
            // 
            this.textBoxJSON.CausesValidation = false;
            this.textBoxJSON.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.textBoxJSON.Location = new System.Drawing.Point(12, 95);
            this.textBoxJSON.Multiline = true;
            this.textBoxJSON.Name = "textBoxJSON";
            this.textBoxJSON.Size = new System.Drawing.Size(559, 244);
            this.textBoxJSON.TabIndex = 0;
            // 
            // labelPayLoadError
            // 
            this.labelPayLoadError.AutoSize = true;
            this.labelPayLoadError.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.labelPayLoadError.Location = new System.Drawing.Point(111, 60);
            this.labelPayLoadError.Name = "labelPayLoadError";
            this.labelPayLoadError.Size = new System.Drawing.Size(0, 23);
            this.labelPayLoadError.TabIndex = 6;
            // 
            // checkBoxRetainJson
            // 
            this.checkBoxRetainJson.AutoSize = true;
            this.checkBoxRetainJson.Font = new System.Drawing.Font("Verdana", 9F);
            this.checkBoxRetainJson.Location = new System.Drawing.Point(220, 365);
            this.checkBoxRetainJson.Name = "checkBoxRetainJson";
            this.checkBoxRetainJson.Size = new System.Drawing.Size(76, 22);
            this.checkBoxRetainJson.TabIndex = 8;
            this.checkBoxRetainJson.Text = "Retain";
            this.checkBoxRetainJson.UseVisualStyleBackColor = true;
            // 
            // QosComboBoxJson
            // 
            this.QosComboBoxJson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QosComboBoxJson.Font = new System.Drawing.Font("Verdana", 9F);
            this.QosComboBoxJson.FormattingEnabled = true;
            this.QosComboBoxJson.Items.AddRange(new object[] {
            "0 At most once",
            "1 At least once",
            "2 Exactly once"});
            this.QosComboBoxJson.Location = new System.Drawing.Point(56, 363);
            this.QosComboBoxJson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QosComboBoxJson.MaxDropDownItems = 3;
            this.QosComboBoxJson.Name = "QosComboBoxJson";
            this.QosComboBoxJson.Size = new System.Drawing.Size(158, 26);
            this.QosComboBoxJson.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F);
            this.label7.Location = new System.Drawing.Point(13, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "QoS:";
            // 
            // buttonClearJson
            // 
            this.buttonClearJson.Font = new System.Drawing.Font("Verdana", 9F);
            this.buttonClearJson.Location = new System.Drawing.Point(302, 358);
            this.buttonClearJson.Name = "buttonClearJson";
            this.buttonClearJson.Size = new System.Drawing.Size(130, 35);
            this.buttonClearJson.TabIndex = 20;
            this.buttonClearJson.Text = "Clear";
            this.buttonClearJson.UseVisualStyleBackColor = true;
            this.buttonClearJson.Click += new System.EventHandler(this.buttonClearJson_Click);
            // 
            // FormJSON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(583, 408);
            this.Controls.Add(this.buttonClearJson);
            this.Controls.Add(this.QosComboBoxJson);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBoxRetainJson);
            this.Controls.Add(this.labelPayLoadError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btPublishJSON);
            this.Controls.Add(this.textBoxJSON);
            this.Controls.Add(this.textBoxJsonTopic);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(601, 455);
            this.Name = "FormJSON";
            this.Text = "JSON";
            this.Load += new System.EventHandler(this.FormJSON_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btPublishJSON;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxJsonTopic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxJSON;
        private System.Windows.Forms.Label labelPayLoadError;
        private System.Windows.Forms.CheckBox checkBoxRetainJson;
        private System.Windows.Forms.ComboBox QosComboBoxJson;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonClearJson;
    }
}
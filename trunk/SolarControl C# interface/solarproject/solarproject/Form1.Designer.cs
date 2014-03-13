namespace solarproject
{
    partial class Form1
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
            this.serialPortArduino = new System.IO.Ports.SerialPort(this.components);
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.timerReadSystemTime = new System.Windows.Forms.Timer(this.components);
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerReadArduinoValues = new System.Windows.Forms.Timer(this.components);
            this.tbLDRLeft = new System.Windows.Forms.TextBox();
            this.tbLDRRight = new System.Windows.Forms.TextBox();
            this.tbLDRTop = new System.Windows.Forms.TextBox();
            this.tbLDRBottom = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.timerShowProgress = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbSerialMessagesRead = new System.Windows.Forms.ListBox();
            this.lbSerialMessagesSend = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbFeedbackVertical = new System.Windows.Forms.TextBox();
            this.tbSetpointVertical = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbFeedbackHorizontal = new System.Windows.Forms.TextBox();
            this.tbSetpointHorizontal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trackBarVertical = new System.Windows.Forms.TrackBar();
            this.trackBarHorizontal = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbSystemState = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHorizontal)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPortArduino
            // 
            this.serialPortArduino.BaudRate = 115200;
            this.serialPortArduino.PortName = "COM7";
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(13, 13);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(121, 21);
            this.cbPorts.TabIndex = 0;
            this.cbPorts.Text = "COM7";
            this.cbPorts.SelectedIndexChanged += new System.EventHandler(this.cbPorts_SelectedIndexChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(140, 11);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(121, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "connect Arduino";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // timerReadSystemTime
            // 
            this.timerReadSystemTime.Interval = 1000;
            this.timerReadSystemTime.Tick += new System.EventHandler(this.timerReadSystemTime_Tick);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(267, 11);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(121, 23);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "disconnect Arduino";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 556);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1214, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Step = 5;
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // timerReadArduinoValues
            // 
            this.timerReadArduinoValues.Enabled = true;
            this.timerReadArduinoValues.Interval = 1500;
            this.timerReadArduinoValues.Tick += new System.EventHandler(this.timerReadArduinoValues_Tick);
            // 
            // tbLDRLeft
            // 
            this.tbLDRLeft.Location = new System.Drawing.Point(54, 281);
            this.tbLDRLeft.Name = "tbLDRLeft";
            this.tbLDRLeft.Size = new System.Drawing.Size(66, 20);
            this.tbLDRLeft.TabIndex = 7;
            this.tbLDRLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbLDRRight
            // 
            this.tbLDRRight.Location = new System.Drawing.Point(422, 281);
            this.tbLDRRight.Name = "tbLDRRight";
            this.tbLDRRight.Size = new System.Drawing.Size(66, 20);
            this.tbLDRRight.TabIndex = 8;
            this.tbLDRRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbLDRTop
            // 
            this.tbLDRTop.Location = new System.Drawing.Point(239, 81);
            this.tbLDRTop.Name = "tbLDRTop";
            this.tbLDRTop.Size = new System.Drawing.Size(66, 20);
            this.tbLDRTop.TabIndex = 9;
            this.tbLDRTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbLDRBottom
            // 
            this.tbLDRBottom.Location = new System.Drawing.Point(239, 430);
            this.tbLDRBottom.Name = "tbLDRBottom";
            this.tbLDRBottom.Size = new System.Drawing.Size(66, 20);
            this.tbLDRBottom.TabIndex = 10;
            this.tbLDRBottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 495);
            this.trackBar1.Maximum = 2000;
            this.trackBar1.Minimum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(532, 45);
            this.trackBar1.TabIndex = 15;
            this.trackBar1.TickFrequency = 100;
            this.trackBar1.Value = 1000;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(239, 469);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "1000";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Read Speed";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::solarproject.Properties.Resources.LDR11;
            this.pictureBox1.Location = new System.Drawing.Point(54, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 356);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.cbBaudRate.Location = new System.Drawing.Point(394, 13);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(134, 21);
            this.cbBaudRate.TabIndex = 20;
            this.cbBaudRate.Text = "115200";
            this.cbBaudRate.SelectedIndexChanged += new System.EventHandler(this.cbBaudRate_SelectedIndexChanged);
            // 
            // timerShowProgress
            // 
            this.timerShowProgress.Interval = 10;
            this.timerShowProgress.Tick += new System.EventHandler(this.timerShowProgress_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Feedback horizontal";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(594, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 356);
            this.panel1.TabIndex = 22;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lbSerialMessagesRead);
            this.panel6.Controls.Add(this.lbSerialMessagesSend);
            this.panel6.Location = new System.Drawing.Point(3, 132);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(522, 214);
            this.panel6.TabIndex = 6;
            // 
            // lbSerialMessagesRead
            // 
            this.lbSerialMessagesRead.FormattingEnabled = true;
            this.lbSerialMessagesRead.Location = new System.Drawing.Point(291, 5);
            this.lbSerialMessagesRead.Name = "lbSerialMessagesRead";
            this.lbSerialMessagesRead.Size = new System.Drawing.Size(226, 186);
            this.lbSerialMessagesRead.TabIndex = 4;
            // 
            // lbSerialMessagesSend
            // 
            this.lbSerialMessagesSend.FormattingEnabled = true;
            this.lbSerialMessagesSend.Location = new System.Drawing.Point(-1, 3);
            this.lbSerialMessagesSend.Name = "lbSerialMessagesSend";
            this.lbSerialMessagesSend.Size = new System.Drawing.Size(226, 186);
            this.lbSerialMessagesSend.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.tbFeedbackVertical);
            this.panel5.Controls.Add(this.tbSetpointVertical);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(3, 68);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(522, 58);
            this.panel5.TabIndex = 5;
            // 
            // tbFeedbackVertical
            // 
            this.tbFeedbackVertical.Location = new System.Drawing.Point(172, 29);
            this.tbFeedbackVertical.Name = "tbFeedbackVertical";
            this.tbFeedbackVertical.Size = new System.Drawing.Size(100, 20);
            this.tbFeedbackVertical.TabIndex = 7;
            this.tbFeedbackVertical.Text = "0";
            // 
            // tbSetpointVertical
            // 
            this.tbSetpointVertical.Location = new System.Drawing.Point(172, 6);
            this.tbSetpointVertical.Name = "tbSetpointVertical";
            this.tbSetpointVertical.Size = new System.Drawing.Size(100, 20);
            this.tbSetpointVertical.TabIndex = 6;
            this.tbSetpointVertical.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Feedback vertical";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Setpoint vertical";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.tbFeedbackHorizontal);
            this.panel4.Controls.Add(this.tbSetpointHorizontal);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(522, 58);
            this.panel4.TabIndex = 4;
            // 
            // tbFeedbackHorizontal
            // 
            this.tbFeedbackHorizontal.Location = new System.Drawing.Point(172, 29);
            this.tbFeedbackHorizontal.Name = "tbFeedbackHorizontal";
            this.tbFeedbackHorizontal.Size = new System.Drawing.Size(100, 20);
            this.tbFeedbackHorizontal.TabIndex = 5;
            this.tbFeedbackHorizontal.Text = "0";
            // 
            // tbSetpointHorizontal
            // 
            this.tbSetpointHorizontal.Location = new System.Drawing.Point(172, 6);
            this.tbSetpointHorizontal.Name = "tbSetpointHorizontal";
            this.tbSetpointHorizontal.Size = new System.Drawing.Size(100, 20);
            this.tbSetpointHorizontal.TabIndex = 4;
            this.tbSetpointHorizontal.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Setpoint horizontal";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.trackBarVertical);
            this.panel2.Location = new System.Drawing.Point(1140, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(69, 348);
            this.panel2.TabIndex = 23;
            // 
            // trackBarVertical
            // 
            this.trackBarVertical.Location = new System.Drawing.Point(20, 3);
            this.trackBarVertical.Maximum = 100;
            this.trackBarVertical.Minimum = 15;
            this.trackBarVertical.Name = "trackBarVertical";
            this.trackBarVertical.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarVertical.Size = new System.Drawing.Size(45, 329);
            this.trackBarVertical.TabIndex = 0;
            this.trackBarVertical.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarVertical.Value = 15;
            this.trackBarVertical.ValueChanged += new System.EventHandler(this.trackBarVertical_ValueChanged);
            // 
            // trackBarHorizontal
            // 
            this.trackBarHorizontal.Location = new System.Drawing.Point(3, 13);
            this.trackBarHorizontal.Maximum = 179;
            this.trackBarHorizontal.Name = "trackBarHorizontal";
            this.trackBarHorizontal.Size = new System.Drawing.Size(597, 45);
            this.trackBarHorizontal.TabIndex = 0;
            this.trackBarHorizontal.ValueChanged += new System.EventHandler(this.trackBarHorizontal_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.trackBarHorizontal);
            this.panel3.Location = new System.Drawing.Point(594, 469);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(615, 74);
            this.panel3.TabIndex = 24;
            // 
            // cbSystemState
            // 
            this.cbSystemState.FormattingEnabled = true;
            this.cbSystemState.Items.AddRange(new object[] {
            "SYSTEM_STOP",
            "SYSTEM_MANUAL",
            "SYSTEM_AUTO",
            "SYSTEM_CLEANING",
            "SYSTEM_MAINTENANCE",
            "SYSTEM_IDLE"});
            this.cbSystemState.Location = new System.Drawing.Point(689, 13);
            this.cbSystemState.Name = "cbSystemState";
            this.cbSystemState.Size = new System.Drawing.Size(183, 21);
            this.cbSystemState.TabIndex = 5;
            this.cbSystemState.Text = "SystemState";
            this.cbSystemState.SelectedIndexChanged += new System.EventHandler(this.cbSystemState_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1214, 578);
            this.Controls.Add(this.cbSystemState);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cbBaudRate);
            this.Controls.Add(this.tbLDRTop);
            this.Controls.Add(this.tbLDRBottom);
            this.Controls.Add(this.tbLDRLeft);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.tbLDRRight);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cbPorts);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHorizontal)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPortArduino;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Timer timerReadSystemTime;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer timerReadArduinoValues;
        private System.Windows.Forms.TextBox tbLDRLeft;
        private System.Windows.Forms.TextBox tbLDRRight;
        private System.Windows.Forms.TextBox tbLDRTop;
        private System.Windows.Forms.TextBox tbLDRBottom;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Timer timerShowProgress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListBox lbSerialMessagesRead;
        private System.Windows.Forms.ListBox lbSerialMessagesSend;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbFeedbackVertical;
        private System.Windows.Forms.TextBox tbSetpointVertical;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbFeedbackHorizontal;
        private System.Windows.Forms.TextBox tbSetpointHorizontal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar trackBarVertical;
        private System.Windows.Forms.TrackBar trackBarHorizontal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbSystemState;
    }
}


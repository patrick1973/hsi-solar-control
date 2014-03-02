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
            this.tbBaudRate = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.timerReadSystemTime = new System.Windows.Forms.Timer(this.components);
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerReadArduinoValues = new System.Windows.Forms.Timer(this.components);
            this.tbLDRLeft = new System.Windows.Forms.TextBox();
            this.tbLDRRight = new System.Windows.Forms.TextBox();
            this.tbLDRTop = new System.Windows.Forms.TextBox();
            this.tbLDRBottom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPortArduino
            // 
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
            // tbBaudRate
            // 
            this.tbBaudRate.Location = new System.Drawing.Point(141, 13);
            this.tbBaudRate.Name = "tbBaudRate";
            this.tbBaudRate.Size = new System.Drawing.Size(100, 20);
            this.tbBaudRate.TabIndex = 1;
            this.tbBaudRate.Text = "9600";
            this.tbBaudRate.TextChanged += new System.EventHandler(this.tbBaudRate_TextChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(247, 13);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(121, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "connect Arduino";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // timerReadSystemTime
            // 
            this.timerReadSystemTime.Enabled = true;
            this.timerReadSystemTime.Interval = 1000;
            this.timerReadSystemTime.Tick += new System.EventHandler(this.timerReadSystemTime_Tick);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(247, 42);
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
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 556);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(857, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // timerReadArduinoValues
            // 
            this.timerReadArduinoValues.Enabled = true;
            this.timerReadArduinoValues.Interval = 500;
            this.timerReadArduinoValues.Tick += new System.EventHandler(this.timerReadArduinoValues_Tick);
            // 
            // tbLDRLeft
            // 
            this.tbLDRLeft.Location = new System.Drawing.Point(428, 12);
            this.tbLDRLeft.Name = "tbLDRLeft";
            this.tbLDRLeft.Size = new System.Drawing.Size(100, 20);
            this.tbLDRLeft.TabIndex = 7;
            // 
            // tbLDRRight
            // 
            this.tbLDRRight.Location = new System.Drawing.Point(428, 38);
            this.tbLDRRight.Name = "tbLDRRight";
            this.tbLDRRight.Size = new System.Drawing.Size(100, 20);
            this.tbLDRRight.TabIndex = 8;
            // 
            // tbLDRTop
            // 
            this.tbLDRTop.Location = new System.Drawing.Point(428, 64);
            this.tbLDRTop.Name = "tbLDRTop";
            this.tbLDRTop.Size = new System.Drawing.Size(100, 20);
            this.tbLDRTop.TabIndex = 9;
            // 
            // tbLDRBottom
            // 
            this.tbLDRBottom.Location = new System.Drawing.Point(428, 90);
            this.tbLDRBottom.Name = "tbLDRBottom";
            this.tbLDRBottom.Size = new System.Drawing.Size(100, 20);
            this.tbLDRBottom.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "LDR Left";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "LDR Right";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "LDR Top";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "LDR Bottom";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 578);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLDRBottom);
            this.Controls.Add(this.tbLDRTop);
            this.Controls.Add(this.tbLDRRight);
            this.Controls.Add(this.tbLDRLeft);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbBaudRate);
            this.Controls.Add(this.cbPorts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPortArduino;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.TextBox tbBaudRate;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


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
            this.timerReadSystemTime = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelBaudRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelComPort = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.timerShowProgress = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbSerialMessagesRead = new System.Windows.Forms.ListBox();
            this.lbSerialMessagesSend = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tbFeedbackVertical = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFeedbackHorizontal = new System.Windows.Forms.TextBox();
            this.cbSystemState = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbArduinoStatus = new System.Windows.Forms.TextBox();
            this.btnJogUp = new System.Windows.Forms.Button();
            this.btnJogDown = new System.Windows.Forms.Button();
            this.btnJogLeft = new System.Windows.Forms.Button();
            this.btnJogRight = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelLoggerStatus = new System.Windows.Forms.Label();
            this.btnStopLogger = new System.Windows.Forms.Button();
            this.tbLoginterval = new System.Windows.Forms.TextBox();
            this.btnStartLogging = new System.Windows.Forms.Button();
            this.timerLoggerInterval = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.communicationPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCbPorts = new System.Windows.Forms.ToolStripComboBox();
            this.baudRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCBbaudrate = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.loggerInstellingenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox5 = new System.Windows.Forms.ToolStripTextBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPortArduino
            // 
            this.serialPortArduino.BaudRate = 115200;
            this.serialPortArduino.PortName = "COM7";
            // 
            // timerReadSystemTime
            // 
            this.timerReadSystemTime.Interval = 1000;
            this.timerReadSystemTime.Tick += new System.EventHandler(this.timerReadSystemTime_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabelBaudRate,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabelComPort});
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
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(63, 17);
            this.toolStripStatusLabel3.Text = "Baud rate :";
            // 
            // toolStripStatusLabelBaudRate
            // 
            this.toolStripStatusLabelBaudRate.Name = "toolStripStatusLabelBaudRate";
            this.toolStripStatusLabelBaudRate.Size = new System.Drawing.Size(57, 17);
            this.toolStripStatusLabelBaudRate.Text = "BaudRate";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(126, 17);
            this.toolStripStatusLabel4.Text = "communication port : ";
            // 
            // toolStripStatusLabelComPort
            // 
            this.toolStripStatusLabelComPort.Name = "toolStripStatusLabelComPort";
            this.toolStripStatusLabelComPort.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabelComPort.Text = "comport";
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
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
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
            this.panel6.Location = new System.Drawing.Point(3, 68);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(522, 278);
            this.panel6.TabIndex = 6;
            // 
            // lbSerialMessagesRead
            // 
            this.lbSerialMessagesRead.FormattingEnabled = true;
            this.lbSerialMessagesRead.Location = new System.Drawing.Point(291, 5);
            this.lbSerialMessagesRead.Name = "lbSerialMessagesRead";
            this.lbSerialMessagesRead.Size = new System.Drawing.Size(226, 264);
            this.lbSerialMessagesRead.TabIndex = 4;
            // 
            // lbSerialMessagesSend
            // 
            this.lbSerialMessagesSend.FormattingEnabled = true;
            this.lbSerialMessagesSend.Location = new System.Drawing.Point(-1, 3);
            this.lbSerialMessagesSend.Name = "lbSerialMessagesSend";
            this.lbSerialMessagesSend.Size = new System.Drawing.Size(226, 264);
            this.lbSerialMessagesSend.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.tbFeedbackVertical);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.tbFeedbackHorizontal);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(522, 58);
            this.panel4.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Empty Debug fields";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbFeedbackVertical
            // 
            this.tbFeedbackVertical.Location = new System.Drawing.Point(172, 3);
            this.tbFeedbackVertical.Name = "tbFeedbackVertical";
            this.tbFeedbackVertical.Size = new System.Drawing.Size(53, 20);
            this.tbFeedbackVertical.TabIndex = 7;
            this.tbFeedbackVertical.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Feedback vertical";
            // 
            // tbFeedbackHorizontal
            // 
            this.tbFeedbackHorizontal.Location = new System.Drawing.Point(172, 29);
            this.tbFeedbackHorizontal.Name = "tbFeedbackHorizontal";
            this.tbFeedbackHorizontal.Size = new System.Drawing.Size(53, 20);
            this.tbFeedbackHorizontal.TabIndex = 5;
            this.tbFeedbackHorizontal.Text = "0";
            // 
            // cbSystemState
            // 
            this.cbSystemState.FormattingEnabled = true;
            this.cbSystemState.Items.AddRange(new object[] {
            "DUMMY",
            "SYS_MANUAL",
            "SYS_AUTO",
            "SYS_CLEANING",
            "SYS_MAINTENANCE",
            "SYS_IDLE   ",
            "SYS_STOP                "});
            this.cbSystemState.Location = new System.Drawing.Point(691, 27);
            this.cbSystemState.Name = "cbSystemState";
            this.cbSystemState.Size = new System.Drawing.Size(183, 21);
            this.cbSystemState.TabIndex = 5;
            this.cbSystemState.Text = "SystemState";
            this.cbSystemState.SelectedIndexChanged += new System.EventHandler(this.cbSystemState_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(880, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Arduino status : ";
            // 
            // tbArduinoStatus
            // 
            this.tbArduinoStatus.Location = new System.Drawing.Point(969, 27);
            this.tbArduinoStatus.Name = "tbArduinoStatus";
            this.tbArduinoStatus.Size = new System.Drawing.Size(100, 20);
            this.tbArduinoStatus.TabIndex = 26;
            // 
            // btnJogUp
            // 
            this.btnJogUp.Location = new System.Drawing.Point(95, 4);
            this.btnJogUp.Name = "btnJogUp";
            this.btnJogUp.Size = new System.Drawing.Size(75, 23);
            this.btnJogUp.TabIndex = 27;
            this.btnJogUp.Text = "Jog up ";
            this.btnJogUp.UseVisualStyleBackColor = true;
            this.btnJogUp.Click += new System.EventHandler(this.btnJogUp_Click);
            // 
            // btnJogDown
            // 
            this.btnJogDown.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnJogDown.Location = new System.Drawing.Point(95, 41);
            this.btnJogDown.Name = "btnJogDown";
            this.btnJogDown.Size = new System.Drawing.Size(75, 23);
            this.btnJogDown.TabIndex = 28;
            this.btnJogDown.Text = "Jog down";
            this.btnJogDown.UseVisualStyleBackColor = true;
            this.btnJogDown.Click += new System.EventHandler(this.btnJogDown_Click);
            // 
            // btnJogLeft
            // 
            this.btnJogLeft.Location = new System.Drawing.Point(16, 21);
            this.btnJogLeft.Name = "btnJogLeft";
            this.btnJogLeft.Size = new System.Drawing.Size(75, 23);
            this.btnJogLeft.TabIndex = 29;
            this.btnJogLeft.Text = "Jog left";
            this.btnJogLeft.UseVisualStyleBackColor = true;
            this.btnJogLeft.Click += new System.EventHandler(this.btnJogLeft_Click);
            // 
            // btnJogRight
            // 
            this.btnJogRight.Location = new System.Drawing.Point(174, 21);
            this.btnJogRight.Name = "btnJogRight";
            this.btnJogRight.Size = new System.Drawing.Size(75, 23);
            this.btnJogRight.TabIndex = 30;
            this.btnJogRight.Text = "Jog right";
            this.btnJogRight.UseVisualStyleBackColor = true;
            this.btnJogRight.Click += new System.EventHandler(this.btnJogRight_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.labelLoggerStatus);
            this.panel2.Controls.Add(this.btnStopLogger);
            this.panel2.Controls.Add(this.tbLoginterval);
            this.panel2.Controls.Add(this.btnStartLogging);
            this.panel2.Controls.Add(this.btnJogRight);
            this.panel2.Controls.Add(this.btnJogUp);
            this.panel2.Controls.Add(this.btnJogDown);
            this.panel2.Controls.Add(this.btnJogLeft);
            this.panel2.Location = new System.Drawing.Point(594, 472);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 81);
            this.panel2.TabIndex = 31;
            // 
            // labelLoggerStatus
            // 
            this.labelLoggerStatus.AutoSize = true;
            this.labelLoggerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoggerStatus.Location = new System.Drawing.Point(292, 44);
            this.labelLoggerStatus.Name = "labelLoggerStatus";
            this.labelLoggerStatus.Size = new System.Drawing.Size(45, 16);
            this.labelLoggerStatus.TabIndex = 34;
            this.labelLoggerStatus.Text = "label1";
            // 
            // btnStopLogger
            // 
            this.btnStopLogger.Location = new System.Drawing.Point(368, 3);
            this.btnStopLogger.Name = "btnStopLogger";
            this.btnStopLogger.Size = new System.Drawing.Size(75, 23);
            this.btnStopLogger.TabIndex = 33;
            this.btnStopLogger.Text = "Stop Logger";
            this.btnStopLogger.UseVisualStyleBackColor = true;
            this.btnStopLogger.Click += new System.EventHandler(this.btnStopLogger_Click);
            // 
            // tbLoginterval
            // 
            this.tbLoginterval.Location = new System.Drawing.Point(449, 5);
            this.tbLoginterval.Name = "tbLoginterval";
            this.tbLoginterval.Size = new System.Drawing.Size(50, 20);
            this.tbLoginterval.TabIndex = 32;
            this.tbLoginterval.Text = "1000";
            // 
            // btnStartLogging
            // 
            this.btnStartLogging.Location = new System.Drawing.Point(287, 4);
            this.btnStartLogging.Name = "btnStartLogging";
            this.btnStartLogging.Size = new System.Drawing.Size(75, 23);
            this.btnStartLogging.TabIndex = 31;
            this.btnStartLogging.Text = "Start Logger";
            this.btnStartLogging.UseVisualStyleBackColor = true;
            this.btnStartLogging.Click += new System.EventHandler(this.btnStartLogging_Click);
            // 
            // timerLoggerInterval
            // 
            this.timerLoggerInterval.Tick += new System.EventHandler(this.timerLoggerInterval_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.loggerInstellingenToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1214, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.communicationPortToolStripMenuItem,
            this.baudRateToolStripMenuItem,
            this.toolStripTextBox1,
            this.toolStripTextBox2,
            this.toolStripTextBox4});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(127, 23);
            this.toolStripMenuItem1.Text = "Arduino Connection";
            // 
            // communicationPortToolStripMenuItem
            // 
            this.communicationPortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCbPorts});
            this.communicationPortToolStripMenuItem.Name = "communicationPortToolStripMenuItem";
            this.communicationPortToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.communicationPortToolStripMenuItem.Text = "Communication Port";
            // 
            // toolStripCbPorts
            // 
            this.toolStripCbPorts.Name = "toolStripCbPorts";
            this.toolStripCbPorts.Size = new System.Drawing.Size(121, 23);
            this.toolStripCbPorts.Text = "Choose com port";
            this.toolStripCbPorts.SelectedIndexChanged += new System.EventHandler(this.toolStripCbPorts_SelectedIndexChanged);
            // 
            // baudRateToolStripMenuItem
            // 
            this.baudRateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCBbaudrate});
            this.baudRateToolStripMenuItem.Name = "baudRateToolStripMenuItem";
            this.baudRateToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.baudRateToolStripMenuItem.Text = "Baud rate";
            // 
            // toolStripCBbaudrate
            // 
            this.toolStripCBbaudrate.Items.AddRange(new object[] {
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
            this.toolStripCBbaudrate.Name = "toolStripCBbaudrate";
            this.toolStripCBbaudrate.Size = new System.Drawing.Size(121, 23);
            this.toolStripCBbaudrate.Text = "Choose a baudrate";
            this.toolStripCBbaudrate.SelectedIndexChanged += new System.EventHandler(this.toolStripCBbaudrate_SelectedIndexChanged);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Connect Arduino";
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(120, 23);
            this.toolStripTextBox2.Text = "Disconnect Arduino";
            this.toolStripTextBox2.Click += new System.EventHandler(this.toolStripTextBox2_Click);
            // 
            // loggerInstellingenToolStripMenuItem
            // 
            this.loggerInstellingenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox3});
            this.loggerInstellingenToolStripMenuItem.Name = "loggerInstellingenToolStripMenuItem";
            this.loggerInstellingenToolStripMenuItem.Size = new System.Drawing.Size(120, 23);
            this.loggerInstellingenToolStripMenuItem.Text = "Logger instellingen";
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox3.Text = "Bestands Naam";
            this.toolStripTextBox3.Click += new System.EventHandler(this.toolStripTextBox3_Click);
            // 
            // toolStripTextBox4
            // 
            this.toolStripTextBox4.Name = "toolStripTextBox4";
            this.toolStripTextBox4.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox4.Text = "Exit";
            this.toolStripTextBox4.Click += new System.EventHandler(this.toolStripTextBox4_Click_1);
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
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox5});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem2.Text = "Help";
            // 
            // toolStripTextBox5
            // 
            this.toolStripTextBox5.Name = "toolStripTextBox5";
            this.toolStripTextBox5.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox5.Text = "?";
            this.toolStripTextBox5.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox5.Click += new System.EventHandler(this.toolStripTextBox5_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1214, 578);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbArduinoStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbSystemState);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbLDRTop);
            this.Controls.Add(this.tbLDRBottom);
            this.Controls.Add(this.tbLDRLeft);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.tbLDRRight);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Finding the light";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPortArduino;
        private System.Windows.Forms.Timer timerReadSystemTime;
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
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Timer timerShowProgress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListBox lbSerialMessagesRead;
        private System.Windows.Forms.ListBox lbSerialMessagesSend;
        private System.Windows.Forms.TextBox tbFeedbackVertical;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbFeedbackHorizontal;
        private System.Windows.Forms.ComboBox cbSystemState;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbArduinoStatus;
        private System.Windows.Forms.Button btnJogUp;
        private System.Windows.Forms.Button btnJogDown;
        private System.Windows.Forms.Button btnJogLeft;
        private System.Windows.Forms.Button btnJogRight;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbLoginterval;
        private System.Windows.Forms.Button btnStartLogging;
        private System.Windows.Forms.Timer timerLoggerInterval;
        private System.Windows.Forms.Button btnStopLogger;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem communicationPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripCbPorts;
        private System.Windows.Forms.ToolStripMenuItem baudRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripCBbaudrate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelBaudRate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelComPort;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem loggerInstellingenToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label labelLoggerStatus;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox5;
    }
}


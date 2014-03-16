using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;




namespace solarproject
{
    public partial class Form1 : Form
    {
        List<String> LDRvalues = new List<string>();
        List<String> Eventvalues = new List<string>();
        Communications comms = new Communications();
        Logger log = new Logger();


        private String bestandsNaam;
        private int teller = 0;
        private Boolean dirCount = false;
        private state status = 0;
        private String inData;
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();

            getComPorts(comms.getComPorts());
            this.labelLoggerStatus.Text = "logger gestopt";
            this.labelLoggerStatus.BackColor = Color.Red;

            serialPortArduino.ReadBufferSize = 100;
            serialPortArduino.DataReceived += new SerialDataReceivedEventHandler(serialPortArduino_DataReceived);
        }
        public void SplashScreen()
        {
            Application.Run(new spashScreen());
        }

        void serialPortArduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            //inData = sp.ReadLine()+ "\n";
            
            String temp = "";
            temp = comms.readSerialData(sp, "begin", "end");
            Eventvalues = comms.collect(temp);
        }

        
        /// <summary>
        /// Controleer welk comporten op de computer aanwezig zijn.
        /// vul de combobox met de gevonden poorten.
        /// </summary>
        void getComPorts(string[] availPorts)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in availPorts)
            {
                this.toolStripCbPorts.Items.Add(port);
            }
        }

        /// <summary>
        /// Als er een poort geselecteerd wordt koppel deze aan de te gebruiken com poort
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripCbPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                serialPortArduino.PortName = this.toolStripCbPorts.SelectedItem.ToString();
                toolStripStatusLabelComPort.Text = this.toolStripCbPorts.SelectedItem.ToString();
            }
            catch (InvalidOperationException ex)
            {

                MessageBox.Show("select a comm port " + ex.ToString(), "Error");
            }
           
        }

        private void toolStripCBbaudrate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!serialPortArduino.IsOpen)
            {
                try
                {
                    serialPortArduino.BaudRate = Convert.ToInt32(this.toolStripCBbaudrate.SelectedItem);
                    toolStripStatusLabelBaudRate.Text = this.toolStripCBbaudrate.SelectedItem.ToString();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("select a comm port " + ex.ToString(), "Error");
                }
            }
        }


        private void timerReadSystemTime_Tick(object sender, EventArgs e)
        {
            String time = DateTime.Now.ToString();
            toolStripStatusLabel1.Text = DateTime.Now.ToString("HH:mm:ss");
            writeStringToArduino(DateTime.Now.ToString("HH:mm:ss"));
            
        }

        void writeStringToArduino(string message)
        {
            if (serialPortArduino.IsOpen)
            {
                //serialPortArduino.WriteLine(message); // met \n teken
                serialPortArduino.Write(message);       // zonder \n teken
            }
        }

       

        private void timerUpdateArduinoValues_Tick(object sender, EventArgs e)
        {
            
            if (serialPortArduino.IsOpen)
            {
                //String temp = "";
                //temp = comms.readSerialData(serialPortArduino, "begin", "end");
                //Eventvalues = comms.collect(temp);
                if (Eventvalues.Count >= 3)
                {
                    this.tbLDRLeft.Text = Eventvalues[0];
                    this.tbLDRRight.Text = Eventvalues[1];
                    this.tbLDRTop.Text = Eventvalues[2];
                    this.tbLDRBottom.Text = Eventvalues[3];
                    this.tbArduinoStatus.Text = Eventvalues[4];
                    this.tbFeedbackHorizontal.Text = Eventvalues[5] + "°";
                    this.tbFeedbackVertical.Text = Eventvalues[6] + "°";
                }
            }
        }

        public SerialPort getPort()
        {
            return serialPortArduino;
        }

        private void timerShowProgress_Tick(object sender, EventArgs e)
        {

            if (!dirCount)
            {
                teller++;
            }
            else 
            {
                teller--;
            }

            if (teller < 1)
            {
                dirCount = false;
                teller = 0;
            }

            if (teller >= 100)
            {
                dirCount = true;
            }
            this.toolStripProgressBar1.Value = teller;

        }    

        private void cbSystemState_SelectedIndexChanged(object sender, EventArgs e)
        {
            state selectedItem = (state)this.cbSystemState.SelectedIndex;
            DialogResult dialogResult = MessageBox.Show("Are You sure to change the system state? ", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string message = "$" + "SYSTEM_STATE" + ";" + this.cbSystemState.SelectedIndex.ToString() + "#";
                if (serialPortArduino.IsOpen)
                {
                    status = selectedItem;
                    serialPortArduino.Write(message);
                }
                lbSerialMessagesRead.Items.Add(selectedItem.ToString());
            }
            else
            {
                cbSystemState.Text = status.ToString();
            }
            
        }

        
        private void btnJogUp_Click(object sender, EventArgs e)
        {
            if ((status== state.SYS_MANUAL) && serialPortArduino.IsOpen)
            {
                String message = "$JOG_UP;#";
                lbSerialMessagesSend.Items.Add(message);
                serialPortArduino.Write(message);
            }


        }

        private void btnJogDown_Click(object sender, EventArgs e)
        {
            if ((status == state.SYS_MANUAL) && serialPortArduino.IsOpen)
            {
                String message = "$JOG_DOWN;#";
                lbSerialMessagesSend.Items.Add(message);
                serialPortArduino.Write(message);
            }

        }

        private void btnJogLeft_Click(object sender, EventArgs e)
        {
            if ((status == state.SYS_MANUAL) && serialPortArduino.IsOpen)
            {
                String message = "$JOG_LEFT;#";
                lbSerialMessagesSend.Items.Add(message);
                serialPortArduino.Write(message);
            }

        }

        private void btnJogRight_Click(object sender, EventArgs e)
        {
            if ((status == state.SYS_MANUAL) && serialPortArduino.IsOpen)
            {
                String message = "$JOG_RIGHT;#";
                lbSerialMessagesSend.Items.Add(message);
                serialPortArduino.Write(message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbSerialMessagesRead.Items.Clear();
            lbSerialMessagesSend.Items.Clear();
        }

        private void btnStartLogging_Click(object sender, EventArgs e)
        {
            timerLoggerInterval.Interval = Convert.ToInt16(tbLoginterval.Text);
            timerLoggerInterval.Enabled = true;
            this.labelLoggerStatus.Text = "logger actief !!";
            this.labelLoggerStatus.BackColor = Color.Green;
        }

        private void btnStopLogger_Click(object sender, EventArgs e)
        {
            timerLoggerInterval.Enabled = false;
            this.labelLoggerStatus.Text = "logger gestopt";
            this.labelLoggerStatus.BackColor = Color.Red;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPortArduino.Open();
                if (serialPortArduino.IsOpen)
                {
                    this.timerShowProgress.Enabled = true;
                    this.toolStripTextBox1.Enabled = false;
                    this.toolStripTextBox2.Enabled = true;
                }
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Problems with openning the com port ", "Error");
            }
            catch (InvalidOperationException ex)
            {

                MessageBox.Show("Problems with openning the com port " + ex.ToString(), "Error");
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Comport already in use ", "Error");
            }

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPortArduino.Close();
                if (!serialPortArduino.IsOpen)
                {
                    this.timerShowProgress.Enabled = false;
                    this.teller = 0;
                    this.toolStripProgressBar1.Value = 0;
                    this.toolStripTextBox1.Enabled = true;
                    this.toolStripTextBox2.Enabled = false;
                }
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Problems with closing the com port ", "Error");
            }
            catch (InvalidOperationException ex)
            {

                MessageBox.Show("Problems with closing the com port " + ex.ToString(), "Error");
            }

        }

        private void toolStripTextBox3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bestandsNaam = saveFileDialog1.FileName; 
            }
        }

        private void timerLoggerInterval_Tick(object sender, EventArgs e)
        { 
            if (bestandsNaam != null)
            {
                log.save(bestandsNaam, LDRvalues);
            }
            else
            {
                timerLoggerInterval.Enabled = false;
                MessageBox.Show("Waarschijnlijk geen bestandsnaam in gevult.", "Error");
               
            }
        }

        private void toolStripTextBox4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

  
        private void toolStripTextBox5_Click_1(object sender, EventArgs e)
        {
            aboutDialog abDialog = new aboutDialog();
            abDialog.Show();
        }
 
    }
}

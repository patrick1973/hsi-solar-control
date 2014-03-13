using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;




namespace solarproject
{
    public partial class Form1 : Form
    {
        List<String> LDRvalues = new List<string>();
        Communications comms = new Communications();
        private int machineState = 0; 
        private int teller = 0;
        private Boolean dirCount = false;
        state status = 0;
       
        public Form1()
        {
            InitializeComponent();
           
            getComPorts(comms.getComPorts());
            toolStripStatusLabel2.Text = "Disconnected";
            
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
                this.cbPorts.Items.Add(port);
            }
        }

        /// <summary>
        /// Als er een poort geselecteerd wordt koppel deze aan de te gebruiken com poort
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                serialPortArduino.PortName = this.cbPorts.SelectedItem.ToString();
            }
            catch (InvalidOperationException ex)
            {

                MessageBox.Show("select a comm port " + ex.ToString(), "Error");
            }
           
        }
        private void cbBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!serialPortArduino.IsOpen)
            {
                try
                {
                    serialPortArduino.BaudRate = Convert.ToInt32(this.cbBaudRate.SelectedItem);
                }
                catch (InvalidOperationException ex)
                {

                    MessageBox.Show("select a comm port " + ex.ToString(), "Error");
                }
            }
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPortArduino.Open();
                if (serialPortArduino.IsOpen)
                {
                    this.toolStripStatusLabel2.Text = "Connected";
                    this.timerShowProgress.Enabled = true;
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

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPortArduino.Close();
                if (!serialPortArduino.IsOpen)
                {
                    this.toolStripStatusLabel2.Text = "not connected";
                    this.timerShowProgress.Enabled = false;
                    this.teller = 0;
                    this.toolStripProgressBar1.Value = 0;
                }
            }
            catch (System.IO.IOException )
            {
                MessageBox.Show("Problems with closing the com port " , "Error");
            }
            catch (InvalidOperationException ex)
            {

                MessageBox.Show("Problems with closing the com port " + ex.ToString(), "Error");
            }
        }

        private void timerReadArduinoValues_Tick(object sender, EventArgs e)
        {
            
            if (serialPortArduino.IsOpen)
            {
                String temp = "";
                temp = comms.readSerialData(serialPortArduino, "begin", "end");
                LDRvalues = comms.collect(temp);
                if (LDRvalues.Count >= 3)
                {
                    this.tbLDRLeft.Text = LDRvalues[0];
                    this.tbLDRRight.Text = LDRvalues[1];
                    this.tbLDRTop.Text = LDRvalues[2];
                    this.tbLDRBottom.Text = LDRvalues[3];
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
            }

            if (teller >= 100)
            {
                dirCount = true;
            }
            this.toolStripProgressBar1.Value = teller;

        }

        private void trackBarHorizontal_ValueChanged(object sender, EventArgs e)
        {
            if ((status ==  state.SYSTEM_MANUAL) && serialPortArduino.IsOpen)
            {
                String message = "$MOVE_SERVO_LEFT_RIGHT;" + this.trackBarHorizontal.Value.ToString() + "#";
                this.tbSetpointHorizontal.Text = this.trackBarHorizontal.Value.ToString();
                lbSerialMessagesSend.Items.Add(message);
                serialPortArduino.WriteLine(message);
            }
        }

        private void trackBarVertical_ValueChanged(object sender, EventArgs e)
        {
            if ((status == state.SYSTEM_MANUAL) && serialPortArduino.IsOpen)
            {
                String message = "$MOVE_SERVO_UP_DOWN;" +this.trackBarVertical.Value.ToString() + "#";
                this.tbSetpointVertical.Text = this.trackBarVertical.Value.ToString();
                lbSerialMessagesSend.Items.Add(message);
                serialPortArduino.Write(message);
            }
        }

        private void cbSystemState_SelectedIndexChanged(object sender, EventArgs e)
        {
            state selectedItem = (state)this.cbSystemState.SelectedIndex;
            DialogResult dialogResult = MessageBox.Show("Are You sure to change the system state? ", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (serialPortArduino.IsOpen)
                {
                    status = selectedItem;
                    serialPortArduino.Write("$" + selectedItem + "#");
                }
                lbSerialMessagesRead.Items.Add(selectedItem.ToString());
            }
            else
            {
                cbSystemState.Text = status.ToString();
            }

        }

        



   

        

        

          
    }
}

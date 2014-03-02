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
        Communications comms = new Communications();
       
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

        private void tbBaudRate_TextChanged(object sender, EventArgs e)
        {
            serialPortArduino.BaudRate = Convert.ToInt32( this.tbBaudRate.Text);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPortArduino.Open();
                if (serialPortArduino.IsOpen)
                {
                    this.toolStripStatusLabel2.Text = "Connected";
                }
            }
            catch (System.IO.IOException ex)
            {
                MessageBox.Show("Problems with openning the com port " , "Error");
            }
            catch (InvalidOperationException ex)
            {

                MessageBox.Show("Problems with openning the com port " + ex.ToString(), "Error");
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
                }
            }
            catch (System.IO.IOException ex)
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
            tbLDRLeft.Text = comms.readSerialData(serialPortArduino);
            tbLDRBottom.Text = comms.readSerialData(serialPortArduino);
            
        }
    }
}

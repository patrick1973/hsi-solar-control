using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace solarproject
{
    class Communications
    {
        string[] ports;
        public Communications()
        {
            this.ports = SerialPort.GetPortNames();
        }

        public String[] getComPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            return ports;
        }

        public string readSerialData(SerialPort port)
        {
            string message = "";
            if (port.IsOpen)
            {
                message = port.ReadLine();
                if (message.Contains("\n"))
                {
                    message = "";
                }
                return message;
            }
            else
                return null;
        }
    }
}

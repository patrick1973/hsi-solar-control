using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;


namespace solarproject
{
    class Logger
    {

        StringBuilder csv = new StringBuilder();
        public Logger()
        {
                
        }

        public void save(string bestandsnaam, List<String> waardes)
        {
            string message = "";
            int hoeVeelElementen = waardes.Count;
            foreach (String item in waardes)
            {
                message = message + item + ',';
                
            }
            try
            {
                message = message + DateTime.Now.ToString() + "\n";
                File.AppendAllText(bestandsnaam, message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Iets mis gegaan met schrijven : "+ex,"ERROR");
            }
        }
    }
}

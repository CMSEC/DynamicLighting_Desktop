using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Diagnostics;

namespace Lighting
{
    public partial class AutoConnector : Form
    {
        public AutoConnector()
        {
            InitializeComponent();
        }

        static string confirmKey = "CONFIRM";

        private void AutoConnector_Load(object sender, EventArgs e)
        {
            
        }

        private void AutoConnector_Shown(object sender, EventArgs e)
        {
            autoConnect();
        }

        private async void autoConnect()
        {
            string[] ports = SerialPort.GetPortNames();
            int[] rates = { 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 28800, 38400, 57600, 115200 };

            for (int p = 0; p < ports.Length; p++)
            {
                for (int r = 0; r < rates.Length; r++)
                {
                    string port = ports[p];
                    int rate = rates[r];
                    try
                    {
                        portDisplay.Text = port;
                        baudDisplay.Text = rate.ToString();
                        SerialPort serial = new SerialPort(port, rate);
                        serial.Open();
                        serial.DataReceived += new SerialDataReceivedEventHandler(SerialReceived);
                        serial.WriteLine(confirmKey);
                    }
                    catch (Exception error)
                    {
                        report(error.Message, Color.White);
                        report(String.Format(" - Port: {0} | BaudRate: {1}", port, rate), Color.White);
                    }
                    await Task.Delay(200);
                }
            }
            report("No Connection", Color.Red);
        }

        private void SerialReceived(object sender, EventArgs e)
        {
            SerialPort sp = sender as SerialPort;
            string data = sp.ReadLine();
            MessageBox.Show(data);
            sp.Close();
        }

        private void report(string data, Color foreColor)
        {
            FontFamily fontFamily = output.Font.FontFamily;
            int lineSpacing = fontFamily.GetLineSpacing(output.Font.Style);
            float diff = output.Font.Size * lineSpacing / fontFamily.GetEmHeight(output.Font.Style);
            int before = output.Text.Length;
            output.Text += data + Environment.NewLine;
            int after = output.Text.Length;
            if (foreColor != Color.White)
            {
                output.Select(before, after - before);
                output.SelectionColor = foreColor;
                output.Select(after, after);
                output.DeselectAll();
            }
            this.Height += (int)Math.Ceiling(diff) + 1;
        }
    }
}

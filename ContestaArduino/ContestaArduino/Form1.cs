using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms;

namespace ContestaArduino
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;

        public Form1()
        {            
            InitializeComponent();
            serialPort = new SerialPort("COM8");
            serialPort.BaudRate = 9600;
            serialPort.RtsEnable = true;
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            serialPort.Open();

        }


        private void btn_envio_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine(txt_envio.Text);

        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            label1.Text = "Dato Recibido" + indata;

        }
    }
}

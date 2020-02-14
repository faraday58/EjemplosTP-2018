using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace PalindromoArduino
{
    public partial class Form1 : Form
    {
        public SerialPort Mipuerto;
        Stack<char> pilapalabra;
        Queue<char> colapalabra;


        public Form1()
        {
            Mipuerto = new SerialPort();
            pilapalabra = new Stack<char>();
            colapalabra = new Queue<char>();
            
            InitializeComponent();
            selecciona();
        }

        private void txt_palindromo_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            if (e.KeyChar == 13)
            {
                for (int i = 0; i < txt_palindromo.Text.Length; i++)
                {
                    pilapalabra.Push(txt_palindromo.Text[i]);
                    colapalabra.Enqueue(txt_palindromo.Text[i]);
                }
                bool palindromo = true;
                while (pilapalabra.Pop() != colapalabra.Dequeue())
                {
                    palindromo = false;
                }
                 if(palindromo)
                {
                    MessageBox.Show("Es palindromo");
                    Mipuerto.Write("a");
                }
            
            }
        }

        public void selecciona()
        {
            string[] v = SerialPort.GetPortNames();
            Array.Sort(v);
            cmb_puertos.Items.AddRange(v);
        }

        private void cmb_puertos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Mipuerto.BaudRate = 9600;
                Mipuerto.PortName = cmb_puertos.SelectedItem.ToString();
                Mipuerto.Parity = Parity.None;
                Mipuerto.DataBits = 8;
                Mipuerto.Open();
            }
            catch(Exception error)
            {
                MessageBox.Show("Error" + error.Message);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Mipuerto.Close();
        }
    }
}

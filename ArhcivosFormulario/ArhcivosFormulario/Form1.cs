using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;

namespace ArhcivosFormulario
{
    public partial class Form1 : Form
    {
        FileStream fs;
        StreamWriter sw;
        StreamReader sr;
        SaveFileDialog saveFile;
        SerialPort Mipuerto;


        public Form1()
        {
            InitializeComponent();
            Mipuerto = new SerialPort();
        } 

        public void selecciona()
        {
            string[] v = SerialPort.GetPortNames();
            Array.Sort(v);
            cmb_puertos.Items.Add(v);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            selecciona();

            try
            {
                Mipuerto.BaudRate = 9600;
                Mipuerto.PortName = cmb_puertos.SelectedItem.ToString();
                Mipuerto.Parity = Parity.None;
                Mipuerto.DataBits = 8;
                Mipuerto.Open();
                
            }
            catch(IOException error)
            {
                MessageBox.Show(error.Message);
            }


            try
            {
                saveFile = new SaveFileDialog();
                if(  saveFile.ShowDialog() == DialogResult.OK  )
                {
                    fs = new FileStream(saveFile.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    sw.WriteLine(txt_parametros.Text);

                }
                timer1.Start();


            }
            catch(IOException error)
            {
                MessageBox.Show("Error " + error.Message);
            }
            finally
            {
                sw.Close();
                fs.Close();
                
            }

        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            
            

            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    fs = new FileStream(openFile.FileName, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    txt_nombreArchivo.Text = sr.ReadLine();

                }


            }
            catch (IOException error)
            {
                MessageBox.Show("Error " + error.Message);
            }
            finally
            {
                sr.Close();
                fs.Close();

            }
        }

        bool bandera=true;
        int k = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(bandera)
            {
                Mipuerto.Write("a");
                bandera = false;
                sw.WriteLine( k++ + " Encendido");
            }
            else
            {
                bandera = true;
                Mipuerto.Write("b");
                sw.WriteLine(k++ + "Apagado");
            }
            


        }
    }
}

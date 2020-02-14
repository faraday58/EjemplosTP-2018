using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SeñalAleatoria
{
    public partial class Form1 : Form
    {
        int tiempo = 0;
        FileStream fs;
        StreamWriter sw;
        StreamReader sr;
        public Form1()
        {
            InitializeComponent();
        }

        private void generarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer_señal.Start();

        }

        private void timer_señal_Tick(object sender, EventArgs e)
        {
            Random rnd_aleatorio = new Random();
            double señal = rnd_aleatorio.Next(5, 10);
            ch_señal.Series["Series1"].Points.AddXY(tiempo,señal);
            tiempo++;
            if(fs.CanWrite)
            {
                sw.WriteLine(tiempo.ToString() + " " + señal.ToString());
            }
            else
            {
                tiempo = 0;
            }


            if(tiempo == 100)
            {
                timer_señal.Stop();
                tiempo = 0;
                sw.Close();
                fs.Close();                
                
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog()== DialogResult.OK)
            {
                try
                {
                    fs = new FileStream(saveFileDialog.FileName, FileMode.Append, FileAccess.Write);                    
                    sw = new StreamWriter(fs);
                }
                catch(IOException error)
                {
                    MessageBox.Show("Error " + error.Message);
                }
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog()== DialogResult.OK)
            {
                try
                {
                    fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    string dato = sr.ReadLine();
                    while( dato != null)
                    {
                        string[] datos = dato.Split(' ');
                        ch_señal.Series["Series1"].Points.AddXY(double.Parse(datos[0]),double.Parse(datos[1]));
                        dato = sr.ReadLine();
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
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ch_señal.Series["Series1"].Points.Clear();
        }
    }
}

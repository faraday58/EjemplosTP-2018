using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; // Agregado
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficar
{
    public partial class Form1 : Form
    {
        Image im = Graficar.Properties.Resources.
        Pen pluma = new Pen(Color.Black,2);
        Graphics g = null;
        static int center_x, center_y, start_x,start_y, end_x,end_y;
        static int angle,lines,length,increment;

        public Form1()
        {
            InitializeComponent();
            //Calculate the middle of the canvas
            start_x = canvas.Width / 2;
            start_y = canvas.Height / 2;
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            g = canvas.CreateGraphics();
            try
            {
                length = Int32.Parse(longitud.Text);
            }
            catch (Exception) {
                MessageBox.Show("Has ingresado un dato incorrecto");
            }
            for (int i = 0; i < lineas.Value;i++ )
            {
                Pintar();
            }
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            try
            {
                length = Int32.Parse(longitud.Text);
                increment = Int32.Parse(incremento.Text);
                angle = Int32.Parse(angulo.Text);
            }
            catch (Exception ) {
                MessageBox.Show("Has ingresado un dato incorrecto");
            }
            //Calculate the middle of the canvas
            start_x = canvas.Width / 2;
            start_y = canvas.Height / 2;
            // Cleans the canvas
            canvas.Refresh();
        }

        public void Pintar() {
            angle += Int32.Parse(angulo.Text);
            length += Int32.Parse(incremento.Text);

            end_x = (int)(start_x + length * Math.Cos(angle * 0.01745329));
            end_y = (int)(start_y + length * Math.Sin(angle * 0.01745329));

            Point[] puntos = {new Point(start_x,start_y),new Point(end_x,end_y)};

            start_x = end_x;
            start_y = end_y;

            //pluma.Color = Color.

            g.DrawLines(pluma,puntos);
        }

    }
}

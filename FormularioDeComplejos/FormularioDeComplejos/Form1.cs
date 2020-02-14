using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormularioDeComplejos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Complejo c1 = new Complejo( float.Parse( txtreal1.Text), float.Parse(txtimaginario1.Text) );
            Complejo c2 = new Complejo(float.Parse(txtreal2.Text), float.Parse(txtimaginario2.Text));

            etSuma.Text = (c1 + c2).ToString();
            etMultiplicacion.Text = (c1 * c2).ToString();

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            Complejo c1 = new Complejo(float.Parse(txtreal1.Text), float.Parse(txtimaginario1.Text));
            Complejo c2 = new Complejo(float.Parse(txtreal2.Text), float.Parse(txtimaginario2.Text));

            etMultiplicacion.Text = (c1 * c2).ToString();

        }
    }
}

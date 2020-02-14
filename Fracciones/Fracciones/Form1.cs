using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fracciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdbsuma_CheckedChanged(object sender, EventArgs e)
        {
            etoperador.Text = "     +     ";
        }

        private void rdbResta_CheckedChanged(object sender, EventArgs e)
        {
            etoperador.Text = "     -     ";
        }

        private void rdbMulti_CheckedChanged(object sender, EventArgs e)
        {
            etoperador.Text = "     *     ";
        }

        private void rdbDiv_CheckedChanged(object sender, EventArgs e)
        {
            etoperador.Text = "     /    ";

        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            Fraccion f1 = new Fraccion(int.Parse(txt_num1.Text), int.Parse(txtdenom1.Text));
            Fraccion f2 = new Fraccion(int.Parse(txtnum2.Text), int.Parse(txtdenom2.Text));

            if (rdbsuma.Checked)
            {
                etRestultado.Text = (f1 + f2).ToString();
            }
            if (rdbResta.Checked)
            {
                etRestultado.Text = (f1 - f2).ToString();
            }
            if (rdbMulti.Checked)
            {
                etRestultado.Text = (f1 * f2).ToString();
            }
            if (rdbDiv.Checked)
            {
                etRestultado.Text = (f1 / f2).ToString();
            }

        }
    }
}

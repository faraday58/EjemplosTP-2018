using System;
using System.Drawing;
using Apilamiento;
using System.Windows.Forms;

namespace FrasesApilamientop
{
    public partial class Form1 : Form
    {

        Pila miPila;
        public Form1()
        {
            InitializeComponent();
            miPila = new Pila();
        }

        private void pUSHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miPila.PUSH(txt_frase.Text);
            lst_push.Items.Add(miPila.TOPE());
        }

        private void pOPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                lst_pop.Items.Add(miPila.POP());
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}

using System;
using System.Drawing;
using Listas;
using System.Windows.Forms;

namespace ejemplolistas2
{
    public partial class Form1 : Form
    {
        Lista milista = new Lista();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            milista.LeeNombre(textNombre.Text);
            textNombre.Text = "";
            this.BackColor = Color.Aqua;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
           MessageBox.Show( milista.EliminaPrimeraCoincidencia(textNombre.Text));
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            for(int i=0; i<4;i++)
            {
                MessageBox.Show(milista.DevuelveNombre());
            }
        }
    }
}

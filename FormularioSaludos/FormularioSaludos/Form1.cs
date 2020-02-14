using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioSaludos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Hola " + txtNombre.Text, "Saludo a al usuario");
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            etBienvenido.Text = "Holaaaaaaaa";
            etBienvenido.Font = new Font("Arial", 20, FontStyle.Bold);
        }
    }
}

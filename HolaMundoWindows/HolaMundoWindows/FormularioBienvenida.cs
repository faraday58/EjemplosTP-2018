using System;
using System.Windows.Forms;

namespace HolaMundoWindows
{
    partial class  FormularioBienvenida
    {
        public FormularioBienvenida()
        {
            IniciarComponentes();
        }

        public void Saludo(object sender,EventArgs e )
        {
            MessageBox.Show("Hola " + txtbNombre.Text);
        }

    }
}

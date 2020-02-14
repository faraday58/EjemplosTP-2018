using System;
using System.Windows.Forms;
namespace Implementamensajes
{
    public class Mensajes
    {
        public void ElementoAgregado()
        {
            MessageBox.Show("El elemento fue agregado de manera correcta");
        }
        public void ElementoEliminado()
        {
            MessageBox.Show("El elemento fue eliminado");
        }
    }
}

using System;
using System.Windows.Forms;

namespace ColeccionDeMusica
{
    public class ReproducirMusica:IReproducir
    {
        void IReproducir.siguiente()
        {
            MessageBox.Show("Siguiente");
        }

        void IReproducir.anterior()
        {
            MessageBox.Show("Anterior");
        }

        void IReproducir.avanzar()
        {
            MessageBox.Show("Avanzando");
        }

         void IReproducir.retroceder()
        {
            MessageBox.Show("Retrocediendo");
        }

    }
}

using System.Collections.Generic;

namespace ListaServicios
{
    public class Servicios
    {
        List<string> listaservicios;

        public Servicios()
        {
            listaservicios = new List<string>();
        }

        public void IngresaServicio(string servicio)
        {
            listaservicios.Add(servicio);
        }

        public string LeerServicio(int indice)
        {
            return listaservicios[indice];
        }

        public void ElimnaDatoPosicion(int indice)
        {
            listaservicios.RemoveAt(indice);
        }

        public void EliminaDato(string Dato  )
        {
            listaservicios.Remove(Dato);
        }



    }
}

using System;
using System.Collections.Generic;

namespace Listas
{
    public class Lista
    {
        List<string> nombres;
        int indice;

        public Lista()
        {
            nombres = new List<string>();
        }
        
        public void LeeNombre(string nombre)
        {
            nombres.Add(nombre);
        }

           
        public string DevuelveNombre()
        {
            if( indice < nombres.Count   )
            {
                return nombres[indice++];
            }
            else if( indice == nombres.Count)
            {
                indice = 0;
                return nombres[indice++];
            }
            else
            {
                return "No hay elementos que mostrar";
            }
        }

        public string EliminaPrimeraCoincidencia(string nombre)
        {
            if(nombres.Remove(nombre))
            {
                return "Se eliminó el elemento buscado";
            }
            else
            {
                return "No se encontró el elemento";
            }
        }


    }
}

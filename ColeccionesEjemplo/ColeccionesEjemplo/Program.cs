using System;
using System.Collections;

namespace ColeccionesEjemplo
{
    class Program
    {
        static void Main()
        {
            ArrayList micoleccioncadenas = new ArrayList();
            micoleccioncadenas.Add("Uno");
            micoleccioncadenas.Add("Dos");
            micoleccioncadenas.Add("Tres");
            foreach(String elemento in micoleccioncadenas)
            {
                Console.WriteLine(elemento);
            }

            ArrayList micoleccionnumeros = new ArrayList();
            micoleccionnumeros.Add(1);
            micoleccionnumeros.Add(2);
            micoleccionnumeros.Add(3);
            foreach(int elemento in micoleccionnumeros)
            {
                Console.WriteLine(elemento);
            }

           
            ArrayList micoleccion = new ArrayList();
            micoleccion.Add("uno");
            micoleccion.Add("Dos");
            micoleccion.Add("Tres");
            micoleccion.Add(4);
            micoleccion.Add(5);
            micoleccion.Add(6);

            for(int i = 0; i < micoleccion.Count; i++)
            {
                if (i > 2)
                {
                    Console.WriteLine((int)micoleccion[i] * 2);
                }
            }

            micoleccion.Add("7");
            micoleccion.Add("8");
            micoleccion.Add("9");

            for(int i = 0; i < micoleccion.Count; i++)
            {
                if( i > 5)
                {
                    Console.WriteLine(Convert.ToInt16(micoleccion[i]) * 3);
                }
            }
        }
    }
}

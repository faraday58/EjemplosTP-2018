using System;
using System.Collections;

namespace ColeccionesMusica
{
    class Program
    {
        static void Main()
        {
            ArrayList miLista = new ArrayList();
            miLista.Add("Uno");
            miLista.Add("Dos");
            miLista.Add("Tres");

            foreach (string numero in miLista)
            {
                Console.WriteLine(numero);
            }

            ArrayList miListanumeros = new ArrayList();
            miListanumeros.Add(1);
            miListanumeros.Add(2);
            miListanumeros.Add(3);

            foreach (int numero in miListanumeros)
            {
                Console.WriteLine(numero);
            }

            miListanumeros.Add("4");
            miListanumeros.Add("5");
            miListanumeros.Add("6");

            for(int i=0; i < miListanumeros.Count; i++)
            {
                Console.WriteLine(miListanumeros[i]);
                if (i < 3)
                {
                    Console.WriteLine((int)miListanumeros[i] * 2);
                }
                else
                {
                    Console.WriteLine(Int16.Parse((string)miListanumeros[i])*2);
                }
            }



        }
    }
}

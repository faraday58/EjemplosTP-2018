using System;
using System.Collections;

namespace MisColecciones
{
    class Program
    {
        static void Main()
        {
            ArrayList coleccioncadenas = new ArrayList();
            coleccioncadenas.Add("Uno");
            coleccioncadenas.Add("dos");
            coleccioncadenas.Add("tres");
            foreach(string cadena in coleccioncadenas)
            {
                Console.WriteLine(cadena);
            }

            ArrayList coleccionnumeros = new ArrayList();
            coleccionnumeros.Add((byte)1);
            coleccionnumeros.Add((byte)2);
            coleccionnumeros.Add((byte)3);
            foreach(byte numero in coleccionnumeros)
            {
                Console.WriteLine(numero.GetType());
            }

            coleccionnumeros.Add("4");

            int sum = 0;
            for(int i=0; i < coleccionnumeros.Count; i++)
            {
                sum +=int.Parse(coleccionnumeros[i].ToString()); // sum= sum +int.Parse(coleccionnumeros[i].toString());
                Console.WriteLine(coleccionnumeros[i] );
                
            }
            Console.WriteLine("Suma de los elementos de la colección " + sum);

            coleccioncadenas.Add(5);
            coleccioncadenas.Add(6);
            for(int i=3; i < coleccioncadenas.Count;i++)
            {
                
                    sum += int.Parse(coleccioncadenas[i].ToString());
                              

            }
            Console.WriteLine("Suma de los elementos de la colección cadenas {0} " + sum);


        }
    }
}

using System;
using Listas;

namespace EjemploListas
{
    class Program
    {
        static void Main()
        {
            Lista milista = new Lista();
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Escribe el nombre de la persona número {0}:", i+1);
                milista.LeeNombre(Console.ReadLine());
            }

            Console.WriteLine("Escribe el nombre de la persona que deseas eliminar");
            Console.WriteLine(milista.EliminaPrimeraCoincidencia(Console.ReadLine()));

            for(int i=0; i < 4; i++)
            {
                Console.WriteLine(milista.DevuelveNombre());
            }
            


        }
    }
}

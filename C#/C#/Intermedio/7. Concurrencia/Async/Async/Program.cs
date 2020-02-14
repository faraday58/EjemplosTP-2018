using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                esperaTarea();
                string resultadoLectura = Console.ReadLine();
                Console.WriteLine("La entrada fue: " + resultadoLectura);
            }
        }

        static async void esperaTarea()
        {
            int resultadoSuma = await Task.Run(
                () => tareaEnSegundoPlano(new Random().Next(10000, 100000))
                );
            Console.WriteLine("Resultado de tarea en segundo plano: " + resultadoSuma);
        }

        static int tareaEnSegundoPlano(int numero)
        {
            Console.WriteLine("Numero entrante: " + numero);
            int suma = 0;
            for (int i = 1; i < numero; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    suma += j;
                }
            }
            return suma;
        }
    }
}












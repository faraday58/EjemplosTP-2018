using System;

namespace Matrices
{
    class Program
    {
        static void Main()
        {
            Matriz matriz1 = new Matriz();
            Console.WriteLine();
            Matriz matriz2 = new Matriz();
            Console.WriteLine();
            matriz2.mat = matriz1 + matriz2;
            Console.WriteLine(matriz2.ToString());

            //matriz.imprime(); No es recomendable controlar excepciones 
            //desde la clase main o fuera de la clase original


        }
    }
}

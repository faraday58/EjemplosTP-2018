using System;

namespace MiniMatlab
{
    class Program
    {
        static void Main(string[] args)
        {
            Matriz matriz1 = new Matriz();
            matriz1 = Matriz.Leer();
            Console.WriteLine(matriz1.ToString());
            Matriz matriz2 = new Matriz();
            matriz2 = Matriz.Leer();
            Console.WriteLine(matriz2.ToString());
            Console.WriteLine(matriz1 + matriz2);
        }
    }
}

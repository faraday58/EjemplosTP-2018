using System;

namespace MiMatlab
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingresa tu matriz \n >>");
            string m1 = Console.ReadLine();
            Matriz matriz1 = Matriz.LeerMatriz(m1);
            Console.WriteLine(matriz1.ToString());
            Console.Write("Ingresa una nueva matriz\n>>");
            string m2 = Console.ReadLine();
            Matriz matriz2 = Matriz.LeerMatriz(m2);
            Console.WriteLine(matriz2.ToString());
            Matriz matriz3 = matriz1 + matriz2;
            Console.WriteLine("Suma matriz1 + matriz2 =\n{0}",matriz1+matriz2);
        } 
    }
}

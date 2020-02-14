using System;

namespace miniMATLAB2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingresa tu matriz \n >> ");
            string m1 = Console.ReadLine();
            Matriz matriz1 = Matriz.Leer(m1);
            Console.WriteLine(matriz1.ToString());
            Console.Write(">>");
            string m2 = Console.ReadLine();
            Matriz matriz2 = Matriz.Leer(m2);
            Console.WriteLine(matriz2 + " \n m1*m2 ");
           //Console.WriteLine((matriz1 + matriz2).ToString());
            //Console.Write(">>+m2 \n");
            //Console.WriteLine(+matriz2);
            Console.WriteLine(matriz1 * matriz2 + "\n>>");
           
   
        }
    }
}

using System;

namespace MetodosOrdenamiento
{
    class Program
    {
        static void Main()
        {
            int[] A = { 10, 5, 9, 8, 11, 4 };
            Ordenamiento ordena = new Ordenamiento();
            int[] Aor = ordena.Burbuja(A);

            foreach(int a in Aor)
            {
                Console.Write(" "+ a);
            }
            Console.WriteLine();

            Random Arreglo = new Random();
            int[] V = new int[1000000];

            Console.WriteLine("***********Matriz Original*****************");
            for(int i=0; i < V.Length; i++)
            {
                V[i] = Arreglo.Next(0,100);
                Console.Write(" " + V[i]);
            }

            int[] Vor = ordena.Burbuja(V);

            Console.WriteLine("**************Matriz Ordenada*********");
            foreach(int v in Vor)
            {
                Console.Write(" " + v);
            }

            

            Console.Read();
        }
    }
}

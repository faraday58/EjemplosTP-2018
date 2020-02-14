using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HiloBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Principal";
            Thread hiloHijo = new Thread(new ThreadStart(Contador));
            hiloHijo.Name = "Hijo";
            hiloHijo.Start();
            //hiloHijo.Join();
            Contador();
        }

        public static void Contador() { 
            for (int i = 0; i < 100; i++)
			{
                Console.WriteLine(Thread.CurrentThread.Name+ " - " + i);
			}
        }
    }
}

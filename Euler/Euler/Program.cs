using System;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            double z = 2.5;

            double A = Math.Round(z, 0,MidpointRounding.AwayFromZero);
            int B =(int) A;

            Console.WriteLine(" {0}  {1} ",A,B);
        }
    }
}

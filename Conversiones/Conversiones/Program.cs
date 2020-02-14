using System;

namespace Conversiones
{
    class Program
    {
        static void Main()
        {
            byte mibyte = 120;
            int miEntero = mibyte;
            Console.WriteLine(miEntero);

            int a = 2, b = 5;
            float resultado = b / a;
            Console.WriteLine(resultado);


            Console.WriteLine(sizeof(decimal)*8);



            float num1 = 2.5f;
            float num2 = 3.5f;
            decimal resul = (decimal)num1 + (decimal)num2;
            Console.WriteLine(resul);


             int num= (int)Console.ReadLine();
            Console.WriteLine(num);

        }
    }
}

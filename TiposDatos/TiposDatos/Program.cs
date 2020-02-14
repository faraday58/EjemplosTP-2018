using System;

namespace TiposDatos
{
    class Program
    {
        static void Main()
        {
            sbyte mivarsbyte = 127;
            Console.WriteLine(mivarsbyte);
            mivarsbyte = -128;
            Console.WriteLine(mivarsbyte);
            int miEntero = 2147483647;

            miEntero = miEntero + 2;
            //El resultado es negativos porque 
            //se ha superado el intervalo dinamico
            miEntero = -miEntero - 2;
            Console.WriteLine(miEntero);

            float miFlotante = 1.000000007f;
            Console.WriteLine( 1 == miFlotante );
            double miDouble = 222555.00000000007;
            Console.WriteLine(222555 == miDouble);
            decimal miDecimal = 222555.0000000000000007M;
            Console.WriteLine(222555 == miDecimal);

            Console.WriteLine(sizeof(float) + " bytes");
            Console.WriteLine(sizeof(double) + " bytes");
            Console.WriteLine(sizeof(decimal) + " bytes"  );




        }
    }
}

using System;

namespace TiposDeDatos
{
    class Program
    {
        static void Main()
        {
            //Diferencia de precisión en punto flotante
            float mifloat = .8f;
            mifloat += .0000001f;            
            Console.WriteLine( .8f == mifloat  );

            int miEntero = 2147483647;

            int EnteroFin = miEntero +1;
            Console.WriteLine("Nuevo resultado " + EnteroFin  );

            int sizeofDecimal = sizeof(decimal);
            int sizeofDouble = sizeof(double);
            int sizeofFloat = sizeof(float);

            Console.WriteLine(" Tipo de dato | Tamaño en bits ");
            Console.WriteLine("      Decimal | {0}  ",sizeofDecimal*8);
            Console.WriteLine("      Double  | {0}  ", sizeofDouble*8);
            Console.WriteLine("      float   | {0}  ", sizeofFloat*8);

            //Representación
            decimal midecimal = 110025210.2570896108400m;
            Console.WriteLine("Valor decimal : {0}", midecimal);
            Console.WriteLine(" Método toString " + midecimal.ToString("#.##"));
            Console.WriteLine(" Método toString " + midecimal.ToString("n2"));
            Console.WriteLine( " Método Format " + String.Format("{0:0.00}",midecimal));
            Console.WriteLine("Valor decimal moneda: {0:c}", midecimal);

        }
    }
}

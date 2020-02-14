using System;


namespace NumerosEnteros
{
    class SumaDeEnteros
    {
        static void Main()
        {
            Console.WriteLine("¿Cuántos números quieres ingresar?");
            int N = Int16.Parse ( Console.ReadLine());
            int i = 0;
            int sump = 0;
            int sumt = 0;
            int mayor = 0;

            for( i=0; i < N; i++)  // (i++  i = i+1)
            {
                Console.WriteLine("Ingrese el número");
                int Num = Int16.Parse(Console.ReadLine());
                sumt = sumt + Num;
                if ( Num > 0  )
                {
                    mayor++;
                    sump += Num; // sump = sump +Num
                }
            }

            Console.WriteLine(" Total de números mayores que cero: {0}", mayor);
            Console.WriteLine("Suma de números positivos: {0}", sump);
            Console.WriteLine("Suma total de números ingresados: {0}", sumt);

        }
    }
}

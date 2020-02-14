using System;

namespace Calificacion
{
    class Clasifica
    {
        static void Main()
        {
            Console.WriteLine("Ingresa calificación");
             int Cal = Int16.Parse(Console.ReadLine());
            
            if (Cal > 8)
            {
                Console.WriteLine("Aprobado");
            }
            
           /* if (Cal > 8)

                Console.WriteLine("Aprobado");
                */
        }
    }
}

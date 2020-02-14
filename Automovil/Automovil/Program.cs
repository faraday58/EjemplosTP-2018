using System;

namespace Automovil
{
    class Bocho
    {
        static void Main()
        {
            float velocidad = 0;
            Console.WriteLine(velocidad);
            for(int i=0; i< 20; i++)
            {
                velocidad++;
            }
            Console.WriteLine(velocidad);

            while (true)
            {
                
                   velocidad++;
                if (velocidad == 120)
                {
                    Console.WriteLine(velocidad);
                    break;
                }                    
            }
            Console.WriteLine();
            int vel = 0;
            for (int i=0; i < 10; i++)
            {
                
                vel++;
                Console.Write(" {0}  ", vel);
            }


        }
    }
}

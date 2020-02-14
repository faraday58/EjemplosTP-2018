/*using System;

namespace LlamadasCobro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Hola! Elige el tipo de llamada que gustes \n 1.- Internacional \n 2.- Nacional \n 3.- Local");
            int llama = int.Parse( Console.ReadLine());
            Console.WriteLine("¿Cuántos minutos?");
            int min = int.Parse(Console.ReadLine());
            switch(llama)
            {
                case 1:
                    Finternacional();
                    break;
            }

            Console.ReadLine();

            void Finternacional()
            {
                if(min > 3)
                {
                    double n = min - 3;
                    n = n * 3.03 + 5.02;
                    Console.WriteLine("Debes {0}", n);
                }
            }
        }

        


    }
}
*/
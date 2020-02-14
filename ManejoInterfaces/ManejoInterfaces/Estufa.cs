using System;

namespace ManejoInterfaces
{
    class Estufa : IApagar, IEncender
    {
        void IEncender.Encender()
        {
            Console.WriteLine("Encender Estufa");
        }

        void IApagar.Apagar()
        {
            Console.WriteLine("Apagando estufa");
        }
    }
}

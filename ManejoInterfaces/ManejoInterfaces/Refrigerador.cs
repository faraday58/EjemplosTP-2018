using System;

namespace ManejoInterfaces
{
    class Refrigerador : IApagar, IEncender
    {
        void IEncender.Encender()
        {
            Console.WriteLine("Encender Refri");
        }

        void IApagar.Apagar()
        {
            Console.WriteLine("Apagar Refrigerador");
        }

    }
}

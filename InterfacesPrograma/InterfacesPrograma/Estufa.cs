using System;

namespace InterfacesPrograma
{
    class Estufa:IApagar, IEncender
    {
        void IApagar.Apagar()
        {
            Console.WriteLine("  Apagar estufa  ");
        }

        void IEncender.Encender()
        {
            Console.WriteLine("Encender estufa");
        }

    }
}

using System;

namespace Interfaces
{
    class Estufa : IApagar
    {
        void IApagar.Apagar()
        {
            Console.WriteLine("Apagando Estufa");
        }
    }
}

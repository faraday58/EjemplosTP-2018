using System;

namespace Interfaces
{
    class Refrigerador:IApagar
    {
        void IApagar.Apagar()
        {
            Console.WriteLine("Apagar Refrigerador");
        }
    }
}

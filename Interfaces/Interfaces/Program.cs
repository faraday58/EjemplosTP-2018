using System;

namespace Interfaces
{
    class Program
    {
        static void Main()
        {
            IApagar Iapagar = new Estufa();
            Iapagar.Apagar();

            Refrigerador mirefrigerador = new Refrigerador();
            IApagar apagarRefri =(Refrigerador)mirefrigerador;
            apagarRefri.Apagar();


        }
    }
}

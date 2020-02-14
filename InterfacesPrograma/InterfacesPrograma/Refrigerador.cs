using System;


namespace InterfacesPrograma
{
    class Refrigerador:IApagar,IEncender
    {
        void IApagar.Apagar()
        {
            Console.WriteLine(" Apagar Refrigerador ");
        }

        void IEncender.Encender()
        {
            Console.WriteLine("Encender Refrigerador");
        }
    }
}

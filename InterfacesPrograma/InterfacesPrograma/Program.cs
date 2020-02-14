using System;

namespace InterfacesPrograma
{
    class Program
    {
        static void Main()
        {
            IEncender iencenderestufa = new Estufa();
            iencenderestufa.Encender();

            IApagar iapagarestufa = new Estufa();
            iapagarestufa.Apagar();

            IEncender iencenderrefrigerador = new Refrigerador();
            iencenderrefrigerador.Encender();

            Refrigerador mirefri = new Refrigerador();
            IApagar iapagarmirefri = (IApagar)mirefri;
            iapagarmirefri.Apagar();

        }
    }
}

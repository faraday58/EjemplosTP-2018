using System;

namespace ManejoInterfaces
{
    class Program
    {
        static void Main()
        {
            IEncender EncenderEstufa = new Estufa();
            EncenderEstufa.Encender();

            IEncender EncenderRefri = new Refrigerador();
            EncenderRefri.Encender();

            IApagar apagarEstufa = new Estufa();
            apagarEstufa.Apagar();

            IApagar apagarRefrigerador = new Refrigerador();
            apagarRefrigerador.Apagar();
        }
    }
}

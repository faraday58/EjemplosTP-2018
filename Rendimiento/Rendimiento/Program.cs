using System;

namespace Rendimiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Meses mes = Meses.Enero;

            Console.WriteLine("El mes de {0}",mes );

        }
    }

    public enum Meses
    {
        Enero,
        Febrero,
        Marzo,
        Abril
    }
}

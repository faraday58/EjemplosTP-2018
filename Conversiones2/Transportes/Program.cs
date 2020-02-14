using System;

namespace Transportes
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Automovil miAutomovil = new Automovil();
            miAutomovil.Apagar();

            Console.WriteLine("Ingresa el color de tu auto");
            string color = Console.ReadLine();
            Automovil colorAutomovil = new Automovil(color  );
            Console.WriteLine("El automovil tiene color {0}", colorAutomovil.Color);

        }
    }
}

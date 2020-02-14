using System;

namespace EventosConsola
{
    class Program
    {
        

        public void Metodo1()
        {
            Console.WriteLine("Hola");
        }
        public void Metodo2()
        {
            Console.WriteLine("Hola de nuevo");
        }

        public void Metodo3()
        {
            Console.WriteLine("Hasta pronto");
        }

        static void Main()
        {
            Program program = new Program();
            Contenedor_de_eventos eventos = new Contenedor_de_eventos();
            eventos.DisparaEvento += program.Metodo1 ;
            eventos.DisparaEvento += program.Metodo2;
            eventos.DisparaEvento += program.Metodo3;
            eventos.Dispara();
            eventos.DisparaEvento -= program.Metodo2;
            Console.WriteLine("  Hola de nueva/ ya no está suscrito al evento  ");
            eventos.Dispara();

            
        }

        
    }
}

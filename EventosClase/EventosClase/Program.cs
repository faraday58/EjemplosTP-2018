using System;

namespace EventosClase
{
    class Program
    {

        public void Metodo1(int num=10)
        {
            Console.WriteLine("Hola: Mostrar valor {0}",num  );
        }
        public void Metodo2(int num=20)
        {
            Console.WriteLine("Hola de nuevo : Mostrar valor {0}", num);
        }

        public void Metodo3(int num=30)
        {
            Console.WriteLine("Hasta pronto : Mostrar valor {0}", num);
        }


        static void Main()
        {
            Program program = new Program();
            Eventos eventos = new Eventos();

            eventos.DisparaEvento += program.Metodo1;
            //Suscribir al evento
            eventos.DisparaEvento += program.Metodo2;
            eventos.DisparaEvento += program.Metodo3;

            eventos.Dispara();
            //Dejar suscripción al evento
            eventos.DisparaEvento -= program.Metodo2;
            Console.WriteLine(" Hola de nuevo/ ya no se va a ejecutar  ");
            eventos.Dispara();

        }
    }
}

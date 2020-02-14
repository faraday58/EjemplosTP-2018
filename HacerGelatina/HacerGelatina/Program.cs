using System;

namespace HacerGelatina
{
    class Program
    {
        static void Main()
        {
            Gelatina miGelatina = new Gelatina();

            Console.WriteLine("Ingresa el sabor que deseas de tu gelatina");
            string sabor = Console.ReadLine();
            Gelatina suGelatina = new Gelatina(sabor);
        
        }
    }

    class Gelatina
    {
        string sabor;
        string color;
        int cantpasas;
        string forma;
        string textura;

        public Gelatina()
        {
            color = "Morado";
            sabor = "uva";
            cantpasas = 5;
            forma = "vaso gelatinero";
            textura = "Suave";
            Hervir();
            Agregar();
            Vaciar();
            Templar();
        }

        public Gelatina(string sabor)
        {
            this.sabor = sabor;
            Console.WriteLine("Tu sabor elegido es: {0}", sabor);
            Console.WriteLine("La textura es {0}", textura);
            Console.WriteLine("La cantidad de pasas es: {0}", cantpasas);
            Console.WriteLine("El color es {0}", color);
        }




        void Hervir()
        {
            Console.WriteLine("Hirviendo un litro de agua");
        }
        void Agregar()
        {
            Console.WriteLine("Agregando la bolsa de grenetina al agua hervida");
        }
        void Vaciar()
        {
            Console.WriteLine("Vaciando el agua con la grenetina en el molde");
        }

        void Templar()
        {
            Console.WriteLine("Refrigerando el molde");
        }
    }

}

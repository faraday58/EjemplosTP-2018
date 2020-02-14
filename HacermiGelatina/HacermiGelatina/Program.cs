using System;

namespace HacermiGelatina
{
    class Program
    {
        static void Main()
        {
            //Instancia de la clase
            Gelatina miGelatina = new Gelatina();
            Console.WriteLine("Ingresa el sabor de tu gelatina");
            Gelatina suGelatina = new Gelatina(Console.ReadLine());
            Gelatina refGelatina;

            refGelatina = miGelatina;

            Console.WriteLine("El sabor de miGelatina es: {0}", refGelatina.sabor);
            refGelatina.sabor = "Naranja";
            Console.WriteLine("Ahora tu sabor es: {0} ", miGelatina.sabor);
            Console.WriteLine("El sabor elegido en suGelatina es:{0}", suGelatina.sabor);

            //****************************************************************
            Console.WriteLine("\n \n  Introduce el sabor: ");
            string sabor = Console.ReadLine();
            Console.WriteLine("Introduce la textura: ");
            string textura = Console.ReadLine();

            Gelatina otraGelatina = new Gelatina(sabor,textura);



        }
    }

    class Gelatina
    {
        public string sabor;
        string textura;
        string color;
        string forma;
        string tamaño;

        //Constructor de la clase Gelatina
        public Gelatina()
        {
            sabor = "UVA";
            textura = "blanda";
            color = "Morado";
            forma = "Circular";
            tamaño = "Chico";
            Console.WriteLine(" El sabor es: {0}",sabor);
            Console.WriteLine(" La textura es: {0}", textura);
            Console.WriteLine(" El color es: {0}", color);
            Console.WriteLine(" La forma es: {0}", forma);
            Console.WriteLine(" El tamaño es: {0}", tamaño);
            Console.WriteLine("Preparando");
            Hervir();
            Agregar();
            Mezclar();
            Refrigerar();
        }


        public Gelatina(string sabor)
        {
            this.sabor = sabor;
            Console.WriteLine("El sabor elegido es: {0}", sabor);
   /*         Console.WriteLine(" La textura es: {0}", textura);
            Console.WriteLine(" El color es: {0}", color);
            Console.WriteLine(" La forma es: {0}", forma);
            Console.WriteLine(" El tamaño es: {0}", tamaño);
            */
            Console.WriteLine("Preparando");
            Hervir();
            Agregar();
            Mezclar();
            Refrigerar();
        }

        public Gelatina(string sabor, string textura )
        {
            this.sabor = sabor;
            this.textura = textura;
            Console.WriteLine("Preparando");
            Hervir();
            Agregar();
            Mezclar();
            Refrigerar();

        }


        void Hervir()
        {
            Console.WriteLine("Hirviendo el agua");
        }
        void Agregar()
        {
            Console.WriteLine("Agregando grenetina");
        }
        void Mezclar()
        {
            Console.WriteLine("Mezclando grenetina con agua");
        }
        void Refrigerar()
        {
            Console.WriteLine("Refrigerando la gelatina");
        }

    }
}

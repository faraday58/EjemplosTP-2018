using System;

namespace Transportes
{
    class Automovil:Transporte
    {
       
        public Automovil()
        {
            //modelo = 2018;
           Color = "Verde";
            Marca = "VAM";
            //Console.WriteLine("Tu automovil es modelo {0}", modelo);
            Console.WriteLine("Ingresa el modelo de tu automovil");
            Modelo = short.Parse( Console.ReadLine());
            Console.WriteLine("Tu automovil es modelo {0}", Modelo);
            Console.WriteLine("Tu automovil es de color {0}",Color);
            Console.WriteLine("Tu automovil es marca {0}", Marca);

            Encender();

        }
        
        /// <summary>
        /// Constructor para asignar el Color del automovil
        /// </summary>
        /// <param name="Color">Variable local que asigna el valor a la propiedad</param>
        public Automovil(string Color)
        {
            //Atributo   //Variable local o parámetro del Constructor
            this.Color = Color;
        }
        public Automovil(string Color,string Marca)
        {
            //Atributo   //Variable local o parámetro del Constructor
            this.Color = Color;
        }
    }
}

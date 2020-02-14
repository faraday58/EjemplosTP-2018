using System;

namespace Transportes
{
    class Automovil
    {
        private short modelo;
        private string color;
        private string marca;


        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                if( value == ""   )
                {
                    color = "Azul Metálico";
                }
                else
                {
                    color = value;
                }

            }
        }


        //Propiedad del atributo modelo
        public short Modelo
        {
            get
            {
                //Cuando leemos el valor de la propiedad
                //Cuando invoquemos a la propiedad

                return (short)(modelo-5);
            }
            set
            {
                //Escribe en la variable modelo
                //a través del operador "=" o asignación
                //Cuando invocamos a la propiedad
                //para asignar un valor

                if(value > 1970  && value < 2020   )
                {
                    modelo = value;
                }
                else
                {
                    modelo = 2019;
                }
                
            }
        }


        public void Encender()
        {
            Console.WriteLine("Automovil encendido");
        }
        public void Apagar()
        {
            Console.WriteLine("Tu automovil está apagado ");
        }
        public Automovil()
        {
            //modelo = 2018;
            color = "Verde";
            marca = "VAM";
            //Console.WriteLine("Tu automovil es modelo {0}", modelo);
            Console.WriteLine("Ingresa el modelo de tu automovil");
            Modelo = short.Parse( Console.ReadLine());
            Console.WriteLine("Tu automovil es modelo {0}", Modelo);
            Console.WriteLine("Tu automovil es de color {0}",color);
            Console.WriteLine("Tu automovil es marca {0}", marca);

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

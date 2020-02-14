using System;


namespace Transportes
{
    //Una clases es abstracta porque 
    //no requiere de una instancia.
    abstract class Transporte
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
                if (value == "")
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

                return (short)(modelo - 5);
            }
            set
            {
                //Escribe en la variable modelo
                //a través del operador "=" o asignación
                //Cuando invocamos a la propiedad
                //para asignar un valor

                if (value > 1970 && value < 2020)
                {
                    modelo = value;
                }
                else
                {
                    modelo = 2019;
                }

            }
        }

        public string Marca {
            get => marca;
            set => marca = value;
        }

        //Virtual: Es para poder sobreescribir
        //el método encender
        public virtual void Encender()
        {
            Console.WriteLine("Encendiendo medio de transporte");
        }
        //Virtual : Para sobreeescribir al método apagar
        public virtual void Apagar()
        {
            Console.WriteLine("Apagando medio de transporte ");
        }
    }
}

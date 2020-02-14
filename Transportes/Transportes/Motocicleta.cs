using System;

namespace Transportes
{
    class Motocicleta:Transporte
    {
        private string color;

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                if(value == "negro" || value == "rojo" )
                {
                    color = value;
                }
                else
                {
                    color = "rojo";
                }

            }
        }



        //Override: Es para sobrecargar 
        //al método virtual Encender
        public override void Encender()
        {
            //base: Hace referencia a la clase Transporte
            //o base es la clase padre.
            base.Encender();
            Console.WriteLine("Motocicleta ON");
        }
        public override void Apagar()
        {
            base.Apagar();
            Console.WriteLine("Motocicleta Off");
        }

        public Motocicleta()
        {
            this.Color = "VERDE";
            Marca = "BMW";
            Modelo = 2019;

            Console.WriteLine("Mi Motocicleta es de color {0}", Color);
            Console.WriteLine("La marca de mi Motocicleta es {0}",Marca);
            Console.WriteLine("El modelo de mi Motocicleta es {0}",Modelo);
            Encender();
        }
    }
}

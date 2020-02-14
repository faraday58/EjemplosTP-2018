using System;

namespace ControlExcepcionesForm
{
    class Persona
    {
        private string nombre;
        private byte edad;
        private string telefono;
        private string correo;

        public Persona(string nombre, byte edad, string telefono, string correo   )
        {

            this.Nombre = nombre;
            Edad = edad;
            this.Telefono = telefono;
            this.Correo = correo;

        }

        public byte Edad
        {
            get
            {
                return edad;
            }
                
            set
            {
                if( value > 10 && value <= 100    )
                {
                    edad = value;
                }
                else
                {
                    edad = 18;
                }
            }
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
    }
    }


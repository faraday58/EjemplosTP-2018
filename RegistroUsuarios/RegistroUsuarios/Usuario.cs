
namespace RegistroUsuarios
{
    class Usuario
    {
        private string nombre;
        private byte edad;
        private string lada;
        private string telefono;
        private string correo;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (value == "")
                {
                    nombre = "Usuario";
                }
                else
                {
                    nombre = value;
                }
            }
        }

        public byte Edad
        {
            get
            {
                return edad;
            }
            set
            {
                if (value < 13 || value > 70)
                {
                    edad = 13;
                }
                else
                {
                    edad = value;
                }
            }
        }


        public string Lada
        {
            get
            {
                return lada;
            }
            set
            {
                if (value == "")
                {
                    lada = "55";
                }
                else
                {
                    lada = value;
                }
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }
            set
            {
                if (value == "")
                {
                    telefono = "0180011111";
                }
                else
                {
                    telefono = value;
                }
            }
        }
        public string Correo
        {
            get
            {
                return correo;
            }
            set
            {
                if (value == "")
                {
                    correo = "usuario@mail.com";
                }
                else
                {
                    correo = value;
                }
            }
        }


        /// <summary>
        /// Constructor de la clase usuario para identificar
        ///cada elemento
        /// </summary>
        /// <param name="Nombre"></param>
        /// <param name="Edad"></param>
        /// <param name="Lada"></param>
        /// <param name="Telefono"></param>
        /// <param name="Correo"></param>
        public Usuario(string Nombre, byte Edad, string Lada, string Telefono, string Correo)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.Lada = Lada;
            this.Telefono = Telefono;
            this.Correo = Correo;
        }

    }
}

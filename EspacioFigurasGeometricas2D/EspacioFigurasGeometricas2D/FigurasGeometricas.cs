using System;

namespace EspacioFigurasGeometricas2D
{
    public abstract class FigurasGeometricas
    {
        private byte nlados;
        private float radio;
        private float longitud;

        public byte Nlados
        {
            get
            {
                return nlados;
            }
            set
            {
                if (value > 254)
                {
                    nlados = 255;
                }
                else if (value < 1)
                {
                    nlados = 0;
                }
                else
                {
                    nlados = value;
                }



            }
        }

        public float Radio
        {
            get
            {
                return radio;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                else
                {
                    radio = value;


                }
            }
        }

        public float Longitud
        {
            get
            {
                return longitud;
            }
            set
            {
                if(value < 0)
                {
                    value = 0;
                }
                else
                {
                    longitud = value;
                }
            }
        }
            

        public virtual void Area()
        {
            Console.WriteLine("Calculando el Área");
        }

        public virtual void Perimetro()
        {
            Console.WriteLine("Calculando el Perímetro");
        }

    }
}

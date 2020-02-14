using System;

namespace Fracciones
{
    class Fraccion
    {
        private int numerador;
        private int denominador;

        public Fraccion(int numerador, int denominador)
        {
            this.numerador = numerador;
            this.denominador = denominador;

        }

        public static Fraccion operator +(Fraccion f1, Fraccion f2)
        {
            Fraccion f3 = new Fraccion(f1.numerador * f2.denominador + f1.denominador * f2.numerador, f1.denominador * f2.denominador);           
            return f3.Reducir(f3);
        }
        public static Fraccion operator -(Fraccion f1, Fraccion f2)
        {
            Fraccion f3 = new Fraccion(f1.numerador * f2.denominador - f1.denominador * f2.numerador, f1.denominador * f2.denominador);
            return f3.Reducir(f3);
        }

        public static Fraccion operator *(Fraccion f1, Fraccion f2)
        {
            Fraccion f3 = new Fraccion(f1.numerador * f2.numerador, f1.denominador * f2.denominador);
            return f3.Reducir(f3);
        }
        public static Fraccion operator /(Fraccion f1, Fraccion f2)
        {
            Fraccion f3 = new Fraccion(f1.numerador * f2.denominador, f1.denominador * f2.numerador);
            return f3.Reducir(f3);
        }



        Fraccion Reducir(Fraccion f)
        {

            if (f.denominador != f.numerador)
            {
                bool haymultiplo;
                int menor = 0;
                int multiplo = 1;

                do
                {
                    if (f.numerador < f.denominador)
                    {
                        menor = f.numerador;
                    }
                    else if (f.numerador > f.denominador)
                    {
                        menor = f.denominador;
                    }
                    int i = 2;
                    haymultiplo = false;
                    while (multiplo <= menor && !haymultiplo)
                    {
                        if (f.numerador % i == 0 && f.denominador % i == 0)
                        {
                            multiplo = i;
                            haymultiplo = true;
                        }
                        i++;
                    }

                    if (haymultiplo)
                    {
                        f.numerador /= multiplo;
                        f.denominador /= multiplo;
                    }


                } while (haymultiplo);
            }
            return f;
        }

        public override string ToString()
        {


            if (numerador == 0)
            {
                return String.Format("    0    ");
            }
            else
            { 
                if (numerador == denominador)
                {
                    return String.Format("    1    ");
                }
                else if (denominador == 1)
                {
                    return String.Format("   {0}   ", numerador);
                }
                else
                {
                    return String.Format("    {0} / {1}   ", numerador, denominador);
                }
            }
        }


    }
}

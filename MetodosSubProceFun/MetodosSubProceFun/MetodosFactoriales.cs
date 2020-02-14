using System;

namespace MetodosSubProceFun
{
    class MetodosFactoriales
    {
        public MetodosFactoriales() {

            Factorial();
            Console.WriteLine("Cual es tu nombre");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Introduce el numero:");
            int N = Convert.ToInt16(Console.ReadLine());

            Factorial(N, Nombre);
            Console.WriteLine("Introduce el numero:");
            N = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("El resultado de tú numero en factorial es:{0}", Factorial(N));



        }
        /// <summary>
        /// Subrutina para calcular el factorial de un número
        /// </summary>
        public void Factorial()
        {
            int fact = 1;
            Console.WriteLine("Introduce tu número a calcular factorial: ");
            int N = Convert.ToInt16(Console.ReadLine());
            Num = N;
            for (int i = 1; i <= Num; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("El factorial es: {0}", fact);
        }


        /// <summary>
        /// El método calcula el factorial a partir de los
        /// parámetros N y pide Nombre
        /// </summary>
        /// <param name="N">Es el número entero positivo a calcular su factorial   </param>
        /// <param name="Nombre">Nombre de la persona que ingresa el número</param>
        public void Factorial(int N, string Nombre)
        {
            int fact = 1;
            Num = N;
            for (int i = 1; i <= Num; i++)
            {
                fact = fact * i;

            }

            Console.WriteLine("Hola {0}, el factorial es : {1}", Nombre, fact);
        }


        /// <summary>
        /// Este método calcula el factorial de "N" por recursividad
        /// </summary>
        /// <param name="N"> Es un número entero</param>
        /// <returns>Devuelve un número entero positivo </returns>
        public int Factorial(int N)
        {
            Num = N;
            if (Num == 0 || Num == 1)
            {
                return 1;
            }
            else
            {
                return Num * Factorial(Num - 1);
            }

        }
        int N;
        private int Num{
           
            get{
               return N;
            }
           set{
               if( value > 12)
                {
                    N = 12;
                }
               else if(value < 0){
                    N = -value;

                }
                else
                {
                    N = value;
                }
            }
            }



    }
}

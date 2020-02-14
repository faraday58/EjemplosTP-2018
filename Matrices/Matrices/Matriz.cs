using System;

namespace Matrices
{
    class Matriz
    {
        public float[] mat;
        private byte n;

        public byte N
        {
            get
            {
                return n;
            }

            set
            {
                if( value == 0 )
                {
                    n = 1;
                }
                else
                {
                    n = value;
                }
            }
        }

        public Matriz()
        {
            Console.WriteLine(" Ingresa el tamaño de la matriz  ");
            try
            {
                N = byte.Parse(Console.ReadLine());
                mat = new float[N];
                leer();
                imprime();

            }
            catch (FormatException error)
            {
                Console.WriteLine(error.Message);
            }
            catch (OverflowException errorOverflow)
            {
                Console.WriteLine(errorOverflow.Message);
            }
        }

        public void imprime()
        {
            foreach(float elemento in mat   )
            {
                Console.Write(" {0} ", elemento);
            }
        }
        public void leer()
        {
            for( int i=0;  i < N;  i++  )
            {
                try
                {
                    Console.WriteLine("Ingresa el elemento  mat[{0}] = ", i);
                    mat[i] = float.Parse(Console.ReadLine());
                }
                catch(FormatException error)
                {
                    Console.WriteLine(error.Message);
                }                
            }
        }

        public static float[] operator +(Matriz m1, Matriz m2)
        {
            float[] summatriz = new float[m1.N];

            for( int i =0;  i < m1.N; i++)
            {
                summatriz[i] = m1.mat[i] + m2.mat[i]; 
            }

            return summatriz;
        }

        public override string ToString()
        {  // 1 2 3 4 5
            //  1 2
            string arreglo = "";
            for( int i = 0;  i < N; i ++)
            {                
                arreglo = arreglo + " " + mat[i] ;
            }

            return arreglo;

        }

    }

}

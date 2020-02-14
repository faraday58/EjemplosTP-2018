using System;

namespace MiniMatlab
{
    class Matriz
    {
        private float[,] mat;
        private byte n;
        private byte m;

        public byte N
        {
            get
            {
                return n;
            }
            set
            {
                if( value == 0)
                {
                    n = 1;
                }
                else
                {
                    n = value;
                }
            }
        }

        public byte M
        {
            get
            {
                return m;
            }
            set
            {
                if (value == 0)
                {
                    m = 1;
                }
                else
                {
                    m = value;
                }
            }
        }

        public Matriz()
        {

        }

        public Matriz(byte M,byte N)
        {
            this.N = N;
            this.M = M;
            mat = new float[M, N];
        }

        public static Matriz Leer()
        {
            Console.WriteLine("Ingresa la matriz de la forma: 1 2 3 4; 5 6 7 8 \n donde ; significa cambio de renglón \n el espacio es una columna nueva");
            string arreglo = Console.ReadLine();

            string[] renglones = arreglo.Split(';');
            string[] columnas = renglones[0].Split(' ');

            Matriz matriz = new Matriz((byte)renglones.Length,(byte)columnas.Length);

            for(int i=0; i < matriz.M; i ++ )
            {
                columnas = renglones[i].Split(' ');
                for (int j=0; j < matriz.N; j ++)
                {
                    matriz.mat[i, j] = float.Parse(columnas[j]);
                }                
            }
            return matriz;
         }


        public static Matriz operator +( Matriz m1, Matriz m2)
        {
            Matriz m3 = new Matriz(m1.M, m2.N);

            for(int i=0; i< m1.M; i++)
            {
                for(int j=0; j< m1.N; j++)
                {
                    m3.mat[i, j] = m1.mat[i, j] + m2.mat[i, j];
                }

            }
            return m3;            
        }

        public override string ToString()
        {
            // 1 2 3 4
            string mat = "";
            for( int i =0; i < M; i++ )
            {
                for(int j=0; j < N; j++)
                {
                    mat = mat + " "  + this.mat[i,j]; 
                }
                mat = mat + "\n";
            }
            return mat;
        }
    }
}

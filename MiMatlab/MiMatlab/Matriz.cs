using System;

namespace MiMatlab
{
    class Matriz
    {
        private byte filas;
        private byte columnas;
        private float[,] matriz;

        public byte Filas
        {
            get
            {
                return filas;
            }
            set
            {
                if( value !=0 || value < 10  )
                {
                    filas = value;
                }
                else
                {
                    filas = 1;
                }
            }
        }

        public byte Columnas
        {
            get
            {
                return columnas;
            }
            set
            {
                if (value != 0 || value < 10)
                {
                    columnas = value;
                }
                else
                {
                    columnas = 1;
                }
            }
        }

        public Matriz(byte Filas,byte Columnas)
        {
            this.Filas = Filas;
            this.Columnas = Columnas;
            matriz = new float[this.Filas,this.Columnas];
        }

        public static Matriz LeerMatriz(string matriz)
        {
            // matriz = " 1 2 3 4; 4 5 6 7" 
            string[] filas = matriz.Split(';'); //Split separa cadenas
            string[] columnas = filas[0].Split(' ');

            Matriz m = new Matriz( (byte)filas.Length,(byte)columnas.Length );

            for(int i=0; i < filas.Length; i++) // i++ -> i=i+1
            {
                columnas = filas[i].Split(' ');
                for(int  j =0; j < columnas.Length; j++ )
                {
                    m.matriz[i, j] = float.Parse( columnas[j]);
                }                
            }

            return m;
        }


        //Sobrecargar al operador +
        public static Matriz operator +(Matriz m1, Matriz m2)
        {
            Matriz m3 = new Matriz(m1.Filas, m1.Columnas);

            for( int i=0; i < m1.Filas; i++ )
            {
                for(int j=0; j < m1.Columnas; j++  )
                {
                    m3.matriz[i, j] = m1.matriz[i, j] + m2.matriz[i, j];
                }
            }
            return m3;

        }




        public override string ToString()
        {
            string matriz = "";
            for(int i=0; i < Filas; i++)
            {
                for(int j=0; j < Columnas; j++)
                {
                    matriz = matriz + " " + this.matriz[i, j];
                }
                matriz = matriz + "\n";
            }
            return matriz;
        }
    }
}

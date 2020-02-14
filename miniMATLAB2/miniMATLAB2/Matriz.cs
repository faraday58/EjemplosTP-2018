using System;

namespace miniMATLAB2
{
    class Matriz
    {
        private byte reng;
        private byte colum;
        private float[,] mat;

        public byte Reng
        {
            get
            {
                return reng;

            }
            set
            {
                if( value == 0   )
                {
                    reng = 1;
                }
                else
                {
                    reng = value;
                }

            }
        }

        public byte Colum
        {
            get
            {
                return colum;
            }
            set
            {
                if( value == 0)
                {
                    colum = 1;
                }
                else
                {
                    colum = value;
                }
            }
        }

        public Matriz(byte Reng, byte Colum)
        {
            this.Reng = Reng;
            this.Colum = Colum;

            mat = new float[this.Reng, this.Colum];
        }

        //1 2 3;4 5 6;7 8 9

        public static Matriz Leer(string matriz )
        {
            string[] renglones = matriz.Split(';');
            string[] columnas = renglones[0].Split(' ');
            Matriz m = new Matriz((byte)renglones.Length,(byte) columnas.Length);

            for(int i=0; i < renglones.Length; i++ )
            {
                columnas = renglones[i].Split(' ');
                for(int j=0; j < columnas.Length; j++)
                {
                    m.mat[i, j] = Convert.ToSingle(columnas[j]);
                }
            }
            return m;
        }

        public static Matriz operator +(Matriz m1,Matriz m2  )
        {
            Matriz m3 = new Matriz(m1.Reng, m1.Colum);
            for(int i= 0; i < m1.Reng; i++)
            {
                for(int j=0; j  < m1.Colum; j++)
                {
                    m3.mat[i, j] = m1.mat[i, j] + m2.mat[i, j];
                }
            }
            return m3;
        }

        public static Matriz operator +(Matriz m1)
        {
            Matriz m = new Matriz(1, 1);
            //float [,] mr= new float(m1.Reng,m1.Colum);

            for( int i=0; i < m1.Reng; i ++)
            {
                //mr[i,j]= m1.mat[i,j];
                m.mat[0, 0] = m.mat[0, 0] + m1.mat[i, i]; 
            }

            return m;
        }

        /*m1      m2
          1 2 3   1 1 
          4 5 6   2 3 
          1 2 1   0 1 
              mx n n xs
       */
       public static Matriz operator *(Matriz m1, Matriz m2)
        {
            Matriz m3 = new Matriz(m1.Reng, m2.Colum);
            for(int i=0; i < m3.Reng; i++)
            {
                for(int j=0; j < m3.Colum; j++  )
                {
                    float suma = 0;
                    for(int k=0; k < m1.Colum; k++)
                    {
                        //suma= suma+ m1.mat[i, k] * m2.mat[k, j]; 
                        suma += m1.mat[i, k] * m2.mat[k, j]; 
                    }
                    m3.mat[i, j] = suma;
                }
            }
            return m3;
        }
       

        public override string ToString()
        {
            string matriz = "";
            for(int i=0; i < Reng; i++)
            {
                for(int j=0; j < Colum;j++)
                {
                    matriz = matriz + " " + mat[i, j];
                }
                matriz = matriz + "\n";
            }
            return matriz;

        }

    }
}

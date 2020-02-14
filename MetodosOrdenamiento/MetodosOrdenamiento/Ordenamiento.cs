
namespace MetodosOrdenamiento
{
    public class Ordenamiento

    {
        private int[] Arreglo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>

        public int [] Burbuja(int [] A)
        {
            int AUX = 0;

            for(int i=0; i< A.Length; i++ )
            {
                for(int j=0; j < A.Length-1;j++)
                {
                    if(A[j]> A[j+1])
                    {
                        AUX = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = AUX;
                    }

                }
            }

            return A;
        }



    }
}

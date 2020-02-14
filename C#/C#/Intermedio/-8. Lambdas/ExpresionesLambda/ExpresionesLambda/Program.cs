using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ExpresionesLambda
{
    delegate void ImprimeMensaje(string mensaje);

    delegate void ImprimeMensaje2(string mensaje, string ext);

    /// <summary>
    /// Expresiones Lambda
    /// </summary>
    class Program
    {
        private static void Main(string[] args)
        {
            //Definicion de exp lambda: Parametro => funcion
            ImprimeMensaje imprime = mensaje =>
            {
                mensaje += ".txt";
                Console.WriteLine(mensaje);
            };

            imprime += mensaje => File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"mensaje_lambda.txt"), mensaje);
 


            ImprimeMensaje2 imprime2 = (string mensaje, string extension) => Console.WriteLine(mensaje + extension);

            imprime2("hola", "txt");

        RegistraMensaje(imprime,"Esto usa una expresion lambda");
        }

        static void RegistraMensaje(ImprimeMensaje imprime, string mensaje)
        {
            // Invoca a los métodos registrados en el delgado
            imprime(mensaje);
        }

        void Metodo()
        {
            Console.WriteLine("Hola");
        }

        char Metodo2(string s)
        {
            return s[0];
        }

        void Metodo3(int[] ints)
        {
            foreach(int i in ints)
            {
                Console.WriteLine(i);
            }
        }
    }
}

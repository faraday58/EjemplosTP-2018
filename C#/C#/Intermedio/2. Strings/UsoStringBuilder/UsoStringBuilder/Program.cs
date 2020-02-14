using System;
using System.Text;

namespace UsoStringBuilder
{
    /// <summary>
    /// La clase StringBuilder permite manipular cadenas
    /// con mejor rendimiento para la aplicación.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder("Cadena de prueba");

            // propiedades Length y Capacity 
            Console.WriteLine("buffer: {0}\nLength: {1}\nCapacity: {2}",
                builder, builder.Length, builder.Capacity);            

            builder.EnsureCapacity(75); // asegura una capacidad de 75
            Console.WriteLine("\nNew capacity = " +
               builder.Capacity);

            /*object[] datos = {"cadena", 1, 0.5, false, 'c', 8}; //
            foreach(var dato in datos)
            {
                builder.Append(dato + " "); //Appemd permite añadir cualuier tipo de caracter al final de la cadena 
          
            }*/

            builder.Append(55);

            Console.WriteLine(builder.ToString());
            builder.Insert(0, "Inserta al principio"); //Insert(int indice; tipo x)

            Console.WriteLine(builder.ToString());

            StringBuilder cadenados = new StringBuilder("Mes de del año ");
            cadenados.Insert(7, "Abril ");
            cadenados.Append(2010);
            Console.WriteLine(cadenados.ToString());
            cadenados.Remove(7,6); //Remove(int p; int n) p-indice a partir del cual quitará n caracteres
            cadenados.Insert(7, "Mayo ");
            Console.WriteLine(cadenados.ToString());
            cadenados.Replace("Mayo","Enero");
            Console.WriteLine(cadenados.ToString());

            Console.ReadKey(true);      
        }
    }
}

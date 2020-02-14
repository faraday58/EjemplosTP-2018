using System;

namespace Promedio
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese el primer número ");
            int num1 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número ");
            int num2 = Int16.Parse(Console.ReadLine());
            int mayor = 0;
            if (num1 > num2)
            {
                mayor = num1;
            }
            else
            {
                mayor = num2;
            }
            int suma = num1 + num2;
            float promedio = suma / 2f; //Conversiones implícitas

            float promedio2 = (float)suma / 2; //Conversión explícita
                                     //Casteo


            Console.WriteLine("El número mayor es {0}", mayor);
            Console.WriteLine("La suma es: {0}", suma);
            Console.WriteLine("El promedio es: {0}", promedio);
            Console.WriteLine("El promedio es: {0}", promedio2);
        }
    }
}

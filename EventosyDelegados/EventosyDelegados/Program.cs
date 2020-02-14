using System;

namespace EventosyDelegados
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo calculo = new Calculo();

            calculo.Calculofinalizado += new Calculo.Resultado(Calculo_Calculofinalizado);
            Console.WriteLine("Primer Paso");
            calculo.Calcular();
        }

        //Método es el definido en la clase que dispara el evento
        //Tiene que tener la misma firma que el Delegado 
        private static int Calculo_Calculofinalizado(int num1,int num2)
        {

            Console.WriteLine("Suma  {0} + {1} = {2} ", num1, num2, num1 + num2);
            Console.WriteLine("Resultado mostrado en la clase Program");
            return num1 + num2;
        }
    }
}

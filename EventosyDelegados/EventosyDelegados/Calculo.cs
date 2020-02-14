using System;

namespace EventosyDelegados
{
    class Calculo
    {
        //Delegado que es un apuntador
        public delegate int Resultado(int num1,int num2);
        public event Resultado Calculofinalizado;

        public void Calcular()
        {
            Console.WriteLine("Se va a realizar un cálculo");
            int suma = 0;
            Resultado evento = Calculofinalizado;

            if (   evento != null  )
            {
              suma =  evento( 10, 20 );
            }
            Console.WriteLine(suma);

        }


    }
}

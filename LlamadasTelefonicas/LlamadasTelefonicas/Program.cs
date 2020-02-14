using System;

namespace LlamadasTelefonicas
{
    class Cobrar
    {
        static void Main()
        {
            Console.WriteLine(" ¿Qué tipo de llamada fue? \n a: Internacional \n  b: Nacional \n c: Local  ");
            char y = char.Parse (Console.ReadLine());
            Console.WriteLine("¿Cuál fue la duración de la llamada en minutos?");
            int min = Int16.Parse(Console.ReadLine());
            while( y != 'x' && min != -1    )
            {
                float precio=0; //Precio es una variable local
                                //Toda variable local debe de ser inicializada
                switch( y  )
                {
                    case 'a':
                        if(  min > 3)
                        {
                            precio = (min - 3) * 3.03f+ 5.02f; //sufijo f representa un número flotante
                        }
                        else
                        {
                            precio = 5.02f;
                        }
                   break;

                    case 'b':
                        if( min > 3)
                        {
                            precio = (min - 3) * .48f + 1.20f;
                        }
                        else
                        {
                            precio = 1.20f;
                        }
                    break;
                    case 'c':
                        Console.WriteLine("¿Total de llamadas?");
                        int ll = Int16.Parse(Console.ReadLine());
                        if( ll> 50  )
                        {
                            precio = (ll - 50) * .6f;
                        }
                        break;    
                }
                Console.WriteLine(" El precio total es: {0}", precio);
                Console.WriteLine(" ¿Qué tipo de llamada fue? \n a: Internacional \n  b: Nacional \n c: Local  ");
                //No se pueden redeclarar las variables locales
                y = char.Parse(Console.ReadLine());  
                Console.WriteLine("¿Cuál fue la duración de la llamada en minutos?");
                min = Int16.Parse(Console.ReadLine());


            }

        }
    }
}

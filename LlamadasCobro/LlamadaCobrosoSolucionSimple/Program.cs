using System;

namespace LlamadaCobrosoSolucionSimplen
{
    class Program
    {
        static void Main(string[] args)
        {
            char tipllamada='d';
            int cmin = 0;
            do
            {
                Console.WriteLine("Ingrese el tipo de llamada \n a.-Internacional \n b.-Nacional \n c.-Local");
                tipllamada = char.Parse(Console.ReadLine());
                float tpagar = 0;
                
                switch (tipllamada)
                {
                    case 'a':
                        Console.WriteLine("Ingrese la cantidad de minutos ");
                        cmin = int.Parse(Console.ReadLine());
                        if (cmin > 3)
                        {
                            tpagar = 5.02f + 3.03f * (cmin - 3);
                        }
                        else
                        {
                            tpagar = 5.02f;
                        }
                        break;
                    case 'b':
                        Console.WriteLine("Ingrese la cantidad de minutos ");
                        cmin = int.Parse(Console.ReadLine());
                        if (cmin > 3)
                        {
                            tpagar = 1.20f + .48f * (cmin - 3);
                        }
                        else
                        {
                            tpagar = 1.20f;
                        }
                        break;
                    case 'c':
                        Console.WriteLine("Ingrese la cantidad de llamadas ");
                        int cllam = int.Parse(Console.ReadLine());
                        if (cllam > 50)
                        {
                            tpagar = .6f * (cllam - 50);
                        }
                        else
                        {
                            tpagar = 0;
                        }
                        break;
                }
                Console.WriteLine("El total a pagar por la(s) llamada(s) es: {0}", tpagar);
            } while (cmin != -1 && tipllamada != 'x');
        }
    }
}

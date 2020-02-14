using System;


namespace EspacioFigurasGeometricas2D
{
    class Cuadrado:FigurasGeometricas
    {
        public Cuadrado()
        {
            Console.WriteLine("Ingrese la longitud de un lado del cuadrado");
            Longitud= Convert.ToSingle(Console.ReadLine());
            Perimetro();
            Area();
        }

        public override void Area()
        {
            base.Area();
            float area = (float)Longitud *Longitud;
            Console.WriteLine("El área del cuadrado es: {0}",area);
        }

        public override void Perimetro()
        {
            base.Perimetro();
            float perimetro = (float)Longitud * 4;
            Console.WriteLine("El perímetro del cuadrado es: {0}",perimetro);
        }


    }
}

using System;

namespace EspacioFigurasGeometricas2D
{
    class Circulo:FigurasGeometricas
    {

        public Circulo()
        {
            Console.WriteLine(" Ingresa el Radio  ");
            Radio = Convert.ToSingle( Console.ReadLine());
            Perimetro();
            Area();
        }


        public override void Area()
        {
            base.Area();
            float area = (float)Math.PI * Radio * Radio;
            Console.WriteLine("El área es: {0}", area);
        }
        public override void Perimetro()
        {
            base.Perimetro();
            float perimetro =  2 * (float)Math.PI * Radio;
            Console.WriteLine("El perímetro es: {0}", perimetro);
        }


    }
}

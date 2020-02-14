using System;
using System.Drawing;

namespace BugGame
{
    class Comida:Objeto
    {
        public int width;
        public int height;
        public Comida(int width, int height)
        {
            this.width = width;
            this.height = height;
            this.x = generar(width/10);
            this.y = generar(height/10);
        }
        public int generar(int n)
        {
            Random random = new Random();
            int num = random.Next(0, n) * 10;
            return num;
        }
        public void DibujaRectangulo(Graphics graphics)
        {
            graphics.FillRectangle(new SolidBrush(Color.Violet), this.x, this.y, ancho, ancho);
        }

        public void Cambiar()
        {
            this.x = generar(width / 10);
            this.y = generar(height / 10);
        }
    }
}

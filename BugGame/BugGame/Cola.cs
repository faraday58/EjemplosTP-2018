using System.Drawing;
namespace BugGame
{
    class Cola : Objeto
    {
        public int X
        {
            get
            {
                return x;
            }

        }

        public int Y
        {
            get
            {
                return y;
            }
        }

        Cola siguiente;

        public Cola Siguiente
        {
            get
            {
                return siguiente;
            }
        }

        public Cola(int x, int y)
        {
            this.x = x;
            this.y = y;
            siguiente = null;
        }
        public void Dibujar(Graphics graphics)
        {
            if (siguiente != null)
            {
                siguiente.Dibujar(graphics);
            }
            graphics.FillRectangle(new SolidBrush(Color.Violet), this.x, this.y, this.ancho, this.ancho);
            

        }
        public void fijaXY(int x, int y)
        {
            if(siguiente != null)
            {
                siguiente.fijaXY(this.x, this.y);
            }
            this.x = x;
            this.y = y;
        }

        public void crecer()
        {
            if( siguiente == null)
            {
                siguiente = new Cola(x, y);
            }
            else
            {
                siguiente.crecer();
            }
        }
    }
}

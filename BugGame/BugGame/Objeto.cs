using System;
namespace BugGame
{
    public abstract class Objeto
    {
        protected int x;
        protected int y;
        protected int ancho;

        public Objeto()
        {
            ancho = 10;
        }

        public bool interseccion(Objeto objeto)
        {
            int difx = Math.Abs(this.x - objeto.x);
            int dify = Math.Abs(this.y - objeto.y);

            if( difx >=0  && difx < ancho && dify >=0 && dify < ancho)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}

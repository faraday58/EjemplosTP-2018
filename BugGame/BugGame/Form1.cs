using System;
using System.Drawing;
using System.Windows.Forms;

namespace BugGame
{
    public partial class Form1 : Form
    {
        //Creando objeto para dibujar
        Graphics graphics;
        Comida micomida;
        Cola siguiente;
        //Creando la cabeza de la víbora
        Cola cabeza;
        //Variables para dar dirección a la víbora
        int xdir = 0;
        int ydir = 0;
        //Banderas para validar movimiento horizontal y vertical
        bool ejex=true;
        bool ejey = true;
        //Variable de desplazamiento
        const int desplaza = 10;
        
        public Form1()
        {
            InitializeComponent();
            graphics = ptb_escenario.CreateGraphics();
            cabeza = new Cola(10, 10);
            micomida = new Comida(ptb_escenario.Width, ptb_escenario.Height);
            
        }

        public void movimiento()
        {
            cabeza.fijaXY(cabeza.X + xdir, cabeza.Y + ydir);

        }
        public void findejuego()
        {
            xdir = 0;
            ydir = 0;
            ejex = true;
            ejey = true;
            cabeza = new Cola(10, 10);
            micomida = new Comida(ptb_escenario.Width, ptb_escenario.Height);
            MessageBox.Show("Fin del juego");
        }
        public void choquecuerpo()
        {
            Cola temp;
            try
            {
                temp = cabeza.Siguiente.Siguiente;
            }
            catch( NullReferenceException  )
            {
                temp = null;
            }

            while(temp != null)
            {
                if(cabeza.interseccion(temp))
                {
                    findejuego();
                }
                else
                {
                    temp = temp.Siguiente;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);

            cabeza.Dibujar(graphics);
            movimiento();
            micomida.DibujaRectangulo(graphics);

            if(cabeza.interseccion(micomida))
            {
                micomida.Cambiar();
                cabeza.crecer();
            }
            choquecuerpo();
            choqueescenario();
        }

        public void choqueescenario()
        {
            if( cabeza.X >= ptb_escenario.Width-8  || cabeza.Y >= ptb_escenario.Height-8  )
            {
                findejuego();
            }
            if (cabeza.X <= -8 || cabeza.Y <=-8 )
            {
                findejuego();
            }
        }
        
        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            timer1.Start();
            ptb_escenario.Focus();
        }


        private void ptb_escenario_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(ejex)
            {
                if( e.KeyCode == Keys.Down)
                {
                    xdir = 0;
                    ydir = desplaza;
                    ejex = false;
                    ejey = true;
                }
                if(e.KeyCode == Keys.Up)
                {
                    xdir = 0;
                    ydir = -desplaza;
                    ejex = false;
                    ejey = true;
                }
            }
            if(ejey)
            {
                if( e.KeyCode == Keys.Right)
                {
                    ydir = 0;
                    xdir = desplaza;
                    ejey = false;
                    ejex = true;
                }
                if (e.KeyCode == Keys.Left)
                {
                    ydir = 0;
                    xdir = -desplaza;
                    ejey = false;
                    ejex = true;
                }
            }

        }
    }
}

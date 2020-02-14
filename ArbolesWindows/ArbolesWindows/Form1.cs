using System;
using System.Drawing;
using Arboles;
using System.Windows.Forms;

namespace ArbolesWindows
{
    public partial class Form1 : Form
    {
        Arbol miarbol;
        public Form1()
        {
            InitializeComponent();
            miarbol = new Arbol(ptb_dibuja_arbol);
        }

        private void txt_dato_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    miarbol.inserta_nodo(miarbol.Raiz, null, int.Parse(txt_dato.Text), 0);
                    txt_dato.Text = "";
                }

                

                if (e.KeyChar == (char)Keys.P)
                {
                    miarbol.preorden(miarbol.Raiz);
                }

                if (e.KeyChar == (char)Keys.I)
                {
                    miarbol.inorden(miarbol.Raiz);
                }

                if (e.KeyChar == (char)Keys.O)
                {
                    miarbol.posorden(miarbol.Raiz);
                }

                
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
    }
}

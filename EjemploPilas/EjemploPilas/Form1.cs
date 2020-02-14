using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EjemploPilas
{
    public partial class Form1 : Form
    {
        Stack<string> pila;

        public Form1()
        {
            pila = new Stack<string>();
            InitializeComponent();
        }

        private void txt_elemento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == 13  )
            {
                pila.Push(txt_elemento.Text);
                cmb_elementos_push.Items.Add(txt_elemento.Text);
            }
        }

        private void cmb_elementos_push_MouseDoubleClick(object sender, MouseEventArgs e)
        {



        }

        private void cmb_elementos_push_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("¿Realmente deseas eliminar el elemento?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
            {
                    string elemento = pila.Pop();
                lst_eliminados_pop.Items.Add(elemento);
                    cmb_elementos_push.Items.Remove(elemento);
            }
        }
    }
}

using System;
using System.Drawing;
using miniMATLAB2;
using System.Windows.Forms;

namespace OperacionesMatrices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            Matriz matriz1 = Matriz.Leer(txtbOperando1suma.Text);
            Matriz matriz2 = Matriz.Leer(txtbOperando2suma.Text);
            Matriz resultado = matriz1 + matriz2;
            lbResultado.Text = resultado.ToString();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            Matriz matriz1 = Matriz.Leer(txtbOperando1suma.Text);
            Matriz matriz2 = Matriz.Leer(txtbOperando2suma.Text);
            Matriz resultado = matriz1 - matriz2;
            lbResultado.Text = resultado.ToString();
        }

        private void btmultiplicacion_Click(object sender, EventArgs e)
        {
            Matriz matriz1 = Matriz.Leer(txtbOperandoUnoMulti.Text);
            Matriz matriz2 = Matriz.Leer(txtbOperandoDosMulti.Text);
            Matriz resultado = matriz1 * matriz2;
            lbResultado.Text = resultado.ToString();
        }
    }
}

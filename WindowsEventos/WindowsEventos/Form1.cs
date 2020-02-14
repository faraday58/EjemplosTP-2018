using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_presiona_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Presionaste el botón");
        }

        private void btn_presiona_MouseHover(object sender, EventArgs e)
        {
            btn_presiona.Text = "Haz click";
        }

        private void btn_presiona_MouseLeave(object sender, EventArgs e)
        {
            btn_presiona.Text = "Presiona";
        }
    }
}

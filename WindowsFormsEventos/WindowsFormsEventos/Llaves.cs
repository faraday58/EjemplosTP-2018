using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEventos
{
    public partial class Llaves : Form
    {
        ListBox list;
        Button button;

        Form FormPadre = null;
        public Llaves(Form Padre, ListBox list, Button button)
        {
            FormPadre = Padre;
            
            InitializeComponent();
            this.list = list;
            this.button = button;
        }

        



        private void Llaves_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormPadre.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list.Items.Add( "formulario hijo");
            button.Text = "Ya le dí click";
           
        }
    }
}

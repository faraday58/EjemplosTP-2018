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
    public partial class Form1 : Form
    {
        Llaves formllaves;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_lanzar_Click(object sender, EventArgs e)
        {
            
             
            if (listbox_objetos.SelectedIndex == 0)
            {                                   
                    formllaves = new Llaves(this, listbox_objetos, btn_lanzar);
               
                formllaves.Show();
                    this.Hide();                
                
            }
        }
    }
}

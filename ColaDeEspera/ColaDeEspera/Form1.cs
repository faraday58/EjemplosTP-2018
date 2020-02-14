using System;
using System.Drawing;
using ColaEspera;
using System.Windows.Forms;

namespace ColaDeEspera
{
    public partial class Form1 : Form
    {
        int indice_turno;
        int a = 0;
        Cola cola_bancaria;
        public Form1()
        {
            InitializeComponent();
            ContenidoCombobox();
            cola_bancaria = new Cola();
        }

        public void ContenidoCombobox()
        {
            cmb_seccion.Items.Add("Cajas");
            cmb_seccion.Items.Add("Aclaraciones");
            cmb_seccion.Items.Add("Ejecutivos");
            cmb_seccion.Items.Add("Ventas");
        }


        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == 13)
            {
                if (indice_turno < 3)
                {
                    dgv_listaespera.Rows.Add(txt_nombre.Text, cmb_seccion.SelectedItem.ToString(), indice_turno++);
                    cola_bancaria.IngresarDato(txt_nombre.Text);
                }
                else
                {
                    indice_turno = 0;
                    indice = 0;
                    a = a + 3;
                }
            }
        }

        int indice;
        private void tiempo_espera_Tick(object sender, EventArgs e)
        {
            if (indice == indice_turno)
            {
                tiempo_espera.Stop();
                MessageBox.Show("Todos los clientes ya fueron atendidos");
            }
            else
            {
                string cliente = cola_bancaria.EliminaPrimerDato();
                dgv_listaespera.Rows[a + indice++].Selected = true;
                MessageBox.Show("Atendido", cliente + "Muchas gracias por su visita");
               
            }
            


        }

        private void atenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tiempo_espera.Start();
        }

        private void detenerServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tiempo_espera.Stop();
        }
    }
}

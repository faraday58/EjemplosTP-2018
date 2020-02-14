using System;
using System.Drawing;
using ListaServicios;
using System.Windows.Forms;

namespace FormularioLista
{
    public partial class Form1 : Form
    {
        Servicios misservicios;
        public Form1()
        {
            misservicios = new Servicios();
            InitializeComponent();
        }

        private void txt_servicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar ==  13 )
            {
                try
                {
                    if(  txt_servicio.Text ==""     )
                    {
                        throw new Exception("Error no ingresaste ningun dato");
                    }
                    else
                    {
                        misservicios.IngresaServicio(txt_servicio.Text);
                        cmb_servicio.Items.Add(txt_servicio.Text);
                        txt_servicio.Text = "";                        
                    }                   

                }
                catch(Exception error  )
                {
                    MessageBox.Show(error.Message);
                }
                
            }
        }

        private void cmb_servicio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MessageBox.Show("Es "+ misservicios.LeerServicio(cmb_servicio.SelectedIndex), "Servicio seleccionado");
        }

        private void cmb_servicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*int indice = cmb_servicio.SelectedIndex;

            if (  DialogResult.OK == MessageBox.Show("Está seguro de eliminar al elemento",misservicios.LeerServicio(indice),MessageBoxButtons.OKCancel,MessageBoxIcon.Question))
            {
                cmb_servicio.Items.RemoveAt(indice);
                misservicios.ElimnaDatoPosicion(indice);
            }*/
        }

        private void cmb_servicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (DialogResult.OK == MessageBox.Show("Está seguro de eliminar al elemento", cmb_servicio.SelectedItem.ToString(), MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    misservicios.EliminaDato(cmb_servicio.SelectedItem.ToString());
                    cmb_servicio.Items.Remove(cmb_servicio.SelectedItem);
                }
            }
        }
    }
}

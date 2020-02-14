using System;
using System.Collections.Generic;
using System.Drawing;
using Musical;
using System.Windows.Forms;

namespace ListasMusica
{
    public partial class Form1 : Form
    {
        Musica mimusica;
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_artista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            mimusica = new Musica(txt_artista.Text, txt_titulo.Text, txt_album.Text);

            string datosmusica = mimusica.Album + " " + mimusica.Titulo + "  " + mimusica.Artista;

            lst_datosmusica.Items.Add(datosmusica);
        }

        private void lst_datosmusica_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lst_datosmusica.SelectedIndex;

            if ( lst_datosmusica.GetSelected(index)  )
            {
                

            }
        }
    }
}

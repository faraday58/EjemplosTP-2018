using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Musica;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public void mostrar(string dato)
        {
            MessageBox.Show(dato);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            Mp3Musica mimp3Musica = new Mp3Musica(txtArtista.Text,txtNombre.Text,txtGenero.Text , txtAlbum.Text);
           
            mimp3Musica.MuestraInfo += mostrar;

            mimp3Musica.Album();
            mimp3Musica.Artista();
            mimp3Musica.Genero();
            mimp3Musica.Nombre();

        }
    }
}

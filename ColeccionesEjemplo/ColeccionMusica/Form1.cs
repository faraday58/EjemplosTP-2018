using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace ColeccionMusica
{
    public partial class Form1 : Form,IReproducir
    {
        ArrayList coleccionmusica;
        IReproducir ireproducir;
        int contador;
        public Form1()
        {
            ireproducir = new Form1();

            coleccionmusica = new ArrayList();
            InitializeComponent();
        }

        void IReproducir.siguiente()
        {
            MessageBox.Show("Reproduciendo");
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            coleccionmusica.Add(new Musica(txtAlbum.Text, txtArtista.Text, Convert.ToInt16(txtRating.Text)));
            MessageBox.Show("Elemento agregado");
            txtAlbum.Text = "";
            txtArtista.Text = "";
            txtRating.Text = "";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if(contador < coleccionmusica.Count)
            {
                Musica mimusica = (Musica)coleccionmusica[contador];
                txtAlbum.Text = mimusica.Album;
                txtArtista.Text = mimusica.Artista;
                txtRating.Text = mimusica.Rating.ToString();
                contador++;
            }
            else
            {
                contador = 0;
            }
        }

        private void siguienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ireproducir.siguiente();
        }
    }
}

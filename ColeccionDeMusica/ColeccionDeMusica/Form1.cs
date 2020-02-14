using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;

namespace ColeccionDeMusica
{
    public partial class Form1 : Form, IReproducir
    {
               
        ArrayList coleccionmusica;
        Musica mimusica;
        int indice;
        IReproducir ireproducir;
        WindowsMediaPlayer windowsMedia;
        string[] directorios;

        public Form1()
        {
            
            coleccionmusica = new ArrayList();
            InitializeComponent();
            reproducciónToolStripMenuItem.Enabled = false;
            windowsMedia = new WindowsMediaPlayer();
        }

        void IReproducir.siguiente()
        {
            MessageBox.Show("Siguiente Pista");
        }

        void IReproducir.retroceder()
        {
            MessageBox.Show("Retrocediendo en pista");
        }

        void IReproducir.avanzar()
        {
            MessageBox.Show("Avanzando en pista");
        }

        void IReproducir.aleatorio()
        {
            MessageBox.Show("Reproducción Aleatoria");
        }

        void IReproducir.anterior()
        {
            MessageBox.Show("Reproduciendo pista anterior");
        }

        void IReproducir.repetir()
        {
            MessageBox.Show("Reiniciando pista");
        }

        void IReproducir.subirvolumen()
        {
            MessageBox.Show("Subiendo volumen");
        }

        void IReproducir.bajarvolumen()
        {
            MessageBox.Show("Bajar volumen");
        }


        private void btn_agregar_Click(object sender, EventArgs e)
        {

            txtb_album.Text = windowsMedia.controls.currentItem.name;
            
         /*   coleccionmusica.Add(new Musica(txtb_album.Text,txtb_artista.Text,int.Parse(txtb_rating.Text)) );
            lst_reproducción.Items.Add(txt_ruta.Text);
            MessageBox.Show("Música agregada correctamente");
            txtb_album.Text = "";
            txtb_artista.Text = "";
            txtb_rating.Text = "";
            txt_ruta.Text = "";
            */
        }

        private void btn_reproducir_Click(object sender, EventArgs e)
        {
                        
            windowsMedia.URL = directorios[0];           
            reproducciónToolStripMenuItem.Enabled = true;
          
            
            if( indice < coleccionmusica.Count  )
            {
                mimusica = (Musica)coleccionmusica[indice];
                lb_album.Text = mimusica.Album;
                lb_artista.Text = mimusica.Artista;
                lb_rating.Text = mimusica.Rating.ToString();
                
                if( indice == 0 )
                {
                    this.ptb_artista.Image = global::ColeccionDeMusica.Properties.Resources.nirvana;
                    windowsMedia.controls.play();
                }
                if(indice == 2)
                {
                    this.ptb_artista.Image = global::ColeccionDeMusica.Properties.Resources.coldplay_1;
                }
                

                indice++;
            }
            else
            {
                indice = 0;
            }
        }

        private void siguienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ireproducir.siguiente();
            if (indice < directorios.Length)
            {
                windowsMedia.URL = directorios[indice++];
                windowsMedia.controls.play();
            }
            else
            {
                indice = 0;
            }



        }

        private void anteriorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
        private void btn_reproducir_MouseHover(object sender, EventArgs e)
        {
            btn_reproducir.Text = "Presione";
        }

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ireproducir = new Form1();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Elige tu música favorita";
            openFileDialog.Filter = "música mp3|*.mp3";

            if ( openFileDialog.ShowDialog() == DialogResult.OK   )
            {               

                 directorios = openFileDialog.FileNames;
            }


        }
    }
}

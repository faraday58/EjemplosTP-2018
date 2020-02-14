
namespace Musica
{
    public class Mp3Musica
    {
        private string artista;
        private string nombre;
        private string genero;
        private string album;
        private float duracion;
                        //Todo 
                      //{  Son la firma del delegado    }
        public delegate void MidelegadoMP3(string valor); 
        public event MidelegadoMP3 MuestraInfo;


        public Mp3Musica(string artista, string nombre, string genero, string  album)
        {
            this.artista = artista;
            this.nombre = nombre;
            this.genero = genero;
            this.album = album;
        }
        
        public void Artista()
        {
            artista = "El nombre del artista es: " + artista;
            MuestraInfo(artista);
        }

        public void Genero()
        {
            genero = "El genero es: " + genero;
            MuestraInfo(genero);
        }

        public void Nombre()
        {
            nombre = "El nombre de la canción es " + nombre;
            MuestraInfo(nombre);
        }

        public void Album()
        {
            album = "El nombre del álbum es : " + album;
            MuestraInfo(album);
        }
    }
}

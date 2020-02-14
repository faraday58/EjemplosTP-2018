
namespace Musical
{
    public class Musica
    {
        private string artista;
        private string titulo;
        private string album;

        public Musica(string Artista, string Titulo, string Album  )
        {
            this.Artista = Artista;
            this.Album = Album;
            this.Titulo = Titulo;

        }

        public string Artista { get => artista; set => artista = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Album { get => album; set => album = value; }
    }
}

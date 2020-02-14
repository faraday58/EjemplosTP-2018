using System;

namespace ColeccionDeMusica
{
    class Musica
    {
        private string album;
        private string artista;
        private int rating;

        public string Album
        {
            get { return album; }
            set { album = value; }
        }

        public string Artista
        {
            get { return artista; }
            set { artista = value; }
        }

        public int Rating
        {
            get { return rating; }
            set
            {
                if (value < 0)
                {
                    rating = 0;
                }
                else
                {
                    rating = value;
                }
            }
        }

        public Musica(string Album, string Artista, int Rating)
        {
            this.Album = Album;
            this.Artista = Artista;
            this.Rating = Rating;
        }




    }
}

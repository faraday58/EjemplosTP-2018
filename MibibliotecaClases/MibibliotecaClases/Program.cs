using System;
using Musica;

namespace MibibliotecaClases
{
    class Program
    {
        public void mostrar(string dato)
        {
            Console.WriteLine(dato);
        }

        static void Main()
        {
            Console.WriteLine("Introduce el nombre del artista");
            string artista = Console.ReadLine();
            Console.WriteLine("Introduce el nombre del álbum");
            string album = Console.ReadLine();
            Console.WriteLine("Introduce el género");
            string genero = Console.ReadLine();
            Console.WriteLine("Introduce el nombre de la canción");
            string nombre = Console.ReadLine();

            Mp3Musica mimp3Musica = new Mp3Musica(artista, nombre, genero, album);
            Program miprogram = new Program();
            mimp3Musica.MuestraInfo += miprogram.mostrar;

            mimp3Musica.Album();
            mimp3Musica.Artista();
            mimp3Musica.Genero();
            mimp3Musica.Nombre();

            


        }
    }
}

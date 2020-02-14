
namespace EventosConsola
{
    class Contenedor_de_eventos
    {
        public delegate void MiManejadorEvento();
        public event MiManejadorEvento DisparaEvento;

        public void Dispara()
        {
            DisparaEvento();
        }
    }
}

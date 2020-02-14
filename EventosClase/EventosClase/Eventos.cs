
namespace EventosClase
{
    class Eventos
    {
        //EL delegado es el apuntador al método
        public delegate void MiManejadorEvento(int num);
        //Evento es el método que lanza la ejecución
        public event MiManejadorEvento DisparaEvento;
     

        public void Dispara()
        {
            DisparaEvento(10);
        }

    }
}

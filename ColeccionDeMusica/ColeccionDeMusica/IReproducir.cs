
namespace ColeccionDeMusica
{
    public interface IReproducir
    {
        void siguiente();
        void anterior();
        void avanzar();
        void retroceder();
        void aleatorio();
        void repetir();
        void subirvolumen();
        void bajarvolumen();
    }
}

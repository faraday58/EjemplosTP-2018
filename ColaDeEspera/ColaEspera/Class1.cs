using System.Collections.Generic;

namespace ColaEspera
{
    public class Cola
    {
        Queue<string> queue;

        public Cola()
        {
            queue = new Queue<string>();
        }

        public void IngresarDato(string Dato)
        {
            queue.Enqueue(Dato);
        }

        public string EliminaPrimerDato()
        {
            return queue.Dequeue();
        }
    }
}

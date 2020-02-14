using System.Collections.Generic;

namespace Apilamiento
{
    public class Pila
    {
        private Stack<string> mistack;

        public Pila()
        {
            mistack = new Stack<string>();
        }

        public void PUSH(string dato)
        {
            mistack.Push(dato);
        }

        public string POP()
        {
            return mistack.Pop();
        }

        public string TOPE()
        {
            return mistack.Peek();
        }

    }
}

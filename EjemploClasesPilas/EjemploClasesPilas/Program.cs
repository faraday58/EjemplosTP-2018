using System;
using System.Collections.Generic;

namespace EjemploClasesPilas
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Miclase> pilaclase = new Stack<Miclase>();

            Miclase clase = new Miclase();
            clase.atributo = "Atributo1";
            clase.atributo2 = "Atributo2";
            pilaclase.Push(clase); ;

            Miclase clase2 = pilaclase.Pop();
            Console.WriteLine("otro" + clase2.atributo);
            Console.WriteLine("Este " + clase2.atributo2);
           

        }
    }
    class Miclase
    {
        public string atributo;
        public string atributo2;
    }
}

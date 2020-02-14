using System;

namespace RegistrosEjemplo
{
    class Program
    {
        static void Main()
        {
            CLIENTE miCliente;
            miCliente.nombre = "Daniel";
            miCliente.telefono = "5678822";
            miCliente.saldo = 22.20F;
            miCliente.moroso = false;

            Console.WriteLine("Nombre del cliente: {0}", miCliente.nombre);
            Console.WriteLine("El teléfono es: {0}", miCliente.telefono);
            Console.WriteLine("El saldo del cliente es: {0} ", miCliente.saldo);
            Console.WriteLine("¿El cliente adeuda? {0} ", miCliente.moroso);
            /*
            CLIENTE[] clientes = new CLIENTE[3];

            for (int i = 0; i < clientes.Length; i++)
            {
                Console.WriteLine("Ingresa el nombre del cliente: ");
                clientes[i].nombre = Console.ReadLine();
                Console.WriteLine("Ingresa el teléfono : ");
                clientes[i].telefono = Console.ReadLine();
                Console.WriteLine("Ingresa el saldo del cliente : ");
                clientes[i].saldo = float.Parse(Console.ReadLine());
                Console.WriteLine("¿El cliente adeuda? (true,false) ");
                clientes[i].moroso = bool.Parse(Console.ReadLine());

            }

            Console.Clear();
            
            for (int i = 0; i < clientes.Length; i++)
            {
                Console.WriteLine("Nombre del cliente: {0} {1}", i + 1, clientes[i].nombre);
                Console.WriteLine("El teléfono es: {0} {1}", i + 1, clientes[i].telefono);
                Console.WriteLine("El saldo del cliente es: {0} {1} ", i + 1, clientes[i].saldo);
                Console.WriteLine("¿El cliente adeuda? {0} {1}", i + 1, clientes[i].moroso);
            }
            */

            Console.Write("Ingresa la calle: " );
            miCliente.direccion.calle = Console.ReadLine();
            Console.Write("Ingresa la numero: " );
            miCliente.direccion.numero = int.Parse(Console.ReadLine());
            Console.Write("Ingresa la ciudad: " );
            miCliente.direccion.ciudad = Console.ReadLine();
            Console.Write("Ingresa la país: " );
            miCliente.direccion.pais = Console.ReadLine();

            Console.WriteLine("La calle de {0} es {1}",miCliente.nombre, miCliente.direccion.calle);
            Console.WriteLine("El número es {0}", miCliente.direccion.numero);
            Console.WriteLine("La ciudad es {0}", miCliente.direccion.ciudad);
            Console.WriteLine("El país es {0}", miCliente.direccion.pais);

            miCliente.saldosdelmes = new float[12];
            for(int i=0;i<miCliente.saldosdelmes.Length;i++)
            {
                Console.WriteLine("Introduce el saldo del mes {0}",i+1);
                miCliente.saldosdelmes[i] = float.Parse(Console.ReadLine());
            }
            for (int i = 0; i < miCliente.saldosdelmes.Length; i++)
            {
                Console.WriteLine("El saldo del mes {0} es: {1}",i+1,miCliente.saldosdelmes[i]);
            }
            Console.ReadKey();
        }

        //Creando la estructura o registro del cliente
        public struct CLIENTE
        {
            public string nombre;
            public string telefono;
            public DIRECCION direccion;
            public float[] saldosdelmes;
            public float saldo;
            public bool moroso;
        }

        public struct DIRECCION
        {
            public string calle;
            public int numero;
            public string ciudad;
            public string pais;
        }

    }
}

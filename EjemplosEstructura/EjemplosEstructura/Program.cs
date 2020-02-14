using System;

namespace EjemplosEstructura
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando variable de tipo la estructura cliente
            CLIENTE cliente;
            cliente.nombre = "Octavio Estrada";
            cliente.telefono = "55 11 12 22";
            cliente.saldo = 25.22F;
            cliente.moroso = true;
            //Creando un arreglo de clientes
            CLIENTE[] clientes= new CLIENTE[3];
            

            for(int i=0; i < clientes.Length; i++)
            {
                Console.WriteLine("Ingresa el nombre del cliente {0} ", i);
                clientes[i].nombre = Console.ReadLine();
                Console.WriteLine("Ingresa el teléfono: ");
                clientes[i].telefono = Console.ReadLine();
                Console.WriteLine("Ingresa saldo del cliente:  ");
                clientes[i].saldo = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa si el cliente es moroso: (true o false)");
                clientes[i].moroso =bool.Parse( Console.ReadLine());
                Console.WriteLine("Ingrese la calle");
                clientes[i].domcilio.calle = Console.ReadLine();
                Console.WriteLine("Ingrese el número");
                clientes[i].domcilio.numero = Int16.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la ciudad");
                clientes[i].domcilio.ciudad = Console.ReadLine();
                Console.WriteLine("Ingrese el país");
                clientes[i].domcilio.pais = Console.ReadLine();
            }

            for (int i = 0; i < clientes.Length; i++)
            {
                Console.WriteLine("Datos del cliente {0}", i);
                Console.WriteLine("Nombre del cliente {0}: {1} ", i, clientes[i].nombre );
                Console.WriteLine("Telefono del cliente {0}: {1} ", i, clientes[i].telefono);
                Console.WriteLine("Saldo del cliente {0}: {1} ", i, clientes[i].saldo.ToString());
                Console.WriteLine("¿El cliente {0} es moroso? {1} ", i, clientes[i].moroso.ToString());
                Console.WriteLine("La calle del cliente {0} es {1}", i, clientes[i].domcilio.calle);
                Console.WriteLine("El número del cliente {0} es {1}", i, clientes[i].domcilio.numero.ToString());
                Console.WriteLine("La ciudad del cliente {0} es {1}", i, clientes[i].domcilio.ciudad);
                Console.WriteLine("El país del cliente {0} es {1}", i, clientes[i].domcilio.pais);
        }

            clientes[1].saldos = new float[12];

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("ingrese su saldo del mes {0}",i+1);
                clientes[1].saldos[i] = float.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("mes    |      saldo   ");
                Console.WriteLine("{0}    |      {1}   ",i+1, clientes[1].saldos[i].ToString());
               
            }





        }

        public struct CLIENTE
        {
            public string nombre;
            public string telefono;
            public float saldo;
            public float [] saldos;
            public DOMICILIO domcilio;
            public bool moroso;
        }

        public struct DOMICILIO
        {
            public string calle;
            public int numero;
            public string ciudad;
            public string pais;
        }


    }
}

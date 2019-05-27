using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente clienteUno = new Cliente(1, "Pepito Gonzalez");
            Cliente clienteDos = new Cliente(2, "Manuelita Gomez");
            Cliente clienteTres = new Cliente(3, "Juancito de la Pera");
            Cliente clienteCuatro = new Cliente(4, "Francisco Yrigoyen");
            Cliente clienteCinco = new Cliente(1, "Pedro Pérez");
            Negocio negocio = new Negocio("Rapipago");

            if (negocio + clienteUno)
            {
                Console.Write("\nCliente agregado-> {0}", clienteUno.Nombre);
            }
            if (negocio + clienteDos)
            {
                Console.Write("\nCliente agregado-> {0}", clienteDos.Nombre);
            }

            if (negocio + clienteTres)
            {
                Console.Write("\nCliente agregado-> {0}", clienteTres.Nombre);
            }

            if (negocio + clienteCuatro)
            {
                Console.Write("\nCliente agregado-> {0}", clienteCuatro.Nombre);
            }

            if (negocio + clienteCinco)
            {
                Console.Write("\nCliente agregado-> {0}", clienteCinco.Nombre);
            }

            Console.WriteLine(negocio.ClientesPendientes);
            Console.ReadKey();
            while (~negocio)
            {
                Console.Write("\nCliente atendido satisfactoriamente");
            }
            Console.ReadKey();
        }
    }
}

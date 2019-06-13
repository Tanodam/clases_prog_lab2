using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda;
using System.Threading;

namespace VistaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja caja1 = new Caja();
            Caja caja2 = new Caja();

            Negocio negocio = new Negocio(caja1, caja2);
            for (int i = 1; i <= 5; i++)
            {
                negocio.Clientes.Add("Cliente " + i);
            }

            Thread hiloNegocio = new Thread(negocio.AsignarCaja);
            Thread hiloCaja1 = new Thread(caja1.AtenderClientes);
            hiloCaja1.Name = "Caja1";
            Thread hiloCaja2 = new Thread(caja2.AtenderClientes);
            hiloCaja2.Name = "Caja2";

            hiloNegocio.Start();
            hiloNegocio.Join();
            hiloCaja1.Start();
            hiloCaja2.Start();

            Console.ReadKey();
        }
    }
}

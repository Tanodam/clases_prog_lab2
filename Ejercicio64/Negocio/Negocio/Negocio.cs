using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tienda
{
    public class Negocio
    {
        private Caja caja1;
        private Caja caja2;
        private List<string> clientes;

        public Caja Caja1
        {
            get
            {
                return caja1;
            }
        }

        public Caja Caja2
        {
            get
            {
                return caja2;
            }
        }

        public List<string> Clientes
        {
            get
            {
                return clientes;
            }
        }

        public Negocio(Caja cj1, Caja cj2)
        {
            clientes = new List<string>();
            caja1 = cj1;
            caja2 = cj2;
        }

        public void AsignarCaja()
        {
            Console.WriteLine("Asignando cajas...");
            foreach (string cliente in this.Clientes)
            {
                Thread.Sleep(2000);
                if (Caja1.FilaClientes.Count < Caja2.FilaClientes.Count)
                {
                    Caja1.FilaClientes.Add(cliente);
                }
                else
                {
                    Caja2.FilaClientes.Add(cliente);
                }
            }
        }
    }
}

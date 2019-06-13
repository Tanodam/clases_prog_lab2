using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tienda
{
    public class Caja
    {
        private List<string> filaClientes;
        
        public List<string> FilaClientes
        {
            get
            {
                return this.filaClientes;
            }
        }
        public Caja()
        {
            this.filaClientes = new List<string>();
        }
        public void AtenderClientes()
        {
            foreach (string cliente in this.FilaClientes)
            {
                Thread.Sleep(2000);
                Console.WriteLine(cliente + "Atendido en " + Thread.CurrentThread.Name);
            }
        }
    }
}

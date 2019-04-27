using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;
        bool agredadoONoAgredado;

        public Cliente Cliente
        {
            get
            {
                if(clientes.Count != 0)
                {
                    return clientes.Dequeue();
                }
                else
                {
                    return null;
                }
            }
            set
            {
                agredadoONoAgredado = this + value;
                //this = negocio y value = cliente
            }
        }
        public int ClientesPendientes
        {
            get
            {
                return clientes.Count;
            }
        }
        private Negocio()
        {
            clientes = new Queue<Cliente>();
            caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }
        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }
        public static bool operator +(Negocio negocio, Cliente cliente)
        {
           if(negocio != cliente)
            {
                negocio.clientes.Enqueue(cliente);
                return true;
            }
           else
            {
                return false;
            }
        }
        public static bool operator ~(Negocio negocio)
        {
            Cliente clientePorAtender = negocio.Cliente; //Traigo el cliente  de la cola
            PuestoAtencion caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1); // disponibilizo una caja
            if(caja.Atender(clientePorAtender))//Atiendo
            {
                  return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(Negocio negocio, Cliente cliente)
        {
            bool retorno = true;
            foreach (Cliente client in negocio.clientes)
            {
                if (client == cliente)
                {
                    retorno = false;
                }

            }
            if (retorno == false)
            {
                negocio.clientes.Enqueue(cliente);
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Negocio negocio, Cliente cliente)
        {
            return !(negocio == cliente);
        }

    }
}

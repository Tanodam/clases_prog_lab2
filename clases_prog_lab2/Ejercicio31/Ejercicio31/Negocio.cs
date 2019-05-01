using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    class Negocio
    {
        public class Negocio
        {
            private PuestoAtencion caja;
            private Queue<Cliente> clientes;
            private string nombre;

            #region Propiedades

            public Cliente Cliente
            {
                get
                {
                    if (clientes.Count > 0)
                    {
                        return clientes.Dequeue();
                    }
                    else
                    {
                        return new Cliente(0); //Se utiliza el numero 0 para validar cliente inexistente
                    }
                }
                set
                {
                    if (!clientes.Contains(value))
                    {
                        clientes.Enqueue(value);
                    }
                }
            }

            public byte ClientesPendientes
            {
                get
                {
                    return (byte)this.clientes.Count;
                }
            }

            #endregion

            #region Constructores

            private Negocio()
            {
                this.clientes = new Queue<Cliente>();
                this.caja = new PuestoAtencion(Puesto.Caja1);
            }

            public Negocio(string nombre) : this()
            {
                this.nombre = nombre;
            }

            #endregion

            #region Operadores

            public static bool operator !=(Negocio negocio, Cliente cliente)
            {
                return !(negocio == cliente);
            }

            public static bool operator ==(Negocio negocio, Cliente cliente)
            {
                if (negocio.clientes.Contains(cliente))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator ~(Negocio negocio)
            {
                if (negocio.caja.Atender(negocio.Cliente))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator +(Negocio negocio, Cliente cliente)
            {
                foreach (Cliente clienteAux in negocio.clientes)
                {
                    if (clienteAux == cliente)
                    {
                        return false;
                    }
                }
                negocio.clientes.Enqueue(cliente);
                return true;
            }

        }
}

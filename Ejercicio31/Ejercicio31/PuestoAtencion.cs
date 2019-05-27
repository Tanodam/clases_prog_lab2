using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    class PuestoAtencion
    {
        private static int numeroActual = 0;
        private Puesto puesto;


        public enum Puesto
        {
            Caja1,
            Caja2
        }

        public bool Atender(Cliente cli)
        {
            System.Threading.Thread.Sleep(4100);
            numeroActual++;
            return true;
        }
        public static int NumeroActual
        {
            get
            {
                return numeroActual++;
            }
        }
        private PuestoAtencion()
        {
       
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

}
}

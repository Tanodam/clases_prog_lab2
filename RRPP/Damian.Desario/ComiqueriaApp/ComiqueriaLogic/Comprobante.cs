using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComiqueriaLogic;

namespace ComprobantesLogic
{
    public abstract class Comprobante
    {
        internal DateTime fechaEmision;
        private Venta venta;

        #region Propiedades
        /// <summary>
        /// Retorna la venta
        /// </summary>
        internal Venta Venta
        {
            get
            {
                return this.venta;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Constructor de Comprobante
        /// </summary>
        /// <param name="venta"></param>
        public Comprobante(Venta venta)
        {
            this.venta = venta;
            this.fechaEmision = venta.Fecha;
        }
        /// <summary>
        /// Metodo generar comprobante
        /// </summary>
        /// <returns></returns>
        public abstract string GenerarComprobante();
        public override bool Equals(Object obj)
        {
            if(obj is Comprobante)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

    }
}

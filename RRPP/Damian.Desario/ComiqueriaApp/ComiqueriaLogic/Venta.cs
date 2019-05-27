using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public sealed class Venta
    {
        private DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        private Producto producto;
        private int cantidad;
        #region Propiedad
        /// <summary>
        /// Propiedad que retorna la fecha
        /// </summary>
        internal DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
        }
        /// <summary>
        /// Propiedad que retorna la cantidad
        /// </summary>
        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor estatico, fija el porcentajeIva en 21
        /// </summary>
        static Venta()
        {
            porcentajeIva = 21;
        }
        public Venta(int cantidad)
        {
            this.cantidad = cantidad;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Calcula el precio final de una venta
        /// </summary>
        /// <param name="precioUnidad"></param>
        /// <param name="cantidad"></param>
        /// <returns></returns>
        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            //multiplica 30 x 5900 y divide por 100
            double iva = (precioUnidad * cantidad) * (porcentajeIva / 100);
            double precioFinalAux = (precioUnidad * cantidad) + iva;
            return precioFinalAux;
        }
        /// <summary>
        /// Meotodo que devuelve en un solo string toda la info mas necesaria de un prodcuto
        /// </summary>
        /// <returns></returns>
        public string ObtenerDescripcionBreve()
        {
            decimal precioFinalDecimal = Convert.ToDecimal(this.precioFinal);
            return String.Format("Fecha {0} - Descripcion {1} - PrecioFinal ${2}\n", this.Fecha, producto.Descripcion, precioFinalDecimal.ToString("N2"));
        }

        private void Vender(int cantidad)
        {
            int auxiliar = producto.Stock;
            auxiliar = auxiliar - cantidad;
            producto.Stock = auxiliar;
            fecha = DateTime.Now;
            this.precioFinal = Venta.CalcularPrecioFinal(producto.Precio, cantidad);
        }
        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            Vender(cantidad);
        }
        public static explicit operator Producto(Venta venta)
        {
            return venta.producto;
        }
        #endregion


    }
}

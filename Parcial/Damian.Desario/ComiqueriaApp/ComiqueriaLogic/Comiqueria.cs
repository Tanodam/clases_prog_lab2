using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        private List<Producto> productos;
        private List<Venta> ventas;
        #region
        public Producto this[Guid codigo]
        {
            get
            {
                foreach (Producto producto in productos)
                {
                    Guid codigoAux = (Guid)producto;
                    if (codigoAux == codigo)
                    {
                        return producto;
                    }
                }
                return null;
            }
        }
        #endregion Propiedades

        #region Metodos

        /// <summary>
        /// Constructor de istancia
        /// </summary>
        public Comiqueria()
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }
        /// <summary>
        /// Metodo de muestra todas las ventas de la lista ordenadas por fecha.
        /// </summary>
        /// <returns></returns>
        public string ListarVentas()
        {
            StringBuilder datos = new StringBuilder();
            IEnumerable<Venta> listaOrdenada = ventas.OrderBy(fecha => fecha);
            foreach (Venta venta in ventas)
            {
                datos.AppendFormat(venta.ObtenerDescripcionBreve());
            }
            return datos.ToString();
        }
        /// <summary>
        /// Metodo que agrega a un diccionario todos los productos utilizando como clave el codigo y como valor la
        /// descripcion del mismo.
        /// </summary>
        /// <returns></returns>
        public Dictionary<Guid, string> ListarProductos()
        {
            Dictionary<Guid, string> diccionario = new Dictionary<Guid, string>();
            foreach (Producto producto in this.productos)
            {
                diccionario.Add((Guid)producto, producto.Descripcion);
            }
            return diccionario;
        }
        /// <summary>
        /// Sobrecarga del ==
        /// </summary>
        /// <param name="comiqueria"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            foreach (Producto prodcutoAux in comiqueria.productos)
            {
                if (producto.Descripcion.Equals(prodcutoAux.Descripcion))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Sobrecarga del !=
        /// </summary>
        /// <param name="comiqueria"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }
        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="comiqueria"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            if (comiqueria == producto)
            {
                return comiqueria;
            }
            comiqueria.productos.Add(producto);
            return comiqueria;
        }
        /// <summary>
        /// Sobrecarga del metodo Vender que no recibe cantidad y genera la venta de UN solo articulo.
        /// </summary>
        /// <param name="producto"></param>
        public void Vender(Producto producto)
        {
            Vender(producto, 1);
        }
        /// <summary>
        /// Metodo que agrega una nueva venta a la lista de ventas
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="cantidad"></param>
        public void Vender(Producto producto, int cantidad)
        {
            Venta ventaNueva = new Venta(producto, cantidad);
            this.ventas.Add(ventaNueva);

        }
        #endregion
    }
}

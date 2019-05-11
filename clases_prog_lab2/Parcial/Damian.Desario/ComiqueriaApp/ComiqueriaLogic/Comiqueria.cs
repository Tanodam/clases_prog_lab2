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
        public Comiqueria()
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }
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
        public Dictionary<Guid, string> ListarProductos()
        {
            Dictionary<Guid, string> diccionario = new Dictionary<Guid, string>();
            foreach (Producto producto in this.productos)
            {
                diccionario.Add((Guid)producto, producto.Descripcion);
            }
            return diccionario;
        }
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
        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }
        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            if (comiqueria == producto)
            {
                return comiqueria;
            }
            comiqueria.productos.Add(producto);
            return comiqueria;
        }
        public void Vender(Producto producto)
        {
            Vender(producto, 1);
        }
        public void Vender(Producto producto, int cantidad)
        {
            Venta ventaNueva = new Venta(producto, cantidad);
            this.ventas.Add(ventaNueva);

        }
    }
}

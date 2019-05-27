using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComprobantesLogic;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        private List<Producto> productos;
        private List<Venta> ventas;
        static Stack<Comprobante> comprobantes;

        static Comiqueria()
        {
            comprobantes = new Stack<Comprobante>();
        }
        private List<Comprobante> this[Producto producto, bool ordenar]
        {
            get
            {
                List<Comprobante> listaComprobantes = comprobantes.ToList();
                if(ordenar)
                {
                    IEnumerable<Comprobante> listaComprobantesOrdenada = listaComprobantes.OrderBy(fechaEmision => fechaEmision);
                    return listaComprobantes;
                }
                else
                {
                    return listaComprobantes;
                }
            }
        }
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
        public static bool operator ==(Comiqueria comiqueria,Comprobante comprobante)
        {
            return (comprobantes.Contains(comprobante));
        }
        public static bool operator !=(Comiqueria comiqueria, Comprobante comprobante)
        {
            return !(comiqueria == comprobante);
        }
        static bool AgregarComprobante(Comprobante comprobante)
        {
            if(!comprobantes.Contains(comprobante))
            {
                comprobantes.Push(comprobante);
                return true;
            }
            return false;
        }
        private bool AgregarComprobante(Venta venta)
        {
            Factura factura = new Factura(venta, Factura.TipoFactura.B);
            AgregarComprobante(factura);
            return true;

        }
    }
}

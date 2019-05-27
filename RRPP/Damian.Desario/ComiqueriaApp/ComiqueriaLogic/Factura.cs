using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComiqueriaLogic;

namespace ComprobantesLogic
{
    class Factura : Comprobante
    {
        public enum TipoFactura
        {
            A,B,C,E
        };
        private DateTime fechaVecimiento;
        private TipoFactura tipoFactura;

        /// <summary>
        /// Constructor factura
        /// </summary>
        /// <param name="diasParaVencimiento"></param>
        /// <param name="tipoFactura"></param>
        /// <param name="venta"></param>
        public Factura(int diasParaVencimiento, TipoFactura tipoFactura, Venta venta) : base(venta)
        {
            this.fechaVecimiento = DateTime.Now;
            this.fechaVecimiento = fechaVecimiento.AddDays(diasParaVencimiento);
            this.tipoFactura = tipoFactura;

        }
        public Factura(Venta venta, TipoFactura tipoFactura) :this(15,tipoFactura,venta)
        {

        }
        public override bool Equals(Object obj)
        {
            if(obj is Factura)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Genera un comprobante con todos los datos de la venta
        /// </summary>
        /// <returns></returns>
        public override string GenerarComprobante()
        {
            Venta venta = base.Venta;
            Producto producto = (Producto)venta;
            decimal precioUnitario = Convert.ToDecimal(producto.Precio);
            double iva = (producto.Precio * 21) / 100;
            double precioFinal = Convert.ToDouble(precioUnitario) * venta.Cantidad + iva;
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("FACTURA {0}\n\nFecha Emision: {1}\nFecha Vencimiento {2}\nProducto: {3}\nCantidad: {4}\n", this.tipoFactura,this.fechaVecimiento,
                this.fechaVecimiento,producto.Descripcion,venta.Cantidad);
            datos.AppendFormat("Precio Unitario: ${0}\n\nSubtotal{1}\nImporte IVA: ${2}\nImporte Total: ${3}", precioUnitario.ToString("N2"), producto.Precio * venta.Cantidad, producto.Precio, iva, precioFinal);
            return datos.ToString();
        }

    }
}

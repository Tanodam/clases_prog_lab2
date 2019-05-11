using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
        }
        public double Precio
        {
            get
            {
                return this.precio;
            }
        }
        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if (value >= 0)
                {
                    this.stock = (value);
                }
            }
        }
        public static explicit operator Guid(Producto producto)
        {
            return producto.codigo;
        }
        protected Producto(string descripcion, int stock, double precio)
        {
            this.codigo = Guid.NewGuid();
            this.descripcion = descripcion;
            this.stock = stock;
            this.precio = precio;
        }
        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("Descripcion: {0}\n", Descripcion);
            datos.AppendFormat("Codigo: {0}\n", this.codigo);
            datos.AppendFormat("Precio: ${0}\n", Precio);
            datos.AppendFormat("Stock: {0}\n", Stock);

            return datos.ToString();

        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5_Campus
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio = 0;

        public Producto(string marca, string codigoDeBarras, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigoDeBarras;
            this.precio = precio;
        }
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        public static string MostrarProducto(Producto product)
        {
            string datosProducto = "";
            datosProducto += "Marca: "+ product.GetMarca();
            datosProducto += "\nPrecio: " + product.GetPrecio().ToString();
            datosProducto += "\nCodigo de barra: " + (string)product;

            return datosProducto;
        }
        //Console.Write(string(Producto))
        public static explicit operator string(Producto product)
        {
            return product.codigoDeBarra;
        }
        public static bool operator == (Producto productOne, Producto productTwo)
        {
            if(productOne.marca == productTwo.marca && productOne.codigoDeBarra == productTwo.codigoDeBarra)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator !=(Producto productOne, Producto productTwo)
        {
            return productOne != productTwo;//Chequear con ale
        }
        public static bool operator ==(Producto productOne, string marca)
        {
            if (productOne.marca == marca)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Producto productOne, string marca)
        {
            return productOne != marca;
        }
    }
}

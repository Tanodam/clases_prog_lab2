using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5_Campus
{
    class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        public Estante(int cantidad)
        {
            this.productos = new Producto[capacidad];
        }
        public Estante(int cantidad, int ubicacion) : this (capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        public Producto[] GetProductos()
        {
            return this.productos;
        }
        public string MostrarEstante(Estante estante)
        {
            string datosEstante = "";

            foreach(Producto auxiliar in Estante.productos)
            {
                datosEstante += Producto.MostrarProducto(auxiliar);
            }
            return datosEstante;
        }
        public static bool operator !=(Estante estante, Producto product)
        {
            return estante == product;
        }
        public static bool operator ==(Estante estante, Producto product)
        {
            if(estante.productos.Contains(product))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Estante operator -(Estante estante, Producto product)
        {
          
        }
        public static bool operator +(Estante estante, Producto product)
        {
            bool valorRetorno = false;
            if (estante != product)
            {
                for(int i=0; i<capacidad;i++)
                {
                    if(Object.ReferenceEquals(product[i], null))
                    {
                        valorRetorno = true;
                        estante.productos[i] = product;
                        break;
                    }
                }
            }
            return true;
        }
    }
}

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

        public Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        public Producto[] GetProductos()
        {
            return this.productos;
        }
        public static string MostrarEstante(Estante estante)
        {
            string datosEstante = "";

            foreach(Producto auxiliar in estante.productos)
            {
                datosEstante += Producto.MostrarProducto(auxiliar);
            }
            return datosEstante;
        }
        public static bool operator !=(Estante estante, Producto product)
        {
            return !(estante == product);
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
        {;
            if (estante == product)
            {
                for (int i = 0; i < estante.productos.Length; i++)
                {
                    if (Object.ReferenceEquals(estante.productos[i], product))
                    {
                        estante.productos[i] = null;
                        break;
                    }
                }
            }
            return estante;
        }
        public static bool operator +(Estante estante, Producto product)
        {
            bool valorretorno = false;
            if (estante != product)
            {
                for(int i=0; i<estante.productos.Length;i++)
                {
                    if(Object.ReferenceEquals(estante.productos[i], null))
                    {
                        estante.productos[i] = product;
                        valorretorno = true;
                        break;
                    }
                }
            }
            else
            {
                valorretorno = false;
            }
            return valorretorno;
              
        }
    }
}

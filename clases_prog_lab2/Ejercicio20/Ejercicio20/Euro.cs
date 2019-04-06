using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Euro
    {
        private double cantidad = 0;
        private static float cotizRespectoDolar;

        static Euro()
        {
           cotizRespectoDolar = (float)1.16;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, float cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }
        public static float GetCotizacion()
        {
            return cotizRespectoDolar;
        }
        public static explicit operator Dolar(Euro euro)
        {
            return new Dolar(euro.cantidad * Euro.GetCotizacion());
        }
    }
}

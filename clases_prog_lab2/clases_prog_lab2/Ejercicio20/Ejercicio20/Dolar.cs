using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Dolar
    {
        private double cantidad = 0;
        private static float cotizRespectoDolar;

        static Dolar()
        {
           cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, float cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }
        public static float GetCotizacion()
        {
            return cotizRespectoDolar;
        }
        public static explicit operator Euro(Dolar dolar)
        {
            return new Euro(dolar.cantidad / Euro.GetCotizacion());
        }


    }
}

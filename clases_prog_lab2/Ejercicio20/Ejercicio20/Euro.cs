using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Euro
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        static Euro()
        {
            cotizRespectoDolar = (float)1.16;
        }

        public Euro(double cantidad)
        {
            this.cantidad = Math.Round(cantidad, 2);//Esto esta bien???
        }

        public Euro(double cantidad, float cotizacion)
        {
            this.cantidad = cantidad;
            cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return cantidad;
        }

        public static float GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad * Euro.GetCotizacion());
        }

        public static explicit operator Peso(Euro e)
        {
            return new Peso(e.cantidad * Euro.GetCotizacion() / Peso.GetCotizacion());
        }

        public static Euro operator +(Euro e1, Euro e2)
        {
            return new Euro(e1.GetCantidad() + e2.GetCantidad());
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return e + (Euro)d;
        }

        public static Euro operator +(Euro e, Peso p)
        {
            return e + (Euro)p;
        }

        public static Euro operator -(Euro e1, Euro e2)
        {
            return e1 + new Euro(-e2.GetCantidad());
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return e + new Dolar(-d.GetCantidad());
        }

        public static Euro operator -(Euro e, Peso p)
        {
            return e + new Peso(-p.GetCantidad());
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.GetCantidad() == e2.GetCantidad();
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return e == (Euro)d;
        }

        public static bool operator ==(Euro e, Peso p)
        {
            return e == (Euro)p;
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }
    }
}

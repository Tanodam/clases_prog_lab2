using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Dolar
    {
        private double cantidad;

        static Dolar()
        {

        }

        public Dolar(double cantidad)
        {
            this.cantidad = Math.Round(cantidad, 2);
        }

        public double GetCantidad()
        {
            return cantidad;
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad / Euro.GetCotizacion());
        }

        public static explicit operator Peso(Dolar d)
        {
            return new Peso(d.cantidad / Peso.GetCotizacion());
        }

        public static Dolar operator +(Dolar d1, Dolar d2)
        {
            return new Dolar(d1.GetCantidad() + d2.GetCantidad());
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return d + (Dolar)e;
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            return d + (Dolar)p;
        }

        public static Dolar operator -(Dolar d1, Dolar d2)
        {
            return d1 + new Dolar(-d2.GetCantidad());
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return d + new Euro(-e.GetCantidad());
        }

        public static Dolar operator -(Dolar d, Peso p)
        {
            return d + new Peso(-p.GetCantidad());
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.GetCantidad() == d2.GetCantidad();
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return d == (Dolar)e;
        }

        public static bool operator ==(Dolar d, Peso p)
        {
            return d == (Dolar)p;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_22
{
    class NumeroDecimal
    {
        private double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public static implicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);
        }

        public static explicit operator double(NumeroDecimal numeroDecimal)
        {
            return numeroDecimal.numero;
        }
    }
}

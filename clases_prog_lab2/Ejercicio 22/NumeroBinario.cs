using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_22
{
    class NumeroBinario
    {
        private string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public static implicit operator NumeroBinario(string numero)
        {
            return new NumeroBinario(numero);
        }

        public static explicit operator string(NumeroBinario numeroBinario)
        {
            return numeroBinario.numero;
        }

        public static NumeroBinario operator +(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return new NumeroBinario((string)numeroBinario + Conversor.DecimalBinario(numeroDecimal));
        }

        //public static NumeroBinario operator -(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        //{
        //   //TODO
        //}
    }
}

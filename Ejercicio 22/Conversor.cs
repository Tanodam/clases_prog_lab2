﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_22
{
    class Conversor
    {
        public static NumeroBinario DecimalBinario(NumeroDecimal numeroDecimal)
        {
            int i;
            int numero = (int)(double)numeroDecimal;
            string binario = "";
            for (i = 0; numero > 0; i++)
            {
                binario += (numero % 2).ToString();
                numero = numero / 2;
            }
            char[] arrayBinario = binario.ToCharArray();
            Array.Reverse(arrayBinario);
            return new string(arrayBinario);
        }
        public static NumeroDecimal BinarioDecimal(NumeroBinario binario)
        {
            char[] arrayBinario = ((string)binario).ToCharArray();
            Array.Reverse(arrayBinario);
            int numero = 0;
            for (int i = 0; i < arrayBinario.Length; i++)
            {
                if (arrayBinario[i] == '1')
                {
                    if (i == 0)
                    {
                        numero += 1;
                    }
                    else
                    {
                        numero += (int)Math.Pow(2, i);
                    }
                }
            }
            return numero;
        }
    }
}

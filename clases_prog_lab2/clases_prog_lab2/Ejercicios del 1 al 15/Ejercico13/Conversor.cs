using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico13
{
    class Conversor
    {
        public static string DecimalBinario(double nrodecimal)
        {
            String cadena = "";
            if (nrodecimal > 0)
            {
                while (nrodecimal > 0)
                {
                    if (nrodecimal % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }
                    nrodecimal = (int)(nrodecimal / 2);
                }
            }
            else
            {
                if (nrodecimal == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine("Ingrese solo numeros positivos");
                }
            }
            return cadena;
        }

        public static double binariodecimal(string binario)
        {
            char[] array = binario.ToCharArray();
            // Invertido pues los valores van incrementandose de derecha a izquierda: 16-8-4-2-1
            Array.Reverse(array);
            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    // Usamos la potencia de 2, según la posición
                    sum += (int)Math.Pow(2, i);
                }
            }
            return sum;
        }
    }
}

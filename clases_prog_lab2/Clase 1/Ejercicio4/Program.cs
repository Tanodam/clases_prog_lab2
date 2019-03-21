using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;
            int contador = 0;
            int numero;

            for (numero = 1; contador <= 4; numero++)
            {
                for (int j = 1; j < numero; j++)
                {
                    if (numero % j == 0)
                    {
                        acumulador += j;
                    }
                }

                if (acumulador == numero)
                {
                    Console.Write(numero + " es un numero perfecto\n");
                    contador++;
                }
                acumulador = 0;
            }
        }
    }
}

  

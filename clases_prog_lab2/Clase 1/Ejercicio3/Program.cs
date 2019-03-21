using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            int i = 0;
            string numeros;
            do
            {
                Console.WriteLine("Ingrese un numero");
                numeros = Console.ReadLine();
                numero = int.Parse(numeros);
                if (numero <= 0)
                {
                    Console.WriteLine("ERROR! Reingresare il numero per favore");
                }
            } while (numero <= 0);
            for (i = 1; i < (numero + 1); i++)
            {
                if (i > 3 && (i%2 == 0 || i%3 == 0))
                {
                    continue;
                }
               Console.WriteLine(i + " es primo");
            }

            Console.ReadKey();
        }
    }
}

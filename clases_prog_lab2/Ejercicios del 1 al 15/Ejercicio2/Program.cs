using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero = 0;
            double resultado = 0;
            string numeros;
            do
            {
                Console.WriteLine("Ingrese un numero");
                numeros = Console.ReadLine();
                numero = double.Parse(numeros);
                if(numero <= 0)
                {
                    Console.WriteLine("ERROR! Reingresare il numero per favore");
                }
            } while (numero <= 0);

            resultado = Math.Pow(numero, 2);
            Console.WriteLine("El numero elevado al cuadrado es: "+resultado);
            resultado = Math.Pow(numero, 3);
            Console.WriteLine("El numero elevado al cuadrado es: " + resultado);
            Console.ReadKey();
            

        }
    }
}

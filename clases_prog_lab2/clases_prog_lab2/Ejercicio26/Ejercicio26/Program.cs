using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numeros;
            List<int> numerosPositivos;
            List<int> numerosNegativos;
            Random numero = new Random();
            Numeros = new List<int>();
            numerosPositivos = new List<int>();
            numerosNegativos = new List<int>();
            for (int i = 0; i<20; i++)
            {
                Numeros.Add(numero.Next(-100, 100));
            }
            foreach(int num in Numeros)
            {
                Console.WriteLine(num);
                if(num >= 0)
                {
                    numerosPositivos.Add(num);
                }
                else
                {
                    numerosNegativos.Add(num);
                }
            }
            Console.ReadKey();
            Console.Clear();
            numerosPositivos.Sort();
            numerosPositivos.Reverse();
            numerosNegativos.Sort();
            Console.WriteLine("Positivos descreciente");
            foreach (int numPos in numerosPositivos)
            {
                Console.WriteLine(numPos);
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Negativos asecendente");
            foreach (int numNeg in numerosNegativos)
            {

                Console.WriteLine(numNeg);
            }

            Console.ReadKey();

        }
    }
}

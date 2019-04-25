using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";
            int numeros;

            int i;
            int minimo = int.MinValue;
            int maximo = int.MaxValue;
            int total = 0;
            int promedio = 0;
            Console.WriteLine("Ingrese 5 numeros, por favor");

            for (i=0;i<5;i++)
            {
           
                string numerito = Console.ReadLine();
                numeros = int.Parse(numerito);
                if(i == 0)
                {
                    minimo = numeros;
                    maximo = numeros;
                }
                else if(numeros < minimo)
                {
                    minimo = numeros;
                }
                else if (numeros > maximo)
                {
                    maximo = numeros;
                }
                total += numeros;
            }
            promedio = total / 5;
            Console.WriteLine("El numero minimo es:"+minimo);
            Console.WriteLine("El numero maximo es:"+maximo);
            Console.WriteLine("El total es:"+total);
            Console.WriteLine("El promedio es:"+promedio);
            Console.ReadKey();
        }
    }
}

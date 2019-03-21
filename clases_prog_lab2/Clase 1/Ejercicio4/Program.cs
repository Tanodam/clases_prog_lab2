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
            int b;
            int s;
            int a;
            int numero;
            int j;

            Console.Write("Determine hasta que numero desea realizar la busqueda de numeros perfectos: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                b = 0;
                s = i / 2;

                for (j = 1; j <= s; j++)
                {

                    a = i % j;

                    if (a == 0)
                        b = b + j;
                }
                if (b == i)
                    Console.WriteLine("El numero " + i + " es perfecto y su divisores son: " + s);

            }
            Console.ReadKey();
        }
}
}

  

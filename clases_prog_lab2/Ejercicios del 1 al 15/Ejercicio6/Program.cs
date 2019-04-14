using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double startYear;
            double finishYear;

            Console.WriteLine("Ingrese el año de comienzo: ");
            startYear = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el año de finalizacion: ");
            finishYear = double.Parse(Console.ReadLine());

            do
            {
                if ((startYear % 4 == 0) && (startYear % 100 != 0) || (startYear % 400 == 0))
                    {
                    Console.WriteLine(startYear + " es año bisiesto");
                }
                startYear++;
            } while (startYear <= finishYear);
            Console.ReadKey();
        }
    }
}

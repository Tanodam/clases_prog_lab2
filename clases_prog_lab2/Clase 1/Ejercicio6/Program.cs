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
            int startYear;
            int finishYear;

            Console.WriteLine("Ingrese el año de comienzo: ");
            startYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el año de finalizacion: ");
            finishYear = int.Parse(Console.ReadLine());

            do
            {
                if (DateTime.IsLeapYear(startYear))
                    {
                    Console.WriteLine(startYear + " es año bisiesto");
                }
                startYear++;
            } while (startYear <= finishYear);
            Console.ReadKey();
        }
    }
}

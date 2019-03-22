using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime fechaNacimiento;
            DateTime hoy;
            TimeSpan diferencia;
            double diasxbisiesto=0;
         
            int i;

            Console.Write("Ingrese fecha de nacimiento DD/MM/AAAA: ");
            fechaNacimiento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("La fecha de nacimiento es: " + fechaNacimiento);
            // Hoy            
            hoy = DateTime.Now;
            Console.WriteLine("La fecha de hoy es: " + hoy);

            for (i = fechaNacimiento.Year; i <= hoy.Year; i++)
            {
                if (((i % 4 == 0) && (i % 100 != 0)) || (i % 400 == 0))
                {
                    diasxbisiesto++;
                    //Console.WriteLine(diasxbisiesto);
                }
            }

            diferencia = hoy - fechaNacimiento;
            diferencia += (TimeSpan.FromDays(diasxbisiesto));
            
            Console.WriteLine("Los dias de vida vividos son: " + diferencia.Days);
            Console.ReadLine();
        }
    }
}

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

            Console.Write("Ingrese fecha de nacimiento DD/MM/AAAA: ");
            fechaNacimiento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("La fecha de nacimiento es: "+ fechaNacimiento);

            // Hoy            
            hoy = DateTime.Now;
            Console.WriteLine("La fecha de hoy es: "+ hoy);

          
            diferencia = hoy - fechaNacimiento;
            Console.WriteLine("Los dias de vida vividos son: "+ diferencia.Days);
            Console.ReadLine();
        }
    }
}

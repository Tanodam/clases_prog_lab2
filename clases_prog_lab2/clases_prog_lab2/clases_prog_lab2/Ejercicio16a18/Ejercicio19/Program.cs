using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            string cantidadSumas; 
            Sumador sumaUno = new Sumador(1);
            Console.WriteLine(sumaUno.Sumar(8, 2));
            Console.WriteLine(sumaUno.Sumar("Hola", " Mundo"));
            Console.WriteLine(sumaUno.GetCantidadSumas());

            Sumador sumaDos = new Sumador();
            Console.WriteLine(sumaDos.Sumar(8, 2));
            Console.WriteLine(sumaDos.Sumar("Hola", " Mundo"));
            Console.WriteLine(sumaDos.GetCantidadSumas());


            Console.ReadKey();

        }
    }
}

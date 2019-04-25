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
            Sumador sumaUno = new Sumador(1);
            Console.WriteLine("La suma de los numeros es: " + sumaUno.Sumar(8, 2));
            Console.WriteLine(sumaUno.Sumar("Jose", " Luis"));
            Console.WriteLine("La cantidad de sumas es: " + (int)sumaUno);

           // Console.ReadKey();

            Sumador sumaDos = new Sumador();
            Console.WriteLine("La suma de los numeros es: " + sumaDos.Sumar(8, 2));
            Console.WriteLine(sumaDos.Sumar("Hola", " Mundo"));
            Console.WriteLine("La cantidad de sumas es: " + (int)sumaDos);



            Console.WriteLine("La cantidad de sumas totales es : {0}", sumaUno+sumaDos);
            Console.WriteLine("La cantidad de sumas son iguales? : {0}", sumaUno | sumaDos);


            Console.ReadKey();
        }
    }
}

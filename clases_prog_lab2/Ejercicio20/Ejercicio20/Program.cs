using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar dolar = new Dolar(100);
            Euro euro = new Euro(86);
            Peso peso = new Peso(3833);
            Dolar total = dolar + euro + peso;

            Peso luz = new Peso(3833 * 2);
            Euro luzEnEuros = (Euro)luz;
            total -= luzEnEuros;

            if (total.GetCantidad() > 99 && total.GetCantidad() < 101)
            {
                Console.WriteLine(total.GetCantidad());
                Console.WriteLine("Good");
            }
            else
                Console.WriteLine("Bad");

            if (new Euro(100) == (Peso)new Dolar(116))
                Console.WriteLine("Good");
            else
                Console.WriteLine("Bad");

            Console.ReadKey();
        }
    }
}

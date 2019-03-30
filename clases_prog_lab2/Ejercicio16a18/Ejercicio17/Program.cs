using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Boligrafo boligrafoAzul = new Boligrafo(12, ConsoleColor.Blue);
            Boligrafo boligrafoRoja = new Boligrafo(50, ConsoleColor.Red);
            string dibujo;

            boligrafoAzul.Pintar(10, out dibujo);
            boligrafoRoja.Pintar(47, out dibujo);
            boligrafoAzul.Pintar(3, out dibujo);
            boligrafoAzul.Pintar(3, out dibujo);
            boligrafoAzul.Pintar(20, out dibujo);

            Console.ReadKey();
        }
    }
}

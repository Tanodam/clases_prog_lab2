using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace VistaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;
            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);
            EscrituraWrapper eLapiz = miLapiz.Escribir("Hola");
            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);
            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);

            Cartuchera1 cartucheraUno = new Cartuchera1();
            cartucheraUno += miBoligrafo;
            cartucheraUno += miLapiz;

            while(cartucheraUno.ProbarElementos() != false)
            {
                Console.WriteLine("Boligrafo: {0}\nLapiz: {1}", miBoligrafo.UnidadesDeEscritura,miLapiz.UnidadesDeEscritura);
                
            }
            Console.ReadKey();
        }
    }
}

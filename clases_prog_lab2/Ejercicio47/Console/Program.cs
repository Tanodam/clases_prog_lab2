using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio47;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoSuperLiga = new Torneo<EquipoFutbol>("Copita de Leche");
            Torneo<EquipoBasquet> torneoSuperLigaDeBasquet = new Torneo<EquipoBasquet>("Copita de Leche Descremada");
            //Equipos de futtol
            EquipoFutbol racing = new EquipoFutbol("Racing", DateTime.Parse("25 / 03 / 1903"));
            EquipoFutbol independiente = new EquipoFutbol("independiente", DateTime.Parse("01 / 01 / 1905"));
            EquipoFutbol arsenal = new EquipoFutbol("Racing", DateTime.Parse("11 / 02 / 1957"));
            //Equipos de basquet
            EquipoBasquet bocaBasquet = new EquipoBasquet("Boca Basquet", DateTime.Parse("12 / 08 / 1967"));
            EquipoBasquet riverBasquet = new EquipoBasquet("River Basquet", DateTime.Parse("06 / 11 / 1973"));
            EquipoBasquet modeloBasquet = new EquipoBasquet("Modelo Basquet", DateTime.Parse("19 / 05 / 1988"));
            //Agrego equipos al torneo de futbol
            torneoSuperLiga += racing;
            torneoSuperLiga += independiente;
            torneoSuperLiga += arsenal;
            torneoSuperLiga += racing;
            //Agrego equipos al torneo de basquet
            torneoSuperLigaDeBasquet += riverBasquet;
            torneoSuperLigaDeBasquet += bocaBasquet;
            torneoSuperLigaDeBasquet += riverBasquet;
            torneoSuperLigaDeBasquet += modeloBasquet;

            System.Console.WriteLine("EQUIPOS DE FUTBOL");
            System.Console.WriteLine(racing.Ficha());
            System.Console.WriteLine(independiente.Ficha());
            System.Console.WriteLine(arsenal.Ficha());
            System.Console.ReadKey();
            System.Console.Clear();
            System.Console.WriteLine("EQUIPOS DE BASQUET");
            System.Console.WriteLine(bocaBasquet.Ficha());
            System.Console.WriteLine(riverBasquet.Ficha());
            System.Console.WriteLine(modeloBasquet.Ficha());
            System.Console.ReadKey();
            System.Console.Clear();

            System.Console.WriteLine(torneoSuperLiga.CalcularPartido(racing, independiente));
            System.Console.WriteLine(torneoSuperLiga.CalcularPartido(racing, arsenal));
            System.Console.ReadKey();
        }
    }
}

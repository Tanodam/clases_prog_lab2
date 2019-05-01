using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil autoUno = new Automovil(4, 4, VehiculoTerrestre.Color.Azul, 6, 5);
            Automovil autoDos = new Automovil(2, 2, VehiculoTerrestre.Color.Blanco, 5, 2);
            Automovil autoTres = new Automovil(4, 4, VehiculoTerrestre .Color.Rojo, 6, 3);
            Camion camioncito = new Camion(4, 2, VehiculoTerrestre.Color.Gris, 5, 30000);
            Moto laMotitoDeCarlitos = new Moto(2, 0, VehiculoTerrestre.Color.Blanco, 6, 110);

            Console.WriteLine(autoUno.Mostrar());
            Console.WriteLine(autoDos.Mostrar());
            Console.WriteLine(autoTres.Mostrar());
            Console.WriteLine(camioncito.Mostrar());
            Console.WriteLine(laMotitoDeCarlitos.Mostrar());

            Console.ReadKey();
        }
    }
}

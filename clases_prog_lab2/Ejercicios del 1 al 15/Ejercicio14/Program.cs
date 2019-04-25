using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            double ladodelCuadrado = pedirDoublePositivo("Ingrese el lado del cuadrado", "Error!");
            double areaCuadrado = CalculoDeArea.CalcularCuadrado(ladodelCuadrado);
            Console.WriteLine("El area del cuadrado es {0}", areaCuadrado);

            double baseDelTriangulo = pedirDoublePositivo("Ingrese la base del triangulo", "Error!");
            double alturaDelTriangulo = pedirDoublePositivo("Ingrese la altura del triangulo", "Error!");
            double areaTriangulo = CalculoDeArea.CalcularTriangulo(baseDelTriangulo,alturaDelTriangulo);
            Console.WriteLine("El area del triangulo es {0}", areaTriangulo);

            double radioDelCirculo = pedirDoublePositivo("Ingrese el radio del circulo", "Error!");
            double areaDelCirculo = CalculoDeArea.CalcularCirculo(radioDelCirculo);
            Console.WriteLine("El area del cuadrado es {0}", areaDelCirculo);

            Console.ReadKey();
        }




        // PEDIR DOUBLE
        static double pedirDoublePositivo(String mensaje, String mensajeError)
        {
            double numero;
            Console.WriteLine(mensaje);
            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out numero) || numero <= 0)
                {
                    Console.WriteLine(mensajeError);
                }
                else
                    return numero;
            }
        }
    }
}

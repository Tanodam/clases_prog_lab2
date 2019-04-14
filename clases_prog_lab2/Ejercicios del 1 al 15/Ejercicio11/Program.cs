using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int maximo = 0;
            int minimo = 0;
            int sumaTotal = 0;
            double promedio;

            for (int i = 0; i < 10; i++)
            {
                numero = pedirIntEnIntervalo(-100, 100, "Introduzca Numero", "Error");
                if (i == 0 || numero > maximo)
                    maximo = numero;
                if (i == 0 || numero < minimo)
                    minimo = numero;
                sumaTotal = sumaTotal + numero;
            }
            promedio = sumaTotal / 10;
            Console.WriteLine("El maximo es {0}", maximo);
            Console.WriteLine("El minimo es {0}", minimo);
            Console.WriteLine("El promedio es {0}", promedio);
            Console.ReadKey();
        }
        static int pedirIntEnIntervalo(int min, int max, String mensaje, String mensajeError)
        {
            int numero;
            Console.WriteLine(mensaje);
            do
            {
                if (!int.TryParse(Console.ReadLine(), out numero) || !Validacion.Validar(numero, min, max))
                {
                    Console.WriteLine(mensajeError);
                }
                else
                    return numero;
            } while (true);
        }
    }
}

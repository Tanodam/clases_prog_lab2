using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            char continuarSoN;
            int suma = 0;

            do
            {
                numero = pedirIntPositivo("\nIntroduza un numero", "Error!");
                suma =+numero;
                continuarSoN = pedirChar("¿Desea continuar?");
            }while (ValidarRespuesta.ValidaS_N(continuarSoN));
            Console.WriteLine("La suma es {0}", suma);
            Console.ReadKey();
        }
        // PEDIR STRING
        static char pedirChar(String mensaje)
        {
            Console.WriteLine(mensaje);
            return Console.ReadKey().KeyChar;
        }
        // PEDIR INT
        static int pedirIntPositivo(String mensaje, String mensajeError)
        {
            int numero;
            Console.WriteLine(mensaje);
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
                {
                    Console.WriteLine(mensajeError);
                }
                else
                    return numero;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuar = 'n';
            do
            {
            double numeroOne = pedirDoublePositivo("Ingrese el primer numero", "Error!");
            char operando = pedirChar("Ingrese el operando");
            double resultado;

                if (ValidarOperando(operando))
                {
                    double numeroTwo = pedirDoublePositivo("\nIngrese el segundo numero", "Error!");
                    resultado = Calculadora.Calcular(numeroOne, numeroTwo, operando);
                    Console.WriteLine("El resultado de la operacion {0} {1} {2} es {3}", numeroOne, operando, numeroTwo, resultado);
                    continuar = pedirChar("¿Desea continuar?");
                    Console.Clear();
                }
            } while (ValidarS_N(continuar));
            Console.WriteLine("Presione una tecla para cerrar el programa");
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
        // PEDIR STRING
        static char pedirChar(String mensaje)
        {
            Console.WriteLine(mensaje);
            return Console.ReadKey().KeyChar;
        }

        //VALIDAR OPERANDO
        public static bool ValidarOperando(char c)
        {
            if (c == '+' || c == '-' || c == '*' || c == '/')
            {
                return true;

            }
            return false;
        }

        //VALIDAR CHAR
        public static bool ValidarS_N(char c)
        {
            if (c == 's')
            {
                return true;
            }
            return false;
        }

    }
}

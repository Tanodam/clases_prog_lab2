using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico13
{
    class Program
    {
        static void Main(string[] args)
        {
            string decimaltobinary;
            string binarytodecimal;
            double auxiliarDos;
            double auxiliar;
            auxiliar = pedirDoublePositivo("Ingrese un numero: ", "Error!!");
            decimaltobinary = Conversor.DecimalBinario(auxiliar);
            Console.WriteLine(decimaltobinary);

            binarytodecimal = pedirString("Ingrese un numero", "Error!!");
            auxiliarDos = Conversor.binariodecimal(binarytodecimal);
            Console.WriteLine(auxiliarDos);
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
        //PEDIR STRING
        static string pedirString(String mensaje, String mensajeError)
        {
            string binario;
            Console.WriteLine(mensaje);
            binario = Console.ReadLine();

            while (true)
            {
                if (binario.Equals(""))
                {
                    Console.WriteLine(mensajeError);
                }
                else
                    return binario;
            }
        }

    }
}


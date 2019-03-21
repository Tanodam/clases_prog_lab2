using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int aumento = 1;
            int numero;
            int i;
            int j;
            int sumaAtras;
            int sumaAdelante;

            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            while (aumento < numero)
            {

                aumento++;
                sumaAtras = 0;
                sumaAdelante = 0;

                // Calculo para atras
                for (i = 1; i < aumento; i++)
                {
                    sumaAtras = sumaAtras + i;
                    
                }
                //calculo para adelante
                for (j = aumento + 1; j <= sumaAtras; j++)
                {
                    if ((sumaAdelante == sumaAtras) || (sumaAdelante > sumaAtras))
                    {
                        break;
                    }
                        sumaAdelante = sumaAdelante + j;
                }

                // Mostrando en pantalla
                if (sumaAtras == sumaAdelante)
                {
                    Console.WriteLine("Es centro numerico: "+ aumento);
                }
            }
            Console.ReadKey();
        }
    }
}

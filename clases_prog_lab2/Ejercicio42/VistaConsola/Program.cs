using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistaConsola
{
     /*   a.Lanzar una excepción DivideByZeroException en un método estático
        b.Capturar la excepción del punto a en un constructor de instancia y relanzarla hacia otro
        constructor de instancia.
        c.En este segundo constructor, crear una excepción propia llamada UnaException (utilizar
        innerException para almacenar la excepción original) y volver a lanzarla.
        d.Luego crear un método de instancia que capture la excepción anterior. Este método
        generará una excepción propia llamada MiException y la lanzará.
        e.MiException será capturada en el Main, mostrando el mensaje de error que esta almacena
        por pantalla y los mensajes de todas las excepciones almacenadas en sus innerException.*/
    class Program
    {
        static void Main(string[] args)
        {
            ClaseMetodo test;

            try
            {
                test = new ClaseMetodo();
                test.MetodoInstancia(1);
            }
            catch(MiExcepcion excepcion)
            {
                Console.Write(excepcion.Message);

                if (!object.ReferenceEquals(excepcion.InnerException, null))
                {
                    Exception auxiliar = excepcion.InnerException;

                    do
                    {
                        Console.Write(auxiliar.Message);
                        auxiliar = auxiliar.InnerException;

                    } while (!object.ReferenceEquals(auxiliar, null));
                }

                Console.ReadKey();
            }
        }
    }
}

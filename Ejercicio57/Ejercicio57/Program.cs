using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio57
{
    class Program
    {
        static void Main(string[] args)
        {
            /*En el Main instanciar un objeto del tipo Persona e intentar serializarlo.*/
            Persona personaUno = new Persona("Damian", "Desario");
            Persona.Guardar(personaUno);
            /*Luego intentar leer ese objeto serializado en una nueva instancia de persona y lo muestre por pantalla.*/
            Persona personaDos = Persona.Leer();
            Console.Write(personaDos.ToString());
            Console.ReadKey();
        }
    }
}

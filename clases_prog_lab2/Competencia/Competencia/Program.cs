using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competencia
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoF1 autoUno = new AutoF1(1, "Mercedes Benz");
            AutoF1 autoDos = new AutoF1(2, "Ford");
            AutoF1 autoTres = new AutoF1(3, "Toyota");
            Competencia competencia = new Competencia(10, 5);

            if (competencia + autoUno)
            {
                Console.Write("\n{0}", autoUno.MostrarDatos());
            }

            if (competencia + autoDos)
            {
                Console.Write("\n{0}", autoDos.MostrarDatos());
            }

            if (competencia + autoTres)
            {
                Console.Write("\n{0}", autoTres.MostrarDatos());
            }
            Console.WriteLine("\n{0}", competencia.MostrarDatos());

            Console.ReadKey();
        }
    }
}

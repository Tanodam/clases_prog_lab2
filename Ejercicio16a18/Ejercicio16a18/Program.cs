using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16a18
{
    class Program
    {
        static void Main(string[] args)
        {
            string alumnoOne;
            string alumnoTwo;
            string alumnoThree;

            Alumno alumnoUno = new Alumno("Damian","Desario",104327);
            alumnoUno.Estudiar(8, 7);
            Alumno alumnoDos = new Alumno("Alejandro", "Torres", 110987);
            alumnoDos.Estudiar(5, 4);
            Alumno alumnoTres = new Alumno("Lucas Gabriel ", "Planes Saliba",312567);
            alumnoTres.Estudiar(3, 2);

            alumnoUno.calcularFinal();
            System.Threading.Thread.Sleep(200);
            alumnoDos.calcularFinal();
            System.Threading.Thread.Sleep(200);
            alumnoTres.calcularFinal();
            System.Threading.Thread.Sleep(200);

            alumnoOne = alumnoUno.Mostrar();
            Console.WriteLine(alumnoOne);
            Console.ReadKey();
            alumnoTwo = alumnoDos.Mostrar();
            Console.WriteLine(alumnoTwo);
            Console.ReadKey();
            alumnoThree = alumnoTres.Mostrar();
            Console.WriteLine(alumnoThree);
            Console.ReadKey();
        }
    }
}

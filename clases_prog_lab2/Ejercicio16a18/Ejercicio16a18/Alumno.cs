using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16a18
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        private double notaFinal;
        public int legajo = 0;
        public string apellido;
        public string nombre;

 
        public Alumno(string nombre, string apellido, int legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
        }
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }
        public void calcularFinal()
        {
            if (nota1 >= 4 && nota2 >= 4)
            {
                Random rnd = new Random();
                notaFinal = rnd.Next(10);
            }
            else
            {
                notaFinal = -1;
            }
        }
        public string Mostrar()
        {
            string infoAlumno = "El nombre del alumno es " + nombre +' '+ apellido +"\nLegajo: "+legajo+ "\nNota 1: " + nota1 + "\nNota 2: "+nota2;
            if(notaFinal != -1)
            {
                infoAlumno += "\nLa nota final del alumno es: " + notaFinal;
            }
            else
              {
                infoAlumno += "\nEl alumno esta desaprobado";
            }
            return infoAlumno;
        }

    }
}

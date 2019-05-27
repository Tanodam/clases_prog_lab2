using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short anio;
        private Division division;
        private Profesor profesor;

        public string AnioDivision
        {
            get
            {
                return anio + "°" + division.ToString();
            }
        }
        private Curso()
        {
            alumnos = new List<Alumno>();
        }
        public Curso(short anio, Division division, Profesor profesor) : this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }

        public static explicit operator string(Curso c)
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("Curso: "+ c.AnioDivision);
            datos.Append("Profesor: ");
            datos.AppendLine(c.profesor.ExponerDatos());
            datos.AppendLine("\nAlumnos\n");
            foreach (Alumno alumno in c.alumnos)
            {
                datos.AppendLine(alumno.ExponerDatos());
            }
            return datos.ToString();

        }
        public static bool operator ==(Curso c, Alumno a)
        {
            if (c.alumnos != null && a.AnioDivision == c.AnioDivision)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }
        public static Curso operator +(Curso c, Alumno a)
        {
            if(c.alumnos != null && a.Documento != null && c == a)
            {
                c.alumnos.Add(a);
                return c;
            }
            else
            {
                return c;
            }
        }




    }
}

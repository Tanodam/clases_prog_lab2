using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private DateTime fechaIngreso;
        
        public int Antiguedad
        {
            get
            {
                TimeSpan antiguedad = DateTime.Now - fechaIngreso;
                return antiguedad.Days;
            }

        }
        public Profesor(string nombre, string apellido, string documento) : base(nombre, apellido, documento)
        {

        }
        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso) : base(nombre, apellido, documento)
        {
            this.fechaIngreso = fechaIngreso;
        }
        protected override bool ValidarDocumentacion(string doc)
        {
            return true;
        }
        public override string ExponerDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine(base.ExponerDatos());
            datos.AppendLine(Antiguedad.ToString());
            return datos.ToString();
        }
    }
}

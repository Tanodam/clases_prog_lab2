using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class Alumno : Persona
    {
        private short anio;
        private Division division;
        #region Propiedades
        public string AnioDivision
        {
            get
            {
                return this.anio+ "°"+this.division.ToString();
            }
        }
        #endregion
        public Alumno(string nombre, string apellido, string documento, short anio, Division division) : base(nombre, apellido, documento)
        {
            this.anio = anio;
            this.division = division;
        }
        protected override bool ValidarDocumentacion(string doc)
        {
            return true;
        }
        public override string ExponerDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine(base.ExponerDatos());
            //datos.AppendLine(AnioDivision);
            return datos.ToString();
        }

    }
}

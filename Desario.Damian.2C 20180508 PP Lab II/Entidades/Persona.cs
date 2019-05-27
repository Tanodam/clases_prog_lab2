using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Division
    {
        A,
        B,
        C,
        D,
        E,
    };

    abstract public class Persona
    {
        private string apellido;
        private string nombre;
        private string documento;

        #region Propiedades 
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }
        public string Documento
        {
            set
            {
                if(ValidarDocumentacion(value))
                {
                this.documento = (value);

                }
            }
            get
            {
                return this.documento;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        #endregion

        #region Metodos
        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            Documento = documento;
        }
        public virtual string ExponerDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine(Nombre +" "+ Apellido);
            datos.AppendLine("DNI: "+Documento);
            return datos.ToString();
        }
        abstract protected bool ValidarDocumentacion(string doc);
        #endregion

    }
}

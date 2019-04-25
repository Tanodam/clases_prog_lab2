using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private int edad;
        private string nombre;

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }
        public int Dni
        {
            get
            {
                return this.dni;
            }
        }
        public int Edad
        {
            get
            {
                return this.edad;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public Persona (string nombre, string apellido, int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
        }
        public virtual string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append(this.nombre);
            datos.Append("\n" + this.apellido);
            datos.Append("\n" + this.edad);
            datos.Append("\n" + this.dni);
            return datos.ToString();
        }
        public virtual bool ValidarAptitud()
        {
            return true;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio61
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int Id;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }
        public int ID
        {
            get
            {
                return this.Id;
            }
        }
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public Persona(string nombre, string apellido,int id) :this(nombre,apellido)
        {
            this.Id = id;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} {2}", this.ID,this.nombre,this.apellido);
        }
    }
}

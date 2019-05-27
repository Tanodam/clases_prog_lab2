using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    abstract public class Vehiculo
    {
        protected DateTime ingreso;
        private string patente; 

        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                if(value.Length == 6)
                {
                    this.patente = value;
                }
            }
        }

        public Vehiculo(string patente)
        {
            this.ingreso = DateTime.Now.AddHours(-3);
            this.Patente = patente;
        }
        abstract public string ConsultarDatos();
        public override string ToString()
        {
            return string.Format("Patente: {0}", this.patente);
        }
        public virtual string ImprimirTicket()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine(ToString());
            datos.AppendLine("Ingreso: " + this.ingreso.ToString());
            return datos.ToString();
        }
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.Patente == v2.Patente && v1.Equals(v2);
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;
        public Equipo(string nombre, DateTime fecha)
        {
            this.nombre = nombre;
            this.fechaCreacion = fecha;
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public DateTime FechaCreacion
        {
            get
            {
                return this.fechaCreacion;
            }
        }

        public static bool operator ==(Equipo equipoUno, Equipo equipoDos)
        {
            return (equipoUno.nombre == equipoDos.nombre && equipoUno.fechaCreacion == equipoDos.fechaCreacion);
        }
        public static bool operator !=(Equipo equipoUno, Equipo equipoDos)
        {
            return !(equipoUno == equipoDos);
        }
        /*El método Ficha retornará el nombre del equipo y su fecha de creación con el
          siguiente formato “[EQUIPO] fundado el [FECHA]
         */
        public virtual string Ficha()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("{0} fundado el {1}", this.Nombre, this.FechaCreacion.ToShortDateString());
            return datos.ToString();
        }
    }
}

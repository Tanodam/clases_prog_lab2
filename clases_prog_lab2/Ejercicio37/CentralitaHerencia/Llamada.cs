using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

    public enum TipoLlamada
    {
        Local,
        Provincial,
        Todas,
    }
        #region Propiedades

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return this.nroDestino;

            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        #endregion
        #region Metodos
        public Llamada()
        {
        }
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        public string Mostrar()
        {
            StringBuilder datosAMostrar = new StringBuilder();
            datosAMostrar.Append(this.Duracion.ToString());
            datosAMostrar.Append("\t"+this.nroDestino);
            datosAMostrar.Append("\t"+this.nroOrigen);
            return datosAMostrar.ToString();
        }
        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int returnValue = 0;

            if (llamada1.Duracion > llamada2.Duracion)
            {
                returnValue = 1;
            }
            else if (llamada1.Duracion < llamada2.Duracion)
            {
                returnValue = -1;
            }
            return returnValue;
        }
        #endregion


    }
}

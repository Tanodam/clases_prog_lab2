using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public enum TipoLlamada
    {
        Local,
        Provincial,
        Todas,
    }
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        #region Propiedades
        public abstract float CostoLlamada { get; }

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
        public override bool Equals(object obj)
        {
            return (obj is TipoLlamada);
        }
        protected virtual string Mostrar()
        {
            StringBuilder datosAMostrar = new StringBuilder();
            datosAMostrar.Append(this.Duracion.ToString());
            datosAMostrar.Append("\t "+this.nroDestino);
            datosAMostrar.Append("\t "+this.nroOrigen);
            return datosAMostrar.ToString();
        }
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.Duracion > llamada2.Duracion)
                return 1;
            else if (llamada1.Duracion < llamada2.Duracion)
                return -1;
            return 0;
        }
        public static bool operator ==(Llamada llamada1, Llamada llamada2)
        {
            return (llamada1.Equals(llamada2) && llamada1.nroDestino == llamada2.nroDestino && llamada1.nroOrigen == llamada2.nroOrigen);
        }
        public static bool operator !=(Llamada llamada1, Llamada llamada2)
        {
            return !(llamada1 == llamada2);
        }
        #endregion


    }
}

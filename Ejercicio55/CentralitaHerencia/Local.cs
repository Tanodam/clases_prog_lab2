using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada, IGuardar<Local>
    {
        private float costoLlamada;

        #region Propiedades
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public string RutaDelArchivo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        #endregion
        private float CalcularCosto()
        {
            return this.costoLlamada * this.Duracion;
        }

        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
          
        }
        public Local(string origen, float duracion, string destino, float costo)
        {
            this.duracion = duracion;
            this.nroDestino = destino;
            this.nroOrigen = origen;
            this.costoLlamada = costo;
        }
        public override string ToString()
        {
            return Mostrar();
        }
        protected override string Mostrar()
        {
            StringBuilder datosAMostrar = new StringBuilder("");

            datosAMostrar.Append(base.Mostrar());
            datosAMostrar.Append(" "+this.CostoLlamada.ToString());

            return datosAMostrar.ToString();
        }
        public override bool Equals(object obj)
        {
            return (obj is Local);
        }

        public bool Guardar()
        {
            throw new NotImplementedException();
        }

        public Local Leer()
        {
            throw new NotImplementedException();
        }
    }
}

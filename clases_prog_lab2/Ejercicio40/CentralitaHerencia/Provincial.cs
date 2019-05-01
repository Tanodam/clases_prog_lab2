using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{

    public enum Franja
    {
        Franja_1,
        Franja_2,
        Franja_3,
    }
    public class Provincial : Llamada
    {
        private Franja franjaHoraria;

        #region Propiedades

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }


        #endregion

        #region Métodos


        private float CalcularCosto()
        {
            float costoTotal = 0;

            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    costoTotal = (float)(this.Duracion * 0.99);
                    break;
                case Franja.Franja_2:
                    costoTotal = (float)(this.Duracion * 1.25);
                    break;
                case Franja.Franja_3:
                    costoTotal = (float)(this.Duracion * 0.66)  ;
                    break;
            }
            return costoTotal;
        }

        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
        {
            this.duracion = duracion;
            this.nroDestino = destino;
            this.nroOrigen = origen;
        }

        protected override string Mostrar()
        {
            StringBuilder datos = new StringBuilder("");

            datos.Append(base.Mostrar());
            datos.Append(this.CostoLlamada.ToString());
            datos.Append(this.franjaHoraria.ToString());

            return datos.ToString();
        }
        public override bool Equals(object obj)
        {
            return (obj is Provincial);
        }
        public override string ToString()
        {
            return Mostrar();
        }


        #endregion
    }
}

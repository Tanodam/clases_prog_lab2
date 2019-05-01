using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        private string razonSocial;

        #region Propiedades

        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        #endregion

        #region Métodos

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(TipoLlamada tipo) //ANALIZAR DE DONDE VIENE TIPO DE LLAMADA
        {
            float total = 0;
            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                if (llamada is Local && (tipo.Equals(TipoLlamada.Todas) || tipo.Equals(TipoLlamada.Local)))
                {
                    Local local = (Local)llamada;
                    total += local.CostoLlamada;
                }
                if (llamada is Provincial && (tipo.Equals(TipoLlamada.Todas) || tipo.Equals(TipoLlamada.Provincial)))
                {
                    Provincial provincial = (Provincial)llamada;
                    total += provincial.CostoLlamada;
                }
            }
            return total;
        }
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaDeLlamadas.Add(nuevaLlamada);
        }
        public new string Mostrar()
        {
            return ToString();
        }
        public override string ToString()
        {
            StringBuilder datos = new StringBuilder("");

            datos.Append("\nRAZÓN SOCIAL: " + this.razonSocial);
            datos.Append("\nGANANCIAS POR LLAMADAS LOCALES: " + this.CalcularGanancia(TipoLlamada.Local));
            datos.Append("\nGANANCIAS POR LLAMADAS PROVINCIALES: " + this.CalcularGanancia(TipoLlamada.Provincial));
            datos.Append("\nGANANCIA TOTAL: " + this.CalcularGanancia(TipoLlamada.Todas));

            foreach (Llamada llamada in this.Llamadas)
            {
                datos.Append("\n" + llamada.ToString());
            }
            return datos.ToString();
        }
        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        public static Centralita operator +(Centralita centralita, Llamada llamada)
        {
            if (centralita == llamada)
            {
                return centralita;
            }
            centralita.AgregarLlamada(llamada);
            return centralita;
        }
        public static bool operator ==(Centralita centralita, Llamada llamada)
        {
            foreach (Llamada llamadaAux in centralita.listaDeLlamadas)
            {
                if (llamada == llamadaAux)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Centralita centralita, Llamada llamada)
        {
            return !(centralita == llamada);
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CentralitaHerencia
{
    public class Centralita : Llamada
    {
        private List<Llamada> listaDeLlamadas;
        private string razonSocial;

        #region Propiedades

        public float GananciasPorLocal
        {
            get
            {
                float ganancia = 0;

                foreach (Llamada llamada in this.listaDeLlamadas)
                {
                    if(llamada is Local)
                    {
                    Local local = (Local)(llamada);
                    ganancia += local.CostoLlamada;
                    }
                }
                return ganancia;
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                float ganancia = 0;

                foreach (Llamada llamada in this.listaDeLlamadas)
                {
                    if (llamada is Provincial)
                    {
                        Provincial provincial = (Provincial)(llamada);
                        ganancia += provincial.CostoLlamada;
                    }
                }
                return ganancia;
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                float ganancia = 0;

                foreach (Llamada llamada in this.Llamadas)
                {
                    ganancia += this.GananciasPorLocal + this.GananciasPorProvincial;
                }
                return ganancia;
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
            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    return this.GananciasPorLocal;

                case Llamada.TipoLlamada.Provincial:
                    return this.GananciasPorProvincial;

                case Llamada.TipoLlamada.Todas:
                    return this.GananciasPorTotal;
                default:
                    return 0;

            }
        }

        public new string Mostrar()
        {
            StringBuilder datos = new StringBuilder("");


            datos.Append("\nRAZÓN SOCIAL: " + this.razonSocial);
            datos.Append("\nGANANCIAS POR LLAMADAS LOCALES: " + this.CalcularGanancia(TipoLlamada.Local));
            datos.Append("\nGANANCIAS POR LLAMADAS PROVINCIALES: " + this.CalcularGanancia(TipoLlamada.Provincial));
            datos.Append("\nGANANCIA TOTAL: " + this.CalcularGanancia(TipoLlamada.Todas));

            foreach (Llamada llamada in this.Llamadas)
            {
                datos.Append("\n" + llamada.Mostrar());
            }
            return datos.ToString();
        }

        public void OrdenarLlamadas()
        {

        }
        #endregion
    }
}

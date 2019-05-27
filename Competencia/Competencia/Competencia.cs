using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competencia
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadVueltas,short cantidadCompetidores) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }
        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("Cantidad competidores: " + this.cantidadCompetidores);
            datos.AppendLine("Cantidad vueltas: " + this.cantidadVueltas);
            return datos.ToString();
        }
        public static bool operator -(Competencia c, AutoF1 f)
        {
            return true;
        }
        public static bool operator +(Competencia c, AutoF1 f)
        {
            Random rdm = new Random();
            if (c.competidores.Count <= c.cantidadCompetidores && c != f)
            {
                c.competidores.Add(f);
                f.EnCompetencia = true;
                f.VueltasRestantes = c.cantidadVueltas;
                f.CantidadCombustible = Convert.ToInt16(rdm.Next(15,100));
                return true;
            }
            return false;
        }
        public static bool operator ==(Competencia c, AutoF1 f)
        {
            foreach (AutoF1 auto in c.competidores)
            {
                if(auto != f)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Competencia c, AutoF1 f)
        {
            return !(c == f);
        }


    }
}

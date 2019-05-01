using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competencia
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private int numero;
        private short vueltasRestantes;


        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;

        }
        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = (value);
            }
        }
        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = (value);
            }
        }
        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = (value);
            }
        }
        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("Auto n°: "+ this.numero);
            datos.AppendLine("Escuderia: "+ this.escuderia);
            datos.AppendLine("Cantidad combustible"+ CantidadCombustible);
            datos.AppendLine("Vueltas restantes" + VueltasRestantes);
            return datos.ToString();
        }
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            if(a1.numero == a2.numero && a1.escuderia == a2.escuderia)
            {
                return false; 
            }
            return true;
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}

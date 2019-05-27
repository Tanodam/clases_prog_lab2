using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz : IAcciones
    {
        public float tamanioMina;

        #region Propiedades

        public ConsoleColor Color //Preguntar declaracion explicita, problema con ToString
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public float UnidadesDeEscritura // //Preguntar declaracion explicita, problema con ToString
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }

        #endregion

        #region Métodos

        public Lapiz(int unidades)
        {
            this.UnidadesDeEscritura = unidades;
        }

        public override string ToString()
        {
            
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("Es un Lapiz\nColor {0}\nCantidad de tinta {1}", Color, UnidadesDeEscritura);
            return datos.ToString();
        }

        public EscrituraWrapper Escribir(string texto)
        {
            for(int i = 0;i<texto.Length;i++)
            {
                this.tamanioMina -= 0.1f;

            }
            return new EscrituraWrapper(texto, Color);
        }

        bool IAcciones.Recargar(int unidades)
        {
            this.UnidadesDeEscritura = unidades;
            return true;
        }

        #endregion

    }
}

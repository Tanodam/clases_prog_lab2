using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        #region Propiedades

        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }

        #endregion

        #region Métodos

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.Color = color;
            this.UnidadesDeEscritura = unidades;
        }
        /// <summary>
        /// En ambas clases el método ToString retornará un texto informando que es (Lapiz o Boligrafo)
        /// Color de escritura y nivel de tinta.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("Es un Boligrafo\nColor {0}\nCantidad de tinta {1}", this.Color, this.UnidadesDeEscritura);
            return datos.ToString();
        }

        public EscrituraWrapper Escribir(string texto)
        {
            for (int i = 0; i < texto.Length; i++)
            {
                this.tinta -= 0.1f;

            }
            return new EscrituraWrapper(texto, Color);
        }

        public bool Recargar(int unidades)
        {
            this.tinta = unidades;
            return true;
        }

        #endregion

    }
}

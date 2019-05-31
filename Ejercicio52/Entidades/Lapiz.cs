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
        IAcciones iacciones;

        #region Propiedades
        ConsoleColor IAcciones.Color
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
        float IAcciones.UnidadesDeEscritura
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
            iacciones = this;
            iacciones.UnidadesDeEscritura = unidades;
        }

        public override string ToString()
        {
            iacciones = this;
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("Es un Lapiz\nColor {0}\nCantidad de tinta {1}", iacciones.Color , iacciones.UnidadesDeEscritura);
            return datos.ToString();
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            iacciones = this;
            for (int i = 0; i < texto.Length; i++)
            {
                this.tamanioMina -= 0.1f;

            }
            return new EscrituraWrapper(texto, iacciones.Color);
        }

        #endregion

    }
}

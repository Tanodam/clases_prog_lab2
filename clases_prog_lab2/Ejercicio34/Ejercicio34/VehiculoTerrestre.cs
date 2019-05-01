using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    public class VehiculoTerrestre
    {
        public enum Color{ Rojo, Blanco, Azul, Gris, Negro };
        protected short cantidadRuedas;
        protected short cantidadPuertas;
        private short cantidadMarchas;
        protected Color color;

        public VehiculoTerrestre(short ruedas, short puertas, Color color, short marchas)
        {
            this.cantidadRuedas = ruedas;
            this.cantidadPuertas = puertas;
            this.color = color;
            this.cantidadMarchas = marchas;
        }
        public virtual string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("Cant. ruedas: " + this.cantidadRuedas);
            datos.AppendLine("Cant. puertas: " + this.cantidadPuertas);
            datos.AppendLine("Color:" + this.color);
            datos.AppendLine("Marchas: " + this.cantidadMarchas);
            return datos.ToString();
        }
    }
}

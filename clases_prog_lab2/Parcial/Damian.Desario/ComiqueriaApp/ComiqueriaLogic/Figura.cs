using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Figura : Producto
    {
        private double altura;
        /// <summary>
        /// Constructor que inicializa todos los campos con los parametros de entrada
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="stock"></param>
        /// <param name="precio"></param>
        /// <param name="altura"></param>
        public Figura(string descripcion, int stock, double precio, double altura) : base(descripcion, stock, precio)
        {
            this.altura = altura;
        }
        /// <summary>
        /// Sobrecarga del constructor, no recibe Descripcion ppero lo reemplaza con "Figura *altura* cm"
        /// </summary>
        /// <param name="stock"></param>
        /// <param name="precio"></param>
        /// <param name="altura"></param>
        public Figura(int stock, double precio, double altura) : this("Figura" + altura + "cm", stock, precio, altura)
        {
        }
        /// <summary>
        /// Sobreescritura del metodo ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append(base.ToString());
            datos.AppendFormat("Altura: {0} cm\n", this.altura);
            return datos.ToString();
        }
    }
}

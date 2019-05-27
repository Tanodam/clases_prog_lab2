using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic : Producto
    {
        /// <summary>
        /// Enumerado de tipos de comics
        /// </summary>
        public enum TipoComic
        {
            Occidental, Oriental
        };
        private string autor;
        private TipoComic tipoComic;

        /// <summary>
        /// Constructor que inicializa todos los campos con los parametros de entrada
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="stock"></param>
        /// <param name="precio"></param>
        /// <param name="autor"></param>
        /// <param name="tipoComic"></param>
        public Comic(string descripcion, int stock, double precio, string autor, TipoComic tipoComic) : base(descripcion, stock, precio)
        {
            this.autor = autor;
            this.tipoComic = tipoComic;
        }
        /// <summary>
        /// Sobrescarga del metodo ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append(base.ToString());
            datos.AppendFormat("Autor: {0}\n", this.autor);
            datos.AppendFormat("Tipo Comic: {0}\n", this.tipoComic.ToString());

            return datos.ToString();
        }
    }
}

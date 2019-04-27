using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas
{
    abstract public class Mascota
    {
        private string nombre;
        private string raza;

        #region Propiedades
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public string Raza
        {
            get
            {
                return this.raza;
            }
        }
        #endregion
        #region Metodos
        abstract public string Ficha();
        virtual protected string DatosCompletos()
        {
            return string.Format("Nombre: {0} {1}", Nombre, Raza);
        }
        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }
        #endregion
    }
}

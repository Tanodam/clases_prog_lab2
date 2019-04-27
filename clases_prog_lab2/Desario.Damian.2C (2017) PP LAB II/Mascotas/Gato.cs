using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas
{
    public class Gato : Mascota
    {
        public override string Ficha()
        {
            return string.Format(base.DatosCompletos());
        }
        public Gato(string nombre, string raza) : base(nombre, raza)
        {

        }
        public static bool operator ==(Gato j1, Gato j2)
        {
            if(j1.Nombre == j2.Nombre && j2.Raza == j1.Raza)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Gato j1, Gato j2)
        {
            return !(j1 == j2);
        }
        public override string ToString()
        {
            return Ficha();
        }
    }
}

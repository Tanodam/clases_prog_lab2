using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio38
{
    public abstract class Sobreescrito
    {
        protected string miAtributo;

        public Sobreescrito()
        {
            this.miAtributo = "Probar abstractos";
        }

        public string MiAtributo
        {
            get
            {
                return this.miAtributo;
            }
        }
        public abstract string miMetodo();

        public override string ToString()
        {
            return "¡Este es mi método ToString sobreescrito!";
        }
        public override bool Equals(object obj)
        {
            return (obj is Sobreescrito);
        }
        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}

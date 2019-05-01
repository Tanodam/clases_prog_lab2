using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio38
{
    public class SobreSobreescrito : Sobreescrito
    {
        public override string miMetodo()
        {
            return MiAtributo;
        }

    }
}

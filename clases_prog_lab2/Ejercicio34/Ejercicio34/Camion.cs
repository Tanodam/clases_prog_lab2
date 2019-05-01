using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    public class Camion : VehiculoTerrestre
    {
        int pesoCarga;
        public Camion(short ruedas, short puertas, Color color, short marchas, int pesoCarga) : base(ruedas,puertas,color,marchas)
        {
            this.pesoCarga = pesoCarga;
        }
        public override string Mostrar()
        {
            return base.Mostrar();
        }

    }
}

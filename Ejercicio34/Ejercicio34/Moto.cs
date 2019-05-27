using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    public class Moto : VehiculoTerrestre
    {
        int cilindrada;
        public Moto(short ruedas, short puertas, Color color, short marchas, int cilindrada) : base(ruedas, puertas, color, 0)
        {
            this.cilindrada = cilindrada;
        }
        public override string Mostrar()
        {
            return base.Mostrar();
        }

    }
}

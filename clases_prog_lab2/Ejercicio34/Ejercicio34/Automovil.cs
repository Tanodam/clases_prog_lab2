using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    public class Automovil : VehiculoTerrestre
    {
        int cantidadPasajeros;
        public Automovil(short ruedas, short puertas, Color color, short marchas, int cantidadPax) : base(ruedas, puertas, color, marchas)
        {
            this.cantidadPasajeros = cantidadPax;
        }
        public override string Mostrar()
        {
            return base.Mostrar();
        }

    }
}

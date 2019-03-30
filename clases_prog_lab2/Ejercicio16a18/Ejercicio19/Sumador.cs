using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Sumador
    {
        private int cantidadSumas = 0;

        public Sumador (int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }
        public Sumador () : this (0)
        {
        }
        public long Sumar (long numeroUno, long numeroDos)
        {
            cantidadSumas++;
            return numeroUno + numeroDos;
        }
        public string Sumar(string stringUno, string stringDos)
        {
            this.cantidadSumas++;
            return stringUno + stringDos;
        }

        public int GetCantidadSumas()
        {
            return this.cantidadSumas;
        }

    }
}

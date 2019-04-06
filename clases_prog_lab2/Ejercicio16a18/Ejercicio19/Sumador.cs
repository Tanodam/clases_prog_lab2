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
           cantidadSumas++;
           return stringUno + stringDos;
        }

        public static explicit operator int(Sumador suma)
        {
            return suma.cantidadSumas;
        }
        public static long operator +(Sumador sumaUno, Sumador sumaDos)
        {
            long total = sumaUno.cantidadSumas + sumaDos.cantidadSumas;
            return total;
        }
        public static bool operator |(Sumador sumaUno, Sumador sumaDos)
        {
            if(sumaUno.cantidadSumas == sumaDos.cantidadSumas)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}

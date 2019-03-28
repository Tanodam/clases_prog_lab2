using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double ladoCuadrado)
        {
            double resultado = ladoCuadrado * ladoCuadrado;
            return resultado;

        }
        public static double CalcularTriangulo(double sabe, double altura)
        {
            double resultado = sabe * altura;
            return resultado;
        }
        public static double CalcularCirculo(double radio)
        {
            double area;
            double pi;

            pi = Convert.ToDouble(3.1416);
            area = pi * radio * radio;
            return area;
        }
    }
}

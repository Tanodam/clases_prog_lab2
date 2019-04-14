using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Calculadora
    {
        public static double Calcular(double numeroUno, double numeroDos, char operando)
        {
            double resultado = 0;
            if (operando != '/' && operando == '+')
            {
                resultado = numeroUno + numeroDos;
            }
            if (operando != '/' && operando == '-')
            {
                resultado = numeroUno - numeroDos;
            }
            if (operando != '/' && operando == '*')
            {
                resultado = numeroUno * numeroDos;
            }
            if (operando == '/' && Validar(numeroDos))
            {
                resultado = numeroUno / numeroDos;
            }

            return resultado;

        }

        private static bool Validar(double divisor)
        {
            if (divisor != 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}

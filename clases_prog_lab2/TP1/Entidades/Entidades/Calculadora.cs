using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Calculadora
    {
        /// <summary>
        /// Metodo Operar
        /// </summary>
        /// <param name="num1">Numero Uno recibido</param>
        /// <param name="num2">Numero Dos recibido</param>
        /// <param name="operador">Operador a utilizar</param>
        /// <returns>Resultado de la operacion solicitada</returns>
        public static string Operar(Numero num1, Numero num2, string operador)
        {
            double resultado = 0.0;

            switch (operador)
            {

                case "+":
                    {//SUMA
                        resultado = num1 + num2;
                        break;
                    }
                case "-":
                    {//RESTA
                        resultado = num1 - num2;
                        break;
                    }
                case "*":
                    {//MULTIPLICACION
                        resultado = num1 * num2;
                        break;
                    }
                case "/":
                    {//DIVISION
                        if (num2 == 0.0) // Se valida que no se divida por 0.
                        {
                            break;
                        }
                        else
                        {
                            resultado = num1 / num2;
                            break;
                        }
                    }
            }
            return Convert.ToString(resultado);
        }
        private static string ValidarOperador(string operador)
        {
            string operadorValido = "";
            switch (operador)
            {
                case "+":
                    {
                        operadorValido = operador;
                        break;
                    }
                case "-":
                    {
                        operadorValido = operador;
                        break;
                    }
                case "*":
                    {
                        operadorValido = operador;
                        break;
                    }
                case "/":
                    {
                        operadorValido = operador;
                        break;
                    }
                default:
                    {
                        operadorValido = "+";
                        break;
                    }
            }
            return operadorValido;
        }
    }
}

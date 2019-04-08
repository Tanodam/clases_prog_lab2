using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Numero
    {
        private double numero = double.MinValue;

        //Constructor por defecto, asigna 0 al valor inicial de numero
        public Numero()
        {
            numero = 0.0;
        }
        //Constructor propio, asigna el valor pasado por parametro al valor inicial de numero, conviertiendolo a double antes
        public Numero(string numero)
        {
            Double.TryParse(numero, out this.numero);
        }
        public double SetNumero
        {
            set
            {
                double num = ValidarNumero(Convert.ToString(value));
                this.numero = num;
            }
        }
        /// <summary>
        ///  comprobará que el valor recibido sea numérico, y lo retornará en formato double. Caso contrario, retornará 0
        /// </summary>
        /// <param name="strNumero">Numero recibido que hay que validar</param>
        /// <returns>numero validado</returns>
        private static double ValidarNumero(string strNumero)
        {
            //Se inicializa el valor de numero en 0.0 y solo se cambiara si la conversion a Double fue correcta, caso
            //contratio retornara 0;
            double numero = 0.0;

            if (Double.TryParse(strNumero, out numero))
            {
                return numero;
            }
            else
            {
                return numero;
            }
        }

        /// <summary>
        /// Metodo que recibe un string con un numeor binario y lo transforma a a un numero del tipo entero
        /// </summary>
        /// <param name="binario">string con el nuevo binario</param>
        /// <returns></returns>
        public string BinarioDecimal(string binario)
        {
            char[] array = binario.ToCharArray();
            // Invertido pues los valores van incrementandose de derecha a izquierda: 16-8-4-2-1
            Array.Reverse(array);
            string retorno = "";
            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    // Usamos la potencia de 2, según la posición
                    sum += (int)Math.Pow(2, i);
                    retorno = Convert.ToString(sum);
                }
                else
                {
                    retorno = "Valor invalido";
                }
            }
            return retorno;
        }

        /// <summary>
        /// Recibe un numero en formato double y lo convierte a binario
        /// </summary>
        /// <param name="numero">Numero recibido para convertirlo</param>
        /// <returns>Numero convertido o valor invalido si la conversion falla</returns>
        public static string DecimalBinario(double numero)
        {
            //Convierte el double en string para hacer el TryParse a int
            string numerostr = Convert.ToInt32(numero).ToString();
            int num = 0;
            if (int.TryParse(numerostr,out num))
            {
                return Convert.ToString(num, 2);
            }
            else
            {
                return "Valor invalido";
            }
        }

        /// <summary>
        /// Recibe un numero decimal en formato string y lo convierte a binario
        /// </summary>
        /// <param name="numero">Numero recibido para convertirlo</param>
        /// <returns>Numero convertido o valor invalido si la conversion falla</returns>
        public string DecimalBinario(string numero)
        {
            if (numero.All(Char.IsNumber))
            {
                int num = 0;
                Int32.TryParse(numero, out num);
                return Convert.ToString(num, 2);
            }
            else
            {
                return "Valor invalido";
            }
        }
        
        //SOBRECARGA DEL OPERADOR + PARA PODER PODER SUMAR DOS OBJETOS DEL TIPO NUMERO
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        //SOBRECARGA DEL OPERADOR - PARA PODER PODER RESTAR DOS OBJETOS DEL TIPO NUMERO
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        //SOBRECARGA DEL OPERADOR * PARA PODER PODER MULTIPLICAR DOS OBJETOS DEL TIPO NUMERO
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        //SOBRECARGA DEL OPERADOR / PARA PODER PODER DIVIDIR DOS OBJETOS DEL TIPO NUMERO
        public static double operator /(Numero n1, Numero n2)
        {
            return n1.numero / n2.numero;
        }

        //SOBRECARGA DEL OPERADOR == PARA PODER PODER COMPARAR DOS OBJETOS DEL TIPO NUMERO
        public static bool operator ==(Numero n1, double numero)
        {
            return n1.numero == numero;
        }

        //SOBRECARGA DEL OPERADOR != PARA PODER PODER COMPARAR DOS OBJETOS DEL TIPO NUMERO
        public static bool operator !=(Numero n1, double numero)
        {
            return n1.numero != numero;
        }
    }
}

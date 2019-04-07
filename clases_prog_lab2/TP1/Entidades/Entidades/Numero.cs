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


        public Numero()
        {
            numero = 0.0;
        }
        public Numero(double numero)
        {
            this.numero = numero;
        }
        public Numero(string numero)
        {
            Double.TryParse(numero, out this.numero);
        }
        public double SetNumero
        {
            set
            {
                double num = ValidarNumero(Convert.ToString(value));
                numero = num;
            }
        }
        private static double ValidarNumero(string strNumero)
        {
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
        public string BinarioDecimal(string binario)
        {
            string num = Convert.ToInt32(binario, 2).ToString();
            if(num.All(Char.IsNumber))
            {
                return num;
            }
            else
            {
                return "Valor invalido";
            }

        }
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
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            return n1.numero / n2.numero;
        }

        public static bool operator ==(Numero n1, double numero)
        {
            return n1.numero == numero;
        }
        public static bool operator !=(Numero n1, double numero)
        {
            return n1.numero != numero;
        }
    }
}

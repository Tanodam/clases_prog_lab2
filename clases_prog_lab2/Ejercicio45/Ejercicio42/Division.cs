using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    public class Division
    {
        double resultado;
        public Division(int numeroUno, int numeroDos)
        {
            try
            {
                if (numeroDos == 0)
                {
                    throw new DivideByZeroException();
                }
                else
                {
                    this.resultado = numeroUno / numeroDos;
                }
            }
            catch (DivideByZeroException e)
            {
                throw e;
            }
    

        }
        public Division(int numeroUno, double numeroDos) : this(numeroUno,Convert.ToInt32(numeroDos))
        {
            try
            {
                Division division = new Division(10, 0);

            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("ERRRRRRRRRRRRRRROR");
            }
        }
    }
}

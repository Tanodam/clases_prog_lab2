using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia<VehiculoCarrera> competencia = new Competencia<VehiculoCarrera>(20, 5, TipoCompetencia.F1);
            MotoCross motoUno = new MotoCross(3, "Mercedes Benz");
            AutoF1 autoUno = new AutoF1(7, "Fiat 8000");
            AutoF1 autoDos = new AutoF1(12, "Toyota");

            try
            {
                motoUno.EnCompetencia = false; //esta moto no es de la competencia para disparar la ecepcion
                if(competencia + motoUno)
                {
                    Console.Write("Agregado");
                }

                if (competencia + motoUno)
                {
                    Console.Write("Agregado");
                }
            }
            catch(CompetenciaNoDisponibleException exception)
            {
                Console.Write(exception.Message);
            }
            Console.ReadKey();
        }
    }
}

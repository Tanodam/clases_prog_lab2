using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Empleado
    {
        int horasTrabajadas;
        string nombre;
        int antiguedad;

        int calculoMensual()
        {
            int horasDelMes = 24 * 30;
            return horasTrabajadas * horasDelMes;
        }

        Boolean setHorasTrabajadas(int valorHoras);
        {}
         Boolean setNombre(string auxNombre)
        {}
        Boolean setAnios(int años)
        {}

        Boolean getHorasTrabajadas()
        {}
        Boolean getNombre()
        {}
        Boolean getAnios()
        {}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera2
    {
        private List<Lapiz> listaLapices;
        private List<Boligrafo> listaBoligrafo;

        bool flag = true;

        #region Metodos
        /// <summary>
        /// i. Se deberá recorrer la lista y gastará 1 unidades de cada elemento.
        ///ii.Cuando sea necesario, recargará antes de salir del método.
        ///iii.Retornará true si todos los bolígrafos pudieron gastar exactamente las 1 unidades.
        /// </summary>
        /// <returns></returns>
        public bool ProbarElementos()
        {
            if (listaLapices is List<Lapiz>)
            {

                foreach (IAcciones elemento in this.listaLapices)
                {
                    if (elemento.UnidadesDeEscritura != 0)
                    {
                        elemento.UnidadesDeEscritura -= 1;
                    }
                    else
                    {
                        elemento.Recargar(1);
                        flag = false;
                    }

                }
                if (flag)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                foreach (IAcciones elemento in this.listaBoligrafo)
                {
                    if (elemento.UnidadesDeEscritura != 0)
                    {
                        elemento.UnidadesDeEscritura -= 1;
                    }
                    else
                    {
                        elemento.Recargar(1);
                        flag = false;
                    }

                }
                if (flag)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        #endregion
    }
}

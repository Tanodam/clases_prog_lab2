using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera1
    {
        private List<IAcciones> lista;
        bool flag = true;

        public Cartuchera1()
        {
            lista = new List<IAcciones>();
        }

        #region Metodos
        public static Cartuchera1 operator +(Cartuchera1 cartuchera, IAcciones elemento)
        {
            cartuchera.lista.Add(elemento);
            return cartuchera;
        }
        /// <summary>
        /// i. Se deberá recorrer la lista y gastará 1 unidades de cada elemento.
        ///ii.Cuando sea necesario, recargará antes de salir del método.
        ///iii.Retornará true si todos los bolígrafos pudieron gastar exactamente las 1 unidades.
        /// </summary>
        /// <returns></returns>
        public bool ProbarElementos()
        {
            foreach (IAcciones elemento in this.lista)
            {
                if (elemento.UnidadesDeEscritura > 0)
                {   
                    elemento.UnidadesDeEscritura -= 1;
                }
                else
                {
                    elemento.Recargar(1);
                    flag = false;
                }

            }
            if(flag)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;
        public Torneo(string nombre)
        {
            this.nombre = nombre;
            this.equipos = new List<T>();
        }

        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            foreach (Equipo team in torneo.equipos)
            {
                if(team == equipo)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }
        public static Torneo<T> operator +(Torneo<T> torneo, T equipo)
        {
            if(torneo != equipo)
            {
                torneo.equipos.Add(equipo);
            }
            return torneo;
        }
        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("Nombre del torneo:" + this.nombre);
            foreach (Equipo equipo in this.equipos)
            {
                datos.AppendLine();
            }
            return datos.ToString();
        }
        /*6. El método privado CalcularPartido(T, T): string recibirá dos elementos del tipo
            T, que deberán ser del tipo Equipo o sus herencias, y calculará utilizando
            Random un resultado del partido. Retornará el resultado con el siguiente
            formato: “[EQUIPO1] [RESULTADO1] – [RESULTADO2] [EQUIPO2]”, siendo
            EQUIPOX el nombre del equipo y RESULTADOX la cantidad de goles/puntos.*/
        public string CalcularPartido (T equipoUno, T equipoDos)
        {
            StringBuilder datos = new StringBuilder();
            Random resultado = new Random();
            datos.AppendFormat("{0} {1} - {2} {3}", equipoUno.Nombre, resultado.Next(0, 10), resultado.Next(0,10), equipoDos.Nombre);
            return datos.ToString();
        }
        public void JugarPartido()
        {
            Random seleccion = new Random();

            CalcularPartido(this.equipos.ElementAt(seleccion.Next(0, equipos.Count)), this.equipos.ElementAt(seleccion.Next(0, equipos.Count)));
        }
        
    }
}

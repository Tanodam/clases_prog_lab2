using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        DirectorTecnico directorTecnico;
        private List<Jugador> listaJugadores;
        private string nombre;

        public DirectorTecnico DirectorTecnico
         {
            set
            {
                if(value.ValidarAptitud())
                {
                    this.DirectorTecnico = value;
                }
            }
         }
        public string Nombre
        {
            get
            {
                return this.nombre; 
            }
        }
        private Equipo()
        {

        }
        public Equipo (string nombre)
        {
            this.nombre = nombre;
        }

        public static explicit operator string(Equipo e)
        {
            StringBuilder datos = new StringBuilder();

            datos.Append(e.nombre);
            if (e.directorTecnico != null)
            {
                datos.AppendLine(e.directorTecnico.Mostrar());
            }
            else
            {
                datos.AppendLine("Sin DT asignado");
            }
            foreach (Jugador jugador in e.listaJugadores)
            {
                datos.AppendLine(jugador.Mostrar());
            }
            
            return datos.ToString();
        }
        public static Equipo operator +(Equipo e, Jugador j)
        {
            if(e == j && e.listaJugadores.Count > Equipo.cantidadMaximaJugadores && !j.ValidarAptitud())
            {
                return e;
            }
            else
            {
                return e + j;
            }
        }
        public static bool operator == (Equipo e, Jugador j)
        {
            if(e.listaJugadores.Contains(j))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static bool ValidarEquipo (Equipo e)
        {
            bool arquero = false;
            bool central = false;
            bool defensor = false;
            bool delantero = false;
            int contadorArquero = int.MinValue;
            foreach (var jugador in e.listaJugadores)
            {
                if(jugador.Posicion is Posicion.Arquero)
                {
                     arquero = true;
                    contadorArquero++;
                }
                if (jugador.Posicion is Posicion.Central)
                {
                     central = true;
                }
                if (jugador.Posicion is Posicion.Defensor)
                {
                     defensor = true;
                }
                if (jugador.Posicion is Posicion.Delantero)
                {
                     delantero = true;
                }
            }
            if (e.directorTecnico != null && delantero && central 
                && defensor && arquero && contadorArquero == 1 && 
                e.listaJugadores.Count() == Equipo.cantidadMaximaJugadores)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

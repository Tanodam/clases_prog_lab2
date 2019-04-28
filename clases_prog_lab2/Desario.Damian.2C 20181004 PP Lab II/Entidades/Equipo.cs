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
        private DirectorTecnico directorTecnico;
        private List<Jugador> listaJugadores;
        private string nombre;

        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if (value.ValidarAptitud())
                {
                    this.directorTecnico = (value);
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
        public Equipo(string nombre)
        {
            this.nombre = nombre;
            listaJugadores = new List<Jugador>();
        }

        public static explicit operator string(Equipo e)
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine(e.nombre);
            if (e.directorTecnico != null)
            {
                datos.AppendLine(e.directorTecnico.Mostrar());
            }
            else
            {
                datos.AppendLine("Sin DT asignado");
            }
            if (e.listaJugadores != null)
            {
                foreach (Jugador jugador in e.listaJugadores)
                {
                    datos.AppendLine(jugador.Mostrar());
                }

            }

            return datos.ToString();
        }
        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e.listaJugadores != null && e != j && e.listaJugadores.Count < Equipo.cantidadMaximaJugadores && j.ValidarAptitud())
            {
                e.listaJugadores.Add(j);
                return e;
            }
            else
            {
                return e;
            }
        }
        public static bool operator ==(Equipo e, Jugador j)
        {
            if (e.listaJugadores != null)
            {
                return e.listaJugadores.Contains(j);
            }
            else
            {
                return false;
            }

        }
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static bool ValidarEquipo(Equipo e)
        {
            bool arquero = false;
            bool central = false;
            bool defensor = false;
            bool delantero = false;
            int contadorArquero = int.MinValue;
            if(e.listaJugadores != null)
            {

                foreach (Jugador jugador in e.listaJugadores)
                {
                    if (jugador.Posicion is Posicion.Arquero)
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

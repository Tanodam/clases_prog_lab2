using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad,string nombre): this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }
        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e.jugadores.Contains(j) || e.jugadores.Count >= e.cantidadDeJugadores)
            {
                return e;
            }
            e.jugadores.Add(j);
            return e;
        }
    }
}

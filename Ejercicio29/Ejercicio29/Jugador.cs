using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.dni = 0;
            this.nombre = "";
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }
        public Jugador(int dni, string nombre)
        {
            this.nombre = nombre;
            this.dni = dni;
        }
        public Jugador(int dni, string nombre, int totalGoles,int totalPartidos) :this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }
        public float GetPromedioGoles()
        {
            return this.totalGoles / partidosJugados;
        }
        public virtual string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("DATOS DEL JUGADOR");
            datos.AppendLine("Nombre: " + this.nombre);
            datos.AppendLine("DNI: " + this.dni);
            datos.AppendLine("Promedio G/P:" + GetPromedioGoles());
            return datos.ToString();
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            if(j1.dni == j2.dni)
            {
                return false;
            }
            return true;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }

}

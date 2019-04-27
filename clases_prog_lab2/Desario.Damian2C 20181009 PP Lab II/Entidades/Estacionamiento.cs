using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        private Estacionamiento()
        {
            vehiculos = new List<Vehiculo>();
        }
        public Estacionamiento(string nombre, int espacioDisp) : this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisp;
        }
        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            foreach (Vehiculo vehiculoLista in estacionamiento.vehiculos)
            {
                if (vehiculoLista == vehiculo)
                {
                    return true;

                }
            }
            return false;
        }
        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }
        public static explicit operator string(Estacionamiento estacionamiento)
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine(estacionamiento.nombre);
            datos.Append(estacionamiento.espacioDisponible.ToString());
            foreach (Vehiculo vehiculo in estacionamiento.vehiculos)
            {
                datos.AppendLine(vehiculo.ConsultarDatos());
            }
            return datos.ToString();
        }
        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento != vehiculo && vehiculo.Patente != null && vehiculo.Patente.Length == 6&&
                estacionamiento.espacioDisponible > estacionamiento.vehiculos.Count)
            {
                estacionamiento.vehiculos.Add(vehiculo);
                return estacionamiento;
            }
            else
            {
                return estacionamiento;
            }
        }
        public static string operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            foreach (Vehiculo vehiculoLista in estacionamiento.vehiculos)
            {
                if (vehiculoLista == vehiculo)
                {
                    estacionamiento.vehiculos.Remove(vehiculoLista);
                    return vehiculo.ImprimirTicket();

                }
            }
            return "El vehículo no es parte del estacionamiento";

        }
    }
}

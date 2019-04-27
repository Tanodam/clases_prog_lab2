using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        static int valorHora;

        static Automovil()
        {
            valorHora = 50;
            
        }
        public Automovil(string patente, ConsoleColor color) : base(patente)
        {
            this.color = color;
        }
        public Automovil(string patente, ConsoleColor color, int valorHoraNuevo) : this(patente, color)
        {
            valorHora = valorHoraNuevo;
        }
        public override string ConsultarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("Patente: " + this.Patente);
            datos.AppendLine("Color: " + this.color.ToString());
            datos.AppendLine("Ingreso: " + base.ingreso.ToString());
            return datos.ToString();
        }
        public override bool Equals(object obj)
        {
            return obj is Automovil;

        }
        public override string ImprimirTicket()
        {
            TimeSpan diferencia = DateTime.Now - ingreso;
            int diferenciaInt = Convert.ToInt32(diferencia.Hours);
            diferenciaInt = diferenciaInt * valorHora;
            StringBuilder datos = new StringBuilder();
            datos.Append(base.ImprimirTicket());
            datos.AppendLine("Valor Hora: " + valorHora);
            datos.AppendLine("Costo: " + diferenciaInt.ToString());
            return datos.ToString();
        }
    }
}

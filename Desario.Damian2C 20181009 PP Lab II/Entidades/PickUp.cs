using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
    {
        private string modelo;
        static int valorHora;

        static PickUp()
        {
            valorHora = 70;

        }
        public PickUp(string patente, string modelo) : base(patente)
        {
            this.modelo = modelo;
        }
        public PickUp(string patente, string modelo, int valorHoraNuevo) : this(patente, modelo)
        {
            valorHora = valorHoraNuevo;
        }
        public override string ConsultarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("Patente: " + this.Patente);
            datos.AppendLine("Modelo: " + this.modelo);
            datos.AppendLine("Ingreso: " + base.ingreso.ToString());
            return datos.ToString();
        }
        public override bool Equals(object obj)
        {
            return obj is PickUp;
        }
        public override string ImprimirTicket()
        {
            TimeSpan diferencia = DateTime.Now - ingreso;
            int diferenciaInt = Convert.ToInt32(diferencia.Hours);
            diferenciaInt = diferenciaInt * valorHora;
            StringBuilder datos = new StringBuilder();
            datos.Append(base.ImprimirTicket());
            datos.AppendLine("Valor Hora: $" + valorHora);
            datos.AppendLine("Costo: $"+ diferenciaInt.ToString());
            return datos.ToString();
        }
    }
}

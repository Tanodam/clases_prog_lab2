using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        static int valorHora;

        static Moto()
        {
            valorHora = 30;
        }
        public Moto(string patente, int cilindrada) : base(patente)
        {
            this.cilindrada = cilindrada;
            this.ruedas = 2;
        }
        public Moto(string patente, int cilindrada, short ruedas) : this(patente, cilindrada)
        {
            this.ruedas = ruedas;
        }
        public Moto(string patente, int cilindrada, short ruedas, int valorHoraNew) : this(patente, cilindrada,ruedas)
        {
            valorHora = valorHoraNew;
        }

        public override string ConsultarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("Patente: " + base.Patente);
            datos.AppendLine("Ruedas: " + this.ruedas.ToString());
            datos.AppendLine("Cilindrada: " + this.cilindrada.ToString());
            datos.AppendLine("Ingreso: " + base.ingreso.ToString());
            return datos.ToString();
        }
        public override bool Equals(object obj)
        {
            return obj is Moto;
        }
        public override string ImprimirTicket()
        {
            TimeSpan diferencia = DateTime.Now - ingreso;
            int diferenciaInt = Convert.ToInt32(diferencia.Hours);
            diferenciaInt = diferenciaInt * valorHora;
            StringBuilder datos = new StringBuilder();
            datos.Append(base.ImprimirTicket());
            datos.AppendLine("Valor Hora: $" + valorHora);
            datos.AppendLine("Costo: $" + diferenciaInt.ToString());
            return datos.ToString();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class MEspecialista : Medico, IMedico
    {
        public enum Especialidad
        {
            Traumatologo, Odontologo
        };
        private Especialidad especialidad;
        public MEspecialista(string apellido, string nombre, Especialidad especialidad) : base(nombre, apellido)
        {
            this.especialidad = especialidad;
        }
        public void IniciarAtencionPaciente(Paciente paciente)
        {
            Thread hiloAtender = new Thread(this.Atender);
            base.AtenderA = paciente;
            hiloAtender.Start();
        }

        protected override void Atender()
        {
            Thread.Sleep(tiempoAletorio.Next(5000, 10000));
            base.FinalizarAtencion();
        }

    }
}

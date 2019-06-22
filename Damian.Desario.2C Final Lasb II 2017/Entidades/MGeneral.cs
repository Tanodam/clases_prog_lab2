using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class MGeneral : Medico, IMedico
    {
        public MGeneral(string apellido, string nombre) : base(apellido, nombre)
        {

        }
        public void IniciarAtencionPaciente(Paciente paciente)
        {
            Thread hiloAtender = new Thread(this.Atender);
            base.AtenderA = paciente;
            hiloAtender.Start();
        }

        protected override void Atender()
        {
            Thread.Sleep(tiempoAletorio.Next(1500, 2200));
            base.FinalizarAtencion();
        }

    }
}

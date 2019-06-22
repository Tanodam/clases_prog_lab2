using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void FinAtencionPaciente(Paciente paciente, Medico medico);
    public abstract class Medico : Persona
    {
        public event FinAtencionPaciente AtencionFinalizada;

        private Paciente pacienteActual;
        protected static Random tiempoAletorio;

        public Paciente AtenderA
        {
            set
            {
                this.pacienteActual = value;
            }
        }
        public virtual string EstaAtendiendoA
        {
            get
            {
                return pacienteActual.ToString();
            }
        }
        protected abstract void Atender();
        protected void FinalizarAtencion()
        {
            if (AtencionFinalizada != null)
            {
                AtencionFinalizada(this.pacienteActual, this);
                pacienteActual = null;
            }
        }

        static Medico()
        {
            tiempoAletorio = new Random();
        }
        public Medico(string nombre, string apeliido) : base(apeliido, nombre)
        {

        }
        public override string ToString()
        {
            return String.Format("Medico {0}, {1}", this.nombre, this.apellido);
        }
    }
}

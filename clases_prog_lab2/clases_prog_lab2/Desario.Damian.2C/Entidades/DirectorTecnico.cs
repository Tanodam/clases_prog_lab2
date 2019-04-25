using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private int añosExpericiencia;

        public int AñosExperiencia
        {
            get
            {
                return this.añosExpericiencia;
            }
            set
            {
                this.añosExpericiencia = value;
            }
        }

       public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia) : base(nombre, apellido, edad, dni)
        {
            this.añosExpericiencia = añosExperiencia;
        }
        public override string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append(base.Mostrar());
            datos.Append("\nAños experiencia" + this.añosExpericiencia);
            return datos.ToString();
        }
        public override bool ValidarAptitud()
        {
            bool retorno = false;
            if(this.Edad < 65 && this.añosExpericiencia >= 2)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}

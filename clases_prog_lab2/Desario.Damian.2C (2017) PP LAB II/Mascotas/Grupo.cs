using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas
{
    public enum TipoManada
    {
        Unica,
        Mixta,
    };
    class Grupo
    {
        List<Mascota> manada;
        string nombre;
        TipoManada tipo;

        public TipoManada Tipo
        {
            set
            {
                this.tipo = (value);    
            }
        }
        public Grupo()
        {
            Tipo = TipoManada.Unica;
            this.manada = new List<Mascota>();
        }
        public Grupo (string nombre) : this()
        {
            this.nombre = nombre;
        }
        public Grupo (string nombre, TipoManada tipo) : this(nombre)
        {
            Tipo = tipo;
        }
        public static bool operator ==(Grupo e, Mascota j)
        {
            if(e.manada != null && e.manada.Contains(j))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Grupo e, Mascota j)
        {
            return !(e == j);
        }
        public static Grupo operator +(Grupo e, Mascota j)
        {
            if(e.manada != null && e != j)
            {
                e.manada.Add(j);
                return e;
            }
            else
            {
                return e;
            }
        }
        public static Grupo operator -(Grupo e, Mascota j)
        {
            if (e.manada != null && e == j)
            {
                e.manada.Remove(j);
                return e;
            }
            else
            {
                return e;
            }
        }
        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine(this.nombre + " " +this.tipo);
            foreach (Mascota mascota in this.manada)
            {
                datos.AppendLine(mascota.Ficha());
            }
            return datos.ToString();
        }

    }


}

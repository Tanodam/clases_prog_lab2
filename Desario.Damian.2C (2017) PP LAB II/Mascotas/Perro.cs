using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas
{
    public class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;

    #region Propiedades
    public int Edad
    {
        set
        {
            this.edad = (value);
        }
        get
        {
            return this.edad;
        }
    }
    public bool EsAlfa
    {
        set
        {
            this.esAlfa = (value);
        }
        get
        {
            return this.esAlfa;
        }
    }
        #endregion
        #region Metodos
        public Perro(string nombre, string raza) : base(nombre,raza)
        {
            Edad = 0;
            EsAlfa = false;
        }
        public Perro(string nombre, string raza, int edad, bool esAlfa) : base(nombre, raza)
        {
            Edad = edad;
            EsAlfa = esAlfa;
        }
        public override string Ficha()
        {
            if(EsAlfa)
            {
                return string.Format(base.DatosCompletos()+ " alfa de la manada, edad {0}", Edad);
            }
            else
            {
                return string.Format(base.DatosCompletos() + " edad {0}", Edad);
            }
        }
        public static explicit operator int(Perro perro)
        {
            return perro.Edad;
        }
        public static bool operator ==(Perro j1, Perro j2)
        {
            if(j1.Nombre == j2.Nombre && j1.Edad == j2.Edad && j1.Raza == j2.Raza)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Perro j1, Perro j2)
        {
            return !(j1 == j2);
        }
        public override string ToString()
        {
            return Ficha();
        }
        #endregion
    }
}

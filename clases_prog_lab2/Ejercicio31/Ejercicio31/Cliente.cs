using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    class Cliente
    {
        private string nombre;
        private int numero;


        public string Nombre
        {
            set
            {
                this.nombre = value;
            }
            get
            {
                return nombre;
            }
        }
        public int Numero
        {
            get
            {
                return numero;
            }
        }
        public Cliente(int numero)
        {
        
        }
        public Cliente(int numero, string nombre) : this(numero)
        {
           
        }
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.numero == c2.numero;
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return (c1.numero != c2.numero);
        }

    }
}

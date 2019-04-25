using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        public float Altura
        {
            get
            {
                return this.altura;
            }

        }
        public float Peso
        {
            get
            {
                return this.peso;
            }

        }
        public Posicion Posicion
        {
            get
            {
                return this.posicion;
            }

        }
        public Jugador (string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion) : base(nombre, apellido, edad, dni)
        {
            this.peso = peso;
            this.altura = altura;
            this.posicion = posicion;
        }
        public override string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append(base.Mostrar());
            datos.Append("\nPeso" + this.peso);
            datos.Append("\nAltura" + this.altura);
            datos.Append("\nPosicion" + this.posicion);
            return datos.ToString();
        }
        public override bool ValidarAptitud()
        {
            bool retorno = false;
            if (this.Edad < 40 && ValidarEstadoFisico())
            {
                retorno = true;
            }
            return retorno;
        }
        public bool ValidarEstadoFisico()
        {
            bool retorno = false;
            double imc = 0;
            imc = this.Peso / Math.Pow(this.Altura, 2);
            if(imc >= 18.5 && imc <= 25)
            {
                retorno = true;
            }
            return retorno;
            
        }
    }
}

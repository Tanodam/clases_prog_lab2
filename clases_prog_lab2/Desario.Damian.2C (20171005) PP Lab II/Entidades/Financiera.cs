using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class Financiera
    {
        private List<Prestamo> listaDePrestamos;
        private string razonsocial;
        float acumulador;

       #region Propiedades
        public float InteresEnDolares
        {
            get
            {
                return 
            }
        }
        public float InteresEnPesos
        {
            get
            {
                foreach (PrestamoPesos prestamo in listaDePrestamos)
                {
                    return prestamo.Interes;
                }
                return 0;
            }
        }
        public float InteresTotales
        {
            get
            {
                return InteresEnDolares + InteresEnPesos;
            }
        }
        public List<Prestamo> ListaDePrestamos
        {
            get
            {
                return listaDePrestamos;
            }
        }
        public string RazonSocial
        {
            get
            {
                return this.razonsocial;
            }
        }
        #endregion
        private Financiera()
        {
            listaDePrestamos = new List<Prestamo>();
        }
        public Financiera(string razonsocial) : this()
        {
            this.razonsocial = razonsocial;
        }
        public static explicit operator string(Financiera financiera)
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("Razon Social: {0}\nTotal Intereses Dolar: U$s{1}\nTotal Intereses Pesos: ${2}\nTotal Intereses: ${3}",
                financiera.RazonSocial,financiera.InteresEnDolares,financiera.InteresEnPesos,financiera.InteresTotales);
            foreach (Prestamo prestamo in financiera.listaDePrestamos)
            {
                datos.AppendLine(prestamo.Mostrar());
            }
            return datos.ToString();
        }
        public static string Mostrar()
        {
            return "";
        }
        public void OrdenarPrestamos()
        {
            IEnumerable<Prestamo> listaOrdenada = ListaDePrestamos.OrderBy(fecha => fecha.Vencimiento);
        }
        private float CalcularInteresGanado(TipoDePrestamo tipoDePrestamo)
        {
            return InteresTotales;
        }
        public static Financiera operator +(Financiera f, Prestamo p)
        {
            if(f != p)
            {
                return f;
            }
            f.listaDePrestamos.Add(p);
            return f;
        }
        public static bool operator ==(Financiera f, Prestamo p)
        {
            if(!f.listaDePrestamos.Contains(p))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Financiera f, Prestamo p)
        {
            return !(f == p);
        }
    }
}

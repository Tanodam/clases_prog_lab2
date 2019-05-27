using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales  
{
    public enum  PeriocidadDePagos
    {
        Mensual,
        Bimestral,
        Trimestral
    };
    public enum TipoDePrestamo
    {
        Pesos,
        Dolares,
        Todos
    };
    abstract public class Prestamo
    {
        protected float monto;
        private DateTime vencimiento;

        #region Propiedades
        public float Monto
        {
            get
            {
                return this.monto;
            }
        }
        public DateTime Vencimiento
        {
            set
            {
                if(value > DateTime.Now)
                {
                 this.vencimiento = value;
                }
                else
                {
                    this.vencimiento = DateTime.Now;
                }
            }
            get
            {
                return this.vencimiento;
            }
        }
        #endregion
        public Prestamo(float monto, DateTime vencimiento)
        {
            this.monto = monto;
            Vencimiento = vencimiento;
        }
        abstract public void ExtenderPlazo(DateTime nuevoVencimiento);
        public virtual string Mostrar()
        {
            return string.Format("Monto: ${0} \nVencimiento: {1}",Monto,Vencimiento);
        }
        public static int OrdenarPorFecha(Prestamo p1, Prestamo p2)
        {
            return 1;
        }
    }
}

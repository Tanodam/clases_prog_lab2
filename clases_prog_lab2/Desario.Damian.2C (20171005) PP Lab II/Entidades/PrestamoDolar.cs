using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoDolar : Prestamo
    {
        private PeriocidadDePagos periocidad;

        #region Propiedades
         public float Interes
        {
            get
            {
                if(periocidad is (PeriocidadDePagos)0)
                {
                    return 25;
                }
                else if (periocidad is (PeriocidadDePagos)1)
                {
                    return 35;
                }
                return 40;
            }
        }
        public PeriocidadDePagos Periocidad
        {
            get
            {
                if (periocidad is (PeriocidadDePagos)0)
                {
                    return PeriocidadDePagos.Mensual;
                }
                else if (periocidad is (PeriocidadDePagos)1)
                {
                    return PeriocidadDePagos.Bimestral;
                }
                return PeriocidadDePagos.Trimestral;
            }
        }
        #endregion
        public PrestamoDolar(float monto, DateTime vencimiento, PeriocidadDePagos periocidad) : base(monto,vencimiento)
        {
            this.periocidad = periocidad;
        }
        private float CalcularInteres()
        {
            return monto + monto*Interes/100;
        }
        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            TimeSpan diferenciaDias = nuevoVencimiento.Date - base.Vencimiento.Date;
            for(int i=0;i<diferenciaDias.Days;i++)
            {
                base.monto=+ (float)2.5;
            }
        }
        public override string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine(base.Mostrar());
            datos.AppendFormat("Periocidad del pago: {0}  Interes: {1}", periocidad, Interes);
            return datos.ToString();
        }


    }
}

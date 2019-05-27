using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoPesos : Prestamo
    {
        private float porcentajeInteres;

        public float Interes
        {
            get
            {
                return this.porcentajeInteres;
            }
        }
        public PrestamoPesos(float monto, DateTime vencimiento, float porcentajeInteres) : base(monto, vencimiento)
        {
            this.porcentajeInteres = porcentajeInteres;
        }
        private float CalcularInteres()
        {
            return monto + monto * Interes / 100;
        }
        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            this.porcentajeInteres = this.porcentajeInteres * (float)0.25 / 100;
        }
        public override string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine(base.Mostrar());
            datos.AppendFormat("Interes: {0}", Interes);
            return datos.ToString();
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio48;

namespace VistaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura,Recibo> contabilidad = new Contabilidad<Factura,Recibo>();
            Recibo recibo1 = new Recibo();
            Recibo recibo2 = new Recibo(1586940);
            Recibo recibo3 = new Recibo(0000001);
            Factura factura1 = new Factura(1586940);
            Factura factura2 = new Factura(00000041);
            Factura factura3 = new Factura(0);
        }
    }
}

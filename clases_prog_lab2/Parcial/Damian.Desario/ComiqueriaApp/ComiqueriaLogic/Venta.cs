using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
  sealed class Venta
  {
    private DateTime fecha;
    private static int porcentajeIva;
    private double precioFinal;
    private Producto producto;

    protected DateTime Fecha
    {
      get
      {
        return this.fecha;
      }
    }
    /// <summary>
    /// Calcula el precio final de una venta
    /// </summary>
    /// <param name="precioUnidad"></param>
    /// <param name="cantidad"></param>
    /// <returns></returns>
    public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
    {
      //multiplica 30 x 5900 y divide por 100
      double precioFinalAux = precioUnidad * cantidad;
      precioFinalAux = (porcentajeIva * precioFinalAux) / 100;
      return precioFinalAux;
    }
    public string ObtenerDescripcionBreve()
    {
      return String.Format("fecha {0} - descripcion {1} - precioFinal {2}", this.Fecha, producto.Descripcion, Math.Round(precioFinal, 2));
    }
    private void Vender(int cantidad)
    {//Me guardo el valor de stock en un aux
      int stockAux = producto.Stock;
      stockAux -= cantidad;
      producto.Stock = stockAux;
      fecha = DateTime.Now;
      this.precioFinal = CalcularPrecioFinal(producto.Precio, cantidad);
    }
    static Venta()
    {
      porcentajeIva = 21;
    }
    internal Venta(Producto producto, int cantidad)
    {
      this.producto = producto;
      Vender(cantidad);
    }
    

  }
}

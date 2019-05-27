using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
  public class Figura : Producto
  {
    private double altura;

    public Figura(string descripcion, int stock, double precio, double altura) : base(descripcion, stock, precio)
    {
      this.altura = altura;
    }
    public Figura(int stock, double precio, double altura) : this("Figura" + altura + "cm", stock, precio, altura)
    {

    }
    public override string ToString()
    {
      StringBuilder datos = new StringBuilder();
      datos.Append(base.ToString());
      datos.AppendFormat("Altura: {0} cm\n", this.altura);
      return datos.ToString();
    }
  }
}

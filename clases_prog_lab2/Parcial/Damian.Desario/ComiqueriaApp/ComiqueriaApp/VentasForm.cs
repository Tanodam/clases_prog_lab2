using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic;

namespace ComiqueriaApp
{
  public partial class VentasForm : Form
  {
    Producto producto;
    public VentasForm()
    {
      InitializeComponent();
    }
    public VentasForm(Producto producto)
    {
      this.producto = producto;
    }

    private void VentasForm_Load(object sender, EventArgs e)
    {
      lblDescription.Text = this.producto.Descripcion;
 
    }

  }
}

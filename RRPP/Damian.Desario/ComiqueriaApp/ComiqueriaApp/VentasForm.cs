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
        Comiqueria comiqueria;
        public VentasForm()
        {
            InitializeComponent();
        }
        public VentasForm(Producto producto, Comiqueria comiqueria) : this()
        {
            this.producto = producto;
            this.comiqueria = comiqueria;
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            lblDescription.Text = this.producto.Descripcion;
            lblPrecioFinal.Text = "PrecioFinal: $" + producto.Precio;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Modificando el maximo NO se permite que el usuario puede seleccionar una cantidad mayor al stock
            numericUpDownCantidad.Maximum = producto.Stock;
            double precioFinal = Venta.CalcularPrecioFinal(producto.Precio, (int)numericUpDownCantidad.Value);
            decimal precioFinalDecimal = Convert.ToDecimal(precioFinal);
            lblPrecioFinal.Text = "PrecioFinal: $" + precioFinalDecimal.ToString("N2");
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (numericUpDownCantidad.Value <= producto.Stock)
            {
                comiqueria.Vender(producto, (int)numericUpDownCantidad.Value);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Supero el stock, debe disminuir la cantidad de unidades"
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

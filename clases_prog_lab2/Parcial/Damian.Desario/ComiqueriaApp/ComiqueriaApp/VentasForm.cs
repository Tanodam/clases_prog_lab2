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
        /// <summary>
        /// Construcor que recibe la comiqueria y el producto que se va a vender
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="comiqueria"></param>
        public VentasForm(Producto producto, Comiqueria comiqueria) : this()
        {
            this.producto = producto;
            this.comiqueria = comiqueria;
        }
        /// <summary>
        /// Carga del formulario, muestra el nombre del producto y el precio inicial por UNA unidad.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VentasForm_Load(object sender, EventArgs e)
        {
            lblDescription.Text = this.producto.Descripcion;
            lblPrecioFinal.Text = "PrecioFinal: $" + producto.Precio;

        }
        /// <summary>
        /// Metodo que actualiza el precio final de la compra a medida que se modifican las cantidades de unidades
        /// en la compra.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            double precioFinal = Venta.CalcularPrecioFinal(producto.Precio, (int)numericUpDownCantidad.Value);
            decimal precioFinalDecimal = Convert.ToDecimal(precioFinal);
            lblPrecioFinal.Text = "PrecioFinal: $" + precioFinalDecimal.ToString("N2");
        }
        /// <summary>
        /// Metodo que realiza la venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVender_Click(object sender, EventArgs e)
        {
            if (numericUpDownCantidad.Value <= producto.Stock)
            {
                comiqueria.Vender(producto, (int)numericUpDownCantidad.Value);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Se superó el stock de unidades, disminuir la cantidad que desea comprar"
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Cierra el formulario Vender.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

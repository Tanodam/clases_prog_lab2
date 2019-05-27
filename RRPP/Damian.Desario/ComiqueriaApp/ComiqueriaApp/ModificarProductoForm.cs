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
    public partial class ModificarProductoForm : Form
    {
        Producto producto;
        public ModificarProductoForm()
        {
            InitializeComponent();
        }
        public ModificarProductoForm(Producto producto) : this()
        {
            this.producto = producto;
        }
        /// <summary>
        /// Metodo que carga el form de modificar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModificarProductoForm_Load(object sender, EventArgs e)
        {
            double precioActual = producto.Precio;
            decimal precioActualDecimal = Convert.ToDecimal(precioActual);
            txtPrecioActual.Text = precioActualDecimal.ToString("N2");
            lblDescripcion.Text = producto.Descripcion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            double precioNuevo;
            if(double.TryParse(txtNuevoPrecio.Text,out precioNuevo))
            {
                DialogResult result = MessageBox.Show("Desea confirmar el cambio de precio?", "CAMBIO PRECIO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                     producto.Precio = precioNuevo;
                    
                }
                else
                {
                    this.DialogResult = DialogResult.No;
                }
            }
            else
            {
                lblError.Text = "Error. Debe ingresar un precio valido";
            }


        }

        private void txtNuevoPrecio_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
        }
    }
}

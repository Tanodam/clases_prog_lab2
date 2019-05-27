using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class FrmPickup : Form
    {
        public FrmPickup()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            PickUp camioneta = new PickUp(txtBoxPatente.Text, txtBoxModelo.Text);
            MessageBox.Show(camioneta.ConsultarDatos());
        }
    }
}

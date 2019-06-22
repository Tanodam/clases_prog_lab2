using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Entidades;

namespace Damian.Desario._2_C
{
    public partial class frmPpal : Form
    {
        LosHilos hilos;
        public frmPpal()
        {
            InitializeComponent();
            hilos = new LosHilos();
            hilos.AvisoFinn += this.MostrarMensajeFin;
        }
        private void btnLanzar_Click(object sender, EventArgs e)
        {
            try
            {
                hilos += 1;
            }
            catch (CantidadInvalidaException exception)
            {
                MessageBox.Show(exception.Message, "ERROR", MessageBoxButtons.OK);
            }
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            MessageBox.Show(hilos.Bitacora, "MOSTRAR BITACORA", MessageBoxButtons.OK);
        }
        public void MostrarMensajeFin(string mensaje)
        {
            MessageBox.Show(mensaje, "MOSTRAR MENSAJE", MessageBoxButtons.OK);
        }

    }
}

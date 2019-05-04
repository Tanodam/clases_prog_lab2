using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace CentralitaForm
{
    public partial class FrmMenu : Form
    {
        Centralita centralita = new Centralita();
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void botonGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador frmLlamdor = new FrmLlamador(centralita);
            frmLlamdor.ShowDialog();
            centralita = frmLlamdor.Centralita;
        }

        private void botonFacturacionTotal_Click(object sender, EventArgs e)
        {
            if(ReferenceEquals(centralita, null))
            {
              MessageBox.Show("No se cargo ninguna llamada","ERROR",MessageBoxButtons.OK);
            }
            else
            {

            FrmMostrar frmMostrar = new FrmMostrar(centralita, TipoLlamada.Todas);
            frmMostrar.ShowDialog();
            }
            
        }
        private void botonFacturacionLocal_Click(object sender, EventArgs e)
        {
            if (ReferenceEquals(centralita, null))
            {
                MessageBox.Show("No se cargo ninguna llamada", "ERROR", MessageBoxButtons.OK);
            }
            else
            {

                FrmMostrar frmMostrar = new FrmMostrar(centralita, TipoLlamada.Local);
                frmMostrar.ShowDialog();
            }
        }

        private void botonFacturacionProvincial_Click(object sender, EventArgs e)
        {
            if (ReferenceEquals(centralita, null))
            {
                MessageBox.Show("No se cargo ninguna llamada", "ERROR", MessageBoxButtons.OK);
            }
            else
            {

                FrmMostrar frmMostrar = new FrmMostrar(centralita, TipoLlamada.Provincial);
                frmMostrar.ShowDialog();
            }
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

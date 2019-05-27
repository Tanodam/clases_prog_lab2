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
    public partial class FormDT : Form
    {
        DirectorTecnico dt;

        public FormDT()
        {
            InitializeComponent();
        }

        private void FormDT_Load(object sender, EventArgs e)
        {
            numericUpDownEdad.Value = 0;
            numericUpDownDni.Value = 0;
            numericUpDownExperiencia.Value = 0;
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            dt = new DirectorTecnico(txtBoxNombre.Text, txtBoxApellido.Text, (int)numericUpDownEdad.Value,
                (int)numericUpDownDni.Value, (int)numericUpDownExperiencia.Value);

                 MessageBox.Show("Un DT ha sida creado!");
            
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (dt == null)
            {
                MessageBox.Show("No se cargo ningun DT");
            }
            else if (dt.ValidarAptitud())
            {
                MessageBox.Show("El DT es apto");
            }
            else
            {
                MessageBox.Show("El DT no es apto");
            }
        }
    }
}

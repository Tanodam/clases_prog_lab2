using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio61
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public void Limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Persona> personas = PersonaDAO.Leer();
            foreach (Persona persona in personas)
            {
                lstPersonas.Items.Add(persona);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(!(String.IsNullOrEmpty(txtNombre.Text)) || !(String.IsNullOrEmpty(txtApellido.Text)))
            {
                PersonaDAO.Guardar(txtNombre.Text, txtApellido.Text);
                MessageBox.Show("Persona agregada con exito","AGREGAR", MessageBoxButtons.OK);
                this.btnLeer_Click(sender, e);
                this.Limpiar();
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            lstPersonas.Items.Clear();
            List<Persona> personas = PersonaDAO.Leer();
            foreach (Persona persona in personas)
            {
                lstPersonas.Items.Add(persona);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Persona personaSeleccionada = (Persona)lstPersonas.SelectedItem;
            if(personaSeleccionada != null && !(String.IsNullOrEmpty(txtNombre.Text)) && !(String.IsNullOrEmpty(txtApellido.Text)))
            {
                 PersonaDAO.Modificar(new Persona(txtNombre.Text, txtApellido.Text, personaSeleccionada.ID));
                 this.btnLeer_Click(sender,e);
                this.Limpiar();
            }
            else
            {
                MessageBox.Show("NO SE HA ELEGIDO NINGUNA PERSONA", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
           
        }

        private void lstPersonas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Persona personaSeleccionada = (Persona)lstPersonas.SelectedItem;
            if (personaSeleccionada != null)
            {
                txtNombre.Text = personaSeleccionada.Nombre;
                txtApellido.Text = personaSeleccionada.Apellido;
            }
            else
            {
                MessageBox.Show("NO SE HA ELEGIDO NINGUNA PERSONA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Persona personaSeleccionada = (Persona)lstPersonas.SelectedItem;
            if (personaSeleccionada != null)
            {
                PersonaDAO.Borrar(personaSeleccionada.ID);
                this.btnLeer_Click(sender, e);
            }
            else
            {
                MessageBox.Show("NO SE HA ELEGIDO NINGUNA PERSONA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

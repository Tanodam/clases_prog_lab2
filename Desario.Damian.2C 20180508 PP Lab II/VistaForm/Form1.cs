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
    public partial class Form1 : Form
    {
        private Profesor profesor;
        private Division division;
        private Curso curso;
        private Alumno alumno;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearCurso_Click(object sender, EventArgs e)
        {
            Enum.TryParse<Division>(comboBoxDivisonCurso.SelectedValue.ToString(), out division);
            profesor = new Profesor(txtNombreCurso.Text, txtBoxApellidoCurso.Text, txtBoxDniCurso.Text, dateTimePickerIngreso.Value.Date);
            curso = new Curso((short)numericUpDownAñoCurso.Value, division, profesor);
        }

        private void btnMostrarCurso_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            if (Object.ReferenceEquals(curso,null))
            {
                MessageBox.Show("Error", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
                richTextBox.AppendText((string)curso);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxDivisonAlumno.DataSource = Enum.GetValues(typeof(Division));
            comboBoxDivisonCurso.DataSource = Enum.GetValues(typeof(Division));
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            Enum.TryParse<Division>(comboBoxDivisonAlumno.SelectedValue.ToString(), out division);
            alumno = new Alumno(txtBoxApellidoAlumno.Text, txtBoxApellidoAlumno.Text, txtBoxLegajo.Text,(short)numericUpDownAñoAlumno.Value, division);
            curso += alumno;

        }
    }
}

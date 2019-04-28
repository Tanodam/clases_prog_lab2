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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            profesor = new Profesor(txtNombreCurso.Text, txtBoxApellidoCurso.Text, txtBoxDniCurso.Text, dateTimePickerIngreso.Value.Date);
            division = new Division();
            switch (comboBoxDivisonCurso.Text)
            {
                case "A":
                    division = Division.A;
                    break;
                case "B":
                    division = Division.B;
                    break;
                case "C":
                    division = Division.C;
                    break;
                case "D":
                    division = Division.D;
                    break;
                case "E":
                    division = Division.E;
                    break;
                 
            }
            curso = new Curso((short)numericUpDownAñoCurso.Value, division, profesor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox.AppendText((string)curso);
        }
    }
}

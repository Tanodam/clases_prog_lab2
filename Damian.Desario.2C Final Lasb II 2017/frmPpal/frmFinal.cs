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
using System.Threading;

namespace frmPpal
{
    public partial class Form1 : Form
    {
        private MEspecialista medicoEspecialista;
        private MGeneral medicoGeneral;
        private Thread mocker;
        private Queue<Paciente> pacientesEnEspera;

        public Form1()
        {
            InitializeComponent();
            this.medicoGeneral = new MGeneral("Luis", "Salinas");
            this.medicoEspecialista = new MEspecialista("Jorge", "Iglesias", MEspecialista.Especialidad.Traumatologo);
            this.pacientesEnEspera = new Queue<Paciente>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mocker = new Thread(this.MockPaciente);
            mocker.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mocker.IsAlive)
            {
                mocker.Abort();
            }
        }
        private void MockPaciente()
        {
            this.pacientesEnEspera.Enqueue(new Paciente("Juan", "Perez"));
            this.pacientesEnEspera.Enqueue(new Paciente("Concha", "Margarita"));
            this.pacientesEnEspera.Enqueue(new Paciente("Perenuso", "Cardozo"));
            this.pacientesEnEspera.Enqueue(new Paciente("Espumoso", "Nicasia"));
            Thread.Sleep(5000);
        }
        private void AtenderPacientes(IMedico iMedico)
        {
            if (!(this.pacientesEnEspera is null))
                iMedico.IniciarAtencionPaciente(pacientesEnEspera.Dequeue());

        }
        private void FinAtencionPaciente(Paciente paciente, Medico medico)
        {
            //if (this.InvokeRequired)
            //{
            //    FinAtencionPaciente delegado = new FinAtencionPaciente(this.FinAtencionPaciente);
            //    object[] objects = new object[] { paciente, medico };
            //    this.Invoke(delegado, objects);
            //}
            //else
            //{
            //    string datos = String.Format("Finalizó la atención de {0} por {1}!", paciente.ToString(), medico.ToString());
            //    MessageBox.Show(datos.ToString(), "Atencion finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            //if (this.InvokeRequired)
            //{
            //    this.BeginInvoke((MethodInvoker)delegate ()
            //    {
            //        string datos = String.Format("Finalizó la atención de {0} por {1}!", paciente.ToString(), medico.ToString());
            //        MessageBox.Show(datos, "Atencion finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    });
            //}
            StringBuilder s = new StringBuilder();
            s.AppendFormat("Finalizó la atención de {0} por {1}!", paciente.ToString(), medico.ToString());
            MessageBox.Show(s.ToString(), "Atencion finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            medicoGeneral.AtencionFinalizada += this.FinAtencionPaciente;
            this.AtenderPacientes(this.medicoGeneral);
        }

        private void btnEspecialista_Click(object sender, EventArgs e)
        {
            medicoEspecialista.AtencionFinalizada += this.FinAtencionPaciente;
            this.AtenderPacientes(this.medicoEspecialista);
        }
    }
}

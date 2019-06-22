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
using Archivos;
using System.Threading;

namespace _20181122_SP
{
    public partial class FrmPpal : Form
    {
        Queue<Patente> cola;
        List<Thread> listaThreads;
        public FrmPpal()
        {
            InitializeComponent();
            this.listaThreads = new List<Thread>();
            this.cola = new Queue<Patente>();
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            this.vistaPatente1.FinExposicion += ProximaPatente;
            this.vistaPatente2.FinExposicion += ProximaPatente;
        }
        public void ProximaPatente(Patentes.VistaPatente vp)
        {
            if (this.cola.Count > 0)
            {
                Thread hilo = new Thread(new ParameterizedThreadStart(vp.MostrarPatente));
                hilo.Start(this.cola.Dequeue());
                this.listaThreads.Add(hilo);
            }

        }
        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FinalizarSimulacion();
        }
        private void btnXml_Click(object sender, EventArgs e)
        {
            Xml<Queue<Patente>> colaAux = new Xml<Queue<Patente>>();
            colaAux.Leer(@"D:\Damian Desario\clases_prog_lab2\20181122-SP\patentes.xml", out cola); 
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            Texto texto = new Texto();
            texto.Leer(@"C:\Users\Dami\Documents\UTN\clases_prog_lab2\20181122-SP\patentes.txt", out this.cola);
            this.IniciarSimulacion();
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            Sql conexiosql = new Sql();

        }
        public void IniciarSimulacion()
        {
            this.FinalizarSimulacion();
            this.ProximaPatente(vistaPatente1);
            this.ProximaPatente(vistaPatente2);
        }
        private void FinalizarSimulacion()
        {
            foreach (Thread hilo in listaThreads)
            {
                if (hilo.IsAlive)
                {
                    hilo.Abort();
                }
            }
        }
    }
}

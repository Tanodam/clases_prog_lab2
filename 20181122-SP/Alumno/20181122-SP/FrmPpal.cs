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
            vistaPatente1.MostrarProximaPatente += this.ProximaPatente;
            vistaPatente2.MostrarProximaPatente += this.ProximaPatente;
        }
        public void ProximaPatente(object patente)
        {
            Thread hilo = new Thread());

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
            texto.Leer(@"D:\Damian Desario\clases_prog_lab2\20181122-SP\patentes.txt", out cola);
           
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

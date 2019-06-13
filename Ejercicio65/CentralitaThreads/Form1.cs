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
using CentralitaHerencia;

namespace CentralitaThreads
{
    public partial class Form1 : Form
    {
        Centralita centralita;
        Thread hilo;
        public Form1()
        {
            InitializeComponent();
            centralita = new Centralita();
            hilo = new Thread(centralita.crearLlamadas);
        }

        private void btnLocales_Click(object sender, EventArgs e)
        {
            MessageBox.Show(centralita.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            centralita = new Centralita();
            hilo = new Thread(centralita.crearLlamadas);
            hilo.Start();
        }
    }
}

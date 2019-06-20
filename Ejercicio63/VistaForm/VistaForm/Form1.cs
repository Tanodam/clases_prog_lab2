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

namespace VistaForm
{
    public partial class Form1 : Form
    {
        Thread hilo;
        public Form1()
        {
            InitializeComponent();
        }
        public void AsignarHora()
        {
            while (true)
            {

                if (lblHora.InvokeRequired)
                {
                    lblHora.BeginInvoke((MethodInvoker)delegate ()
                    {
                        lblHora.Text = DateTime.Now.ToString();
                    }
                    );
                }
                else
                {
                    lblHora.Text = DateTime.Now.ToString();
                }
                Thread.Sleep(1000);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
            hilo = new Thread(AsignarHora);
            hilo.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //AsignarHora();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            hilo.Abort();
        }
    }
}

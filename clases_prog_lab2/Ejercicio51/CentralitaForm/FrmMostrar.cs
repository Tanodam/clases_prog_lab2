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
    public partial class FrmMostrar : Form
    {
        Centralita centralita;
        TipoLlamada tipo;
        public FrmMostrar()
        {
            InitializeComponent();
        }
        public FrmMostrar(Centralita centralita, TipoLlamada tipo) : this()
        {
            this.centralita = centralita;
            this.tipo = tipo;
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            {
                switch (tipo)
                {
                    case TipoLlamada.Local:
                        richTextBox1.Text += ("Facturacion por Local\n" + centralita.GananciasPorLocal);
                        break;
                    case TipoLlamada.Provincial:

                        richTextBox1.Text += ("Facturacion por Provincial\nPesos: $" + centralita.GananciasPorProvincial);
                        break;
                    default:
                        StringBuilder total = new StringBuilder();
                        total.AppendLine("Facturacion por Local: "+ centralita.GananciasPorLocal);
                        total.AppendLine("Facturacion por Provincial: " + centralita.GananciasPorProvincial);
                        total.AppendLine("Facturacion Total: " + centralita.GananciasPorTotal);
                        richTextBox1.Text += total.ToString();
                        break;

                }

            }
        }
    }
}

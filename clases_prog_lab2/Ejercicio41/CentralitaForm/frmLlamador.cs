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
    public partial class FrmLlamador : Form
    {
        Centralita centralita;

        public FrmLlamador()
        {
            InitializeComponent();
        }
        public FrmLlamador(Centralita centralita) : this()
        {
            this.centralita = centralita;
            comboBoxFranja.DataSource = Enum.GetValues(typeof(Franja));
        }
        public Centralita Centralita
        {
            get
            {
                return this.centralita;
            }
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            //Aca inhabilito el textbox de destino, se puede escribir con el panel

            textBoxNroOrigen.Text = "1136955821";
            textBoxNumeroDestino.Enabled = false;
            textBoxNroOrigen.Enabled = false;
        }
        private void botonNumerico1_Click(object sender, EventArgs e)
        {
            if (textBoxNumeroDestino.Text == "Nro Destino")
            {
                textBoxNumeroDestino.Text = "";
            }
            textBoxNumeroDestino.Text += "1";

        }

        private void botonNumerico2_Click(object sender, EventArgs e)
        {
            if (textBoxNumeroDestino.Text == "Nro Destino")
            {
                textBoxNumeroDestino.Text = "";
            }
            textBoxNumeroDestino.Text += "2";
        }

        private void botonNumerico3_Click(object sender, EventArgs e)
        {
            if (textBoxNumeroDestino.Text == "Nro Destino")
            {
                textBoxNumeroDestino.Text = "";
            }
            textBoxNumeroDestino.Text += "3";
        }

        private void botonNumerico4_Click(object sender, EventArgs e)
        {
            if (textBoxNumeroDestino.Text == "Nro Destino")
            {
                textBoxNumeroDestino.Text = "";
            }
            textBoxNumeroDestino.Text += "4";
        }

        private void botonNumerico5_Click(object sender, EventArgs e)
        {
            if (textBoxNumeroDestino.Text == "Nro Destino")
            {
                textBoxNumeroDestino.Text = "";
            }
            textBoxNumeroDestino.Text += "5";
        }

        private void botonNumerico6_Click(object sender, EventArgs e)
        {
            if (textBoxNumeroDestino.Text == "Nro Destino")
            {
                textBoxNumeroDestino.Text = "";
            }
            textBoxNumeroDestino.Text += "6";
        }

        private void botonNumerico7_Click(object sender, EventArgs e)
        {
            if (textBoxNumeroDestino.Text == "Nro Destino")
            {
                textBoxNumeroDestino.Text = "";
            }
            textBoxNumeroDestino.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBoxNumeroDestino.Text == "Nro Destino")
            {
                textBoxNumeroDestino.Text = "";
            }
            textBoxNumeroDestino.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBoxNumeroDestino.Text == "Nro Destino")
            {
                textBoxNumeroDestino.Text = "";
            }
            textBoxNumeroDestino.Text += "9";
        }

        private void botonNumerico0_Click(object sender, EventArgs e)
        {
            if (textBoxNumeroDestino.Text == "Nro Destino")
            {
                textBoxNumeroDestino.Text = "";
            }
            textBoxNumeroDestino.Text += "0";
        }

        private void botonAsterisco_Click(object sender, EventArgs e)
        {
            if (textBoxNumeroDestino.Text == "Nro Destino")
            {
                textBoxNumeroDestino.Text = "";
            }
            textBoxNumeroDestino.Text += "*";
        }

        private void botonNumeral_Click(object sender, EventArgs e)
        {
            if (textBoxNumeroDestino.Text == "Nro Destino")
            {
                textBoxNumeroDestino.Text = "";
            }
            textBoxNumeroDestino.Text += "#";
        }

        private void botonLlamar_Click(object sender, EventArgs e)
        {
            Franja franja;
            Random duracion = new Random();
            Random costo = new Random();
            if (textBoxNumeroDestino.Text[0] == '#')
            {
                Enum.TryParse<Franja>(comboBoxFranja.SelectedValue.ToString(), out franja);
                Provincial llamada = new Provincial(textBoxNroOrigen.Text, franja, duracion.Next(1, 50), textBoxNumeroDestino.Text);
                if(!ReferenceEquals(llamada,null))
                {
                    this.centralita += llamada;
                    MessageBox.Show("Llamada realiza con exito\n");
                }
            }
            else
            {
                comboBoxFranja.Enabled = false;
                Local llamada = new Local(textBoxNroOrigen.Text, duracion.Next(1, 50), textBoxNumeroDestino.Text, (float)costo.Next(5, 56) / 10);
                if (!ReferenceEquals(llamada, null))
                {
                    this.centralita += llamada;
                    MessageBox.Show("Llamada realiza con exito\n");
                }
            }
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNroOrigen.Text = "";
            textBoxNumeroDestino.Text = "";
            comboBoxFranja.Enabled = true;
            textBoxNroOrigen.Text = "1136955821";
            textBoxNumeroDestino.Text = "Nro Destino";
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}

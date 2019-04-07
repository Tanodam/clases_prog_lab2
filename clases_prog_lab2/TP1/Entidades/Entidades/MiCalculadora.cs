using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public partial class MiCalculadora : Form
    {
        public MiCalculadora()
        {
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado = 0;

            if (txtNumeroDos.Text != "0" || cbOperador.Text != "/")
            {
                resultado = MiCalculadora.Operar(txtNumeroUno.Text, txtNumeroDos.Text, cbOperador.Text);
                txtResultado.Text = Convert.ToString(resultado);
            }
            else
            {
                txtResultado.Text = "MATH ERROR";
            }

        }
        private static double Operar(string numeroUno, string numeroDos, string operador)
        {
            Numero numero1 = new Numero(numeroUno);
            Numero numero2 = new Numero(numeroDos);
            string resultado = Calculadora.Operar(numero1, numero2, operador);
            double resultadoDouble = 0;
            if (double.TryParse(resultado, out resultadoDouble))
            {
                return resultadoDouble;
            }
            else
            {
                return resultadoDouble;
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumeroUno.Text = "";
            txtNumeroDos.Text = "";
            cbOperador.Text = "";
            txtResultado.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero numeroUno = new Numero();
            string strNumeroUno = txtNumeroUno.Text;
            txtResultado.Text = numeroUno.DecimalBinario(strNumeroUno);
        }

        private void ConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero numeroUno = new Numero();
            string strNumeroUno = txtNumeroUno.Text;
            txtResultado.Text = numeroUno.BinarioDecimal(strNumeroUno);
        }
    }
}

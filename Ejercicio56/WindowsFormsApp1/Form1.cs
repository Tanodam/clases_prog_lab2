using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string archivoAbierto;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBoxTexto_TextChanged(object sender, EventArgs e)
        {
            StripStatusLblCantCaracteres.Text = richTextBoxTexto.TextLength.ToString() + " caracteres";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string rutaArchivo;
            OpenFileDialog abridorDeArchivos = new OpenFileDialog();

            abridorDeArchivos.InitialDirectory = "C://";
            abridorDeArchivos.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            abridorDeArchivos.FilterIndex = 2;
            if (abridorDeArchivos.ShowDialog() == DialogResult.OK)
            {
                //Obtiene la ruta del archivo especifico
                rutaArchivo = abridorDeArchivos.FileName;
                archivoAbierto = rutaArchivo;
                StreamReader stream = new StreamReader(rutaArchivo);
                richTextBoxTexto.Text = stream.ReadToEnd();
                stream.Close();
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardadorDeArchivos = new SaveFileDialog();
            string rutaArchivo;
            guardadorDeArchivos.InitialDirectory = "C:\\";
            guardadorDeArchivos.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            guardadorDeArchivos.FilterIndex = 2;
            if (guardadorDeArchivos.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = guardadorDeArchivos.FileName;
                StreamWriter textoAGuardear = new StreamWriter(rutaArchivo);
                if(File.Exists(rutaArchivo))
                {
                    textoAGuardear.Write(richTextBoxTexto.Text);
                    textoAGuardear.Close();
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(archivoAbierto))
            {
                StreamWriter textoAGuardar = new StreamWriter(archivoAbierto);
                textoAGuardar.Write(richTextBoxTexto.Text);
            }
            else
            {
                this.guardarComoToolStripMenuItem_Click(sender, e);
            }
        }
    }
}

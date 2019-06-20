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
            IO.PuntoDat puntoDat = new IO.PuntoDat();
            OpenFileDialog abridorDeArchivos = new OpenFileDialog();
            string rutaArchivo;
            abridorDeArchivos.InitialDirectory = "C://";
            abridorDeArchivos.Filter = "txt files (*.txt)|*.txt|dat files (*.dat)|*.dat";
            abridorDeArchivos.FilterIndex = 2;
            if (abridorDeArchivos.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = abridorDeArchivos.FileName;
                if (Path.GetExtension(abridorDeArchivos.FileName) == ".dat")
                {
                    puntoDat=puntoDat.Leer(rutaArchivo);
                    richTextBoxTexto.Text = puntoDat.Contenido;
                    this.archivoAbierto = rutaArchivo;
                }
                else
                {
                    //Obtiene la ruta del archivo especifico
                    rutaArchivo = abridorDeArchivos.FileName;
                    StreamReader stream = new StreamReader(rutaArchivo);
                    richTextBoxTexto.Text = stream.ReadToEnd();
                    stream.Close();
                }
                    this.archivoAbierto = rutaArchivo;
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IO.PuntoDat puntoDat = new IO.PuntoDat();
            SaveFileDialog guardadorDeArchivos = new SaveFileDialog();
            string rutaArchivo;
            guardadorDeArchivos.InitialDirectory = "C:\\";
            guardadorDeArchivos.Filter = "txt files (*.txt)|*.txt|dat files (*.dat)|*.dat";
            guardadorDeArchivos.FilterIndex = 2;
            if (guardadorDeArchivos.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = guardadorDeArchivos.FileName;
                if (Path.GetExtension(guardadorDeArchivos.FileName) == ".dat")
                {
                    puntoDat.Contenido = richTextBoxTexto.Text;
                    puntoDat.GuardarComo(rutaArchivo, puntoDat);
                }
                StreamWriter textoAGuardear = new StreamWriter(rutaArchivo);
                if (File.Exists(rutaArchivo))
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> Palabras = new Dictionary<string, int>();
            char[] delimiterChars = { ' ', ',', '.', ':', ';', '\t', '\n' };
            string[] words = richTextBox1.Text.Split(delimiterChars);
            int clave = 1;
            foreach (string word in words)
            {
                if (!Palabras.ContainsKey(word))
                {
                    Palabras.Add(word, clave);
                }
                else
                {
                    Palabras[word] += 1;
                }
            }
            //foreach (KeyValuePair<string, int> palabra in Palabras)
            //{
            //   MessageBox.Show("Clave ="+ palabra.Key +" Valor = "+ palabra.Value);
            //}

            // Acquire keys and sort them.
            var list = Palabras.Keys.ToList();
            list.Sort();

            // Loop through keys.
            foreach (var key in list)
            {
               MessageBox.Show(key + (Palabras[key]));
            }

        }
    }
}

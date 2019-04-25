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
            //Ordena el diccionario en orden descendiente, ni idea como se hizo
            Palabras = Palabras.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            var list = new List<KeyValuePair<string, int>>();
            foreach (KeyValuePair<string, int> palabra in Palabras)
            {
                list.Add(new KeyValuePair<string, int>(palabra.Key,palabra.Value));
            }
            //Mostrar TOP 3
            MessageBox.Show("TOP 3 [palabra, repeticiones]\n" + 
                            Convert.ToString(list.ElementAt(0)) + 
                            "\n" + Convert.ToString(list.ElementAt(1)) + 
                            "\n" + Convert.ToString(list.ElementAt(2)));
        }
    }
}

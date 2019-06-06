using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ejercicio60
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String conexion = @"Data Source=.\SQLEXPRESS; Initial Catalog=base1; Integrated Security = True";
            SqlConnection connection = new SqlConnection(conexion);

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;

            comando.Connection = connection;
            string insert = String.Format("INSERT INTO articulos (descripcion, cantidad) VALUES ('{0}','{1}')", textBox1.Text,2);
            comando.CommandText = insert;
            connection.Open();
            comando.ExecuteNonQuery();
            connection.Close();

        }
    }
}

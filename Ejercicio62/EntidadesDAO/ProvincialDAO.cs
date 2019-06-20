using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace EntidadesDAO
{
    public static class ProvincialDAO
    {
        public static SqlConnection conexion;
        public static SqlCommand comando;

        static ProvincialDAO()
        {
            string connectionStr = @"Data Source=.\SQLEXPRESS; Initial Catalog=Persona; Integrated Security = True";

            try
            {
                conexion = new SqlConnection(connectionStr);
                comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static bool Guardar(string nombre, string apellido)
        {
            bool respuesta = false;

            try
            {
                string consulta = String.Format("INSERT INTO persona (nombre, apellido) VALUES ('{0}','{1}')",
                                                                     nombre, apellido);
                comando.CommandText = consulta;
                conexion.Open();
                comando.ExecuteNonQuery();
                respuesta = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            return respuesta;
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
    public class Sql : IArchivo<Queue<Patente>>
    {
        private SqlCommand comando;
        private SqlConnection conexion;

        public Sql()
        {
            string connectionStr = @"Data Source=.\SQLEXPRESS; Initial Catalog=correo-sp-2017; Integrated Security = True";

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

        public void Guardar(string tabla, Queue<Patente> datos)
        {
            try
            {
                conexion.Open();
                foreach (Patente patente in datos)
                {
                    string consulta = String.Format("INSERT INTO" + tabla + "(codigo, tipo) VALUES ('{0}','{1})", patente.CodigoPatente, patente.TipoCodigo);
                    comando.CommandText = consulta;
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public void Leer(string tabla, out Queue<Patente> datos)
        {
            datos = new Queue<Patente>();
            try
            {
                string consulta = String.Format("SELECT from Personas");
                comando.CommandText = consulta;
                conexion.Open();
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    string codigoPatente = oDr["codigo"].ToString();
                    Patente.Tipo tipoPatente = (Patente.Tipo)oDr["tipo"];
                    datos.Enqueue(new Patente(codigoPatente, tipoPatente));
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
    }
}

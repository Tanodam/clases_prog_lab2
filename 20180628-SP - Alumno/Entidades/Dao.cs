using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public class Dao<T> : IArchivos<Votacion>
    {
        public static SqlConnection conexion;
        public static SqlCommand comando;
        static Dao()
        {
            string connectionStr = @"Data Source=.\SQLEXPRESS; Initial Catalog=votacion-sp-2018; Integrated Security = True";

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
        public bool Guardar(string rutaArchivo, Votacion objeto)
        {
            bool respuesta = false;

            try
            {
                string consulta = String.Format("INSERT INTO dbo.Votaciones (nombreLey, afirmativos, negativos, abstenciones, nombreAlumno) VALUES ('{0}','{1}','{2}','{3}','{4}')",
                                                objeto.NombreLey, objeto.ContadorAfirmativo, objeto.ContadorNegativo,objeto.ContadorAbstencion, "Damian Desario");
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
                {
                    conexion.Close();
                }
            }
            return respuesta;
        }

        public Votacion Leer(string rutaArchivo)
        {
            throw new NotImplementedException();
        }
    }
}

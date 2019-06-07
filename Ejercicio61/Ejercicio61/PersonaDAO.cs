using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Ejercicio61
{
    public static class PersonaDAO
    {
        public static SqlConnection conexion;
        public static SqlCommand comando;

        static PersonaDAO()
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
                                                                     nombre,apellido);
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
        public static List<Persona> Leer()
        {
            List<Persona> personas = new List<Persona>();
            Persona persona;
            int id;
            string nombre;
            string apellido;

            string consulta = String.Format("Select * from persona");
            try
            {
                comando.CommandText = consulta;
                conexion.Open();
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    id = int.Parse(oDr["id"].ToString());
                    nombre = oDr["nombre"].ToString();
                    apellido = oDr["apellido"].ToString();
                    persona = new Persona(nombre,apellido,id);
                    personas.Add(persona);
                }
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

            return personas;
        }
        public static Persona LeerPorID(int ID)
        {
            Persona persona;
            int id;
            string nombre;
            string apellido;

            string consulta = String.Format("Select * from persona WHERE id={0}",ID);
            try
            {
                comando.CommandText = consulta;
                conexion.Open();
                SqlDataReader oDr = comando.ExecuteReader();

                if(oDr.Read())
                {
                    id = int.Parse(oDr["id"].ToString());
                    nombre = oDr["nombre"].ToString();
                    apellido = oDr["apellido"].ToString();
                    persona = new Persona(nombre, apellido, id);
                    return persona;
                }
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

            return null;
        }
        public static bool Modificar(Persona persona)
        {
            bool respuesta = false;
            try
            {
                string consulta = String.Format("UPDATE persona set nombre ='{0}', apellido='{1}'WHERE id={2}",
                                                                     persona.Nombre, persona.Apellido, persona.ID);
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
        public static bool Borrar(int ID)
        {
            bool respuesta = false;

            try
            {
                string consulta = String.Format("DELETE FROM persona WHERE id={0} ", ID);
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

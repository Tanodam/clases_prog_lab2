using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Entidades;

namespace Archivos
{
    public class Texto : IArchivo<Queue<Patente>>
    {
        StreamWriter writer;
        StreamReader reader;
        public void Guardar(string archivo, Queue<Patente> datos)
        {
            try
            {
                writer = new StreamWriter(archivo, true);
                writer.WriteLine(datos);

            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                //Cierro conexion con el archivo
                writer.Close();
            }
        }

        public void Leer(string archivo, out Queue<Patente> datos)
        {
            datos = new Queue<Patente>();
            try
            {
                reader = new StreamReader(archivo, Encoding.UTF8);
                datos.Enqueue(reader.ReadLine().ValidarPatente());
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                //Cierro conexion con el archivo
                reader.Close();
            }
        }
    }
}

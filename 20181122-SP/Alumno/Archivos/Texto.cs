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
            using (System.IO.StreamReader file = new System.IO.StreamReader(archivo))
            {
                while (!file.EndOfStream)
                {
                    try
                    {
                        datos.Enqueue(file.ReadLine().ValidarPatente());
                    }
                    catch (PatenteInvalidException e)
                    { }
                }
            }
        }
    }
}

using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class SerializarXML<T> : IArchivos<T>
    {
        public bool Guardar(string rutaArchivo, T objeto)
        {
            bool returnAux = false;
            XmlTextWriter writer = null;
            XmlSerializer ser = null;
            try
            {
                ser = new XmlSerializer(typeof(T));
                writer = new XmlTextWriter(rutaArchivo, Encoding.UTF8);
                ser.Serialize(writer, objeto);
            }
            catch (Exception ex)
            {
                    throw new ErrorArchivoException("No se pudo serializar\n" + ex.Message, ex);
            }
            finally
            {
                if (!(writer is null))
                {
                    writer.Close();
                    returnAux = true;
                }
            }
            return returnAux;
        }

        public T Leer(string rutaArchivo)
        {
            T retorno;
            XmlTextReader reader = null;
            XmlSerializer ser = new XmlSerializer(typeof(T));
            try
            {
                reader = new XmlTextReader(rutaArchivo);
                retorno = (T)ser.Deserialize(reader);
            }
            catch (Exception ex)
            {
                throw new ErrorArchivoException("Error al leer el archivo\n" + ex.Message, ex);
            }
            finally
            {
                if (!(reader is null))
                {
                    reader.Close();
                }
            }
            return retorno;
        }
    }
}

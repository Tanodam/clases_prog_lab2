﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public void Guardar(string archivo, T datos)
        {
            //Objeto que escribirá en XML.
            XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8);
            //Objeto que serializará.
            XmlSerializer objetoSerializador = new XmlSerializer(typeof(T)); /// T es del tipo Universidad.
            try
            {
                //Serializo
                objetoSerializador.Serialize(writer, datos);
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

        public void Leer(string archivo, out T datos)
        {
            //Objeto que leerá en XML.
            XmlTextReader reader = new XmlTextReader(archivo);
            //Objeto que serializará.
            XmlSerializer objetoDeserializador = new XmlSerializer(typeof(T)); /// T es del tipo Universidad.
            try
            {
                //Deserializo
                datos = (T)objetoDeserializador.Deserialize(reader);

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

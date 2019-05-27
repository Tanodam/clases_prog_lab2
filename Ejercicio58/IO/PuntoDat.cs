using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace IO
{
    [Serializable]
    public class PuntoDat : Archivo, IArchivos<PuntoDat>
    {
        private string contenido;

        #region Propiedades
        public string Contenido
        {
            get
            {
                return this.contenido;
            }
            set
            {
                this.contenido = value;
            }
        }
        #endregion
        #region Metodos
        public bool Guardar(string ruta, PuntoDat objeto)
        {
            //Creo el objeto serializador
            BinaryFormatter objetoSerializer = new BinaryFormatter();
            //Indico ubicacion del archuvo y modo de apertura
            try
            {
                FileStream archivo = new FileStream(ruta, FileMode.Open);
                //Serializo
                objetoSerializer.Serialize(archivo, objeto);
                //Cierro el archivo
                archivo.Close();
                return true;
            }
            catch (FileNotFoundException)
            {
                return false;
            }

        }

        public bool GuardarComo(string ruta, PuntoDat objeto)
        {
            //Creo el objeto serializador
            BinaryFormatter objetoSerializer = new BinaryFormatter();
            //Indico ubicacion del archuvo y modo de apertura
            FileStream archivo = new FileStream(ruta, FileMode.Create);

            //Serializo
            objetoSerializer.Serialize(archivo, objeto);
            //Cierro el archivo
            archivo.Close();
            return true;

        }

        public PuntoDat Leer(string ruta)
        {
            PuntoDat puntoDat = new PuntoDat();

            this.validarArchivo(ruta, true);
            //Creo el objeto serializador
            BinaryFormatter objetoDeserializer = new BinaryFormatter();
            //Indico ubicacion del archuvo y modo de apertura
            FileStream archivo = new FileStream(ruta, FileMode.Open);
            //Deserializo
            puntoDat = (PuntoDat)objetoDeserializer.Deserialize(archivo);
            this.Contenido = puntoDat.contenido;
            //Cierro el archivo
            archivo.Close();
            return puntoDat;
        }


        protected override bool validarArchivo(string ruta, bool validarExistencia)
        {
            if (Path.GetExtension(ruta) != ".dat")
            {
                throw new ArchivoIncorrectoException("El archivo no es un dat");
            }
            if (validarExistencia)
            {
                try
                {
                    File.Exists(ruta);
                }
                catch (FileNotFoundException exception)
                {
                    throw new ArchivoIncorrectoException("El archivo no es correcto", exception);
                }
            }
            return true;
        }
        #endregion
    }
}


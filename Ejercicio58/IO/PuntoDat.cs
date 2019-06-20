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
            FileStream archivo;
            BinaryFormatter serializador;

            archivo = new FileStream(ruta, FileMode.Create); // Creo nuevo archivo
            serializador = new BinaryFormatter();

            serializador.Serialize(archivo, objeto);
            archivo.Close();

            return true;

        }

        public PuntoDat Leer(string ruta)
        {
            FileStream archivo;
            BinaryFormatter serializador;
            PuntoDat objeto;

            try
            {
                archivo = new FileStream(ruta, FileMode.Open); // Abro archivo
                serializador = new BinaryFormatter();

                objeto = (PuntoDat)serializador.Deserialize(archivo); //REVISAR
                archivo.Close();

                return objeto;
            }
            catch (FileNotFoundException exception)
            {
                throw new ArchivoIncorrectoException("Archivo inexistente", exception); //REVISAR
            }
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


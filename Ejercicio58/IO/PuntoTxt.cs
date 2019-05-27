using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    [Serializable]
    public class PuntoTxt : Archivo, IArchivos<PuntoTxt>
    {
        public bool Guardar(string ruta, PuntoTxt objeto)
        {
            throw new NotImplementedException();
        }

        public bool GuardarComo(string ruta, PuntoTxt objeto)
        {
            throw new NotImplementedException();
        }

        public PuntoTxt Leer(string ruta)
        {
            throw new NotImplementedException();
        }
        #region Metodos

        protected override bool validarArchivo(string ruta, bool validarExistencia)
        {
            if (Path.GetExtension(ruta) != ".txt")
            {
                throw new ArchivoIncorrectoException("El archivo no es un txt");
            }
            try
            {
                File.Exists(ruta);
                return true;
            }
            catch (FileNotFoundException exception)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto", exception);
            }
            
        }
        #endregion
    }
}

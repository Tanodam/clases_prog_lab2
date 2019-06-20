using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    [Serializable]
    public abstract class Archivo
    {
        protected virtual bool validarArchivo(string ruta, bool validarExistencia)
        {
            if(validarExistencia)
            {
                if(File.Exists(ruta))
                {
                    return true;
                }                                
            }
            throw new FileNotFoundException();
        }
    }
}

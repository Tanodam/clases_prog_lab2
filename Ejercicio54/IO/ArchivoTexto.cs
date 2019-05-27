using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    public static class ArchivoTexto
    {   /*El método Guardar agregará información al archivo de texto ubicado en la ruta pasada como parámetro. 
         También recibirá un string con la información a guardar.*/
       public static void Guardar(string ruta, string textoAGuardar)
        {
            StreamWriter archivo = new StreamWriter(ruta, true);
            archivo.WriteLine(textoAGuardar);
            archivo.Close();
        }
        /// <summary>
        /// El método Leer retornará el contenido del archivo ubicado en la ruta pasada como parámetro.
        /// En caso de no existir, lanzará la excepción de sistema FileNotFoundException.
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns></returns>
        public static string Leer(string ruta)
        {
            if (File.Exists(ruta))
            {
                string texto;
                StreamReader archivo = new StreamReader(ruta);
                texto = archivo.ReadToEnd();
                archivo.Close();
                return texto;
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.IO;

namespace Entidades
{
    public class LosHilos : IRespuesta<int>
    {
        private int id;
        private List<InfoHilo> misHilos;
        StreamWriter writer;
        StreamReader reader;

        public delegate void AvisoFin(string mensaje);
        public event AvisoFin AvisoFinn;

        public string Bitacora
        {
            get
            {
                try
                {
                    string archivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\bitacora.txt";
                    reader = new StreamReader(archivo, Encoding.UTF8);
                    return reader.ReadToEnd();
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
            set
            {
                try
                {
                    string archivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\bitacora.txt";
                    writer = new StreamWriter(archivo, true);
                    writer.WriteLine(value);
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
        }

        public LosHilos()
        {
            this.id = 0;
            this.misHilos = new List<InfoHilo>();

        }
        private static LosHilos AgregarHilo(LosHilos hilos)
        {
            hilos.id++;
            InfoHilo infoHilo = new InfoHilo(hilos.id, hilos);
            hilos.misHilos.Add(infoHilo);
            return hilos;
        }
        public static LosHilos operator +(LosHilos hilos, int cantidad)
        {
            if (cantidad < 0)
            {
                throw new CantidadInvalidaException();
            }
            else if (cantidad > 0)
            {
                for (int i = 0; i < cantidad; i++)
                {
                   AgregarHilo(hilos);
                }
            }
            return hilos;
        }
        public void RespuestaHilo(int id)
        {
            string datos = string.Format("Terminó el hilo {0}.", id);
            this.Bitacora = datos;
            this.AvisoFinn(datos);
        }
    }
}

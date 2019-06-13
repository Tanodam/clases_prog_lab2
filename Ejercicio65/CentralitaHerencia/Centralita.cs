using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;


namespace CentralitaHerencia
{
    public class Centralita : IGuardar<string>
    {
        private List<Llamada> listaDeLlamadas;
        private string razonSocial;
        //ESTO SE GUARDA EN Ejercicio55\CentralitaHerencia\bin\Debug
        private string rutaArchivo = "LogCentralita.txt";

        #region Propiedades

        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        public string RutaDelArchivo
        {
            get
            {
                return this.rutaArchivo;
            }
            set
            {
                this.rutaArchivo = value;
            }
        }

        #endregion

        #region Métodos

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(TipoLlamada tipo) //ANALIZAR DE DONDE VIENE TIPO DE LLAMADA
        {
            float total = 0;
            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                if (llamada is Local && (tipo.Equals(TipoLlamada.Todas) || tipo.Equals(TipoLlamada.Local)))
                {
                    Local local = (Local)llamada;
                    total += local.CostoLlamada;
                }
                if (llamada is Provincial && (tipo.Equals(TipoLlamada.Todas) || tipo.Equals(TipoLlamada.Provincial)))
                {
                    Provincial provincial = (Provincial)llamada;
                    total += provincial.CostoLlamada;
                }
            }
            return total;
        }
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaDeLlamadas.Add(nuevaLlamada);
        }
        public new string Mostrar()
        {
            return ToString();
        }
        public override string ToString()
        {
            StringBuilder datos = new StringBuilder("");

            datos.Append("\nRAZÓN SOCIAL: " + this.razonSocial);
            datos.Append("\nGANANCIAS POR LLAMADAS LOCALES: " + this.CalcularGanancia(TipoLlamada.Local));
            datos.Append("\nGANANCIAS POR LLAMADAS PROVINCIALES: " + this.CalcularGanancia(TipoLlamada.Provincial));
            datos.Append("\nGANANCIA TOTAL: " + this.CalcularGanancia(TipoLlamada.Todas));

            foreach (Llamada llamada in this.Llamadas)
            {
                datos.Append("\n" + llamada.ToString());
            }
            return datos.ToString();
        }
        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        /// <summary>
        /// El método Guardar de la implementación de IGuardar en Centralita deberá 
        /// guardar en un archivo de texto a modo de bitácora fecha y hora con el siguiente formato 
        /// “Jueves 19 de octubre de 2017 19:09hs – Se realizó una llamada”;
        /// </summary>
        /// <returns></returns>
        public bool Guardar()
        {
            StreamWriter archivo = new StreamWriter(this.RutaDelArchivo,true);
            if (File.Exists(rutaArchivo))
            {
                archivo.WriteLine(DateTime.Now.ToString("dddd dd MMMM yyyy H:mm") + " - Se realizo una llamada");
                archivo.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Leer()
        {
            StreamReader archivo = new StreamReader(RutaDelArchivo);
            string texto = archivo.ReadToEnd();
            archivo.Close();
            return texto;

        }

        public static Centralita operator +(Centralita centralita, Llamada llamada)
        {
            if (centralita == llamada)
            {
                throw new CentralitaException("La llamada ya existe en el sistema", "Centralita", "OPERATOR +");
            }

            centralita.AgregarLlamada(llamada);
            if (!centralita.Guardar())
            {
                throw new CentralitaException("FallaLogException", Convert.ToString(typeof(Centralita)), "OPERADOR +");
            }

            return centralita;
        }
        public static bool operator ==(Centralita centralita, Llamada llamada)
        {
            foreach (Llamada llamadaAux in centralita.listaDeLlamadas)
            {
                if (llamada == llamadaAux)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Centralita centralita, Llamada llamada)
        {
            return !(centralita == llamada);
        }

        public void crearLlamadas()
        {
            while(true)
            {

            Thread hilo;
            Random random;
            random = new Random();
            Thread.Sleep(random.Next(100, 1000));
            if (random.Next(1, 100) % 2 == 0)
            {
                listaDeLlamadas.Add(new Provincial("Hudson", Franja.Franja_2, random.Next(10, 65), "Avellaneda"));
            }
            else
            {
                listaDeLlamadas.Add(new Local("San pedro", random.Next(15, 30), "San Bernado", random.Next(1, 500)));
            }
            }
        }
        #endregion
    }
}

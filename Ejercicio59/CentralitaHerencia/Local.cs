using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;



namespace CentralitaHerencia
{
    public class Local : Llamada, IGuardar<Local>
    {
        private float costoLlamada;

        #region Propiedades
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public string RutaDelArchivo
        {
            get
            {
                    return "LlamadasLocales" + DateTime.Now.ToString("yyyyMMdd-Hmm") + ".txt";
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion
        private float CalcularCosto()
        {
            return this.costoLlamada * this.Duracion;
        }
        public Local()
        {

        }
        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
          
        }
        public Local(string origen, float duracion, string destino, float costo)
        {
            this.duracion = duracion;
            this.nroDestino = destino;
            this.nroOrigen = origen;
            this.costoLlamada = costo;
        }
        public override string ToString()
        {
            return Mostrar();
        }
        protected override string Mostrar()
        {
            StringBuilder datosAMostrar = new StringBuilder("");

            datosAMostrar.Append(base.Mostrar());
            datosAMostrar.Append(" "+this.CostoLlamada.ToString());

            return datosAMostrar.ToString();
        }
        public override bool Equals(object obj)
        {
            return (obj is Local);
        }

        public bool Guardar()
        {
            XmlTextWriter writer;  //Objeto que escribirá en XML.
            XmlSerializer llamadaASerializar;     //Objeto que serializará.

            //Se indica ubicación del archivo XML y su codificación.
            writer = new XmlTextWriter(this.RutaDelArchivo ,Encoding.UTF8);
            //Se indica el tipo de objeto ha serializar.
            llamadaASerializar = new XmlSerializer(typeof(Local));
            //Serializa el objeto p en el archivo contenido en writer.
            llamadaASerializar.Serialize(writer, this);
            //Se cierra la conexión al archivo
            writer.Close();
            return true;

        }

        public Local Leer()
        {
            throw new NotImplementedException();
        }
    }
}

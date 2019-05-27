using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace Ejercicio57
{
    [Serializable]
    public class Persona
    {
        private string nombre;
        private string apellido;

        public Persona(string nombre, string apellido)
        {
            this.apellido = apellido;
            this.nombre = nombre;
        }
        public static void Guardar(Persona persona)
        {
            //Creo el objeto serializador
            BinaryFormatter personaSerializer = new BinaryFormatter();
            //Indico ubicacion del archuvo y modo de apertura
            FileStream archivo = new FileStream("Persona.txt",FileMode.Create);
            //Serializo
            personaSerializer.Serialize(archivo, persona);
            //Cierro el archivo
            archivo.Close();
        }
        public static Persona Leer()
        {
            Persona persona;
            //Creo el objeto serializador
            BinaryFormatter personaDeserializer = new BinaryFormatter();
            //Indico ubicacion del archuvo y modo de apertura
            FileStream archivo = new FileStream("Persona.txt", FileMode.Open);
            //Deserializo
            persona = (Persona)personaDeserializer.Deserialize(archivo);
            //Cierro el archivo
            archivo.Close();
            return persona;
        }
        public override string ToString()
        {
            return String.Format("Nombre Apellido: {0} {1}", this.nombre, this.apellido);
        }


    }
}

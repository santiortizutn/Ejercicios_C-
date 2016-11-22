using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Practica
{
    public static class Serializador
    {
        

        public static void SerializarPersona(Persona per)
        {
            // XmlTextWriter.
            // XmlSerializer;
            using (XmlTextWriter escritor = new XmlTextWriter("Persona.xml", Encoding.UTF8))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Persona));

                serializador.Serialize(escritor, per);
                
            }

        }

        public static Persona DeserializarPersona()
        {
            Persona aux = null;
            using (XmlTextReader lector = new XmlTextReader("Persona.xml"))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Persona));

                return aux = (Persona)serializador.Deserialize(lector);

            }

        }

        public static void SerializarListadoDePersona(Aula miAula)
        {
            // XmlTextWriter.
            // XmlSerializer;
            using (XmlTextWriter escritor = new XmlTextWriter("Aula.xml", Encoding.UTF8))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Aula));

                serializador.Serialize(escritor, miAula);

            }

        }
    }
}

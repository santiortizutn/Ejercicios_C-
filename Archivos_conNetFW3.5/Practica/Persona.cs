using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Practica
{
    [XmlInclude(typeof(Alumno))]

    public class Persona : ISerializable2016
    {
        public string nombre;

        public Persona()
        { }

        public Persona(string nombre):this()
        {
            this.nombre = nombre;
        }

        bool ISerializable2016.serializarGenerico(ISerializable2016 ise)
        {
            return true;
        }

        public bool serializar()
        {

            Serializador.SerializarPersona(this);

            return true;
        }

       
    }
}

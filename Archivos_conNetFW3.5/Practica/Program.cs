using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica
{
    public class Program
    {
        static void Main(string[] args)
        {
            // http://weather.service.msn.com/find.aspx?outputview=search&src=vista&weasearchstr=

            Persona persona = new Persona("Carlos");
            Persona otraPersona = new Persona("Juan");
            List<Persona> listadoPer = new List<Persona>();

            listadoPer.Add(persona);
            listadoPer.Add(otraPersona);
            listadoPer.Add(new Alumno(1, "Luis"));

            Aula miAula = new Aula("AulaUno", 1);
            miAula.profesor = new Persona("Profe");
            listadoPer.Add(miAula.profesor);
            miAula.MisAlumnos = listadoPer;
            

            Serializador.SerializarListadoDePersona(miAula);
            persona.serializar();
            persona = Serializador.DeserializarPersona();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica
{
    public class Aula
    {
        public int numero;
        private string _nombreDeAula;
        private List<Persona> _misAlumnos;
        public Persona profesor;

        public string NombreDeAula
        {
            set 
            {
                this._nombreDeAula = value;
            }

            get
            {
                return this._nombreDeAula;
            }
        }

        public List<Persona> MisAlumnos
        {
            set
            {
                this._misAlumnos = value;
            }

            get
            {
                return this._misAlumnos;
            }
        }

        public Aula()
        { }

        public Aula(string nombre, int numero):this()
        {
            this._nombreDeAula = nombre;
            this.numero = numero;
            this._misAlumnos = new List<Persona>();
        }
    }
}

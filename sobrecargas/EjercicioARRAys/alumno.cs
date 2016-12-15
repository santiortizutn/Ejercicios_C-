using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioARRAys
{
    public class alumno
    {
        public string nombre;
        public int legajo;
        //public alumno[] listaDeAlumnos;

        public alumno()
        {
            
        }

        public static bool operator == (alumno alumno1, alumno alumno2)
        {
            if (alumno1.legajo == alumno2.legajo)
                return true;
                return false;
        }
        public static bool operator !=(alumno alumno1, alumno alumno2)
        {
            if (alumno1.legajo != alumno2.legajo)
                return true;
                return false;
        }

    }
}

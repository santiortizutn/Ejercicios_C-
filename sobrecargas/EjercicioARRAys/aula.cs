using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioARRAys
{
    public class aula
    {
        public int numero;
        public alumno[] listaDeAlumnos;

        public aula()
        {
            this.listaDeAlumnos = new alumno[10];
         /*   for (int contador = 0; contador < 10; contador++)
            {
                this.listaDeAlumnos[contador] = new alumno();
            }

            foreach (alumno objAlumno in this.listaDeAlumnos)
            {
                objAlumno.nombre = "NN";
            }*/
        } 

        public static void mostrarAlumnos(aula aula)
        {
            foreach (alumno objAlumno in aula.listaDeAlumnos)
            {
                if (objAlumno != null)
                {
                    Console.WriteLine("Nombre: " + objAlumno.nombre);
                    Console.WriteLine("Legajo: " + objAlumno.legajo);
                }
                
            }
        }

        /// <summary>
        /// devuelve el indice del primer elemento null, de lo contrario retorna -1. 
        /// </summary>
        /// <returns></returns>
        public int obtenerIndice()
        {
            int indice;
            for (indice = 0; indice < 10; indice++)
            {
                if ((object)this.listaDeAlumnos[indice] == null)
                {
                    break;
                }
            }

            if (true)
                return indice;
                return -1;
                
            
        }
        /// <summary>
        /// retorna el indice del objeto de lo contrario retorna -1. 
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns></returns>
        public int obtenerIndice(alumno alumno)
        {
            int indice;
            for (indice = 0; indice < 10; indice++)
            {
                if ((object)this.listaDeAlumnos[indice] != null)
                {
                    if ((object)this.listaDeAlumnos[indice] == alumno)
                    {
                        return indice;
                    }
                }
            }
            return -1;
        }

        public void agregarALumno(alumno alumno)
        {
           
            int indice = this.obtenerIndice();

                if (existeAlumno(alumno) && indice != -1)
                    this.listaDeAlumnos[indice] = alumno;
                else
                {
                    if (!existeAlumno(alumno))
                    {
                        Console.WriteLine("El alumno ya existe.");
                    }
                    else
                        Console.WriteLine("No hay lugar");
                }

        }

        public void borrarAlumno(alumno alumno)
        {
            int contador;
            for (contador = 0; contador < 10; contador++)
            {
                if ((object)this.listaDeAlumnos != null && listaDeAlumnos[contador] == alumno)
                {
                    this.listaDeAlumnos[contador] = null;
                }
            }
        }

        public bool existeAlumno(alumno alumno)
        {
            int contador;
            for (contador = 0; contador < 10; contador++)
            {
                if (obtenerIndice(alumno) == -1)
                    return true;
            }

            return false;
            
            
        }

        public static bool operator ==(aula aula1, alumno alumno1)
        {
            for (int contador = 0; contador < 10; contador++)
			{
			     if (aula1.listaDeAlumnos[contador].legajo == alumno1.legajo)
                     return true;
			}
            return false;
        }

        public static bool operator !=(aula aula1, alumno alumno1)
        {
            for (int contador = 0; contador < 10; contador++)
            {
                if (aula1.listaDeAlumnos[contador].legajo != alumno1.legajo)
                    return true;
            }
            return false;
        }

        public static aula operator + (aula aula1, alumno alumno1)
        {
            aula1.agregarALumno(alumno1);
            return aula1;
        }

        public static aula operator -(aula aula1, alumno alumno1)
        {
            aula1.borrarAlumno(alumno1);
            return aula1;
        }
    }
}










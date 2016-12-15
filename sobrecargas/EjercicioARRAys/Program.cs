using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioARRAys
{
    public class Program
    {
        static void Main(string[] args)
        {
            aula miPrimerAula;
            alumno alumno1;
            alumno alumno2;
            alumno alumno3;
            alumno alumno4;
            miPrimerAula = new aula();
            

            alumno1 = new alumno();
            alumno1.nombre = "juan";
            alumno1.legajo = 1;
            miPrimerAula.agregarALumno(alumno1);

            alumno2 = new alumno();
            alumno2.nombre = "pepe";
            alumno2.legajo = 2;
            miPrimerAula.agregarALumno(alumno2);

            alumno3 = new alumno();
            alumno3.nombre = "pablo";
            alumno3.legajo = 3;
            miPrimerAula.agregarALumno(alumno3);

            alumno4 = new alumno();
            alumno4.nombre = "lolo";
            alumno4.legajo = 4;
            miPrimerAula.agregarALumno(alumno4);

            aula.mostrarAlumnos(miPrimerAula);


            miPrimerAula.agregarALumno(alumno1);
            miPrimerAula.agregarALumno(alumno2);
            miPrimerAula.agregarALumno(alumno3);
            miPrimerAula.agregarALumno(alumno4);
            // aula.mostrarAlumnos(miPrimerAula);
            if (alumno1 == alumno2)
            {
                Console.WriteLine("igual");
            }

            

            Console.ReadKey();
        }
    }
}

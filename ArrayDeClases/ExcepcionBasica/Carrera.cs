using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionBasica
{
    public class Carrera
    {
        public List<Auto> misAutos;
        public string autodromo;

        public Carrera(string nombreAutodromo)
        {
            this.misAutos = new List<Auto>();
            this.autodromo = nombreAutodromo;
        }

        public void correrCarrera()
        {
            int i = 0;

            if (this.misAutos.Count < 2)
                throw new CarreraException(this, "NO HAY AUTOSSSS SUFICIENTES.", DateTime.Now);
            else
            {
                try
                {
                    foreach (Auto item in this.misAutos)
                    {
                        item.andar();
                        i++;

                        if(i == 4)
                            Console.WriteLine("La carrera se realizo correctamente.");
                    }
                }
                catch (AutoException ex)
                {
                    throw new CarreraException(this, "NO ANDA EL AUTO" + this.misAutos[i].numero + " (viene de autoException) \n" + ex.textoHoraDeLaExcepcion, ex.horaDeLaExcepcion, ex);
                }
                

            }

                
            
        }

    }
}

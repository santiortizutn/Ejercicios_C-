using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionBasica
{
    public class Auto
    {
        public string marca;
        public int numero;
        public List<Rueda> misRuedas;

        public Auto(string marca, int numero)
        {
            this.marca = marca;
            this.numero = numero;
            this.misRuedas = new List<Rueda>();
        }

        public void andar()
        {
            if (this.misRuedas.Count < 4)
                throw new AutoException(this, "NO HAY SUFICIENTES RUEDAS.", DateTime.Now);
            else
            {
                try
                {
                    foreach (Rueda item in this.misRuedas)
                    {
                        item.rodar();
                    }
                }
                catch(PinchaduraException ex)
                {
                    throw new AutoException(this, "NO PUEDE ANDAR EL AUTO. (viene de pinchaduraException) \n" + ex.textoHoraDeLaExcepcion, ex.horaDeLaExcepcion, ex);
                }
            }
        }
    }
}

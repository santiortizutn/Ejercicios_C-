using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexador
{
    public class Laboratorio
    {
        public string nombre;
        public List<PC> listaDePC;

        public Laboratorio(string nombre)
        {
            this.nombre = nombre;
            listaDePC = new List<PC>();
        }

        public PC this[int indice]
        {
            set
            {
                if (indice == this.listaDePC.Count)
                {
                    this.listaDePC.Add(value);
                }
                else
                {
                    if (indice >= 0 && indice < this.listaDePC.Count)
                    {
                        this.listaDePC[indice] = value;
                    }
                }
                
            }


            get
            {
                if (indice >= 0 && indice <= this.listaDePC.Count)
                    return this.listaDePC[indice];
                    return null;
            }
                
        }
    }
}

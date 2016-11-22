using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexador
{
    public class PC
    {
        public string marca;
        public string so;
        public static int contadorPC;
        public int numero;

       /* public PC(string marca, string so):this(marca)
        {
            this.marca = marca;
            
        }*/

        private PC(string marca)
        {
            this.marca = marca;
            this.numero = contadorPC;
            this.so = "Windows";
        }

        static PC()
        {
            contadorPC = 1;
        }

        public static implicit operator PC(string marca)
        {
            return new PC(marca);
        }
    }
}

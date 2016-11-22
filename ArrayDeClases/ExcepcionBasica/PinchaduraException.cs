using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionBasica
{
    public class PinchaduraException : MiExcepcion
    {
        public string marcaRueda;

        public PinchaduraException(string marca, string mensaje, DateTime hora)
            : base(mensaje, hora)
        {
            this.marcaRueda = marca;
        }
    }
}

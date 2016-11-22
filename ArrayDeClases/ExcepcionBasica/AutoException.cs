using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionBasica
{
    public class AutoException : MiExcepcion
    {
        public Auto miAuto;

        public AutoException(Auto unAuto, string mensaje, DateTime hora)
            : base(mensaje, hora)
        {
            this.miAuto = unAuto;
            
        }

        public AutoException(Auto unAuto, string mensaje, DateTime hora, Exception excepcionAnterior)
            : this(unAuto, mensaje, hora)
        { }
    }
}

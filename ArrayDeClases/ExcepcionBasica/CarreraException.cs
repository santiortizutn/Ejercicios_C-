using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionBasica
{
    public class CarreraException : MiExcepcion
    {
        public Carrera miCarrera;

        public CarreraException(Carrera unaCarrera, string mensaje, DateTime hora)
            : base(mensaje, hora)
        {
            this.miCarrera = unaCarrera;
        }

        public CarreraException(Carrera unaCarrera, string mensaje, DateTime hora, Exception excepcionAnterior)
            : this(unaCarrera, mensaje, hora)
        {  }
    }
}

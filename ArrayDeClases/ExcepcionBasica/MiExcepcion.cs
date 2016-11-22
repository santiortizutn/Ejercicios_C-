using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionBasica
{
    public class MiExcepcion:Exception
    {
        public DateTime horaDeLaExcepcion;
        public string textoHoraDeLaExcepcion;

        public MiExcepcion(string mensaje, DateTime hora):base(mensaje)
        {
            this.horaDeLaExcepcion = hora;
            this.textoHoraDeLaExcepcion = mensaje;
        }

    }
}

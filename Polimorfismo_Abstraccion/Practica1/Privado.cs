using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Privado:Avion, IAfip
    {
        public Privado(string patente)
            : base(patente)
        { }


       
    }
}

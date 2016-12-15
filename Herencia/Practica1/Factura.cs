using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Factura:Documento
    {
        public float importe;

        public Factura(int numero):base(numero)
        {
 
        }

        public Factura(int numero, string fecha, int numControl):base(numero, fecha, numControl)
        {
            
        }
    }
}

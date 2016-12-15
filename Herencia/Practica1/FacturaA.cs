using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class FacturaA:Factura
    {
        public int iva;
        public FacturaA(int iva, Factura factura1):base(factura1.numero, factura1.fecha, factura1.numeroControl)
        { 

        }
    }
}

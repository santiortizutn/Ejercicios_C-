using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class FacturaAPagada:FacturaA
    {
        public string fechaDePago;

        public FacturaAPagada(string fechaDepago, FacturaA facturaA):base(facturaA.iva, facturaA)
        {}
    }
}

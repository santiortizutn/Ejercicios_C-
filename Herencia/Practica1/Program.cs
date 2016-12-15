using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Factura miFactura = new Factura(6);
            Remito miRemito = new Remito(8);
            FacturaA miFactutaA = new FacturaA(6, miFactura);
            FacturaAPagada miFacturaAPagada = new FacturaAPagada("dsfsd", miFactutaA);

            
            List<Documento> miListado = new List<Documento>();

            miListado.Add(miFactura);
            miListado.Add(miRemito);
            miListado.Add(miFactutaA);
            miListado.Add(miFacturaAPagada);

            foreach (Documento item in miListado)
            {
                item.mostrar();
            }

            
            Console.ReadKey();
        }
    }
}

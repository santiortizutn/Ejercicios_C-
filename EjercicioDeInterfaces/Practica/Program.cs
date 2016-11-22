using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Program
    {
        static void Main(string[] args)
        {
            Avion nuevo = new Avion(200, 5000);

            double impuesto = nuevo.CalcularImpuesto();

            Console.WriteLine(Gestion.MostrarImpuestoNacional(nuevo));
            Console.WriteLine(Gestion.MostrarImpuestoProvincial(nuevo));
            Console.ReadKey();
        }
    }
}

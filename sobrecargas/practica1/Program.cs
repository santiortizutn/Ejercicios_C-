using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    public class Program
    {
        static void Main(string[] args)
        {
            producto prod1 = (producto)33;
            int resultado;
            resultado = prod1 + prod1;
            Console.WriteLine(resultado);
            Console.ReadKey();

        }
    }
}

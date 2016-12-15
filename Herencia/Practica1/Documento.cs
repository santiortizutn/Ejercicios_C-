using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Documento
    {
        public int numero;
        public string fecha;
        public int numeroControl;

        public Documento(int numero)
        {
            this.numero = numero;
        }

        public Documento(int numero, string fecha, int numControl):this(numero)
        {
            this.fecha = fecha;
            this.numeroControl = numControl;
        }
        
        public void mostrar()
        {
            Console.WriteLine("Numero: " + this.numero);
        }
    }
}

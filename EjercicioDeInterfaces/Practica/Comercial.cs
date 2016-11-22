using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Comercial:Avion, IARBA
    {
        public Comercial(double precio, double velMax)
            : base(precio, velMax)
        {
            
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine("Avion comercial.Precio: " + this._precio);
        }



        public double CalcularImpuesto()
        {
            return (this._precio*25)/100;
        }
    }
}

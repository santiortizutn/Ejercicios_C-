using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Privado:Avion
    {
        public Privado(double precio, double velMax)
            : base(precio, velMax)
        { }

        public override void MostrarPrecio()
        {
            Console.WriteLine("Avion privado.Precio: " + this._precio);
        }
    }

}

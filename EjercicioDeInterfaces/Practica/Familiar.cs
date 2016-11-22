using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Familiar:Auto
    {
        protected int _cantAsientos;

        public Familiar(double precio, string patente, int cantidadAsientos)
            : base(precio, patente)
        {
            this._cantAsientos = cantidadAsientos;
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine("Auto familiar.precio: " + this._precio);
        }

        public override void MostrarPatente()
        {
            Console.WriteLine("Auto familiar.patente: " + this._patente);
        }

        
    }
}

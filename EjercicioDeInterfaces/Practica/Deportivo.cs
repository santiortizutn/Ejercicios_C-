using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Deportivo:Auto, IAFIP, IARBA
    {
        protected int _caballosFuerza;
        public double impuesto;

        public Deportivo(double precio, string patente, int hp)
            : base(precio, patente)
        {
            this._caballosFuerza = hp;
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine("Auto deportivo.precio: " + this._precio);
            
        }

        public override void MostrarPatente()
        {
            Console.WriteLine("Auto deportivo.patente: " + this._patente);
        }



        double IAFIP.CalcularImpuesto()
        {
            return (this._precio * 28) / 100;
  
        }



        public double CalcularImpuesto()
        {
            return (this._precio*23)/100;
        }
    }
}

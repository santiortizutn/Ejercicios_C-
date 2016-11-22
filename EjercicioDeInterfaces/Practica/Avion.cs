using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Avion:Vehiculo, IAFIP, IARBA
    {
        protected double _velocidadMaxima;

        public Avion(double precio, double velMax)
            : base(precio)
        {
            this._velocidadMaxima = velMax;
        }

        public override void MostrarPrecio()
        {
            throw new NotImplementedException();
        }

       
        public double CalcularImpuesto()
        {
            return (this._precio * 33) / 100;

             
        }

        double IARBA.CalcularImpuesto()
        {
            return (this._precio * 27)/100;
        }

    }
}

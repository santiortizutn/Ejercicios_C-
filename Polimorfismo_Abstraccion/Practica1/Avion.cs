using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public abstract class Avion:Vehiculo, IAfip
    {
        public float impuesto;

        public Avion(string patente):base(patente)
        { }

        public override float CalcularCosto()
        {
            return 1500f;
        }

        public float Impuesto
        {
            set
            {
                this.impuesto = value;
            }

            get
            {
                return this.impuesto;
            }
        }

        public float RetornarImpuesto()
        {

            Impuesto = (CalcularCosto() * 21) / 100;

            return Impuesto;
        }
    }
}

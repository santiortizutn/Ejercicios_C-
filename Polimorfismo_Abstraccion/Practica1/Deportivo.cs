using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Deportivo:Auto, IAfip
    {
        public float impuesto;

        public Deportivo(string patente):base(patente)
        { }

        public override float CalcularCosto()
        {
            return 150f;
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

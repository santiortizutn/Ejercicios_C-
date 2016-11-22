using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public abstract class Vehiculo
    {
        public string patente;

        public Vehiculo(string patente)
        {
            this.patente = patente;
        }


        public override string ToString()
        {
            return this.patente;
        }

        public virtual string MostrarDatos()
        {
            StringBuilder nuevoSB = new StringBuilder();

            nuevoSB.AppendLine("Vehiculo: ");
            nuevoSB.AppendLine(this.patente);

            return nuevoSB.ToString();
        }

        public abstract float CalcularCosto();
        
    }

}

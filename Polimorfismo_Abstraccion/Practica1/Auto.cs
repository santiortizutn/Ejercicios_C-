using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public abstract class Auto:Vehiculo
    {
        int cantidadDePuertas = 1;
       

        public Auto(string patente):base(patente)
        { }

        public override string MostrarDatos()
        {
            StringBuilder nuevoSB = new StringBuilder();

            nuevoSB.AppendLine(base.MostrarDatos());
            nuevoSB.AppendLine("Auto: ");
            nuevoSB.AppendLine("Cantidad de puertas: " + this.cantidadDePuertas.ToString());

            return nuevoSB.ToString();
        }



       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    public class dolar
    {
        public int valor;

        public dolar(int valor)
        {
            this.valor = valor;
        }

        public static dolar operator + (peso unP, dolar unD)
        {
            unD = (dolar)(unD.valor + (peso)unP.valor);

            return unD;
        }

        public static implicit operator dolar(int valor)
        {
            return new dolar(valor);
        }
        
    }
}

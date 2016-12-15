using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    public class peso
    {
        public int valor;

        public peso(int valor)
        {
            this.valor = valor;
        }

        public static peso operator + (peso unP, dolar unD)
        {
            unP.valor = unP.valor + (unD.valor * 15);

            return unP;
        }

        public static implicit operator peso(int valor)
        {
            return new peso(valor);
        }
    }
}

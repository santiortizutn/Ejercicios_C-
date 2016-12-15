using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    public class producto
    {
        private int _cantidad;

        private producto(int cantidad)
        {
            this._cantidad = cantidad;
        }

      /*  public static producto operator + (producto producto, int valor)
        {
            producto._cantidad = producto._cantidad + valor;

            return producto;

        }*/

        public static int operator +(producto producto, producto producto2)
        {
            producto._cantidad = producto._cantidad + producto2._cantidad;

            return producto._cantidad;

        }

        public static implicit operator producto(int valor)
        {
            return new producto(valor);
        }

        


    }
}

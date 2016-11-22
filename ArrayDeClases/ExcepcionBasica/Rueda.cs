using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionBasica
{
    public class Rueda
    {
        public string marca;
        public static Random nroRandom;

        public Rueda(string marca)
        {
            this.marca = marca;
        }

        static Rueda()
        {
            nroRandom = new Random();
        }

        public void rodar()
        {
            int elRandom;

            elRandom = nroRandom.Next(1, 10);

            if (elRandom == 5)
                this.pinchar();
            else
                Console.WriteLine("El random: " + elRandom);
        }



        public void pinchar()
        {
            throw new PinchaduraException(this.marca, "PINCHASTE UNA GOMA.", DateTime.Now);
        }
    }
}

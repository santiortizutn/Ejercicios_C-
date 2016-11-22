using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Familiar familiar = new Familiar("srff");
            Deportivo deportivo = new Deportivo("sdifusa");
            Comercial comercial = new Comercial("dfhsodf");
            Privado privado = new Privado("sdfs");
            Carreta carreta = new Carreta("sdfsdaf");
            List<Vehiculo> listado = new List<Vehiculo>();
            List<IAfip> listadoAfip = new List<IAfip>();

            listado.Add(familiar);
            listado.Add(deportivo);
            listado.Add(privado);
            listado.Add(comercial);
            listado.Add(carreta);

            foreach (Vehiculo item in listado)
            {
                item.CalcularCosto();
                
            }

            listadoAfip.Add(privado);
            listadoAfip.Add(comercial);
            listadoAfip.Add(deportivo);

            foreach (IAfip item in listadoAfip)
            {
                if (item is Deportivo)
                {
                    Console.WriteLine("Auto");
                    Console.WriteLine("Impuesto: " + Gestion.MostrarImp(item));
                }

                if (item is Privado)
                {
                    Console.WriteLine("Avion privado");
                    Console.WriteLine("Impuesto: " + Gestion.MostrarImp(item));
                }

                if (item is Comercial)
                {
                    Console.WriteLine("Avion comercial");
                    Console.WriteLine("Impuesto: " + Gestion.MostrarImp(item));
                }
                
            }


            Console.ReadKey();
        }
    }
}

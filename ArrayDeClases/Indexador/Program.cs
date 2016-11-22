using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexador
{
    public class Program
    {
        static void Main(string[] args)
        {
            PC pc1 = "LG";
            PC pc2 = "DELL";
            PC pc3 = "Samsung";
            PC pc4 = "PPPP";

           
            Laboratorio miLab = new Laboratorio("Laboratorio 1");

            miLab[0] = pc1;
            miLab[1] = pc2;
            miLab[2] = pc3;
            miLab[3] = pc4;

            Console.WriteLine(miLab.nombre);

            for (int i = 0; i < miLab.listaDePC.Count; i++)
            {
                Console.WriteLine("\nMarca: " + miLab[i].marca + "\nSO: " + miLab[i].so + "\nPC: " + miLab[i].numero);  
            }

            Console.ReadKey();

        }
    }
}

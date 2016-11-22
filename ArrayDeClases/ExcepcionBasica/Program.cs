using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionBasica
{
    public class Program
    {
        static void Main(string[] args)
        {

            Carrera nuevaCarrera = new Carrera("dsfgsd");
            Auto auto = new Auto("peusho", 1);
            Auto auto2 = new Auto("ford", 2);
            Auto auto3 = new Auto("volsvagen", 3);
            Auto auto4 = new Auto("renou", 4);

            auto.misRuedas.Add(new Rueda("pirelli"));
            auto.misRuedas.Add(new Rueda("pirelli"));
            auto.misRuedas.Add(new Rueda("pirelli"));
            auto.misRuedas.Add(new Rueda("pirelli"));

            auto2.misRuedas.Add(new Rueda("pirelli"));
            auto2.misRuedas.Add(new Rueda("pirelli"));
            auto2.misRuedas.Add(new Rueda("pirelli"));
            auto2.misRuedas.Add(new Rueda("pirelli"));

            auto3.misRuedas.Add(new Rueda("pirelli"));
            auto3.misRuedas.Add(new Rueda("pirelli"));
            auto3.misRuedas.Add(new Rueda("pirelli"));
            auto3.misRuedas.Add(new Rueda("pirelli"));

            auto4.misRuedas.Add(new Rueda("pirelli"));
            auto4.misRuedas.Add(new Rueda("pirelli"));
            auto4.misRuedas.Add(new Rueda("pirelli"));            
            auto4.misRuedas.Add(new Rueda("pirelli"));

            nuevaCarrera.misAutos.Add(auto);
            nuevaCarrera.misAutos.Add(auto2);
            nuevaCarrera.misAutos.Add(auto3);
            nuevaCarrera.misAutos.Add(auto4);

            try
            { nuevaCarrera.correrCarrera(); }

            catch (AutoException ex)
            { Console.WriteLine("AutoEXCP. \n" + ex.Message); }

            catch (PinchaduraException ex)
            { Console.WriteLine("PinchaduraEXCP. \n" + ex.Message); }

            catch (CarreraException ex)
            { Console.WriteLine("CarreraEXCP. \n" + ex.Message); }

            catch (MiExcepcion ex)
            { Console.WriteLine("MiEXCP. \n" + ex.Message); }

            catch (Exception ex)
            { Console.WriteLine("GeneralEXCP. \n" + ex.Message); }
            


            Console.ReadKey();














/*
            try
            {
                LanzarError();
                Operar();
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Error de formato.");
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Division por cero.");
                Console.WriteLine(ex.Message);
            }
            catch (Exception Ex)
            {
                Console.WriteLine("General.");
                Console.WriteLine(Ex.Message); ;
            }
            finally
            {
 
            }

            Console.ReadKey();*/
        }
            
     /*   public static void Operar()
        {
            string dato;
            int numero;

            try
            {
                dato = Console.ReadLine();
                numero = int.Parse(dato);
                numero = numero / numero;
            }
            catch (Exception ex)
            {
                // operaciones para guardar la informacion de la excpecion.

                throw new Exception("se quedo sin internet.");
                
            }
        }

        public static void LanzarError()
        {
            throw new Exception("Se quedo sin memoria RAM.");
        }*/

    }
}

using Business;
using System;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            BarajaEspañola barajaEspañola = new BarajaEspañola();
            Carta ultimaCarta;

            Console.WriteLine($"{barajaEspañola.MostrarTodoElMazo()}");
            

            Console.WriteLine($"----------SACAMOS CARTAS-------------");
            
            for(int i = 0; i < 49; i++)
            {
                ultimaCarta = barajaEspañola.DevolverUltimaCarta();
                Console.WriteLine($"{ultimaCarta.ObtenerNombre()}");
            }

            Console.WriteLine($"----------MAZO ACTUAL-------------");
            Console.WriteLine($"{barajaEspañola.MostrarTodoElMazo()}");

            Console.ReadKey();
        }
    }
}

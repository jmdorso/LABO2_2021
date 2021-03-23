using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();
            Sumador sumador1 = new Sumador(2);
            long a = 5;
            long b = 3;
            long resultado;
            long cantSumas;
            string aString = "Hola ";
            string bString = "Mundo";
            string rString;
            bool esIgual;


            rString = sumador.Sumar(aString, bString);
            resultado = sumador.Sumar(a, b);
            cantSumas = sumador + sumador1;
            esIgual = sumador | sumador1;

            Console.WriteLine($"Los textos concatenados dan la palabra: {rString}");
            Console.WriteLine($"Los numeros sumados dan el resultado: {resultado}");
            Console.WriteLine($"Cantidad de sumas entre ambos sumadores: {cantSumas}");
            Console.WriteLine($"Cantidad de sumas de sumador: {(int)(sumador)}");
            Console.WriteLine($"Cantidad de sumas de sumador1: {(int)(sumador1)}");
            Console.WriteLine($"Cantidad de sumas entre ambos sumadores: {cantSumas}");
            Console.WriteLine($"¿ Son iguales sumador y sumador1 ? {esIgual}");
            Console.ReadKey();
        }
    }
}

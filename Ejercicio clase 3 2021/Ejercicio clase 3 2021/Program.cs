using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_clase_3_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Mascota mascota = new Mascota("Pepa", "Gato", new DateTime(2004, 08, 23));
            Mascota mascota2 = new Mascota("Moro", "Perro", new DateTime(2017, 01, 25));

            mascota.AgregarVacuna("Rabia");
            mascota.AgregarVacuna("Triple viral");

            Cliente cliente = new Cliente("Juan Martin", "Dorso", "Suarez", "42036068");

            cliente.AgregarMascota(mascota);
            cliente.AgregarMascota(mascota2);

            Console.WriteLine(cliente.MostrarDatos(cliente));
            //Console.WriteLine(mascota.MostrarDatos(mascota));

            Console.ReadKey();
        }
    }
}

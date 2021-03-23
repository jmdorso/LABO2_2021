using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private string domicilio;
        private string telefono;
        Mascota[] mascotas;

        public Cliente()
        {

        }

        public Cliente(string nombre, string apellido, string domicilio, string telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.domicilio = domicilio;
            this.telefono = telefono;
            this.mascotas = new Mascota[20];
        }

        public void AgregarMascota(Mascota mascota)
        {
            for (int i = 0; i < 20; i++)
            {
                if (this.mascotas[i] == null)
                {
                    this.mascotas[i] = mascota;
                    break;
                }
            }
        }

        public string MostrarDatos(Cliente cliente)
        {
            StringBuilder auxRetorno = new StringBuilder();

            auxRetorno.AppendLine($"NOMBRE: {cliente.nombre}\r");
            auxRetorno.AppendLine($"APELLIDO : {cliente.apellido}\r");
            auxRetorno.AppendLine($"DOMICILIO : {cliente.domicilio}\r");
            auxRetorno.AppendLine($"TELEFONO : {cliente.telefono}\r");
            auxRetorno.AppendLine($"MASCOTAS: \r");
            for (int i = 0; i < 20; i++)
            {
                if (cliente.mascotas[i] != null)
                {
                    auxRetorno.AppendLine($"{cliente.mascotas[i].MostrarDatos(cliente.mascotas[i])}\r");
                }
            }

            auxRetorno.AppendLine("---------------------");

            return auxRetorno.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Usuario
    {
        string apellido;
        string nombre;
        long dni;

        public Usuario(string apellido, string nombre, long dni)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.dni = dni;
        }
    }
}

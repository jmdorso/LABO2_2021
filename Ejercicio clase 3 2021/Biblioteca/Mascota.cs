using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Mascota
    {
        private string nombre;
        private string especie;
        private DateTime fechaNacimiento;
        private string[] historialVacunacion;

        public Mascota()
        {

        }

        public Mascota(string nombre, string especie, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.fechaNacimiento = fechaNacimiento;
            this.historialVacunacion = new string[20];
        }

        public void AgregarVacuna(string vacuna)
        {
            for(int i=0;i<20;i++)
            {
                if(this.historialVacunacion[i] == null)
                {
                    this.historialVacunacion[i] = vacuna;
                    break;
                }
            }
        }

        public string MostrarDatos(Mascota mascota)
        {
            StringBuilder auxRetorno = new StringBuilder();

            auxRetorno.AppendLine($"NOMBRE: {mascota.nombre}\r");
            auxRetorno.AppendLine($"ESPECIE : {mascota.especie}\r");
            auxRetorno.AppendLine($"FECHA NACIMIENTO : {mascota.fechaNacimiento}\r");
            for(int i=0;i<20;i++)
            {
                if(mascota.historialVacunacion[i] != null)
                {
                    auxRetorno.AppendLine($"VACUNAS: {mascota.historialVacunacion[i]}\r");
                }
            }

            auxRetorno.AppendLine("---------------------");

            return auxRetorno.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public enum TipoLLamada { Local, Provincial, Todas}

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        public string Mostrar()
        {
            StringBuilder auxRetorno = new StringBuilder();

            auxRetorno.AppendLine($"Numero Origen: {NroOrigen}");
            auxRetorno.AppendLine($"Numero Destino: {NroDestino}");
            auxRetorno.AppendLine($"Duracion: {Duracion}");

            return auxRetorno.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int auxRetorno = 0;

            if (llamada1.Duracion < llamada2.Duracion)
            {
                auxRetorno = -1;
            }
            else if(llamada1.Duracion > llamada2.Duracion)
            {
                auxRetorno = 1; 
            }

            return auxRetorno;
        }
    }
}

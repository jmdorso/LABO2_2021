using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            return (float)this.Duracion * this.costo;
        }

        public string Mostrar()
        {
            StringBuilder auxRetorno = new StringBuilder();

            auxRetorno.AppendLine($"{base.Mostrar()}");
            auxRetorno.AppendLine($"Costo de la llamada: $ {this.CostoLlamada}");

            return auxRetorno.ToString();
        }
    }
}

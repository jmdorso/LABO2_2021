using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial :  Llamada
    {
        public enum Franja { Franja_1, Franja_2, Franja_3}

        protected Franja franjaHoraria;

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion,destino,origen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NroOrigen,miFranja, llamada.Duracion, llamada.NroDestino)
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
            float auxRetorno = 0;

            switch(this.franjaHoraria)
            {
                case Franja.Franja_1:
                    auxRetorno = (float)0.99 * this.Duracion;
                    break;
                case Franja.Franja_2:
                    auxRetorno = (float)1.25 * this.Duracion;
                    break;
                case Franja.Franja_3:
                    auxRetorno = (float)0.66 * this.Duracion;
                    break;
            }

            return auxRetorno;
        }

        public string Mostrar()
        {
            StringBuilder auxRetorno = new StringBuilder();

            auxRetorno.AppendLine($"{base.Mostrar()}");
            auxRetorno.AppendLine($"Franja Horaria: {this.franjaHoraria}");
            auxRetorno.AppendLine($"Costo de la llamada: $ {this.CostoLlamada}");

            return auxRetorno.ToString();
        }
    }
}

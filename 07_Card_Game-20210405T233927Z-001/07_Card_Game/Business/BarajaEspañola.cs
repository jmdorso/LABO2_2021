using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BarajaEspañola 
    {
        private Carta[] cartasEspañolas;


        public BarajaEspañola()
        {
            cartasEspañolas = new Carta[48];

            for(int i = 0; i < 4; i++)
            {
                for(int j = 1; j <= 12; j++)
                {
                    cartasEspañolas[((i * 12) + j) - 1] = new Carta((Carta.Valor)j, (Carta.Palo)i);
                }
            }
        }

        public string MostrarTodoElMazo()
        {
            StringBuilder auxRetorno = new StringBuilder();

            foreach(Carta cartaEspañola in cartasEspañolas)
            {
                auxRetorno.AppendLine($"{cartaEspañola.ObtenerNombre()}");
            }

            return auxRetorno.ToString();
        }

        public Carta DevolverUltimaCarta()
        {
            Carta auxRetorno = null;

            if (this.cartasEspañolas.Length > 0 && this.cartasEspañolas[this.cartasEspañolas.Length - 1] != null)
            {
                auxRetorno = this.cartasEspañolas[this.cartasEspañolas.Length - 1];
                 if(this.cartasEspañolas.Length-1 > 0)
                {
                    Array.Resize(ref this.cartasEspañolas, this.cartasEspañolas.Length - 1);
                }

            }

            return auxRetorno;
        }
    }
}

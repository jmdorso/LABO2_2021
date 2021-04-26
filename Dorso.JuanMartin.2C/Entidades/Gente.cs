using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gente : Persona
    {
        #region Constructores
        /// <summary>
        /// Constructor que solo recibe edad y coloca como nombre "Soy un Cliente".  Usa como base el constructor de Persna
        /// </summary>
        /// <param name="edad">edad a cargar en Gente</param>
        public Gente(short edad)
            :base("Soy un Cliente",edad)
        {

        }

        /// <summary>
        /// Constructor que recibe nombre y edad y usa como base el constructor de Persna
        /// </summary>
        /// <param name="nombre">nombre a cargar en Gente</param>
        /// <param name="edad">edad a cargar en Gente</param>
        public Gente(string nombre, short edad)
            :base(nombre,edad)
        {

        }
        #endregion

        #region Metodos y sobrecargas
        /// <summary>
        /// Agrega los datos de Gente, al metodo virtual mostrar de la base
        /// </summary>
        /// <returns>los datos de un objeto Gente</returns>
        protected override string Mostrar()
        {
            StringBuilder auxRetorno = new StringBuilder();

            auxRetorno.AppendLine("ES GENTE");
            auxRetorno.AppendLine(base.Mostrar());

            return auxRetorno.ToString();
        }

        /// <summary>
        /// Valida si el objeto gente es mayor o igual a 18 años
        /// </summary>
        /// <returns>true o false segun corresponda</returns>
        public override bool Validar()
        {
            if (this.Edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}

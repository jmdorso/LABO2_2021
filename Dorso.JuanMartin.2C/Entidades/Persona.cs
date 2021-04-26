using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        #region Atributos
        private short edad;
        private string nombre;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad de lectura y escritura para la edad
        /// </summary>
        public short Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }
        
        /// <summary>
        /// Propiedad de lectura y escritura para el nombre
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            { 
                this.nombre = value;
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor que iniciliza el nombre y edad de una persona, utilizando las propiedades
        /// </summary>
        /// <param name="nombre">nombre a cargar en Persona</param>
        /// <param name="edad">edad a cargar en Persona</param>
        protected Persona(string nombre, short edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
        #endregion

        #region Metodos

        protected virtual string Mostrar()
        {
            return (string)this;
        }

        public static explicit operator string(Persona persona)
        {
            StringBuilder auxRetorno = new StringBuilder();

            if (persona.Validar())
            {
                auxRetorno.AppendLine($"Nombre: {persona.nombre}");
                auxRetorno.AppendLine($"Edad: {persona.edad}");
                return auxRetorno.ToString();
            }
            else
            {
                return "Informacion sin cargar";
            }
        }

        public abstract bool Validar();

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bar
    {
        #region atributos
        private List<Empleado> empleados;
        private List<Gente> gente;
        private static Bar singleton = null;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad solo lectura, que devuelve la lista de Empleados
        /// </summary>
        public List<Empleado> Empleados
        {
            get
            {
                return this.empleados;
            }
        }

        /// <summary>
        /// Propiedad solo lectura, que devuelve la lista de Gente
        /// </summary>
        public List<Gente> Gente
        {
            get
            {
                return this.gente;
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor que crea las nuevas listas de Empleados y Gente
        /// </summary>
        private Bar()
        {
            this.empleados = new List<Empleado>();
            this.gente = new List<Gente>();
        }
        #endregion

        #region Sinleton, Metodos, Sobrecargas y Operadores
        
        /// <summary>
        /// Instancia mediante singleton del bar
        /// </summary>
        /// <returns></returns>
        public static Bar GetBar()
        {
            if (singleton == null)
            {
                singleton = new Bar();
            }
            return singleton;
        }

        /// <summary>
        /// Agrega un empleado al bar
        /// </summary>
        /// <param name="bar">bar a donde va a ser ingresado el empleado</param>
        /// <param name="empleado">empleado a ingresar al bar</param>
        /// <returns>True si el empleado pasa las validaciones, false, si no las pasa</returns>
        public static bool operator +(Bar bar, Empleado empleado)
        {
            foreach (Empleado auxEmpleado in bar.empleados)
            {
                if(auxEmpleado == empleado)
                {
                    return false;
                }
            }
            if(empleado.Validar())
            {
                bar.empleados.Add(empleado);
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Agrega gente al bar
        /// </summary>
        /// <param name="bar">bar a donde va a ser ingresada la gente</param>
        /// <param name="empleado">gente a ingresar al bar</param>
        /// <returns>True si gente pasa las validaciones, false, si no las pasa</returns>
        public static bool operator +(Bar bar, Gente gente)
        {
            int cantGentePosible = bar.empleados.Count * 10;

            if(bar.gente.Count < cantGentePosible && gente.Validar())
            {
                bar.gente.Add(gente);
                return true;
            }
            else
            {
                return false;
            }

        }

        public override string ToString()
        {
            StringBuilder auxRetorno = new StringBuilder();

            auxRetorno.AppendLine($"BAR DE JUAN MARTIN DORSO");
            auxRetorno.AppendLine("-----------------------------------------------------\n");

            foreach(Empleado empleado in this.empleados)
            {
                auxRetorno.AppendLine($"{empleado.ToString()}");
            }
            auxRetorno.AppendLine("-----------------------------------------------------\n");
            foreach (Gente gente in this.gente)
            {
                auxRetorno.AppendLine($"{gente.ToString()}");
            }


            return auxRetorno.ToString();
        }
        #endregion
    }
}

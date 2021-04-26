using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {
        #region Atributo
        private int dni;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor que recibe un nombre y edad, y que inicializa el dni en -1. Utiliza como base, el otro constructor de esta Clase
        /// </summary>
        /// <param name="nombre">nombre a cargar en Empleado</param>
        /// <param name="edad">edad a cargar en Empleado</param>
        public Empleado(string nombre, short edad)
            :this(nombre,edad,-1)
        {

        }

        /// <summary>
        /// Constructor que recibe un nombre, edad y dni. Utiliza como base, el constructor de Persona.
        /// </summary>
        /// <param name="nombre">nombre a cargar en Empleado</param>
        /// <param name="edad">edad a cargar en Empleado</param>
        /// <param name="dni">dni a cargar en Empleado</param>
        public Empleado(string nombre, short edad, int dni)
            :base(nombre,edad)
        {
            this.dni = dni;
        }
        #endregion

        #region Metodos, sobrecargas y operadores

        /// <summary>
        /// Agrega los datos del Empleado, al metodo virtual mostrar de la base
        /// </summary>
        /// <returns>los datos de un empleado</returns>
        protected override string Mostrar()
        {
            StringBuilder auxRetorno = new StringBuilder();

            auxRetorno.AppendLine("ES UN EMPLEADO");
            auxRetorno.Append(base.Mostrar());
            if(this.dni != -1)
            {
                auxRetorno.AppendLine($"DNI: {this.dni}");
            }

            return auxRetorno.ToString();
        }

        /// <summary>
        /// comparo si son iguales 2 empleados por su nombre y edad
        /// </summary>
        /// <param name="empleadooUno">empleado 1 a comparar</param>
        /// <param name="empleadoDos">empleado 2 a comparar</param>
        /// <returns>retorna si el empleado 1 y 2 son iguales</returns>
        public static bool operator ==(Empleado empleadooUno, Empleado empleadoDos)
        {
            return ((empleadooUno.Nombre == empleadoDos.Nombre) && (empleadooUno.Edad == empleadoDos.Edad)) ;
        }

        /// <summary>
        /// comparo si son distintos 2 empleados por su nombre y edad, negando la sobrecarga del operador == 
        /// </summary>
        /// <param name="empleadooUno">empleado 1 a comparar</param>
        /// <param name="empleadoDos">empleado 2 a comparar</param>
        /// <returns>retorna si el empleado 1 y 2 son distintos</returns>
        public static bool operator !=(Empleado empleadooUno, Empleado empleadoDos)
        {
            return !(empleadooUno == empleadoDos);
        }

        /// <summary>
        /// Valida edad y nombre del empleado, siendo edad mayor o igual a 21 y nombre mas de 2 caracteres
        /// </summary>
        /// <returns>True o false segun corresponda</returns>
        public override bool Validar()
        {
            if (this.Edad >= 21 && this.Nombre.Length >= 2)
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace CuentaGanadoForm
{
    public partial class ControlPublicoForm : Form
    {
        #region Atributos
        private Bar bar;
        private static short cantGente = 0;
        private static short cantEmpleados = 0;
        #endregion

        #region Constructor
        public ControlPublicoForm()
        {
            InitializeComponent();
            bar = Bar.GetBar();
        }
        #endregion

        #region Eventos del form
        /// <summary>
        /// Agrega o no un empleado al bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownEmpleados_ValueChanged(object sender, EventArgs e)
        {
            //Si el valor del numericUpAndDown es mayor a la variable cantEmpleados, intento agregar uno
            if (numericUpDownEmpleados.Value > cantEmpleados)
            {
                bool trueOrFalse = false;
                Datos datos = new Datos();
                DialogResult dialogResult = datos.ShowDialog();
                int dni;
                int.TryParse(datos.Dni, out dni);
                short edad;
                short.TryParse(datos.Edad, out edad);

                //Si el DNI ingresado por pantalla es menor o igual a 0 utiliza el constructor que Iniciliza el DNI en -1
                if(dni <= 0)
                {
                    trueOrFalse = bar + new Empleado(datos.Nombre, edad);
                }
                //Sino, utiliza el constructor que carga el DNI. 
                else
                {
                    trueOrFalse = bar + new Empleado(datos.Nombre, edad, dni);
                }

                //Si se pudo agregar correctamente el empleado, aumento la variable estatica de cantEmpleados
                if (trueOrFalse)
                {
                    cantEmpleados += 1;
                }
                //Sino se pudo, informo al usuario y vuelvo el NumericUpAndDown al valor anterior.
                else
                {
                    MessageBox.Show("La persona ingresada no puede ser empleado/a del bar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    numericUpDownEmpleados.Value -= 1;
                }
            }
            //Si el valor del NumericUpAndDown es menor a la variable estatica cantEmpleados, elimino SI ES POSIBLE, el ULTIMO empleado
            else if ((numericUpDownEmpleados.Value < cantEmpleados)  )
            {
                //Si el valor del NumericUpAndDown multiplicado por 10, es superior a la cantidad de gente, elimino el ultimo empleado
                if ((numericUpDownEmpleados.Value * 10) >= cantGente)
                { 
                bar.Empleados.Remove(bar.Empleados.Last());
                cantEmpleados -= 1;
                }
                //Si no cumple con la condicion 1 cada 10, no elimino.
                else
                {
                    MessageBox.Show("El bar necesita 1 empleado, cada 10 clientes. " +
                    "No puede eliminarse el empleado mientras haya mas gente de la permitida para el resto de " +
                    "empleados", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    numericUpDownEmpleados.Value = cantEmpleados;
                }
            }

        }

        private void numericUpDownGente_ValueChanged(object sender, EventArgs e)
        {
            //Si el valor del numericUpAndDown es mayor a la variable cantGente, intento agregar.
            if (numericUpDownGente.Value > cantGente)
            {
                bool trueOrFalse = false;
                Datos datos = new Datos();
                DialogResult dialogResult = datos.ShowDialog();
                short edad;
                short.TryParse(datos.Edad, out edad);
                
                //Sino ingresa nombre, usa el constrcutor que recibe solo la edad y valida el nombre como: Soy cliente
                if(datos.Nombre.Length == 0)
                {
                    trueOrFalse = bar + new Gente(edad);
                }
                //Si ingresa nombre, usa el constructor que recibe edad y nombre. 
                else
                {
                    trueOrFalse = bar + new Gente(datos.Nombre, edad);
                }

                //Si se pudo agregar correctamente la gente, aumento la variable estatica de cantGente
                if (trueOrFalse)
                {
                    cantGente += 1;
                }
                //Sino se pudo, informo al usuario y vuelvo el NumericUpAndDown al valor anterior.
                else
                {
                    MessageBox.Show("La persona ingresada no puede ser cliente del bar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    numericUpDownGente.Value -= 1;
                }
            }
            //Si el valor del NumericUpAndDown es menor a la variable estatica cantGente, elimino el PRIMERO
            else if (numericUpDownGente.Value < cantGente)
            {
                bar.Gente.Remove(bar.Gente.First());
                cantGente -= 1;
            }
        }

        private void buttonInforme_Click(object sender, EventArgs e)
        {
            MostrarDatosForm mostrarDatosForm = new MostrarDatosForm(bar);
            DialogResult dialogResult = mostrarDatosForm.ShowDialog();
        }
    }
    #endregion

        //Los numericUpAndDown son solo lectura, se pueden modificar solamente a traves de las flechas. 
}

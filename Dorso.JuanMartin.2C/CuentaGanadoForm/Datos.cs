using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentaGanadoForm
{
    public partial class Datos : Form
    {
        public Datos()
        {
            InitializeComponent();
        }

        public string Nombre
        {
            get
            {
                return textBoxNombre.Text;
            }
        }

        public string Edad
        {
            get
            {
                return textBoxEdad.Text;
            }
        }

        public string Dni
        {
            get
            {
                return textBoxDni.Text;
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

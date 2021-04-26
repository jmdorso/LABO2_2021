using Entidades;
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
    public partial class MostrarDatosForm : Form
    {
        public MostrarDatosForm(Bar bar)
        {
            InitializeComponent();
            richTextBoxSalidaDeTest.Text = bar.ToString();
        }
    }
}

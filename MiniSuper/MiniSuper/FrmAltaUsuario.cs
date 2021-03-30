using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSuper
{
    public partial class FrmAltaUsuario : Form
    {
        Usuario usuario;
        public FrmAltaUsuario()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string[] formasDePago = new string[0];

            foreach(Control miControl in this.pnlFormaPago.Controls)
            {
                if(miControl is CheckBox && ((CheckBox)miControl).Checked)
                {
                    Array.Resize<string>(ref formasDePago, formasDePago.Length + 1);
                    formasDePago[formasDePago.Length - 1] = ((CheckBox)miControl).Text;
                }
            }

            this.usuario = new Usuario(this.txtApellido.Text, this.txtNombre.Text, (long)this.nudDni.Value);



            this.Close();
        }
    }
}

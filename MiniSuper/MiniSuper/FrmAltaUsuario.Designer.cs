namespace MiniSuper
{
    partial class FrmAltaUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.nudDni = new System.Windows.Forms.NumericUpDown();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.checkBoxEfectivo = new System.Windows.Forms.CheckBox();
            this.checkBoxTarjeta = new System.Windows.Forms.CheckBox();
            this.checkBoxAplicacion = new System.Windows.Forms.CheckBox();
            this.pnlFormaPago = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudDni)).BeginInit();
            this.pnlFormaPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 9);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(12, 105);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "DNI:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(62, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(293, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(63, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(292, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // nudDni
            // 
            this.nudDni.Location = new System.Drawing.Point(62, 98);
            this.nudDni.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudDni.Name = "nudDni";
            this.nudDni.Size = new System.Drawing.Size(293, 20);
            this.nudDni.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(152, 241);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // checkBoxEfectivo
            // 
            this.checkBoxEfectivo.AutoSize = true;
            this.checkBoxEfectivo.Location = new System.Drawing.Point(0, 9);
            this.checkBoxEfectivo.Name = "checkBoxEfectivo";
            this.checkBoxEfectivo.Size = new System.Drawing.Size(65, 17);
            this.checkBoxEfectivo.TabIndex = 7;
            this.checkBoxEfectivo.Text = "Efectivo";
            this.checkBoxEfectivo.UseVisualStyleBackColor = true;
            // 
            // checkBoxTarjeta
            // 
            this.checkBoxTarjeta.AutoSize = true;
            this.checkBoxTarjeta.Location = new System.Drawing.Point(81, 9);
            this.checkBoxTarjeta.Name = "checkBoxTarjeta";
            this.checkBoxTarjeta.Size = new System.Drawing.Size(59, 17);
            this.checkBoxTarjeta.TabIndex = 8;
            this.checkBoxTarjeta.Text = "Tarjeta";
            this.checkBoxTarjeta.UseVisualStyleBackColor = true;
            // 
            // checkBoxAplicacion
            // 
            this.checkBoxAplicacion.AutoSize = true;
            this.checkBoxAplicacion.Location = new System.Drawing.Point(163, 9);
            this.checkBoxAplicacion.Name = "checkBoxAplicacion";
            this.checkBoxAplicacion.Size = new System.Drawing.Size(69, 17);
            this.checkBoxAplicacion.TabIndex = 9;
            this.checkBoxAplicacion.Text = "Apliacion";
            this.checkBoxAplicacion.UseVisualStyleBackColor = true;
            // 
            // pnlFormaPago
            // 
            this.pnlFormaPago.Controls.Add(this.checkBoxAplicacion);
            this.pnlFormaPago.Controls.Add(this.checkBoxTarjeta);
            this.pnlFormaPago.Controls.Add(this.checkBoxEfectivo);
            this.pnlFormaPago.Location = new System.Drawing.Point(15, 129);
            this.pnlFormaPago.Name = "pnlFormaPago";
            this.pnlFormaPago.Size = new System.Drawing.Size(262, 37);
            this.pnlFormaPago.TabIndex = 10;
            // 
            // FrmAltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 276);
            this.Controls.Add(this.pnlFormaPago);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.nudDni);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Name = "FrmAltaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta de usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.nudDni)).EndInit();
            this.pnlFormaPago.ResumeLayout(false);
            this.pnlFormaPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown nudDni;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.CheckBox checkBoxEfectivo;
        private System.Windows.Forms.CheckBox checkBoxTarjeta;
        private System.Windows.Forms.CheckBox checkBoxAplicacion;
        private System.Windows.Forms.Panel pnlFormaPago;
    }
}
namespace CuentaGanadoForm
{
    partial class ControlPublicoForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelEmpleados = new System.Windows.Forms.Label();
            this.labelGente = new System.Windows.Forms.Label();
            this.buttonInforme = new System.Windows.Forms.Button();
            this.numericUpDownEmpleados = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGente = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGente)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEmpleados
            // 
            this.labelEmpleados.AutoSize = true;
            this.labelEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpleados.Location = new System.Drawing.Point(12, 32);
            this.labelEmpleados.Name = "labelEmpleados";
            this.labelEmpleados.Size = new System.Drawing.Size(265, 55);
            this.labelEmpleados.TabIndex = 0;
            this.labelEmpleados.Text = "Empleados";
            // 
            // labelGente
            // 
            this.labelGente.AutoSize = true;
            this.labelGente.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGente.Location = new System.Drawing.Point(12, 116);
            this.labelGente.Name = "labelGente";
            this.labelGente.Size = new System.Drawing.Size(155, 55);
            this.labelGente.TabIndex = 0;
            this.labelGente.Text = "Gente";
            // 
            // buttonInforme
            // 
            this.buttonInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInforme.Location = new System.Drawing.Point(312, 200);
            this.buttonInforme.Name = "buttonInforme";
            this.buttonInforme.Size = new System.Drawing.Size(120, 38);
            this.buttonInforme.TabIndex = 2;
            this.buttonInforme.Text = "INFORME";
            this.buttonInforme.UseVisualStyleBackColor = true;
            this.buttonInforme.Click += new System.EventHandler(this.buttonInforme_Click);
            // 
            // numericUpDownEmpleados
            // 
            this.numericUpDownEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownEmpleados.Location = new System.Drawing.Point(312, 32);
            this.numericUpDownEmpleados.Name = "numericUpDownEmpleados";
            this.numericUpDownEmpleados.ReadOnly = true;
            this.numericUpDownEmpleados.Size = new System.Drawing.Size(120, 62);
            this.numericUpDownEmpleados.TabIndex = 0;
            this.numericUpDownEmpleados.ValueChanged += new System.EventHandler(this.numericUpDownEmpleados_ValueChanged);
            // 
            // numericUpDownGente
            // 
            this.numericUpDownGente.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownGente.Location = new System.Drawing.Point(312, 116);
            this.numericUpDownGente.Name = "numericUpDownGente";
            this.numericUpDownGente.ReadOnly = true;
            this.numericUpDownGente.Size = new System.Drawing.Size(120, 62);
            this.numericUpDownGente.TabIndex = 1;
            this.numericUpDownGente.ValueChanged += new System.EventHandler(this.numericUpDownGente_ValueChanged);
            // 
            // ControlPublicoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(444, 250);
            this.Controls.Add(this.numericUpDownGente);
            this.Controls.Add(this.numericUpDownEmpleados);
            this.Controls.Add(this.buttonInforme);
            this.Controls.Add(this.labelGente);
            this.Controls.Add(this.labelEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ControlPublicoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contador de Juan Martin Dorso";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmpleados;
        private System.Windows.Forms.Label labelGente;
        private System.Windows.Forms.Button buttonInforme;
        private System.Windows.Forms.NumericUpDown numericUpDownEmpleados;
        private System.Windows.Forms.NumericUpDown numericUpDownGente;
    }
}


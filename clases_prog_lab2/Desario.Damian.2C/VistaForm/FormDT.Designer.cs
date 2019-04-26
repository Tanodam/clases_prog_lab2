namespace VistaForm
{
    partial class FormDT
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblExperiencia = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.numericUpDownEdad = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDni = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownExperiencia = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExperiencia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(16, 270);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(185, 270);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 1;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(34, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(34, 106);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(34, 67);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(34, 151);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 5;
            this.lblDni.Text = "DNI";
            // 
            // lblExperiencia
            // 
            this.lblExperiencia.AutoSize = true;
            this.lblExperiencia.Location = new System.Drawing.Point(34, 188);
            this.lblExperiencia.Name = "lblExperiencia";
            this.lblExperiencia.Size = new System.Drawing.Size(62, 13);
            this.lblExperiencia.TabIndex = 6;
            this.lblExperiencia.Text = "Experiencia";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(114, 32);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNombre.TabIndex = 7;
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Location = new System.Drawing.Point(114, 64);
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(100, 20);
            this.txtBoxApellido.TabIndex = 8;
            // 
            // numericUpDownEdad
            // 
            this.numericUpDownEdad.Location = new System.Drawing.Point(114, 104);
            this.numericUpDownEdad.Name = "numericUpDownEdad";
            this.numericUpDownEdad.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownEdad.TabIndex = 9;
            // 
            // numericUpDownDni
            // 
            this.numericUpDownDni.Location = new System.Drawing.Point(114, 144);
            this.numericUpDownDni.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDownDni.Name = "numericUpDownDni";
            this.numericUpDownDni.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDni.TabIndex = 10;
            // 
            // numericUpDownExperiencia
            // 
            this.numericUpDownExperiencia.Location = new System.Drawing.Point(114, 181);
            this.numericUpDownExperiencia.Name = "numericUpDownExperiencia";
            this.numericUpDownExperiencia.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownExperiencia.TabIndex = 11;
            // 
            // FormDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 322);
            this.Controls.Add(this.numericUpDownExperiencia);
            this.Controls.Add(this.numericUpDownDni);
            this.Controls.Add(this.numericUpDownEdad);
            this.Controls.Add(this.txtBoxApellido);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.lblExperiencia);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnCrear);
            this.Name = "FormDT";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormDT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExperiencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblExperiencia;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.NumericUpDown numericUpDownEdad;
        private System.Windows.Forms.NumericUpDown numericUpDownDni;
        private System.Windows.Forms.NumericUpDown numericUpDownExperiencia;
    }
}


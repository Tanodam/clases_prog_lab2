namespace frmPpal
{
    partial class Form1
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
            this.btnGeneral = new System.Windows.Forms.Button();
            this.btnEspecialista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGeneral
            // 
            this.btnGeneral.Location = new System.Drawing.Point(21, 24);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(376, 120);
            this.btnGeneral.TabIndex = 0;
            this.btnGeneral.Text = "Atender Medico General";
            this.btnGeneral.UseVisualStyleBackColor = true;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // btnEspecialista
            // 
            this.btnEspecialista.Location = new System.Drawing.Point(21, 150);
            this.btnEspecialista.Name = "btnEspecialista";
            this.btnEspecialista.Size = new System.Drawing.Size(376, 120);
            this.btnEspecialista.TabIndex = 1;
            this.btnEspecialista.Text = "Atender Medico Especialista";
            this.btnEspecialista.UseVisualStyleBackColor = true;
            this.btnEspecialista.Click += new System.EventHandler(this.btnEspecialista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 281);
            this.Controls.Add(this.btnEspecialista);
            this.Controls.Add(this.btnGeneral);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Button btnEspecialista;
    }
}


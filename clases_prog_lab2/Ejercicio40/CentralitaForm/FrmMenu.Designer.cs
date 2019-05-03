namespace CentralitaForm
{
    partial class FrmMenu
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
            this.botonGenerarLlamada = new System.Windows.Forms.Button();
            this.botonFacturacionTotal = new System.Windows.Forms.Button();
            this.botonFacturacionLocal = new System.Windows.Forms.Button();
            this.botonFacturacionProvincial = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonGenerarLlamada
            // 
            this.botonGenerarLlamada.Location = new System.Drawing.Point(12, 12);
            this.botonGenerarLlamada.Name = "botonGenerarLlamada";
            this.botonGenerarLlamada.Size = new System.Drawing.Size(189, 58);
            this.botonGenerarLlamada.TabIndex = 0;
            this.botonGenerarLlamada.Text = "Generar Llamada";
            this.botonGenerarLlamada.UseVisualStyleBackColor = true;
            this.botonGenerarLlamada.Click += new System.EventHandler(this.botonGenerarLlamada_Click);
            // 
            // botonFacturacionTotal
            // 
            this.botonFacturacionTotal.Location = new System.Drawing.Point(12, 76);
            this.botonFacturacionTotal.Name = "botonFacturacionTotal";
            this.botonFacturacionTotal.Size = new System.Drawing.Size(189, 58);
            this.botonFacturacionTotal.TabIndex = 1;
            this.botonFacturacionTotal.Text = "FacturacionTotal";
            this.botonFacturacionTotal.UseVisualStyleBackColor = true;
            this.botonFacturacionTotal.Click += new System.EventHandler(this.botonFacturacionTotal_Click);
            // 
            // botonFacturacionLocal
            // 
            this.botonFacturacionLocal.Location = new System.Drawing.Point(12, 140);
            this.botonFacturacionLocal.Name = "botonFacturacionLocal";
            this.botonFacturacionLocal.Size = new System.Drawing.Size(189, 58);
            this.botonFacturacionLocal.TabIndex = 2;
            this.botonFacturacionLocal.Text = "Facturacion Local";
            this.botonFacturacionLocal.UseVisualStyleBackColor = true;
            this.botonFacturacionLocal.Click += new System.EventHandler(this.botonFacturacionLocal_Click);
            // 
            // botonFacturacionProvincial
            // 
            this.botonFacturacionProvincial.Location = new System.Drawing.Point(12, 204);
            this.botonFacturacionProvincial.Name = "botonFacturacionProvincial";
            this.botonFacturacionProvincial.Size = new System.Drawing.Size(189, 58);
            this.botonFacturacionProvincial.TabIndex = 3;
            this.botonFacturacionProvincial.Text = "Facturacion Provincial";
            this.botonFacturacionProvincial.UseVisualStyleBackColor = true;
            this.botonFacturacionProvincial.Click += new System.EventHandler(this.botonFacturacionProvincial_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(12, 268);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(189, 58);
            this.botonSalir.TabIndex = 4;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 335);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonFacturacionProvincial);
            this.Controls.Add(this.botonFacturacionLocal);
            this.Controls.Add(this.botonFacturacionTotal);
            this.Controls.Add(this.botonGenerarLlamada);
            this.Name = "FrmMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonGenerarLlamada;
        private System.Windows.Forms.Button botonFacturacionTotal;
        private System.Windows.Forms.Button botonFacturacionLocal;
        private System.Windows.Forms.Button botonFacturacionProvincial;
        private System.Windows.Forms.Button botonSalir;
    }
}


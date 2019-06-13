namespace CentralitaThreads
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
            this.btnLocales = new System.Windows.Forms.Button();
            this.btnProvinciales = new System.Windows.Forms.Button();
            this.btnTodas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLocales
            // 
            this.btnLocales.Location = new System.Drawing.Point(12, 12);
            this.btnLocales.Name = "btnLocales";
            this.btnLocales.Size = new System.Drawing.Size(124, 23);
            this.btnLocales.TabIndex = 0;
            this.btnLocales.Text = "Locales";
            this.btnLocales.UseVisualStyleBackColor = true;
            this.btnLocales.Click += new System.EventHandler(this.btnLocales_Click);
            // 
            // btnProvinciales
            // 
            this.btnProvinciales.Location = new System.Drawing.Point(12, 41);
            this.btnProvinciales.Name = "btnProvinciales";
            this.btnProvinciales.Size = new System.Drawing.Size(124, 23);
            this.btnProvinciales.TabIndex = 1;
            this.btnProvinciales.Text = "Provinciales";
            this.btnProvinciales.UseVisualStyleBackColor = true;
            // 
            // btnTodas
            // 
            this.btnTodas.Location = new System.Drawing.Point(12, 70);
            this.btnTodas.Name = "btnTodas";
            this.btnTodas.Size = new System.Drawing.Size(124, 23);
            this.btnTodas.TabIndex = 2;
            this.btnTodas.Text = "Todas";
            this.btnTodas.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(153, 112);
            this.Controls.Add(this.btnTodas);
            this.Controls.Add(this.btnProvinciales);
            this.Controls.Add(this.btnLocales);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLocales;
        private System.Windows.Forms.Button btnProvinciales;
        private System.Windows.Forms.Button btnTodas;
    }
}


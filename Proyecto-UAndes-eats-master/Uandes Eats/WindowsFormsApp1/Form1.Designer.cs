namespace WindowsFormsApp1
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
            this.IniciarSesionBoton = new System.Windows.Forms.Button();
            this.RegistrarseBoton = new System.Windows.Forms.Button();
            this.SalirBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IniciarSesionBoton
            // 
            this.IniciarSesionBoton.Location = new System.Drawing.Point(306, 109);
            this.IniciarSesionBoton.Name = "IniciarSesionBoton";
            this.IniciarSesionBoton.Size = new System.Drawing.Size(101, 47);
            this.IniciarSesionBoton.TabIndex = 0;
            this.IniciarSesionBoton.Text = "Iniciar Sesión";
            this.IniciarSesionBoton.UseVisualStyleBackColor = true;
            this.IniciarSesionBoton.Click += new System.EventHandler(this.IniciarSesionBoton_Click);
            // 
            // RegistrarseBoton
            // 
            this.RegistrarseBoton.Location = new System.Drawing.Point(306, 162);
            this.RegistrarseBoton.Name = "RegistrarseBoton";
            this.RegistrarseBoton.Size = new System.Drawing.Size(101, 50);
            this.RegistrarseBoton.TabIndex = 1;
            this.RegistrarseBoton.Text = "Registrarse";
            this.RegistrarseBoton.UseVisualStyleBackColor = true;
            this.RegistrarseBoton.Click += new System.EventHandler(this.RegistrarseBoton_Click);
            // 
            // SalirBoton
            // 
            this.SalirBoton.Location = new System.Drawing.Point(306, 218);
            this.SalirBoton.Name = "SalirBoton";
            this.SalirBoton.Size = new System.Drawing.Size(101, 44);
            this.SalirBoton.TabIndex = 2;
            this.SalirBoton.Text = "Salir";
            this.SalirBoton.UseVisualStyleBackColor = true;
            this.SalirBoton.Click += new System.EventHandler(this.SalirBoton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SalirBoton);
            this.Controls.Add(this.RegistrarseBoton);
            this.Controls.Add(this.IniciarSesionBoton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IniciarSesionBoton;
        private System.Windows.Forms.Button RegistrarseBoton;
        private System.Windows.Forms.Button SalirBoton;
    }
}


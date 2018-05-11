namespace WindowsFormsApp1
{
    partial class AgregarLocal
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
            this.NombreNuevoLocal = new System.Windows.Forms.Label();
            this.NombreNuevoLocalBox = new System.Windows.Forms.TextBox();
            this.UbicacionNuevoLocal = new System.Windows.Forms.Label();
            this.UbicaionLocalNuevoBox = new System.Windows.Forms.TextBox();
            this.TiempoNuevoLocal = new System.Windows.Forms.Label();
            this.TiempoNuevoLocalBox = new System.Windows.Forms.TextBox();
            this.AgregarBoton = new System.Windows.Forms.Button();
            this.CancelarBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NombreNuevoLocal
            // 
            this.NombreNuevoLocal.AutoSize = true;
            this.NombreNuevoLocal.Location = new System.Drawing.Point(274, 86);
            this.NombreNuevoLocal.Name = "NombreNuevoLocal";
            this.NombreNuevoLocal.Size = new System.Drawing.Size(76, 13);
            this.NombreNuevoLocal.TabIndex = 0;
            this.NombreNuevoLocal.Text = "Nombre Local:";
            // 
            // NombreNuevoLocalBox
            // 
            this.NombreNuevoLocalBox.Location = new System.Drawing.Point(277, 103);
            this.NombreNuevoLocalBox.Name = "NombreNuevoLocalBox";
            this.NombreNuevoLocalBox.Size = new System.Drawing.Size(224, 20);
            this.NombreNuevoLocalBox.TabIndex = 1;
            // 
            // UbicacionNuevoLocal
            // 
            this.UbicacionNuevoLocal.AutoSize = true;
            this.UbicacionNuevoLocal.Location = new System.Drawing.Point(274, 126);
            this.UbicacionNuevoLocal.Name = "UbicacionNuevoLocal";
            this.UbicacionNuevoLocal.Size = new System.Drawing.Size(58, 13);
            this.UbicacionNuevoLocal.TabIndex = 2;
            this.UbicacionNuevoLocal.Text = "Ubicacion:";
            // 
            // UbicaionLocalNuevoBox
            // 
            this.UbicaionLocalNuevoBox.Location = new System.Drawing.Point(277, 142);
            this.UbicaionLocalNuevoBox.Name = "UbicaionLocalNuevoBox";
            this.UbicaionLocalNuevoBox.Size = new System.Drawing.Size(224, 20);
            this.UbicaionLocalNuevoBox.TabIndex = 3;
            // 
            // TiempoNuevoLocal
            // 
            this.TiempoNuevoLocal.AutoSize = true;
            this.TiempoNuevoLocal.Location = new System.Drawing.Point(274, 165);
            this.TiempoNuevoLocal.Name = "TiempoNuevoLocal";
            this.TiempoNuevoLocal.Size = new System.Drawing.Size(124, 13);
            this.TiempoNuevoLocal.TabIndex = 4;
            this.TiempoNuevoLocal.Text = "Tiempo de espera aprox:";
            // 
            // TiempoNuevoLocalBox
            // 
            this.TiempoNuevoLocalBox.Location = new System.Drawing.Point(277, 181);
            this.TiempoNuevoLocalBox.Name = "TiempoNuevoLocalBox";
            this.TiempoNuevoLocalBox.Size = new System.Drawing.Size(224, 20);
            this.TiempoNuevoLocalBox.TabIndex = 5;
            // 
            // AgregarBoton
            // 
            this.AgregarBoton.Location = new System.Drawing.Point(277, 220);
            this.AgregarBoton.Name = "AgregarBoton";
            this.AgregarBoton.Size = new System.Drawing.Size(98, 41);
            this.AgregarBoton.TabIndex = 6;
            this.AgregarBoton.Text = "Agregar Local";
            this.AgregarBoton.UseVisualStyleBackColor = true;
            this.AgregarBoton.Click += new System.EventHandler(this.AgregarBoton_Click);
            // 
            // CancelarBoton
            // 
            this.CancelarBoton.Location = new System.Drawing.Point(403, 220);
            this.CancelarBoton.Name = "CancelarBoton";
            this.CancelarBoton.Size = new System.Drawing.Size(98, 41);
            this.CancelarBoton.TabIndex = 7;
            this.CancelarBoton.Text = "Cancelar";
            this.CancelarBoton.UseVisualStyleBackColor = true;
            this.CancelarBoton.Click += new System.EventHandler(this.CancelarBoton_Click);
            // 
            // AgregarLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelarBoton);
            this.Controls.Add(this.AgregarBoton);
            this.Controls.Add(this.TiempoNuevoLocalBox);
            this.Controls.Add(this.TiempoNuevoLocal);
            this.Controls.Add(this.UbicaionLocalNuevoBox);
            this.Controls.Add(this.UbicacionNuevoLocal);
            this.Controls.Add(this.NombreNuevoLocalBox);
            this.Controls.Add(this.NombreNuevoLocal);
            this.Name = "AgregarLocal";
            this.Text = "AgregarLocal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NombreNuevoLocal;
        private System.Windows.Forms.TextBox NombreNuevoLocalBox;
        private System.Windows.Forms.Label UbicacionNuevoLocal;
        private System.Windows.Forms.TextBox UbicaionLocalNuevoBox;
        private System.Windows.Forms.Label TiempoNuevoLocal;
        private System.Windows.Forms.TextBox TiempoNuevoLocalBox;
        private System.Windows.Forms.Button AgregarBoton;
        private System.Windows.Forms.Button CancelarBoton;
    }
}
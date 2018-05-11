namespace WindowsFormsApp1
{
    partial class IniciarSesion
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
            this.RutInicio = new System.Windows.Forms.Label();
            this.IngresarBoton = new System.Windows.Forms.Button();
            this.ContraseñaInicio = new System.Windows.Forms.Label();
            this.RutTextBox = new System.Windows.Forms.TextBox();
            this.ContraseñaTextBox = new System.Windows.Forms.TextBox();
            this.AtrasBoton = new System.Windows.Forms.Button();
            this.IniciarComoComboBox = new System.Windows.Forms.ComboBox();
            this.IniciarComo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RutInicio
            // 
            this.RutInicio.AutoSize = true;
            this.RutInicio.Location = new System.Drawing.Point(303, 108);
            this.RutInicio.Name = "RutInicio";
            this.RutInicio.Size = new System.Drawing.Size(27, 13);
            this.RutInicio.TabIndex = 0;
            this.RutInicio.Text = "Rut:";
            // 
            // IngresarBoton
            // 
            this.IngresarBoton.Location = new System.Drawing.Point(336, 228);
            this.IngresarBoton.Name = "IngresarBoton";
            this.IngresarBoton.Size = new System.Drawing.Size(75, 23);
            this.IngresarBoton.TabIndex = 1;
            this.IngresarBoton.Text = "Ingresar";
            this.IngresarBoton.UseVisualStyleBackColor = true;
            this.IngresarBoton.Click += new System.EventHandler(this.IngresarBoton_Click);
            // 
            // ContraseñaInicio
            // 
            this.ContraseñaInicio.AutoSize = true;
            this.ContraseñaInicio.Location = new System.Drawing.Point(269, 146);
            this.ContraseñaInicio.Name = "ContraseñaInicio";
            this.ContraseñaInicio.Size = new System.Drawing.Size(61, 13);
            this.ContraseñaInicio.TabIndex = 2;
            this.ContraseñaInicio.Text = "Contraseña";
            // 
            // RutTextBox
            // 
            this.RutTextBox.Location = new System.Drawing.Point(336, 108);
            this.RutTextBox.Name = "RutTextBox";
            this.RutTextBox.Size = new System.Drawing.Size(204, 20);
            this.RutTextBox.TabIndex = 3;
            // 
            // ContraseñaTextBox
            // 
            this.ContraseñaTextBox.Location = new System.Drawing.Point(336, 146);
            this.ContraseñaTextBox.Name = "ContraseñaTextBox";
            this.ContraseñaTextBox.Size = new System.Drawing.Size(204, 20);
            this.ContraseñaTextBox.TabIndex = 4;
            // 
            // AtrasBoton
            // 
            this.AtrasBoton.Location = new System.Drawing.Point(465, 228);
            this.AtrasBoton.Name = "AtrasBoton";
            this.AtrasBoton.Size = new System.Drawing.Size(75, 23);
            this.AtrasBoton.TabIndex = 5;
            this.AtrasBoton.Text = "Atras";
            this.AtrasBoton.UseVisualStyleBackColor = true;
            this.AtrasBoton.Click += new System.EventHandler(this.AtrasBoton_Click);
            // 
            // IniciarComoComboBox
            // 
            this.IniciarComoComboBox.AccessibleName = "";
            this.IniciarComoComboBox.Items.AddRange(new object[] {
            "Cliente",
            "Repartidor"});
            this.IniciarComoComboBox.Location = new System.Drawing.Point(336, 182);
            this.IniciarComoComboBox.Name = "IniciarComoComboBox";
            this.IniciarComoComboBox.Size = new System.Drawing.Size(121, 21);
            this.IniciarComoComboBox.TabIndex = 6;
            this.IniciarComoComboBox.Tag = "";
            // 
            // IniciarComo
            // 
            this.IniciarComo.AutoSize = true;
            this.IniciarComo.Location = new System.Drawing.Point(263, 185);
            this.IniciarComo.Name = "IniciarComo";
            this.IniciarComo.Size = new System.Drawing.Size(67, 13);
            this.IniciarComo.TabIndex = 7;
            this.IniciarComo.Text = "Iniciar como:";
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IniciarComo);
            this.Controls.Add(this.IniciarComoComboBox);
            this.Controls.Add(this.AtrasBoton);
            this.Controls.Add(this.ContraseñaTextBox);
            this.Controls.Add(this.RutTextBox);
            this.Controls.Add(this.ContraseñaInicio);
            this.Controls.Add(this.IngresarBoton);
            this.Controls.Add(this.RutInicio);
            this.Name = "IniciarSesion";
            this.Text = "IniciarSesion";
            this.Load += new System.EventHandler(this.IniciarSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RutInicio;
        private System.Windows.Forms.Button IngresarBoton;
        private System.Windows.Forms.Label ContraseñaInicio;
        private System.Windows.Forms.TextBox RutTextBox;
        private System.Windows.Forms.TextBox ContraseñaTextBox;
        private System.Windows.Forms.Button AtrasBoton;
        private System.Windows.Forms.ComboBox IniciarComoComboBox;
        private System.Windows.Forms.Label IniciarComo;
    }
}
namespace WindowsFormsApp1
{
    partial class AdminIniciado
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
            this.LocalesAdminComboBox = new System.Windows.Forms.ComboBox();
            this.MenuAdmin = new System.Windows.Forms.ListBox();
            this.AgregarLocalBoton = new System.Windows.Forms.Button();
            this.QuitarLocalBoton = new System.Windows.Forms.Button();
            this.AgregarPlatoBoton = new System.Windows.Forms.Button();
            this.QuitarPlatoBoton = new System.Windows.Forms.Button();
            this.CerrarSesionBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LocalesAdminComboBox
            // 
            this.LocalesAdminComboBox.FormattingEnabled = true;
            this.LocalesAdminComboBox.Location = new System.Drawing.Point(49, 100);
            this.LocalesAdminComboBox.Name = "LocalesAdminComboBox";
            this.LocalesAdminComboBox.Size = new System.Drawing.Size(229, 21);
            this.LocalesAdminComboBox.TabIndex = 0;
            this.LocalesAdminComboBox.SelectedIndexChanged += new System.EventHandler(this.LocalesAdminComboBox_SelectedIndexChanged);
            // 
            // MenuAdmin
            // 
            this.MenuAdmin.FormattingEnabled = true;
            this.MenuAdmin.Location = new System.Drawing.Point(284, 72);
            this.MenuAdmin.Name = "MenuAdmin";
            this.MenuAdmin.Size = new System.Drawing.Size(331, 199);
            this.MenuAdmin.TabIndex = 1;
            // 
            // AgregarLocalBoton
            // 
            this.AgregarLocalBoton.Location = new System.Drawing.Point(49, 71);
            this.AgregarLocalBoton.Name = "AgregarLocalBoton";
            this.AgregarLocalBoton.Size = new System.Drawing.Size(229, 23);
            this.AgregarLocalBoton.TabIndex = 2;
            this.AgregarLocalBoton.Text = "Agregar Local";
            this.AgregarLocalBoton.UseVisualStyleBackColor = true;
            this.AgregarLocalBoton.Click += new System.EventHandler(this.AgregarLocalBoton_Click);
            // 
            // QuitarLocalBoton
            // 
            this.QuitarLocalBoton.Location = new System.Drawing.Point(49, 127);
            this.QuitarLocalBoton.Name = "QuitarLocalBoton";
            this.QuitarLocalBoton.Size = new System.Drawing.Size(229, 23);
            this.QuitarLocalBoton.TabIndex = 3;
            this.QuitarLocalBoton.Text = "Quitar Local";
            this.QuitarLocalBoton.UseVisualStyleBackColor = true;
            // 
            // AgregarPlatoBoton
            // 
            this.AgregarPlatoBoton.Location = new System.Drawing.Point(487, 283);
            this.AgregarPlatoBoton.Name = "AgregarPlatoBoton";
            this.AgregarPlatoBoton.Size = new System.Drawing.Size(128, 53);
            this.AgregarPlatoBoton.TabIndex = 4;
            this.AgregarPlatoBoton.Text = "Agregar Plato";
            this.AgregarPlatoBoton.UseVisualStyleBackColor = true;
            this.AgregarPlatoBoton.Click += new System.EventHandler(this.AgregarPlatoBoton_Click);
            // 
            // QuitarPlatoBoton
            // 
            this.QuitarPlatoBoton.Location = new System.Drawing.Point(284, 283);
            this.QuitarPlatoBoton.Name = "QuitarPlatoBoton";
            this.QuitarPlatoBoton.Size = new System.Drawing.Size(128, 53);
            this.QuitarPlatoBoton.TabIndex = 5;
            this.QuitarPlatoBoton.Text = "Quitar Plato";
            this.QuitarPlatoBoton.UseVisualStyleBackColor = true;
            this.QuitarPlatoBoton.Click += new System.EventHandler(this.QuitarPlatoBoton_Click);
            // 
            // CerrarSesionBoton
            // 
            this.CerrarSesionBoton.Location = new System.Drawing.Point(49, 283);
            this.CerrarSesionBoton.Name = "CerrarSesionBoton";
            this.CerrarSesionBoton.Size = new System.Drawing.Size(146, 40);
            this.CerrarSesionBoton.TabIndex = 6;
            this.CerrarSesionBoton.Text = "Cerrar Sesión";
            this.CerrarSesionBoton.UseVisualStyleBackColor = true;
            this.CerrarSesionBoton.Click += new System.EventHandler(this.CerrarSesionBoton_Click);
            // 
            // AdminIniciado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.CerrarSesionBoton);
            this.Controls.Add(this.QuitarPlatoBoton);
            this.Controls.Add(this.AgregarPlatoBoton);
            this.Controls.Add(this.QuitarLocalBoton);
            this.Controls.Add(this.AgregarLocalBoton);
            this.Controls.Add(this.MenuAdmin);
            this.Controls.Add(this.LocalesAdminComboBox);
            this.Name = "AdminIniciado";
            this.Text = "AdminIniciado";
            this.Load += new System.EventHandler(this.AdminIniciado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox LocalesAdminComboBox;
        private System.Windows.Forms.ListBox MenuAdmin;
        private System.Windows.Forms.Button AgregarLocalBoton;
        private System.Windows.Forms.Button QuitarLocalBoton;
        private System.Windows.Forms.Button AgregarPlatoBoton;
        private System.Windows.Forms.Button QuitarPlatoBoton;
        private System.Windows.Forms.Button CerrarSesionBoton;
    }
}
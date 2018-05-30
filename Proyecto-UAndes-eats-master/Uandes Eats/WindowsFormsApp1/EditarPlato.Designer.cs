namespace WindowsFormsApp1
{
    partial class EditarPlato
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
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CancelarBoton = new System.Windows.Forms.Button();
            this.EditarBoton = new System.Windows.Forms.Button();
            this.PrecioPlato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DescripcionPlato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NombrePlato = new System.Windows.Forms.TextBox();
            this.NombreNuevoPlatoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 26);
            this.label3.TabIndex = 29;
            this.label3.Text = "Editar plato\r\nLocal:\r\n";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(287, 123);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(229, 17);
            this.listBox1.TabIndex = 28;
            // 
            // CancelarBoton
            // 
            this.CancelarBoton.Location = new System.Drawing.Point(414, 307);
            this.CancelarBoton.Name = "CancelarBoton";
            this.CancelarBoton.Size = new System.Drawing.Size(102, 49);
            this.CancelarBoton.TabIndex = 27;
            this.CancelarBoton.Text = "Cancelar";
            this.CancelarBoton.UseVisualStyleBackColor = true;
            this.CancelarBoton.Click += new System.EventHandler(this.CancelarBoton_Click);
            // 
            // EditarBoton
            // 
            this.EditarBoton.Location = new System.Drawing.Point(287, 307);
            this.EditarBoton.Name = "EditarBoton";
            this.EditarBoton.Size = new System.Drawing.Size(102, 49);
            this.EditarBoton.TabIndex = 26;
            this.EditarBoton.Text = "Editar";
            this.EditarBoton.UseVisualStyleBackColor = true;
            this.EditarBoton.Click += new System.EventHandler(this.EditarBoton_Click);
            // 
            // PrecioPlato
            // 
            this.PrecioPlato.Location = new System.Drawing.Point(287, 260);
            this.PrecioPlato.Name = "PrecioPlato";
            this.PrecioPlato.Size = new System.Drawing.Size(229, 20);
            this.PrecioPlato.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Precio:";
            // 
            // DescripcionPlato
            // 
            this.DescripcionPlato.Location = new System.Drawing.Point(287, 206);
            this.DescripcionPlato.Name = "DescripcionPlato";
            this.DescripcionPlato.Size = new System.Drawing.Size(229, 20);
            this.DescripcionPlato.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Descripción:";
            // 
            // NombrePlato
            // 
            this.NombrePlato.Location = new System.Drawing.Point(287, 163);
            this.NombrePlato.Name = "NombrePlato";
            this.NombrePlato.Size = new System.Drawing.Size(229, 20);
            this.NombrePlato.TabIndex = 21;
            // 
            // NombreNuevoPlatoLabel
            // 
            this.NombreNuevoPlatoLabel.AutoSize = true;
            this.NombreNuevoPlatoLabel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.NombreNuevoPlatoLabel.Location = new System.Drawing.Point(287, 143);
            this.NombreNuevoPlatoLabel.Name = "NombreNuevoPlatoLabel";
            this.NombreNuevoPlatoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NombreNuevoPlatoLabel.Size = new System.Drawing.Size(48, 17);
            this.NombreNuevoPlatoLabel.TabIndex = 20;
            this.NombreNuevoPlatoLabel.Text = "Nombre:";
            this.NombreNuevoPlatoLabel.UseCompatibleTextRendering = true;
            // 
            // EditarPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CancelarBoton);
            this.Controls.Add(this.EditarBoton);
            this.Controls.Add(this.PrecioPlato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescripcionPlato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombrePlato);
            this.Controls.Add(this.NombreNuevoPlatoLabel);
            this.Name = "EditarPlato";
            this.Text = "EditarPlato";
            this.Load += new System.EventHandler(this.EditarPlato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button CancelarBoton;
        private System.Windows.Forms.Button EditarBoton;
        private System.Windows.Forms.TextBox PrecioPlato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DescripcionPlato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombrePlato;
        private System.Windows.Forms.Label NombreNuevoPlatoLabel;
    }
}
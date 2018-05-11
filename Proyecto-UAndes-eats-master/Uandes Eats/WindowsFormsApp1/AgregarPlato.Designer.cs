namespace WindowsFormsApp1
{
    partial class AgregarPlato
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
            this.NombreNuevoPlatoLabel = new System.Windows.Forms.Label();
            this.NombreNuevoPlato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DescripocionNuevoPlato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PrecioNuevoPlato = new System.Windows.Forms.TextBox();
            this.AgregarBoton = new System.Windows.Forms.Button();
            this.CancelarBoton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NombreNuevoPlatoLabel
            // 
            this.NombreNuevoPlatoLabel.AutoSize = true;
            this.NombreNuevoPlatoLabel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.NombreNuevoPlatoLabel.Location = new System.Drawing.Point(299, 82);
            this.NombreNuevoPlatoLabel.Name = "NombreNuevoPlatoLabel";
            this.NombreNuevoPlatoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NombreNuevoPlatoLabel.Size = new System.Drawing.Size(48, 17);
            this.NombreNuevoPlatoLabel.TabIndex = 0;
            this.NombreNuevoPlatoLabel.Text = "Nombre:";
            this.NombreNuevoPlatoLabel.UseCompatibleTextRendering = true;
            // 
            // NombreNuevoPlato
            // 
            this.NombreNuevoPlato.Location = new System.Drawing.Point(296, 102);
            this.NombreNuevoPlato.Name = "NombreNuevoPlato";
            this.NombreNuevoPlato.Size = new System.Drawing.Size(229, 20);
            this.NombreNuevoPlato.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción:";
            // 
            // DescripocionNuevoPlato
            // 
            this.DescripocionNuevoPlato.Location = new System.Drawing.Point(296, 145);
            this.DescripocionNuevoPlato.Name = "DescripocionNuevoPlato";
            this.DescripocionNuevoPlato.Size = new System.Drawing.Size(229, 20);
            this.DescripocionNuevoPlato.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Precio:";
            // 
            // PrecioNuevoPlato
            // 
            this.PrecioNuevoPlato.Location = new System.Drawing.Point(296, 199);
            this.PrecioNuevoPlato.Name = "PrecioNuevoPlato";
            this.PrecioNuevoPlato.Size = new System.Drawing.Size(229, 20);
            this.PrecioNuevoPlato.TabIndex = 5;
            // 
            // AgregarBoton
            // 
            this.AgregarBoton.Location = new System.Drawing.Point(296, 246);
            this.AgregarBoton.Name = "AgregarBoton";
            this.AgregarBoton.Size = new System.Drawing.Size(102, 49);
            this.AgregarBoton.TabIndex = 6;
            this.AgregarBoton.Text = "Agregar";
            this.AgregarBoton.UseVisualStyleBackColor = true;
            this.AgregarBoton.Click += new System.EventHandler(this.AgregarBoton_Click);
            // 
            // CancelarBoton
            // 
            this.CancelarBoton.Location = new System.Drawing.Point(423, 246);
            this.CancelarBoton.Name = "CancelarBoton";
            this.CancelarBoton.Size = new System.Drawing.Size(102, 49);
            this.CancelarBoton.TabIndex = 7;
            this.CancelarBoton.Text = "Cancelar";
            this.CancelarBoton.UseVisualStyleBackColor = true;
            this.CancelarBoton.Click += new System.EventHandler(this.CancelarBoton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(296, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(229, 17);
            this.listBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Agregando plato al local:";
            // 
            // AgregarPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CancelarBoton);
            this.Controls.Add(this.AgregarBoton);
            this.Controls.Add(this.PrecioNuevoPlato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescripocionNuevoPlato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombreNuevoPlato);
            this.Controls.Add(this.NombreNuevoPlatoLabel);
            this.Name = "AgregarPlato";
            this.Text = "AgregarPlato";
            this.Load += new System.EventHandler(this.AgregarPlato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NombreNuevoPlatoLabel;
        private System.Windows.Forms.TextBox NombreNuevoPlato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescripocionNuevoPlato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PrecioNuevoPlato;
        private System.Windows.Forms.Button AgregarBoton;
        private System.Windows.Forms.Button CancelarBoton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
    }
}
namespace WindowsFormsApp1
{
    partial class RepartidorIniciado
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
            this.PedidosBox = new System.Windows.Forms.ListBox();
            this.Pedidos = new System.Windows.Forms.Label();
            this.TusPedidosBox = new System.Windows.Forms.ListBox();
            this.AgregarAPedidosButtom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PedidosBox
            // 
            this.PedidosBox.FormattingEnabled = true;
            this.PedidosBox.Location = new System.Drawing.Point(12, 25);
            this.PedidosBox.Name = "PedidosBox";
            this.PedidosBox.Size = new System.Drawing.Size(318, 303);
            this.PedidosBox.TabIndex = 0;
            this.PedidosBox.SelectedIndexChanged += new System.EventHandler(this.PedidosBox_SelectedIndexChanged);
            // 
            // Pedidos
            // 
            this.Pedidos.AutoSize = true;
            this.Pedidos.Location = new System.Drawing.Point(9, 9);
            this.Pedidos.Name = "Pedidos";
            this.Pedidos.Size = new System.Drawing.Size(48, 13);
            this.Pedidos.TabIndex = 1;
            this.Pedidos.Text = "Pedidos:";
            // 
            // TusPedidosBox
            // 
            this.TusPedidosBox.FormattingEnabled = true;
            this.TusPedidosBox.Location = new System.Drawing.Point(470, 25);
            this.TusPedidosBox.Name = "TusPedidosBox";
            this.TusPedidosBox.Size = new System.Drawing.Size(318, 303);
            this.TusPedidosBox.TabIndex = 2;
            // 
            // AgregarAPedidosButtom
            // 
            this.AgregarAPedidosButtom.Location = new System.Drawing.Point(336, 73);
            this.AgregarAPedidosButtom.Name = "AgregarAPedidosButtom";
            this.AgregarAPedidosButtom.Size = new System.Drawing.Size(128, 72);
            this.AgregarAPedidosButtom.TabIndex = 3;
            this.AgregarAPedidosButtom.Text = "Agregar Pedido";
            this.AgregarAPedidosButtom.UseVisualStyleBackColor = true;
            this.AgregarAPedidosButtom.Click += new System.EventHandler(this.AgregarAPedidosButtom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tu/s Pedido/s:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 67);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cerrar Sesión";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 72);
            this.button1.TabIndex = 6;
            this.button1.Text = "Terminar Pedido";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RepartidorIniciado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AgregarAPedidosButtom);
            this.Controls.Add(this.TusPedidosBox);
            this.Controls.Add(this.Pedidos);
            this.Controls.Add(this.PedidosBox);
            this.Name = "RepartidorIniciado";
            this.Text = "RepartidorIniciado";
            this.Load += new System.EventHandler(this.RepartidorIniciado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PedidosBox;
        private System.Windows.Forms.Label Pedidos;
        private System.Windows.Forms.ListBox TusPedidosBox;
        private System.Windows.Forms.Button AgregarAPedidosButtom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
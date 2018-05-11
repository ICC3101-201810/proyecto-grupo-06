namespace WindowsFormsApp1
{
    partial class ClienteIniciado
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
            this.CerrarSesionBoton = new System.Windows.Forms.Button();
            this.TerminarPedidoBoton = new System.Windows.Forms.Button();
            this.MenuClientes = new System.Windows.Forms.ListBox();
            this.LocalesComboBox = new System.Windows.Forms.ComboBox();
            this.PedidoCliente = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SacarCarroBoton = new System.Windows.Forms.Button();
            this.TotalPrecio = new System.Windows.Forms.Label();
            this.DescripcionPrecioPlato = new System.Windows.Forms.ListBox();
            this.AgregarPlatoCarroBoton = new System.Windows.Forms.Button();
            this.TotalListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MinBox = new System.Windows.Forms.ComboBox();
            this.HoraBox = new System.Windows.Forms.ComboBox();
            this.PedidosHechosBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CerrarSesionBoton
            // 
            this.CerrarSesionBoton.Location = new System.Drawing.Point(22, 12);
            this.CerrarSesionBoton.Name = "CerrarSesionBoton";
            this.CerrarSesionBoton.Size = new System.Drawing.Size(163, 54);
            this.CerrarSesionBoton.TabIndex = 1;
            this.CerrarSesionBoton.Text = "Cerrar Sesión";
            this.CerrarSesionBoton.UseVisualStyleBackColor = true;
            this.CerrarSesionBoton.Click += new System.EventHandler(this.CerrarSesionBoton_Click);
            // 
            // TerminarPedidoBoton
            // 
            this.TerminarPedidoBoton.Location = new System.Drawing.Point(22, 289);
            this.TerminarPedidoBoton.Name = "TerminarPedidoBoton";
            this.TerminarPedidoBoton.Size = new System.Drawing.Size(163, 49);
            this.TerminarPedidoBoton.TabIndex = 4;
            this.TerminarPedidoBoton.Text = "Hacer pedido";
            this.TerminarPedidoBoton.UseVisualStyleBackColor = true;
            this.TerminarPedidoBoton.Click += new System.EventHandler(this.TerminarPedidoBoton_Click);
            // 
            // MenuClientes
            // 
            this.MenuClientes.FormattingEnabled = true;
            this.MenuClientes.Location = new System.Drawing.Point(191, 39);
            this.MenuClientes.Name = "MenuClientes";
            this.MenuClientes.Size = new System.Drawing.Size(585, 199);
            this.MenuClientes.TabIndex = 6;
            this.MenuClientes.SelectedIndexChanged += new System.EventHandler(this.MenuClientes_SelectedIndexChanged);
            // 
            // LocalesComboBox
            // 
            this.LocalesComboBox.FormattingEnabled = true;
            this.LocalesComboBox.Location = new System.Drawing.Point(191, 12);
            this.LocalesComboBox.Name = "LocalesComboBox";
            this.LocalesComboBox.Size = new System.Drawing.Size(585, 21);
            this.LocalesComboBox.TabIndex = 5;
            this.LocalesComboBox.Text = "Locales";
            this.LocalesComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // PedidoCliente
            // 
            this.PedidoCliente.FormattingEnabled = true;
            this.PedidoCliente.Location = new System.Drawing.Point(22, 85);
            this.PedidoCliente.Name = "PedidoCliente";
            this.PedidoCliente.Size = new System.Drawing.Size(163, 121);
            this.PedidoCliente.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tu pedido:";
            // 
            // SacarCarroBoton
            // 
            this.SacarCarroBoton.Location = new System.Drawing.Point(22, 212);
            this.SacarCarroBoton.Name = "SacarCarroBoton";
            this.SacarCarroBoton.Size = new System.Drawing.Size(163, 23);
            this.SacarCarroBoton.TabIndex = 9;
            this.SacarCarroBoton.Text = "Sacar del carro";
            this.SacarCarroBoton.UseVisualStyleBackColor = true;
            this.SacarCarroBoton.Click += new System.EventHandler(this.SacarCarroBoton_Click);
            // 
            // TotalPrecio
            // 
            this.TotalPrecio.AutoSize = true;
            this.TotalPrecio.Location = new System.Drawing.Point(19, 238);
            this.TotalPrecio.Name = "TotalPrecio";
            this.TotalPrecio.Size = new System.Drawing.Size(34, 13);
            this.TotalPrecio.TabIndex = 10;
            this.TotalPrecio.Text = "Total:";
            // 
            // DescripcionPrecioPlato
            // 
            this.DescripcionPrecioPlato.FormattingEnabled = true;
            this.DescripcionPrecioPlato.Location = new System.Drawing.Point(191, 256);
            this.DescripcionPrecioPlato.Name = "DescripcionPrecioPlato";
            this.DescripcionPrecioPlato.Size = new System.Drawing.Size(436, 82);
            this.DescripcionPrecioPlato.TabIndex = 11;
            // 
            // AgregarPlatoCarroBoton
            // 
            this.AgregarPlatoCarroBoton.Location = new System.Drawing.Point(633, 256);
            this.AgregarPlatoCarroBoton.Name = "AgregarPlatoCarroBoton";
            this.AgregarPlatoCarroBoton.Size = new System.Drawing.Size(143, 82);
            this.AgregarPlatoCarroBoton.TabIndex = 12;
            this.AgregarPlatoCarroBoton.Text = "Agregar plato al carro";
            this.AgregarPlatoCarroBoton.UseVisualStyleBackColor = true;
            this.AgregarPlatoCarroBoton.Click += new System.EventHandler(this.AgregarPlatoCarroBoton_Click);
            // 
            // TotalListBox
            // 
            this.TotalListBox.FormattingEnabled = true;
            this.TotalListBox.Location = new System.Drawing.Point(59, 238);
            this.TotalListBox.Name = "TotalListBox";
            this.TotalListBox.Size = new System.Drawing.Size(120, 17);
            this.TotalListBox.TabIndex = 13;
            this.TotalListBox.SelectedIndexChanged += new System.EventHandler(this.TotalListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = ":";
            // 
            // MinBox
            // 
            this.MinBox.FormattingEnabled = true;
            this.MinBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.MinBox.Location = new System.Drawing.Point(114, 265);
            this.MinBox.Name = "MinBox";
            this.MinBox.Size = new System.Drawing.Size(40, 21);
            this.MinBox.TabIndex = 17;
            // 
            // HoraBox
            // 
            this.HoraBox.FormattingEnabled = true;
            this.HoraBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.HoraBox.Location = new System.Drawing.Point(52, 265);
            this.HoraBox.Name = "HoraBox";
            this.HoraBox.Size = new System.Drawing.Size(40, 21);
            this.HoraBox.TabIndex = 18;
            // 
            // PedidosHechosBox
            // 
            this.PedidosHechosBox.FormattingEnabled = true;
            this.PedidosHechosBox.Location = new System.Drawing.Point(191, 344);
            this.PedidosHechosBox.Name = "PedidosHechosBox";
            this.PedidosHechosBox.Size = new System.Drawing.Size(436, 95);
            this.PedidosHechosBox.TabIndex = 19;
            this.PedidosHechosBox.SelectedIndexChanged += new System.EventHandler(this.PedidosHechosBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tus Pedidos:";
            // 
            // ClienteIniciado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PedidosHechosBox);
            this.Controls.Add(this.HoraBox);
            this.Controls.Add(this.MinBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalListBox);
            this.Controls.Add(this.AgregarPlatoCarroBoton);
            this.Controls.Add(this.DescripcionPrecioPlato);
            this.Controls.Add(this.TotalPrecio);
            this.Controls.Add(this.SacarCarroBoton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PedidoCliente);
            this.Controls.Add(this.MenuClientes);
            this.Controls.Add(this.LocalesComboBox);
            this.Controls.Add(this.TerminarPedidoBoton);
            this.Controls.Add(this.CerrarSesionBoton);
            this.Name = "ClienteIniciado";
            this.Text = "ClienteIniciado";
            this.Load += new System.EventHandler(this.ClienteIniciado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CerrarSesionBoton;
        private System.Windows.Forms.Button TerminarPedidoBoton;
        private System.Windows.Forms.ListBox MenuClientes;
        private System.Windows.Forms.ComboBox LocalesComboBox;
        private System.Windows.Forms.ListBox PedidoCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SacarCarroBoton;
        private System.Windows.Forms.Label TotalPrecio;
        private System.Windows.Forms.ListBox DescripcionPrecioPlato;
        private System.Windows.Forms.Button AgregarPlatoCarroBoton;
        private System.Windows.Forms.ListBox TotalListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MinBox;
        private System.Windows.Forms.ComboBox HoraBox;
        private System.Windows.Forms.ListBox PedidosHechosBox;
        private System.Windows.Forms.Label label4;
    }
}
namespace WindowsFormsApp1
{
    partial class WebPAy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebPAy));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NumTarjetaBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AnoVenBox = new System.Windows.Forms.ComboBox();
            this.MesVecBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CodVerBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.OpcPagoBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.PagarBoton = new System.Windows.Forms.Button();
            this.AnularBoton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarjeta de Crédito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(781, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total a Pagar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(781, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TotalBox
            // 
            this.TotalBox.FormattingEnabled = true;
            this.TotalBox.Location = new System.Drawing.Point(127, 101);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.Size = new System.Drawing.Size(188, 17);
            this.TotalBox.TabIndex = 4;
            this.TotalBox.SelectedIndexChanged += new System.EventHandler(this.TotalBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(228, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Comercio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(321, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "UandesEats";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(162, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Número de Tarjeta:";
            // 
            // NumTarjetaBox
            // 
            this.NumTarjetaBox.Location = new System.Drawing.Point(321, 165);
            this.NumTarjetaBox.Name = "NumTarjetaBox";
            this.NumTarjetaBox.Size = new System.Drawing.Size(179, 20);
            this.NumTarjetaBox.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(210, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Vencimiento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(398, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "/";
            // 
            // AnoVenBox
            // 
            this.AnoVenBox.FormattingEnabled = true;
            this.AnoVenBox.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.AnoVenBox.Location = new System.Drawing.Point(416, 208);
            this.AnoVenBox.Name = "AnoVenBox";
            this.AnoVenBox.Size = new System.Drawing.Size(84, 21);
            this.AnoVenBox.TabIndex = 12;
            // 
            // MesVecBox
            // 
            this.MesVecBox.FormattingEnabled = true;
            this.MesVecBox.Items.AddRange(new object[] {
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
            "12"});
            this.MesVecBox.Location = new System.Drawing.Point(321, 208);
            this.MesVecBox.Name = "MesVecBox";
            this.MesVecBox.Size = new System.Drawing.Size(69, 21);
            this.MesVecBox.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(163, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "Código Verificador:";
            // 
            // CodVerBox
            // 
            this.CodVerBox.Location = new System.Drawing.Point(321, 254);
            this.CodVerBox.Name = "CodVerBox";
            this.CodVerBox.Size = new System.Drawing.Size(179, 20);
            this.CodVerBox.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(781, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(163, 305);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 18);
            this.label12.TabIndex = 17;
            this.label12.Text = "Opciones de Pago:";
            // 
            // OpcPagoBox
            // 
            this.OpcPagoBox.FormattingEnabled = true;
            this.OpcPagoBox.Items.AddRange(new object[] {
            "Sin Cuotas",
            "3 Cuotas",
            "6 Cuotas",
            "9 Cuotas"});
            this.OpcPagoBox.Location = new System.Drawing.Point(324, 302);
            this.OpcPagoBox.Name = "OpcPagoBox";
            this.OpcPagoBox.Size = new System.Drawing.Size(96, 21);
            this.OpcPagoBox.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 365);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(781, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = resources.GetString("label13.Text");
            // 
            // PagarBoton
            // 
            this.PagarBoton.BackColor = System.Drawing.Color.Goldenrod;
            this.PagarBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PagarBoton.Location = new System.Drawing.Point(213, 391);
            this.PagarBoton.Name = "PagarBoton";
            this.PagarBoton.Size = new System.Drawing.Size(102, 47);
            this.PagarBoton.TabIndex = 20;
            this.PagarBoton.Text = "Pagar";
            this.PagarBoton.UseVisualStyleBackColor = false;
            this.PagarBoton.Click += new System.EventHandler(this.PagarBoton_Click);
            // 
            // AnularBoton
            // 
            this.AnularBoton.BackColor = System.Drawing.Color.Goldenrod;
            this.AnularBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnularBoton.Location = new System.Drawing.Point(401, 391);
            this.AnularBoton.Name = "AnularBoton";
            this.AnularBoton.Size = new System.Drawing.Size(102, 47);
            this.AnularBoton.TabIndex = 21;
            this.AnularBoton.Text = "Anular";
            this.AnularBoton.UseVisualStyleBackColor = false;
            this.AnularBoton.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 56);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // WebPAy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AnularBoton);
            this.Controls.Add(this.PagarBoton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.OpcPagoBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CodVerBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MesVecBox);
            this.Controls.Add(this.AnoVenBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NumTarjetaBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TotalBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WebPAy";
            this.Text = "WebPay";
            this.Load += new System.EventHandler(this.WebPay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox TotalBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NumTarjetaBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox AnoVenBox;
        private System.Windows.Forms.ComboBox MesVecBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CodVerBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox OpcPagoBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button PagarBoton;
        private System.Windows.Forms.Button AnularBoton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
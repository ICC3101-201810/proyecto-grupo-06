using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class WebPAy : Form
    {
        List<Platos> pedido;
        List<Pedido> pedidos;
        List<Usuarios> usuarios;
        Usuarios usuario;
        List<Local> locales;
        string hora;
        string min;
        public WebPAy(List<Platos> pedido,List<Pedido> pedidos,List<Usuarios> usuarios,Usuarios usuario,List<Local> locales, string hora, string min)
        {
            this.pedido = pedido;
            this.pedidos = pedidos;
            this.usuarios = usuarios;
            this.usuario = usuario;
            this.locales = locales;
            this.hora = hora;
            this.min = min;
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void WebPay_Load(object sender, EventArgs e)
        {
            int total = 0;
            foreach (Platos i in pedido)
            {
                total += i.Precio;

            }
            TotalBox.Items.Add("$" + total);
        }

        private void PagarBoton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su pago fue realizado con exito");
            this.Hide();
            Pedido pedido1 = new Pedido(pedido, usuario, hora,min);
            pedidos.Add(pedido1);
            ClienteIniciado c1 = new ClienteIniciado(usuario, locales, usuarios, pedidos);
            c1.ShowDialog();
        }
    }
}

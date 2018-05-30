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
        BaseDatos Datos = new BaseDatos();
        Pedido pedido;
        List<Pedido> pedidos;
        List<Usuarios> usuarios;
        Usuarios usuario;
        List<Local> locales;
        string hora;
        string min;

        public WebPAy(Pedido pedido,List<Pedido> pedidos,List<Usuarios> usuarios,Usuarios usuario,List<Local> locales, string hora, string min)
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
            this.Hide();
            ClienteIniciado c1 = new ClienteIniciado(usuario, locales, usuarios, pedidos);
            c1.ShowDialog();
        }

        private void WebPay_Load(object sender, EventArgs e)
        {
            int total = 0;
            foreach (Platos i in pedido.PlatosCliente)
            {
                total += i.Precio;

            }
            TotalBox.Items.Add("$" + total);
        }

        private void PagarBoton_Click(object sender, EventArgs e)
        {
            if (NumTarjetaBox.Text == "" || MesVecBox.Text == "" || AnoVenBox.Text == "" || CodVerBox.Text == "" || OpcPagoBox.Text == "")
            {
                MessageBox.Show("Ingrese los datos de la tarjeta");
            }
            else
            {
                MessageBox.Show("Su pago fue realizado con exito");
                pedido.CambiarEstado("Finalizado");
                Datos.SerPedidos(pedidos);
                this.Hide();
                ClienteIniciado c1 = new ClienteIniciado(usuario, locales, usuarios, pedidos);
                c1.ShowDialog();
            }
        }

        private void TotalBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

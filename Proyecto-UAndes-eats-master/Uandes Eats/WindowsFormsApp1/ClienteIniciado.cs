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
    public partial class ClienteIniciado : Form
    {
        List<Local> locales;
        List<Usuarios> usuarios;
        Usuarios usuario;
        List<Platos> pedido =new List<Platos>();
        List<Pedido> pedidos;

        public ClienteIniciado(Usuarios usuario, List<Local> locales, List<Usuarios> usuarios,List<Pedido> pedidos)
        {
            InitializeComponent();
            this.locales = locales;
            this.usuario = usuario;
            this.usuarios = usuarios;
            this.pedidos = pedidos;
        }

        private void ClienteIniciado_Load(object sender, EventArgs e)
        {
            foreach (Local local in locales)
            {
                LocalesComboBox.Items.Add(local.Nombre);
            }
            foreach(Pedido pe in pedidos)
            {
                string o = "";
                foreach(Platos pl in pe.PlatosCliente)
                {
                    o += pl.Nombre+", ";
                }
                PedidosHechosBox.Items.Add("Pedido:" + o + "hora:" + pe.hora + ":" + pe.minuto);
            }
        }

        private void CerrarSesionBoton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F1 = new Form1(usuarios, locales, pedidos);
            F1.ShowDialog();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MenuClientes.Items.Clear();
            foreach (Platos plato in locales[LocalesComboBox.SelectedIndex].Menu)
            {
                MenuClientes.Items.Add(plato.Nombre);
            }
        }

        private void MenuClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DescripcionPrecioPlato.Items.Clear();
                DescripcionPrecioPlato.Items.Add("Descripcion= " + locales[LocalesComboBox.SelectedIndex].Menu[MenuClientes.SelectedIndex].Descripcion);
                DescripcionPrecioPlato.Items.Add("Precio = $" + locales[LocalesComboBox.SelectedIndex].Menu[MenuClientes.SelectedIndex].Precio.ToString());
            }
            catch { }
        }

        private void AgregarPlatoCarroBoton_Click(object sender, EventArgs e)
        {
            try
            {
                PedidoCliente.Items.Add(locales[LocalesComboBox.SelectedIndex].Menu[MenuClientes.SelectedIndex].Nombre);
                pedido.Add(locales[LocalesComboBox.SelectedIndex].Menu[MenuClientes.SelectedIndex]);
                int total = 0;
                foreach (Platos plato in pedido)
                {
                    total += plato.Precio;
                }
                TotalListBox.Items.Clear();
                TotalListBox.Items.Add("$" + total);
            }
            catch { }
        }

        private void SacarCarroBoton_Click(object sender, EventArgs e)
        {
            try
            {
                pedido.Remove(pedido[PedidoCliente.SelectedIndex]);
                PedidoCliente.Items.Remove(PedidoCliente.Items[PedidoCliente.SelectedIndex]);
                int total = 0;
                foreach (Platos plato in pedido)
                {
                    total += plato.Precio;
                }
                TotalListBox.Items.Clear();
                TotalListBox.Items.Add("$" + total);
            }
            catch { }
        }

        private void TerminarPedidoBoton_Click(object sender, EventArgs e)
        {
            try
            {
                if (TotalListBox.Items[0].ToString() == "" || TotalListBox.Items[0].ToString() == "$0")
                {
                    MessageBox.Show("No hay pedido por hacer");
                }
                else if (HoraBox.Text == "" || MinBox.Text == "")
                {
                    MessageBox.Show("Escoja una hora para su pedido");
                }
                else
                {
                    this.Hide();
                    WebPAy webPay = new WebPAy(pedido, pedidos, usuarios, usuario, locales, HoraBox.Text, MinBox.Text);
                    webPay.ShowDialog();
                }
            }
            catch { }
        }

        private void PedidosHechosBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TotalListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

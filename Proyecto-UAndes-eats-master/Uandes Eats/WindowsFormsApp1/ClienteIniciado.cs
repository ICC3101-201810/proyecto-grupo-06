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
        BaseDatos Datos = new BaseDatos();
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
            this.pedidos = Datos.DesPedidos();
        }

        private void ClienteIniciado_Load(object sender, EventArgs e)
        {
            foreach (Local local in locales)
            {
                LocalesComboBox.Items.Add(local.Nombre);
            }
            foreach (Pedido pe in pedidos)
            {
                string o = "";
                if (pe.Usuario.Rut == usuario.Rut)
                {

                    foreach (Platos pl in pe.PlatosCliente)
                    {
                        o += pl.Nombre + ", ";
                    }
                    PedidosHechosBox.Items.Add("Pedido: " + o + "   Hora: " + pe.hora + ":" + pe.minuto + "   Estado: " + pe.estado+"   Repartidor: "+pe.repartidor);
                }
                
            }
            int i = 1;
            int h = DateTime.Now.Hour;
            int m = DateTime.Now.Minute;
            MinBox.Items.Add(0);
            MinBox.Items.Add(15);
            MinBox.Items.Add(30);
            MinBox.Items.Add(45);
            while (true)
            {
                if (h + i < 24)
                {
                    HoraBox.Items.Add(h + i);
                }
                else
                {
                    break;
                }
                i += 1;

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
                //else if ((DateTime.Now.Hour+1  + DateTime.Now.Minute/60) <=( Convert.ToInt32(HoraBox.SelectedItem)  + Convert.ToInt32(MinBox.SelectedItem)/60))
                //{
                //    MessageBox.Show("Recuerde que los pedidos tienen que ser agendados con minimo una hora de anticipacion");
                //}
                else
                {

                    Pedido pedido1 = new Pedido(pedido, usuario, HoraBox.SelectedItem.ToString(), MinBox.SelectedItem.ToString(), "En espera","nadie");
                    pedidos.Add(pedido1);
                    string o = "";
                    foreach (Platos pl in pedido1.PlatosCliente)
                    {
                        o += pl.Nombre + ", ";
                    }
                    PedidosHechosBox.Items.Add("Pedido: " + o + "   Hora: " + pedido1.hora + " : " + pedido1.minuto + "   Estado: " + pedido1.estado+"   Repartidor: "+pedido1.repartidor);
                    pedido = new List<Platos>();
                    PedidoCliente.Items.Clear();
                    HoraBox.ResetText();
                    MinBox.ResetText();
                    TotalListBox.Items.Clear();
                    Datos.SerPedidos(pedidos);
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

        private void HoraBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TerButtom_Click(object sender, EventArgs e)
        {
            if (PedidosHechosBox.Text=="") {
                MessageBox.Show("Eliga un pedido, antes de realizar una acción");
            }
            else if (PedidosHechosBox.SelectedItem.ToString().Contains("En espera")==true || PedidosHechosBox.SelectedItem.ToString().Contains("En camino") == true)
            {
                MessageBox.Show("Su pedido todavia se te tiene que entregar antes de realizar esta acción");
            }
            else if (PedidosHechosBox.SelectedItem.ToString().Contains("Finalizado") == true){
                MessageBox.Show("Su pedido ya lo cancelo");
            }
            else {
                this.Hide();

                WebPAy webPay = new WebPAy(pedidos[PedidosHechosBox.SelectedIndex], pedidos, usuarios, usuario, locales, HoraBox.Text, MinBox.Text);
                webPay.ShowDialog();
            }
            
        }
    }
}

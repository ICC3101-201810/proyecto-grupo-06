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
    public partial class RepartidorIniciado : Form
    {
        List<Local> locales;
        List<Usuarios> usuarios;
        Usuarios usuario;
        List<Pedido> pedidos;
        List<Platos> pedido = new List<Platos> { };

        public RepartidorIniciado(Usuarios usuario, List<Local> locales, List<Usuarios> usuarios, List<Pedido> pedidos)
        {
            InitializeComponent();
            this.locales = locales;
            this.usuario = usuario;
            this.usuarios = usuarios;
            this.pedidos = pedidos;
        }

        private void AgregarAPedidosButtom_Click(object sender, EventArgs e)
        {
            try
            {
                TusPedidosBox.Items.Add(PedidosBox.Items[PedidosBox.SelectedIndex]);
                pedidos.Remove(pedidos[PedidosBox.SelectedIndex]);
                PedidosBox.Items.Remove(TusPedidosBox.Items[PedidosBox.SelectedIndex]);

                PedidosBox.Items.Clear();
                foreach (Pedido pedido in pedidos)
                {
                    string o = "";
                    foreach (Platos plato in pedido.PlatosCliente)
                    {
                        o += plato.Nombre + ", ";
                    }
                    PedidosBox.Items.Add("Pedido: " + o + "/ Hora: " + pedido.hora + pedido.minuto);
                }
            }
            catch
            {

            }
            
        }

        private void RepartidorIniciado_Load(object sender, EventArgs e)
        {
            foreach (Pedido pedido in pedidos)
            {
                string o = "";
                foreach(Platos plato in pedido.PlatosCliente)
                {
                    o += plato.Nombre + ", ";
                }
                if (Convert.ToInt32(pedido.hora) >= DateTime.Now.Hour)
                { PedidosBox.Items.Add("Pedido: " + o + "/ Hora: " + pedido.hora + ":" + pedido.minuto); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F1 = new Form1(usuarios, locales, pedidos);
            F1.ShowDialog();
        }

        private void PedidosBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

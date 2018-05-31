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
        BaseDatos Datos = new BaseDatos();
        List<Local> locales;
        List<Usuarios> usuarios;
        Usuarios usuario;
        List<Pedido> pedidos;
        List<Platos> pedido = new List<Platos> { };
        List<int> indices = new List<int> { };

        public RepartidorIniciado(Usuarios usuario, List<Local> locales, List<Usuarios> usuarios, List<Pedido> pedidos)
        {
            InitializeComponent();
            this.locales = locales;
            this.usuario = usuario;
            this.usuarios = usuarios;
            this.pedidos = Datos.DesPedidos();
        }

        private void AgregarAPedidosButtom_Click(object sender, EventArgs e)
        {

            try
            {
                TusPedidosBox.Items.Add(PedidosBox.Items[PedidosBox.SelectedIndex]);
                pedidos[indices[PedidosBox.SelectedIndex]].CambiarEstado("En camino");
                pedidos[indices[PedidosBox.SelectedIndex]].CambiarRepartidor(usuario.Nombre+" "+usuario.Apellido);
                PedidosBox.Items.RemoveAt(PedidosBox.SelectedIndex);
                Datos.SerPedidos(pedidos);
                
                //PedidosBox.Items.Clear();
                //foreach (Pedido pedido in pedidos)
                //{
                //    string o = "";
                //    foreach (Platos plato in pedido.PlatosCliente)
                //    {
                //        o += plato.Nombre + ", ";
                //    }
                //    PedidosBox.Items.Add("Pedido: " + o + "/ Hora: " + pedido.hora + pedido.minuto);
                //}
            }
            catch
            {

            }
            
        }

        private void RepartidorIniciado_Load(object sender, EventArgs e)
        {
            
            foreach (Pedido pedido in pedidos)
            {
                if (pedido.estado=="En espera")
                {
                    indices.Add(pedidos.IndexOf(pedido));
                    string o = "";
                    foreach (Platos plato in pedido.PlatosCliente)
                    {
                        o += plato.Nombre + ", ";
                    }
                    if (Convert.ToInt32(pedido.hora) >= DateTime.Now.Hour)
                    { PedidosBox.Items.Add("Pedido: " + o + "/ Hora: " + pedido.hora + ":" + pedido.minuto+"/ Cliente: "+pedido.Usuario.Nombre+" "+pedido.Usuario.Apellido); }
                }
                else if (pedido.repartidor == usuario.Nombre + " " + usuario.Apellido)
                {

                    string o = "";
                    foreach (Platos plato in pedido.PlatosCliente)
                    {
                        o += plato.Nombre + ", ";
                    }
                    if (Convert.ToInt32(pedido.hora) >= DateTime.Now.Hour)
                    { TusPedidosBox.Items.Add("Pedido: " + o + "/ Hora: " + pedido.hora + ":" + pedido.minuto); }
                }


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

        private void button1_Click(object sender, EventArgs e)
        {
            if (TusPedidosBox.Text== "")
            {
                
            }
            else
            {
                pedidos[TusPedidosBox.SelectedIndex].CambiarEstado("Entregado");
                TusPedidosBox.Items.Remove(TusPedidosBox.Items[TusPedidosBox.SelectedIndex]);
                Datos.SerPedidos(pedidos);
            }
            
            
           
        }
    }
}

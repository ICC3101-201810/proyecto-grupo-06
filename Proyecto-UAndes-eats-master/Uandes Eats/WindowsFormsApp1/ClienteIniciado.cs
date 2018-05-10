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
        List<Platos> pedido = new List<Platos> { };

        public ClienteIniciado(Usuarios usuario, List<Local> locales, List<Usuarios> usuarios)
        {
            InitializeComponent();
            this.locales = locales;
            this.usuario = usuario;
            this.usuarios = usuarios;
        }

        private void ClienteIniciado_Load(object sender, EventArgs e)
        {
            foreach (Local local in locales)
            {
                LocalesComboBox.Items.Add(local.Nombre);
            }
        }

        private void CerrarSesionBoton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F1 = new Form1(usuarios, locales);
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
            DescripcionPrecioPlato.Items.Clear();
            DescripcionPrecioPlato.Items.Add("Descripcion= " + locales[LocalesComboBox.SelectedIndex].Menu[MenuClientes.SelectedIndex].Descripcion);
            DescripcionPrecioPlato.Items.Add("Precio = $" + locales[LocalesComboBox.SelectedIndex].Menu[MenuClientes.SelectedIndex].Precio.ToString());
        }

        private void AgregarPlatoCarroBoton_Click(object sender, EventArgs e)
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

        private void SacarCarroBoton_Click(object sender, EventArgs e)
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
    }
}

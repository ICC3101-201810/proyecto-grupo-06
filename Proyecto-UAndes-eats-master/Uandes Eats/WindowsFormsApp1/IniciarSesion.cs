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
    public partial class IniciarSesion : Form
    {
        List<Usuarios> usuarios;
        List<Local> locales;
        List<Pedido> pedidos;
        public IniciarSesion(List<Usuarios> usuarios, List<Local> locales, List<Pedido> pedidos)
        {
            InitializeComponent();
            this.usuarios = usuarios;
            this.locales = locales;
            this.pedidos = pedidos;
        }

        private void AtrasBoton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 F1 = new Form1(usuarios, locales, pedidos);
            F1.ShowDialog();
        }

        private void IngresarBoton_Click(object sender, EventArgs e)
        {
            if(RutTextBox.Text == "" || ContraseñaTextBox.Text == "")
            {
                MessageBox.Show("Rut o contraseña invalidos");

            }
            else
            {
                foreach(Usuarios usuario in usuarios)
                {
                    if(RutTextBox.Text == usuario.Rut && ContraseñaTextBox.Text == usuario.Contraseña)
                    {
                        if (usuario is Clientes && IniciarComoComboBox.SelectedIndex == 0)
                        {
                            this.Hide();
                            ClienteIniciado F2 = new ClienteIniciado(usuario, locales, usuarios, pedidos);
                            F2.ShowDialog();
                        }
                        else if (usuario is Repartidores && IniciarComoComboBox.SelectedIndex == 1)
                        {
                            this.Hide();
                            RepartidorIniciado F3 = new RepartidorIniciado(usuario, locales, usuarios, pedidos);
                            F3.ShowDialog();
                        }
                        else if (usuario is Administradores)
                        {
                            this.Hide();
                            AdminIniciado F4 = new AdminIniciado(usuario, locales, usuarios, pedidos);
                            F4.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Rut, contraseña y/o tipo de usuario invalidos");
                        }
                    }
                }
            }
        }

        private void IniciarSesion_Load(object sender, EventArgs e)
        {
            IniciarComoComboBox.SelectedIndex = 0;
        }
    }
}

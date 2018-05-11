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
    public partial class Registro : Form
    {
        List<Usuarios> usuarios;
        List<Local> locales;
        List<Pedido> pedidos;

        public Registro(List<Usuarios> usuarios, List<Local> locales, List<Pedido> pedidos)
        {
            InitializeComponent();
            this.usuarios = usuarios;
            this.locales = locales;
            this.pedidos = pedidos;
        }

        private void RegistrarseBoton_Click(object sender, EventArgs e)
        {
            if (TipoUsuarioCombo.Text == "Cliente")
            {
                bool i = false;
                Clientes cliente = new Clientes(NombreTextBox.Text, ApellidoTextBox.Text, RutTextBox.Text, MailTextBox.Text, TelefonoTextBox.Text, ContraseñaTextBox.Text);
                foreach(Usuarios u in usuarios)
                {
                    
                    if(u.Rut==cliente.Nombre && u is Clientes)
                    {
                        i = true;
                    }
                   
                }
                if (i == false)
                {
                    usuarios.Add(new Clientes(NombreTextBox.Text, ApellidoTextBox.Text, RutTextBox.Text, MailTextBox.Text, TelefonoTextBox.Text, ContraseñaTextBox.Text));
                    MessageBox.Show("Felicidades, su cuenta de cliente ha sido creada exitosamente");
                    this.Close();
                    Form1 F1 = new Form1(usuarios, locales, pedidos);
                    F1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Su cuenta ya existe");
                }               
            }
            else if (TipoUsuarioCombo.Text == "Repartidor")
            {
                bool i = false;
                Repartidores cliente = new Repartidores(NombreTextBox.Text, ApellidoTextBox.Text, RutTextBox.Text, MailTextBox.Text, TelefonoTextBox.Text, ContraseñaTextBox.Text);
                foreach (Usuarios u in usuarios)
                {

                    if (u.Rut == cliente.Nombre && u is Repartidores)
                    {
                        i = true;
                    }

                }
                if (i == false)
                {
                    usuarios.Add(new Repartidores(NombreTextBox.Text, ApellidoTextBox.Text, RutTextBox.Text, MailTextBox.Text, TelefonoTextBox.Text, ContraseñaTextBox.Text));
                    MessageBox.Show("Felicidades, su cuenta de cliente ha sido creada exitosamente");
                }
                else
                {
                    MessageBox.Show("Su cuenta ya existe");
                }

            }

        }

        private void AtrasBoton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 F1 = new Form1(usuarios, locales,pedidos);
            F1.ShowDialog();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void TipoUsuarioCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

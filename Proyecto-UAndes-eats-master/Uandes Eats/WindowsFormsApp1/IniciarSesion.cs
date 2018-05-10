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
        public IniciarSesion(List<Usuarios> usuarios, List<Local> locales)
        {
            InitializeComponent();
            this.usuarios = usuarios;
            this.locales = locales;
        }

        private void AtrasBoton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 F1 = new Form1(usuarios, locales);
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
                bool error = true;
                foreach(Usuarios usuario in usuarios)
                {
                    if(RutTextBox.Text == usuario.Rut && ContraseñaTextBox.Text == usuario.Contraseña)
                    {
                        if (usuario is Clientes)
                        {
                            this.Hide();
                            ClienteIniciado F4 = new ClienteIniciado(usuario, locales, usuarios);
                            F4.ShowDialog();
                        }
                        if (usuario is Repartidores)
                        {

                        }
                        if (usuario is Administradores)
                        {

                        }
                        error = false;
                    }
                }
                if (error)
                {
                    MessageBox.Show("Rut o contraseña invalidos");
                }
            }
        }
    }
}

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
        }
    }
}

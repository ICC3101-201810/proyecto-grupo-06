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

        public Registro(List<Usuarios> usuarios, List<Local> locales)
        {
            InitializeComponent();
            this.usuarios = usuarios;
            this.locales = locales;
        }

        private void RegistrarseBoton_Click(object sender, EventArgs e)
        {
            usuarios.Add(new Clientes(NombreTextBox.Text, ApellidoTextBox.Text, RutTextBox.Text, MailTextBox.Text, TelefonoTextBox.Text, ContraseñaTextBox.Text));

        }

        private void AtrasBoton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 F1 = new Form1(usuarios, locales);
            F1.ShowDialog();
        }
    }
}

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
    public partial class Form1 : Form
    {
        List<Usuarios> usuarios;
        List<Local> locales;
        public Form1(List<Usuarios> usuarios, List<Local> locales)
        {
            InitializeComponent();
            this.usuarios = usuarios;
            this.locales = locales;
        }

        private void SalirBoton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegistrarseBoton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro F2 = new Registro(usuarios, locales);
            F2.Show();
        }

        private void IniciarSesionBoton_Click(object sender, EventArgs e)
        {
            this.Hide();
            IniciarSesion F3 = new IniciarSesion(usuarios, locales);
            F3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

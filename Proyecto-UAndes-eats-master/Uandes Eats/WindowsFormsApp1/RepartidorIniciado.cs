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
        List<Platos> pedido = new List<Platos> { };

        public RepartidorIniciado(Usuarios usuario, List<Local> locales, List<Usuarios> usuarios)
        {
            InitializeComponent();
            this.locales = locales;
            this.usuario = usuario;
            this.usuarios = usuarios;
        }

        private void AgregarAPedidosButtom_Click(object sender, EventArgs e)
        {
            TusPedidosBox.Items.Add(PedidosBox.SelectedIndex);
            PedidosBox.Items.Remove(TusPedidosBox.Items[PedidosBox.SelectedIndex]);
        }

        private void RepartidorIniciado_Load(object sender, EventArgs e)
        {
        }
    }
}

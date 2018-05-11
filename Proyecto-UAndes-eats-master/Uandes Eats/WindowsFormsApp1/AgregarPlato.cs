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
    public partial class AgregarPlato : Form
    {
        List<Local> locales;
        Local local;
        public AgregarPlato(List<Local> locales, Local local)
        {
            InitializeComponent();
            this.locales = locales;
            this.local = local;
        }

        private void AgregarBoton_Click(object sender, EventArgs e)
        {
            try
            {
                bool crear = true;
                foreach (Platos plato in local.Menu)
                {
                    if (NombreNuevoPlato.Text == plato.Nombre)
                    {
                        crear = false;
                    }
                }
                if (crear)
                {
                    local.Menu.Add(new Platos(NombreNuevoPlato.Text, DescripocionNuevoPlato.Text, Convert.ToInt32(PrecioNuevoPlato.Text)));
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Error en la informacion entregada, falta informacion o el precio no es concistente");
            }
        }

        private void CancelarBoton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AgregarPlato_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(local.Nombre);
        }
    }
}

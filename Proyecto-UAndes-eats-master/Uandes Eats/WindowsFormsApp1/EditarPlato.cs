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
    public partial class EditarPlato : Form
    {
        BaseDatos Datos = new BaseDatos();
        List<Local> locales;
        Local local;
        Platos plato;

        public EditarPlato(Local local, Platos plato, List<Local> locales)
        {
            InitializeComponent();
            this.locales = locales;
            this.local = local;
            this.plato = plato;
        }

        private void EditarPlato_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(local.Nombre);
            NombrePlato.Text = plato.Nombre;
            DescripcionPlato.Text = plato.Descripcion;
            PrecioPlato.Text = plato.Precio.ToString();
        }

        private void EditarBoton_Click(object sender, EventArgs e)
        {
            try
            {;

                plato.Nombre = NombrePlato.Text;
                plato.Descripcion = DescripcionPlato.Text;
                plato.Precio = Convert.ToInt32(PrecioPlato.Text);
                Datos.SerLocales(locales);
                this.Hide();

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
    }
}

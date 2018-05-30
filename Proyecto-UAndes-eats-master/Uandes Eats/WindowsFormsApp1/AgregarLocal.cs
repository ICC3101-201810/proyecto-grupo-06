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
    public partial class AgregarLocal : Form
    {
        BaseDatos Datos = new BaseDatos();
        List<Local> locales;
        public AgregarLocal(List<Local> locales)
        {
            InitializeComponent();
            this.locales = locales;
        }

        private void CancelarBoton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AgregarBoton_Click(object sender, EventArgs e)
        {
            if (NombreNuevoLocalBox.Text == "" || UbicacionNuevoLocal.Text == "" || TiempoNuevoLocal.Text == "")
            {
                MessageBox.Show("Falta información");
            }
            else
            {
                bool crear = true;
                foreach (Local local in locales)
                {
                    if (local.Nombre == NombreNuevoLocalBox.Text)
                    {
                        crear = false;
                        MessageBox.Show("Este local ya existe");
                        break;
                    }
                }
                if (crear)
                {
                    locales.Add(new Local(NombreNuevoLocalBox.Text, UbicacionNuevoLocal.Text, TiempoNuevoLocal.Text, new List<Platos> { }));
                    Datos.SerLocales(locales);
                    this.Hide();
                }
            }


        }
    }
}

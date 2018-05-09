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
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void AtrasBoton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 F1 = new Form1();
            F1.ShowDialog();
        }

        private void IngresarBoton_Click(object sender, EventArgs e)
        {

        }
    }
}

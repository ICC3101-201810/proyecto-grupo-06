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
        public Registro()
        {
            InitializeComponent();
        }

        private void RegistrarseBoton_Click(object sender, EventArgs e)
        {

        }

        private void AtrasBoton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 F1 = new Form1();
            F1.ShowDialog();
        }
    }
}

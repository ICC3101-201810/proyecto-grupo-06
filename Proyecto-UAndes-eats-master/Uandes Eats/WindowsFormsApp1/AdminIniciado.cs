﻿using System;
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
    public partial class AdminIniciado : Form
    {
        List<Local> locales;
        List<Usuarios> usuarios;
        Usuarios usuario;
        List<Pedido> pedidos;

        public AdminIniciado(Usuarios usuario, List<Local> locales, List<Usuarios> usuarios, List<Pedido> pedidos)
        {
            InitializeComponent();
            this.locales = locales;
            this.usuario = usuario;
            this.usuarios = usuarios;
            this.pedidos = pedidos;
        }

        private void LocalesAdminComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MenuAdmin.Items.Clear();
            foreach (Platos plato in locales[LocalesAdminComboBox.SelectedIndex].Menu)
            {
                MenuAdmin.Items.Add(plato.Nombre);
            }
        }

        private void AdminIniciado_Load(object sender, EventArgs e)
        {
            foreach (Local local in locales)
            {
                LocalesAdminComboBox.Items.Add(local.Nombre);
            }
        }

        private void CerrarSesionBoton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F1 = new Form1(usuarios, locales, pedidos);
            F1.ShowDialog();
        }

        private void AgregarPlatoBoton_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarPlato F2 = new AgregarPlato(locales, locales[LocalesAdminComboBox.SelectedIndex]);
                F2.ShowDialog();
                MenuAdmin.Items.Clear();
                foreach (Platos plato in locales[LocalesAdminComboBox.SelectedIndex].Menu)
                {
                    MenuAdmin.Items.Add(plato.Nombre);
                }
            }
            catch
            { }
        }

        private void QuitarPlatoBoton_Click(object sender, EventArgs e)
        {
            try
            {
                locales[LocalesAdminComboBox.SelectedIndex].Menu.Remove(locales[LocalesAdminComboBox.SelectedIndex].Menu[MenuAdmin.SelectedIndex]);
                MenuAdmin.Items.Clear();
                foreach (Platos plato in locales[LocalesAdminComboBox.SelectedIndex].Menu)
                {
                    MenuAdmin.Items.Add(plato.Nombre);
                }
            }
            catch { }
        }

        private void AgregarLocalBoton_Click(object sender, EventArgs e)
        {
            AgregarLocal F3 = new AgregarLocal(locales);
            F3.ShowDialog();
            LocalesAdminComboBox.Items.Clear();
            foreach (Local local in locales)
            {
                LocalesAdminComboBox.Items.Add(local.Nombre);
            }
        }

        private void QuitarLocalBoton_Click(object sender, EventArgs e)
        {
            try
            {
                locales.Remove(locales[LocalesAdminComboBox.SelectedIndex]);
                LocalesAdminComboBox.Items.Clear();
                LocalesAdminComboBox.Text = "";
                foreach (Local local in locales)
                {
                    LocalesAdminComboBox.Items.Add(local.Nombre);
                }
                MenuAdmin.Items.Clear();

                LocalesAdminComboBox.SelectedIndex = 0;
                foreach (Platos plato in locales[LocalesAdminComboBox.SelectedIndex].Menu)
                {
                    MenuAdmin.Items.Add(plato.Nombre);
                }
            }
            catch
            { }
        }

        private void MenuAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                DescripcionPrecioPlatoAdmin.Items.Clear();
                DescripcionPrecioPlatoAdmin.Items.Add("Descripcion= " + locales[LocalesAdminComboBox.SelectedIndex].Menu[MenuAdmin.SelectedIndex].Descripcion);
                DescripcionPrecioPlatoAdmin.Items.Add("Precio = $" + locales[LocalesAdminComboBox.SelectedIndex].Menu[MenuAdmin.SelectedIndex].Precio.ToString());

            }
            catch { }
        }

        private void EditarPlatoBoton_Click(object sender, EventArgs e)
        {
            try
            {
                EditarPlato F3 = new EditarPlato(locales[LocalesAdminComboBox.SelectedIndex], locales[LocalesAdminComboBox.SelectedIndex].Menu[MenuAdmin.SelectedIndex], locales);
                F3.ShowDialog();
                MenuAdmin.Items.Clear();
                foreach (Platos plato in locales[LocalesAdminComboBox.SelectedIndex].Menu)
                {
                    MenuAdmin.Items.Add(plato.Nombre);
                }
                DescripcionPrecioPlatoAdmin.Items.Clear();
            }
            catch
            { }
        }
    }
}

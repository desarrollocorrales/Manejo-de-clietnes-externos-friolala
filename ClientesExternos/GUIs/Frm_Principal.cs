using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraNavBar;
using ClientesExternos.GUIs.UserControls;
using ClientesExternos.Modelos;

namespace ClientesExternos.GUIs
{
    public partial class Frm_Principal : Form
    {
        private Frm_Articulos frmArticulos;
        private Frm_Clientes frClientes;
        private Frm_Usuarios frmUsuarios;
        private Frm_Entradas frmEntradas;

        public Frm_Principal()
        {
            InitializeComponent();
            InicializarControles();
        }
        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            if (DatosDeApp.usuario_en_turno.permisos == "*")
            {
                itmArticulos.Visible = true;
                itmClientes.Visible = true;
                itmUsuarios.Visible = true;

                itmEntradas.Visible = false;
                itmSalidas.Visible = false;
            }
            if (DatosDeApp.usuario_en_turno.permisos == "+")
            {
                itmArticulos.Visible = false;
                itmClientes.Visible = false;
                itmUsuarios.Visible = false;

                itmEntradas.Visible = true;
                itmSalidas.Visible = true;
            }
        }

        private void InicializarControles()
        {
            frmArticulos = new Frm_Articulos();
            this.Controls.Add(frmArticulos);
            frmArticulos.Hide();

            frClientes = new Frm_Clientes();
            this.Controls.Add(frClientes);
            frClientes.Hide();

            frmUsuarios = new Frm_Usuarios();
            this.Controls.Add(frmUsuarios);
            frmUsuarios.Hide();

            frmEntradas = new Frm_Entradas();
            this.Controls.Add(frmEntradas);
            frmEntradas.Hide();
        }

        private void itmArticulos_LinkPressed(object sender, NavBarLinkEventArgs e)
        {
            frmArticulos.Show();
            frmArticulos.Dock = DockStyle.Fill;
            frmArticulos.BringToFront();
        }

        private void itmClientes_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frClientes.Show();
            frClientes.Dock = DockStyle.Fill;
            frClientes.BringToFront();
        }

        private void itmUsuarios_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmUsuarios.Show();
            frmUsuarios.Dock = DockStyle.Fill;
            frmUsuarios.BringToFront();
        }

        private void itmEntradas_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmEntradas.Show();
            frmEntradas.Dock = DockStyle.Fill;
            frmEntradas.BringToFront();
        }
        

        
    }
}

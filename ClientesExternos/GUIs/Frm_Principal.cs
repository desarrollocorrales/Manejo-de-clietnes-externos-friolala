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
        private Frm_Salidas frmSalidas;
        private Frm_Reporte_Inventario_Cliente frmInventarioPorCliente;
        private Frm_EntradasPorDia frmEntradasPorDia;

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

            this.Text += string.Format(" - [{0}]", DatosDeApp.usuario_en_turno.nombre_completo);
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

            frmSalidas = new Frm_Salidas();
            this.Controls.Add(frmSalidas);
            frmSalidas.Hide();

            frmInventarioPorCliente = new Frm_Reporte_Inventario_Cliente();
            this.Controls.Add(frmInventarioPorCliente);
            frmInventarioPorCliente.Hide();

            frmEntradasPorDia = new Frm_EntradasPorDia();
            this.Controls.Add(frmEntradasPorDia);
            frmEntradasPorDia.Hide();
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

        private void itmSalidas_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmSalidas.Show();
            frmSalidas.Dock = DockStyle.Fill;
            frmSalidas.BringToFront();
        }

        private void itmInventarioCliente_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmInventarioPorCliente.Show();
            frmInventarioPorCliente.Dock = DockStyle.Fill;
            frmInventarioPorCliente.BringToFront();
        }

        private void itmEntregasDia_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmEntradasPorDia.Show();
            frmEntradasPorDia.Dock = DockStyle.Fill;
            frmEntradasPorDia.BringToFront();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClientesExternos.Entity;
using ClientesExternos.Modelos;
using ClientesExternos.DAL;
using ClientesExternos.Reportes;

namespace ClientesExternos.GUIs.UserControls
{
    public partial class Frm_Reporte_Inventario_Cliente : UserControl
    {
        private string entityString = Properties.Settings.Default.EntityString;

        public Frm_Reporte_Inventario_Cliente()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private DateTime getFechaServer()
        {
            var Contexto = new ClientextEntities(entityString);
            var dateQuery = Contexto.CreateQuery<DateTime>("CurrentDateTime()");
            DateTime serverDate = dateQuery.AsEnumerable().First();
            return serverDate;
        }
        private void MostrarExcepcion(Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            var exType = ex.GetType().ToString();
            while (ex != null)
            {
                sb.AppendLine(ex.Message + " --> ");
                ex = ex.InnerException;
            }

            MessageBox.Show(sb.ToString(), exType, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CargarClientes()
        {
            try
            {
                var Contexto = new ClientextEntities(entityString);
                var lstClientes = Contexto.clientes.ToList();
                lstClientes = lstClientes.FindAll(o => o.estatus == "A").OrderBy(o => o.nombre).ToList();
                cmbClientes.DataSource = null;
                cmbClientes.DataSource = lstClientes;
                cmbClientes.DisplayMember = "nombre";
                Contexto.Dispose();
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }

        private void Frm_Reporte_Inventario_Cliente_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                Consultar();
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }
        private void Consultar()
        {
            var cliente = (clientes)cmbClientes.SelectedItem;
            var myDAL = new MyDAL();

            var lstInventario = myDAL.getInventarioPorCliente(cliente.id_cliente);
            gridInvCliente.DataSource = lstInventario;
            gvInvCliente.BestFitColumns();
        }

        private void gvInvCliente_EndGrouping(object sender, EventArgs e)
        {
            (sender as DevExpress.XtraGrid.Views.Grid.GridView).ExpandAllGroups();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }
        private void Imprimir()
        {
            try
            {
                clientes cliente = (clientes)cmbClientes.SelectedItem;
                rptInventarioClientes rptInvCliente = new rptInventarioClientes();
                rptInvCliente.Cliente = cliente.nombre;
                rptInvCliente.Fecha = getFechaServer();

                rptInvCliente.DataSource = gridInvCliente.DataSource;
                rptInvCliente.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }
    }
}

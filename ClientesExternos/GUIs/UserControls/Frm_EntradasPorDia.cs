﻿using System;
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
    public partial class Frm_EntradasPorDia : UserControl
    {
        string entityString = Properties.Settings.Default.EntityString;

        public Frm_EntradasPorDia()
        {
            InitializeComponent();
        }

        private void CargarClientes()
        {
            try
            {
                var todosLosClientes = new clientes();
                todosLosClientes.nombre = "-= TODOS LOS CLIENTES =-";
                todosLosClientes.id_cliente = 0;
                var Contexto = new ClientextEntities(entityString);
                var lstClientesAUX = Contexto.clientes.ToList();

                var lstClientes = new List<clientes>();
                lstClientes.Add(todosLosClientes);
                lstClientes.AddRange(lstClientesAUX.FindAll(o => o.estatus == "A").OrderBy(o => o.nombre).ToList());
                
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultarEntradasPorDia();
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }

        private void ConsultarEntradasPorDia()
        {
            MyDAL mySQL = new MyDAL();
            var fechaInicial = dtpFechaInicial.Value;
            var fechaFinal = dtpFechaFinal.Value;
            var cliente = (clientes)cmbClientes.SelectedItem;
            var lstEntregasPorDia = mySQL.getEntradasPorDia(fechaInicial, fechaFinal, cliente.id_cliente);
            gridEntradasDia.DataSource = lstEntregasPorDia;
            gvEntradasDia.BestFitColumns();

            if (lstEntregasPorDia.Count == 0)
            {
                MessageBox.Show("No hay registros de entrada para la fecha seleccionada...", "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gvEntradasDia_EndGrouping(object sender, EventArgs e)
        {
            (sender as DevExpress.XtraGrid.Views.Grid.GridView).ExpandAllGroups();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Imprimir();
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }
        private void Imprimir()
        {
            rptMovimientosPorDia rptEntradas = new rptMovimientosPorDia();
            rptEntradas.fecha_inicial = dtpFechaInicial.Value;
            rptEntradas.fecha_final = dtpFechaFinal.Value;
            rptEntradas.DataSource = gridEntradasDia.DataSource;
            rptEntradas.ShowPreviewDialog();
        }

        private void Frm_EntradasPorDia_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

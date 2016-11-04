using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ClientesExternos.Reportes
{
    public partial class rptMovimientosPorDia : DevExpress.XtraReports.UI.XtraReport
    {
        public DateTime fecha_inicial;
        public DateTime fecha_final;
        public bool esEntrada = true;

        public rptMovimientosPorDia()
        {
            InitializeComponent();
        }

        private void rptEntregasPorDia_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblFecha.Text = DateTime.Today.ToString("dd/MMM/yyyy").ToUpper();
            lblFechaInicial.Text = fecha_inicial.ToString("dd/MMM/yyyy").ToUpper();
            lblFechaFinal.Text = fecha_final.ToString("dd/MMM/yyyy").ToUpper();

            if (esEntrada == true)
            {
                //Entradas
                lblTitulo.Text = "Entradas de Mercancía";    
            }
            else
            {
                //Salidas
                lblTitulo.Text = "Salidas de Mercancía";
            }            
        }

    }
}

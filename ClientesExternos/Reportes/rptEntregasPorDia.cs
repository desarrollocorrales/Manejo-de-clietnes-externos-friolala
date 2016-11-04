using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ClientesExternos.Reportes
{
    public partial class rptEntregasPorDia : DevExpress.XtraReports.UI.XtraReport
    {
        public DateTime fecha;

        public rptEntregasPorDia()
        {
            InitializeComponent();
        }

        private void rptEntregasPorDia_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblFechaReporte.Text = "Entradas de mercancía del día: " + fecha.ToString("dd/MMMM/yyyy");
            lblFecha.Text = DateTime.Today.ToString("dd/MMM/yyyy").ToUpper();
        }

    }
}

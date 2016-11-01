using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ClientesExternos.Reportes
{
    public partial class rptSalida : DevExpress.XtraReports.UI.XtraReport
    {
        public string Usuario;
        public DateTime Fecha;

        public rptSalida()
        {
            InitializeComponent();
        }

        private void rptSalida_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblUsuario.Text = Usuario;
            lblFecha.Text = Fecha.ToString("dd/MMM/yyyy").ToUpper();
        }

    }
}

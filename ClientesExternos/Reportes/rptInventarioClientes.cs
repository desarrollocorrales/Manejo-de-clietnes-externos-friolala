using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ClientesExternos.Reportes
{
    public partial class rptInventarioClientes : DevExpress.XtraReports.UI.XtraReport
    {
        public string Cliente;
        public DateTime Fecha;

        public rptInventarioClientes()
        {
            InitializeComponent();
        }

        private void rptInventarioClientes_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblCliente.Text = "CLIENTE: " + this.Cliente; 
            lblFecha.Text = this.Fecha.ToString("dd/MMM/yyyy").ToUpper();
        }

    }
}

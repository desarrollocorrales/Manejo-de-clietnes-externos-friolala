using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ClientesExternos.Entity;

namespace ClientesExternos.Reportes
{
    public partial class rptEntrada : DevExpress.XtraReports.UI.XtraReport
    {
        public DateTime Fecha;
        public clientes Cliente = new clientes();
        public usuarios Usuario = new usuarios();

        public rptEntrada()
        {
            InitializeComponent();
        }

        private void rptEntrada_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblFecha.Text = Fecha.ToString("dd/MMM/yyyy").ToUpper();
            lblCliente.Text = Cliente.nombre;
            lblUsuario.Text = Usuario.nombre_completo;
        }

    }
}

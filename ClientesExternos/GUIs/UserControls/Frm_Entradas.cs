using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClientesExternos.Modelos;
using ClientesExternos.Entity;
using ClientesExternos.Reportes;
using Sofbr.Utils.Impresoras;

namespace ClientesExternos.GUIs.UserControls
{
    public partial class Frm_Entradas : UserControl
    {
        private List<articulos> lstArticulos;
        private List<long> lstIDsTarimasImprimir;
        private List<tarimas_entradas> lstTarimasEntrada;
        
        private string entityString = Properties.Settings.Default.EntityString;

        public Frm_Entradas()
        {
            InitializeComponent();
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
        private void CargarArticulos()
        {
            try
            {
                var Contexto = new ClientextEntities(entityString);
                this.lstArticulos = Contexto.articulos.ToList();
                this.lstArticulos = lstArticulos.FindAll(o => o.estatus == "A");

                Contexto.Dispose();
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }
        private void CargarArticulosLocales()
        {
            try
            {
                var cliente = (clientes)cmbClientes.SelectedItem;
                if (this.lstArticulos != null)
                {
                    var lstArticulos = this.lstArticulos.FindAll(o => o.id_cliente == cliente.id_cliente);

                    cmbArticulos.DataSource = null;
                    cmbArticulos.DataSource = lstArticulos;
                    cmbArticulos.DisplayMember = "codigo_nombre";
                }
            }
            catch 
            {

            }
        }

        private void Frm_Entradas_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarArticulosLocales();
        }

        private void Frm_Entradas_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                CargarClientes();
                CargarArticulos();
                CargarArticulosLocales();
                dtpFechaRecepcion.Value = getFechaServer();
                txbFecha.Text = dtpFechaRecepcion.Value.ToString("dd/MMM/yyyy").ToUpper();

                lstTarimasEntrada = new List<tarimas_entradas>();
                gridTarimas.DataSource = lstTarimasEntrada;
                gvTarimas.BestFitColumns();
                cmbClientes.Enabled = true;
            }
        }

        private void txbNumCajas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txbPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.')
            {
                if (txbPeso.Text.Contains(".") == true)
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarTarima();
        }
        private void EliminarTarima()
        {
            try
            {
                if (lstTarimasEntrada.Count > 0)
                {
                    int[] indice = gvTarimas.GetSelectedRows();
                    tarimas_entradas tarima = (tarimas_entradas)gvTarimas.GetRow(indice[0]);

                    lstTarimasEntrada.Remove(tarima);
                    gridTarimas.DataSource = null;
                    gridTarimas.DataSource = lstTarimasEntrada;
                    gvTarimas.BestFitColumns();

                    if (lstTarimasEntrada.Count == 0)
                    {
                        cmbClientes.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarTarima();
        }
        private void AgregarTarima()
        {
            var clienteselec = (clientes)cmbClientes.SelectedItem;
            var articuloselec = (articulos)cmbArticulos.SelectedItem; 
            try
            {
                if (ValidarTarima() == true)
                {
                    tarimas_entradas tarima = new tarimas_entradas();
                    tarima.clientes = new clientes();
                    tarima.clientes.id_cliente = clienteselec.id_cliente;
                    tarima.clientes.nombre = clienteselec.nombre;

                    tarima.articulos = new articulos();
                    tarima.articulos.id_articulo = articuloselec.id_articulo;
                    tarima.articulos.nombre = articuloselec.nombre;

                    tarima.num_cajas = Convert.ToInt32(txbNumCajas.Text);
                    tarima.peso = Convert.ToDecimal(txbPeso.Text);
                    tarima.numero_tarima_cliente = txbNumTarimaCliente.Text.ToUpper();

                    tarima.usuarios = new usuarios();
                    tarima.usuarios.id_usuario = DatosDeApp.usuario_en_turno.id_usuario;
                    tarima.usuarios.nombre_usuario = DatosDeApp.usuario_en_turno.nombre_usuario;

                    tarima.fecha_ingreso = dtpFechaRecepcion.Value;

                    lstTarimasEntrada.Add(tarima);
                    gridTarimas.DataSource = null;
                    gridTarimas.DataSource = lstTarimasEntrada;
                    gvTarimas.BestFitColumns();

                    cmbClientes.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }
        private bool ValidarTarima()
        {
            var cliente = (clientes)cmbClientes.SelectedItem;
            var articulo = (articulos)cmbArticulos.SelectedItem;

            if (cliente == null)
            {
                MessageBox.Show("Debe seleccionar un cliente...", "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (articulo == null)
            {
                MessageBox.Show("Debe seleccionar un artículo...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txbNumCajas.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe proporcionar el número de cajas de la tarima...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txbPeso.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe proporcionar el peso de la tarima...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validarimprimir() == true)
                {
                    CrearEtiquetas();
                    Imprimir();
                    LimpiarControles();
                }
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }
        private void Imprimir()
        {
            var cliente = (clientes)cmbClientes.SelectedItem;
            var sRespaldoPath = Application.StartupPath + "\\Docs Backup\\" + cliente.serie + "_E_" + getFechaServer().ToString("ddMMyyyy_HHmmss") + ".pdf";
            try
            {
                var Contexto = new ClientextEntities(entityString);      
                var lstAuxiliar = Contexto.tarimas_entradas.ToList();
                var lstTarimas_A_Imprimir = new List<tarimas_entradas>();
                foreach (long ID in lstIDsTarimasImprimir)
                {
                    lstTarimas_A_Imprimir.Add(lstAuxiliar.FirstOrDefault(o => o.id_tarima == ID));
                }

                rptEntrada NuevaEntrada = new rptEntrada();
                NuevaEntrada.Cliente = (clientes)cmbClientes.SelectedItem;
                NuevaEntrada.Usuario = DatosDeApp.usuario_en_turno;
                NuevaEntrada.Fecha = dtpFechaRecepcion.Value;
                NuevaEntrada.DataSource = lstTarimas_A_Imprimir;

                //Respaldos de documento
                NuevaEntrada.ExportToPdf(sRespaldoPath);

                NuevaEntrada.ShowPreviewDialog();

                Contexto.Dispose();
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }
        private void CrearEtiquetas()
        {
            var lstEtiquetas = new StringBuilder();
            lstIDsTarimasImprimir = new List<long>();

            try
            {
                var Contexto = new ClientextEntities(entityString);
                var comando = Contexto.plantillas_etiquetas.FirstOrDefault(o => o.nombre == "ENTRADA").comando;

                tarimas_entradas tarima;
                foreach (tarimas_entradas tar_ent in lstTarimasEntrada)
                {
                    tarima = new tarimas_entradas();
                    tarima.id_cliente = tar_ent.clientes.id_cliente;
                    tarima.id_articulo = tar_ent.articulos.id_articulo;
                    tarima.num_cajas = tar_ent.num_cajas;
                    tarima.peso = tar_ent.peso;
                    tarima.fecha_ingreso = tar_ent.fecha_ingreso;
                    tarima.numero_tarima_cliente = tar_ent.numero_tarima_cliente;
                    tarima.id_usuario = DatosDeApp.usuario_en_turno.id_usuario;

                    Contexto.tarimas_entradas.AddObject(tarima);
                    Contexto.SaveChanges();

                    tarima.numero_etiqueta =
                          tarima.id_cliente.ToString().PadLeft(4, '0')
                        + tarima.id_tarima.ToString().PadLeft(8, '0')
                        + getCheckDigit(tarima.id_tarima.ToString());

                    Contexto.SaveChanges();

                    lstIDsTarimasImprimir.Add(tarima.id_tarima);

                    lstEtiquetas.AppendLine(CrearComando(comando, tarima));
                }
                Contexto.SaveChanges();

                ImprimirEtiquetas(lstEtiquetas.ToString());

                Contexto.Dispose();
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }
        private bool Validarimprimir()
        {
            var dr = MessageBox.Show("¿Los datos son correctos?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No)
                return false;

            return true;
        }

        private void LimpiarControles()
        {
            cmbClientes.Enabled = true;
            txbNumCajas.Clear();
            txbPeso.Clear();
            txbNumTarimaCliente.Clear();
            gridTarimas.DataSource = null;
            lstTarimasEntrada.Clear();
            lstIDsTarimasImprimir.Clear();
        }

        public static string getCheckDigit(string barcode)
        {
            // Cálculo del dígito de control EAN
            int iSum = 0;
            int iSumInpar = 0;
            int iDigit = 0;
            string EAN = barcode;

            EAN = EAN.PadLeft(13, '0');

            for (int i = EAN.Length; i >= 1; i--)
            {
                iDigit = Convert.ToInt32(EAN.Substring(i - 1, 1));
                if (i % 2 != 0)
                {
                    iSumInpar += iDigit;
                }
                else
                {
                    iSum += iDigit;
                }
            }

            iDigit = (iSumInpar * 3) + iSum;

            int iCheckSum = (10 - (iDigit % 10)) % 10;
            return iCheckSum.ToString();
        }

        /***** Impresion de etiquetas *****/
        private void ImprimirEtiquetas(string Comando)
        {
            string ImpresoraDeEtiquetas = Properties.Settings.Default.Impresora;
            RawPrinter.SendToPrinter("Etiqueta Entrada", Comando, ImpresoraDeEtiquetas);
        }
        private string CrearComando(string Comando, tarimas_entradas tarima)
        {
            string ComandoReemplazado = Comando;

            ComandoReemplazado = ComandoReemplazado.Replace("{CLIENTE}", tarima.clientes.nombre);
            ComandoReemplazado = ComandoReemplazado.Replace("{CODIGO}", tarima.articulos.codigo);
            ComandoReemplazado = ComandoReemplazado.Replace("{ARTICULO}", tarima.articulos.nombre);
            ComandoReemplazado = ComandoReemplazado.Replace("{CAJAS}", tarima.num_cajas.ToString());
            ComandoReemplazado = ComandoReemplazado.Replace("{PESO}", tarima.peso.ToString());
            ComandoReemplazado = ComandoReemplazado.Replace("{FECHA}", tarima.fecha_ingreso.ToString("dd/mm/yyyy"));
            ComandoReemplazado = ComandoReemplazado.Replace("0000000000000", tarima.numero_etiqueta);

            return ComandoReemplazado;
        }
    }
}

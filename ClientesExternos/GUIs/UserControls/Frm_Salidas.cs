using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ClientesExternos.Entity;
using ClientesExternos.Modelos;
using ClientesExternos.Reportes;

namespace ClientesExternos.GUIs.UserControls
{
    public partial class Frm_Salidas : UserControl
    {
        private string sRutaEscaneo = string.Empty;
        private string entityString = Properties.Settings.Default.EntityString;

        public Frm_Salidas()
        {
            InitializeComponent();
        }

        private void gvSalidas_EndGrouping(object sender, EventArgs e)
        {
            (sender as DevExpress.XtraGrid.Views.Grid.GridView).ExpandAllGroups();
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
        private DateTime getFechaServer()
        {
            var Contexto = new ClientextEntities();
            var dateQuery = Contexto.CreateQuery<DateTime>("CurrentDateTime()");
            DateTime serverDate = dateQuery.AsEnumerable().First();
            return serverDate;
        }

        private void btnBuscarEscaneo_Click(object sender, EventArgs e)
        {
            try
            {
                ObtenerTarimas();
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }
        private void ObtenerTarimas()
        {
            var dr = ofdEscaneo.ShowDialog();
            if (dr == DialogResult.OK)
            {
                sRutaEscaneo = ofdEscaneo.FileName;
                txbRutaEscaneo.Text = sRutaEscaneo;
                var lstNumerosEtiquetas = AbrirArchivo(sRutaEscaneo);
                
                SalidasGrid TarimaSalida;
                var Contexto = new ClientextEntities();
                var lstManiobrasSalida = new List<tarimas_salidas>();
                var lstTarimas = new List<SalidasGrid>();

                foreach (string numeroEtiqueta in lstNumerosEtiquetas)
                {
                    TarimaSalida = new SalidasGrid();

                    var TarimaEntradaEncontrada = Contexto.tarimas_entradas.FirstOrDefault(o => o.numero_etiqueta == numeroEtiqueta);

                    if (TarimaEntradaEncontrada != null)
                    {
                        var lstAuxiliar = Contexto.tarimas_salidas.Where(o => o.id_tarima == TarimaEntradaEncontrada.id_tarima).ToList();

                        int cajasEntregadas = 0;
                        decimal pesoEntregado = 0;
                        if (lstAuxiliar.Count > 0)
                        {
                            cajasEntregadas = lstAuxiliar.Sum(o => o.num_cajas);
                            pesoEntregado = lstAuxiliar.Sum(o => o.peso);                            
                        }

                        TarimaSalida.ID_Tarima = TarimaEntradaEncontrada.id_tarima;
                        TarimaSalida.NumeroTarima = TarimaEntradaEncontrada.numero_etiqueta;
                        TarimaSalida.NumeroTarimaCliente = TarimaEntradaEncontrada.numero_tarima_cliente;

                        TarimaSalida.ID_Articulo = TarimaEntradaEncontrada.articulos.id_articulo;
                        TarimaSalida.Codigo = TarimaEntradaEncontrada.articulos.codigo;
                        TarimaSalida.Articulo = TarimaEntradaEncontrada.articulos.nombre;

                        TarimaSalida.ID_Cliente = TarimaEntradaEncontrada.clientes.id_cliente;
                        TarimaSalida.Cliente = TarimaEntradaEncontrada.clientes.nombre;

                        TarimaSalida.CajasMax = TarimaEntradaEncontrada.num_cajas - cajasEntregadas;
                        TarimaSalida.Cajas = TarimaSalida.CajasMax;
                        TarimaSalida.PesoMax = TarimaEntradaEncontrada.peso - pesoEntregado;
                        TarimaSalida.Peso = TarimaSalida.PesoMax;

                        lstTarimas.Add(TarimaSalida);
                    }
                }

                gridSalidas.DataSource = lstTarimas;
                gvSalidas.BestFitColumns();

                Contexto.Dispose();
            }
        }
        private List<string> AbrirArchivo(string sFile)
        {
            StreamReader sr = new StreamReader(sFile);

            string line;
            List<string> lines = new List<string>();
            while ((line = sr.ReadLine()) != null)
                lines.Add(line);

            sr.Close();

            return lines.Distinct().ToList();
        }

        private void btnGenerarSalida_Click(object sender, EventArgs e)
        {
            GenerarSalida();
        }
        private void GenerarSalida()
        {
            if (ValidarSalida() == true)
            {
                var lstTarimas = (List<SalidasGrid>)gridSalidas.DataSource;
                var Contexto = new ClientextEntities();
                tarimas_salidas Maniobra;
                foreach (SalidasGrid tarima in lstTarimas)
                {
                    Maniobra = new tarimas_salidas();
                    Maniobra.id_tarima = tarima.ID_Tarima;
                    Maniobra.id_cliente = tarima.ID_Cliente;
                    Maniobra.id_articulo = tarima.ID_Articulo;
                    Maniobra.num_cajas = tarima.Cajas;
                    Maniobra.peso = tarima.Peso;
                    Maniobra.fecha_salida = getFechaServer();
                    Maniobra.id_usuario = DatosDeApp.usuario_en_turno.id_usuario;

                    if (Maniobra.num_cajas != 0)
                    {
                        if (Maniobra.peso != 0)
                        {
                            Contexto.tarimas_salidas.AddObject(Maniobra);
                            Contexto.SaveChanges();
                        }
                    }
                }

                Contexto.Dispose();

                MessageBox.Show("¡La salida se realizó con éxito!", "Salida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarControles();

                rptSalida xrSalida = new rptSalida();
                xrSalida.Usuario = DatosDeApp.usuario_en_turno.nombre_completo;
                xrSalida.Fecha = getFechaServer();
                xrSalida.DataSource = lstTarimas;
                xrSalida.ShowPreviewDialog();
            }
        }
        private bool ValidarSalida()
        {
            var lstTarimas = (List<SalidasGrid>)gridSalidas.DataSource;
            foreach (SalidasGrid tarima in lstTarimas)
            {
                if (tarima.Cajas > tarima.CajasMax)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Error en la tarima: " + tarima.NumeroTarima);
                    sb.AppendLine("No puede sacar " + tarima.Cajas + " cajas. El máximo de cajas posible es: " + tarima.CajasMax);
                    MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (tarima.Peso > tarima.PesoMax)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Error en la tarima: " + tarima.NumeroTarima);
                    sb.AppendLine("No puede sacar " + tarima.Peso+ " Kgs. El máximo de peso posible es: " + tarima.PesoMax + " Kgs.");
                    MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            var sum_cajas = lstTarimas.Sum(o => o.Cajas);
            if (sum_cajas == 0)
            {
                MessageBox.Show("No se puede realizar salida por 0 cajas...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var sum_peso = lstTarimas.Sum(o => o.Peso);
            if (sum_peso == 0)
            {
                MessageBox.Show("No se puede realizar salida por 0 Kgs...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var dr = MessageBox.Show("¿Los datos estan correctos?", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return false;
            }

            return true;
        }
        private void LimpiarControles()
        {
            gridSalidas.DataSource = null;
            sRutaEscaneo = string.Empty;
            txbRutaEscaneo.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

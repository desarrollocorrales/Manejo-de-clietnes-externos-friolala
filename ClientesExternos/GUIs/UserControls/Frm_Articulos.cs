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

namespace ClientesExternos.GUIs.UserControls
{
    public partial class Frm_Articulos : UserControl
    {
        private string entityString = Properties.Settings.Default.EntityString;
        private TiposDeAccion tipoAccion;

        public Frm_Articulos()
        {
            InitializeComponent();
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            pnlControles.Visible = false;
            this.Hide();
            LimpiarControles();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlControles.Visible = false;
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            switch (tipoAccion)
            {
                case TiposDeAccion.Nuevo:
                    GuardarNuevo();
                    break;
                case TiposDeAccion.Modificar:
                    GuardarModificacion();
                    break;

            }
        }
        private void GuardarNuevo()
        {
            ClientextEntities Contexto = new ClientextEntities(entityString);
            Contexto.Connection.Open();
            var Transaccion = Contexto.Connection.BeginTransaction();
            try
            {
                if (ValidarNuevo() == true)
                {
                    var nuevo_articulo = new articulos();
                    nuevo_articulo.codigo = txbCodigo.Text.Trim().ToUpper();
                    nuevo_articulo.nombre = txbNombre.Text.Trim().ToUpper();
                    nuevo_articulo.id_cliente = ((clientes)cmbClientes.SelectedItem).id_cliente;
                    nuevo_articulo.id_usuario_creador = DatosDeApp.usuario_en_turno.id_usuario;
                    nuevo_articulo.fecha_creacion = getFechaServer();
                    nuevo_articulo.estatus = "A";

                    
                    Contexto.articulos.AddObject(nuevo_articulo);
                    Contexto.SaveChanges();
                    Transaccion.Commit();

                    MessageBox.Show("¡¡¡Nuevo artículo agregado al catálogo con exito!!!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                }
            }
            catch (Exception ex)
            {
                Transaccion.Rollback();
                MostrarExcepcion(ex);
            }

            if (Contexto.Connection.State != ConnectionState.Closed)
                Contexto.Connection.Close();
        }
        private bool ValidarNuevo()
        {
            if (txbCodigo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe teclear un código para el artículo...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txbNombre.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe teclear un nombre para el artículo...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var dr = MessageBox.Show("¿Son datos correctos?","Validar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return false;
            }
            return true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                NuevoArticulo();
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }
        private void NuevoArticulo()
        {
            LimpiarControles();
            lblAccion.Text = "Nuevo Artículo";
            pnlControles.Visible = true;
            tipoAccion = TiposDeAccion.Nuevo;
            btnEliminarAplicar.Visible = false;
            btnGuardar.Visible = true;

            cmbCodigos.Visible = false;
            txbCodigo.Location = cmbCodigos.Location;
            txbCodigo.Visible = true;
            txbNombre.Text = string.Empty;
        }

        private void Frm_Articulos_Load(object sender, EventArgs e)
        {
            CargarClientes();            
        }
        private void CargarClientes()
        {
            try
            {
                ClientextEntities Contexto = new ClientextEntities(entityString);

                List<clientes> lstClientes = Contexto.clientes.ToList().FindAll(o => o.estatus == "A");
                lstClientes = lstClientes.OrderBy(o => o.nombre).ToList();

                cmbClientes.DataSource = lstClientes;
                cmbClientes.DisplayMember = "nombre";
                cmbClientes.ValueMember = "id_cliente";

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
                var cliente = (clientes)cmbClientes.SelectedItem;
                ClientextEntities Contexto = new ClientextEntities(entityString);

                List<articulos> lstArticulos = Contexto.articulos.ToList();
                lstArticulos = lstArticulos.FindAll(o => o.id_cliente == cliente.id_cliente);
                lstArticulos = lstArticulos.FindAll(o => o.estatus == "A");
                lstArticulos = lstArticulos.OrderBy(o => o.codigo).ToList();

                cmbCodigos.DataSource = null;
                cmbCodigos.DataSource = lstArticulos;
                cmbCodigos.DisplayMember = "codigo";

                Contexto.Dispose();
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }

        private void LimpiarControles()
        {
            txbCodigo.Text = string.Empty;
            txbNombre.Text = string.Empty;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarArticulo();
        }
        private void ModificarArticulo()
        {
            LimpiarControles();
            CargarArticulos();
            lblAccion.Text = "Modificar Artículo";
            pnlControles.Visible = true;
            tipoAccion = TiposDeAccion.Modificar;
            btnEliminarAplicar.Visible = false;
            btnGuardar.Visible = true;

            cmbCodigos.Visible = true;
            txbCodigo.Visible = false;
        }
        private void GuardarModificacion()
        {
            var cliente = (clientes)cmbClientes.SelectedItem;
            var articulo = (articulos)cmbCodigos.SelectedItem;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("¿Esta seguro que desea modificar el artículo?");
            sb.AppendLine("Cliente: " + cliente.nombre);
            sb.AppendLine("Artículo: " + articulo.nombre);
            sb.AppendLine("Nuevo nombre de Artículo: " + txbNombre.Text);
            var dr = MessageBox.Show(sb.ToString(), "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    var Contexto = new ClientextEntities();
                    var ArticuloModificar= Contexto.articulos.FirstOrDefault(o => (o.codigo == articulo.codigo) && (o.id_cliente == articulo.id_cliente));
                    if (ArticuloModificar != null)
                    {
                        Contexto.articulos.DeleteObject(ArticuloModificar);
                        Contexto.SaveChanges();

                        ArticuloModificar.nombre = txbNombre.Text.Trim().ToUpper();
                        ArticuloModificar.id_usuario_ultima_modificacion = DatosDeApp.usuario_en_turno.id_usuario;
                        ArticuloModificar.fecha_ultima_modificacion = getFechaServer();
                        Contexto.articulos.AddObject(ArticuloModificar);
                        Contexto.SaveChanges();
                        MessageBox.Show("¡¡¡Artículo modificado con éxito!!!", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MostrarExcepcion(ex);
                }
                CargarArticulos();
            }
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tipoAccion != TiposDeAccion.Nuevo)
                CargarArticulos();  
        }

        private void cmbCodigos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var articulo = (articulos)cmbCodigos.SelectedItem;
                txbNombre.Text = articulo.nombre;
            }
            catch
            {

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            InicializarEliminar();
        }
        private void InicializarEliminar()
        {
            LimpiarControles();
            CargarArticulos();
            lblAccion.Text = "Eliminar Artículo";
            pnlControles.Visible = true;
            tipoAccion = TiposDeAccion.Eliminar;
            btnEliminarAplicar.Visible = true;
            btnEliminarAplicar.Location = btnGuardar.Location;
            btnGuardar.Visible = false;

            cmbCodigos.Visible = true;
            txbCodigo.Visible = false;
        }

        private void btnEliminarAplicar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        private void Eliminar()
        {
            var cliente = (clientes)cmbClientes.SelectedItem;
            var articulo = (articulos)cmbCodigos.SelectedItem;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("¿Esta seguro que desea eliminar el artículo?");
            sb.AppendLine("Cliente: " + cliente.nombre);
            sb.AppendLine("Artículo: " + articulo.nombre);
            var dr = MessageBox.Show(sb.ToString(), "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                EliminarArticulo();
                CargarArticulos();
            }
        }

        private void EliminarArticulo()
        {
            try
            {
                var articulo = (articulos)cmbCodigos.SelectedItem;
                var Contexto = new ClientextEntities();
                var ArticuloEliminar = Contexto.articulos.FirstOrDefault(o => (o.codigo == articulo.codigo) && (o.id_cliente == articulo.id_cliente));
                if (ArticuloEliminar != null)
                {
                    ArticuloEliminar.estatus = "B";
                    ArticuloEliminar.id_usuario_ultima_modificacion = DatosDeApp.usuario_en_turno.id_usuario;
                    ArticuloEliminar.fecha_ultima_modificacion = getFechaServer();
                    Contexto.SaveChanges();
                    MessageBox.Show("¡¡¡Artículo eliminado con éxito!!!", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }

        private DateTime getFechaServer()
        {
            var Contexto = new ClientextEntities();
            var dateQuery = Contexto.CreateQuery<DateTime>("CurrentDateTime()");
            DateTime serverDate = dateQuery.AsEnumerable().First();
            return serverDate;
        }
    }
}

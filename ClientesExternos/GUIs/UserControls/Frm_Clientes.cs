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
    public partial class Frm_Clientes : UserControl
    {
        private string entityString = Properties.Settings.Default.EntityString;
        private TiposDeAccion tipoAccion;

        public Frm_Clientes()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            pnlControles.Visible = false;
            this.Hide();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            InicializarNuevo();
        }
        private void InicializarNuevo()
        {
            pnlControles.Visible = true;
            txbNombre.Text = string.Empty;
            txbSerie.Text = string.Empty;
            txbNombre.ReadOnly = false;
            txbSerie.ReadOnly = false;
            btnGuardar.Visible = true;
            btnEliminarAplicar.Visible = false;
            tipoAccion = TiposDeAccion.Nuevo;
            CargarClientes();
            lstbClientes.Enabled = false;
            lblAccion.Text = "Nuevo Cliente";
        }
        private bool ValidarNuevo()
        {
            if (txbNombre.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe asignar el nombre del cliente...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txbSerie.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe asignar una serie al cliente...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var dr = MessageBox.Show("¿Son datos correctos?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return false;
            }

            return true;
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
                    var nuevo_cliente = new clientes();
                    nuevo_cliente.nombre = txbNombre.Text.Trim().ToUpper();
                    nuevo_cliente.serie = txbSerie.Text.Trim().ToUpper();
                    nuevo_cliente.id_usuario_creador = (int)DatosDeApp.usuario_en_turno.id_usuario;
                    nuevo_cliente.fecha_creacion = getFechaServer();
                    nuevo_cliente.estatus = "A";


                    Contexto.clientes.AddObject(nuevo_cliente);
                    Contexto.SaveChanges();
                    Transaccion.Commit();

                    MessageBox.Show("¡¡¡Nuevo cliente agregado al catálogo con exito!!!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InicializarNuevo();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlControles.Visible = false;
            txbNombre.Text = string.Empty;
            txbSerie.Text = string.Empty;
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
                    ModificarCliente();
                    break;
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
        private void CargarClientes()
        {
            try
            {
                var Contexto = new ClientextEntities(entityString);
                var lstClientes = Contexto.clientes.ToList();
                lstClientes = lstClientes.FindAll(o => o.estatus == "A").OrderBy(o=>o.nombre).ToList();
                lstbClientes.DataSource = null;
                lstbClientes.DataSource = lstClientes;
                lstbClientes.DisplayMember = "nombre";
                Contexto.Dispose();
            }
            catch(Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }
        private void lstbClientes_Click(object sender, EventArgs e)
        {
            var cliente = (clientes)lstbClientes.SelectedItem;
            txbNombre.Text = cliente.nombre;
            txbSerie.Text = cliente.serie;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            InicializarModificar();
        }
        private void InicializarModificar()
        {
            pnlControles.Visible = true;
            txbNombre.Text = string.Empty;
            txbSerie.Text = string.Empty;
            txbNombre.ReadOnly = false;
            txbSerie.ReadOnly = false;
            btnGuardar.Visible = true;
            btnEliminarAplicar.Visible = false;
            tipoAccion = TiposDeAccion.Modificar;
            CargarClientes();
            lstbClientes.Enabled = true;
            lblAccion.Text = "Modificar Cliente";
        }
        private void ModificarCliente()
        {
            if (ValidarNuevo() == true)
            {
                var Contexto = new ClientextEntities(entityString);
                var ClienteSeleccionado = (clientes)lstbClientes.SelectedItem;
                var ClienteModificado = Contexto.clientes.FirstOrDefault(o => o.id_cliente == ClienteSeleccionado.id_cliente);
                if (ClienteModificado != null)
                {
                    ClienteModificado.nombre = txbNombre.Text.Trim().ToUpper();
                    ClienteModificado.serie = txbSerie.Text.Trim().ToUpper();
                    ClienteModificado.id_usuario_ultima_modificacion = (int)DatosDeApp.usuario_en_turno.id_usuario;
                    ClienteModificado.fecha_ultima_modificacion = getFechaServer();

                    Contexto.SaveChanges();
                    MessageBox.Show("¡¡¡ Los datos se han actualizado con éxito !!!", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Contexto.Dispose();
                InicializarModificar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            InicializarEliminar();
        }
        private void InicializarEliminar()
        {
            pnlControles.Visible = true;
            txbNombre.Text = string.Empty;
            txbSerie.Text = string.Empty;
            txbNombre.ReadOnly = true;
            txbSerie.ReadOnly = true;
            btnEliminarAplicar.Location = btnGuardar.Location;
            btnGuardar.Visible = false;
            btnEliminarAplicar.Visible = true;
            tipoAccion = TiposDeAccion.Eliminar;
            CargarClientes();
            lstbClientes.Enabled = true;
            lblAccion.Text = "Eliminar Cliente";
        }

        private void btnEliminarAplicar_Click(object sender, EventArgs e)
        {
            EliminarCliente();
        }
        private bool ValidarEliminarCliente()
        {
            var cliente = (clientes)lstbClientes.SelectedItem;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("¿Esta seguro de que desea eliminar a este cliente?");
            sb.AppendLine("Cliente: " + cliente.nombre);
            var dr = MessageBox.Show(sb.ToString(), "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return false;
            }

            return true;
        }
        private void EliminarCliente()
        {
            if (ValidarEliminarCliente() == true)
            {
                var Contexto = new ClientextEntities(entityString);
                var ClienteSeleccionado = (clientes)lstbClientes.SelectedItem;
                var ClienteEliminado = Contexto.clientes.FirstOrDefault(o => o.id_cliente == ClienteSeleccionado.id_cliente);
                if (ClienteEliminado != null)
                {
                    ClienteEliminado.estatus = "B";
                    ClienteEliminado.id_usuario_ultima_modificacion = (int)DatosDeApp.usuario_en_turno.id_usuario;
                    ClienteEliminado.fecha_ultima_modificacion = getFechaServer();

                    Contexto.SaveChanges();
                    MessageBox.Show("¡¡¡ El cliente con éxito !!!", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Contexto.Dispose();
                InicializarEliminar();
            }
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClientesExternos.Entity;
using ClientesExternos.Modelos;

namespace ClientesExternos.GUIs.UserControls
{
    public partial class Frm_Usuarios : UserControl
    {
        private TiposDeAccion tipoAccion;
        private string entityString = Properties.Settings.Default.EntityString;
 
        public Frm_Usuarios()
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

            if (sb.ToString().ToUpper().Contains("UNIQUE"))
            {
                MessageBox.Show("El nombre de usuario ya fue utilizado anteriormente, utilice otro nombre por favor... ", exType, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(sb.ToString(), exType, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarUsuarios()
        {
            try
            {
                var Contexto = new ClientextEntities(entityString);
                var lstUsuarios = Contexto.usuarios.ToList();
                lstUsuarios = lstUsuarios.FindAll(o => o.estatus == "A");
                lstUsuarios = lstUsuarios.FindAll(o => o.nombre_usuario != "SYSDBA").OrderBy(o => o.nombre_usuario).ToList();
                lstUsuarios = lstUsuarios.FindAll(o => o.id_usuario != DatosDeApp.usuario_en_turno.id_usuario);
                lstbUsuarios.DataSource = null;
                lstbUsuarios.DataSource = lstUsuarios;
                lstbUsuarios.DisplayMember = "nombre_usuario";
                Contexto.Dispose();
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            InicializarNuevo();
        }
        private void InicializarNuevo()
        {
            tipoAccion = TiposDeAccion.Nuevo;
            lblAccion.Text = "Nuevo Usuario";
            pnlControles.Visible = true;
            btnGuardar.Visible = true;
            btnEliminarAplicar.Visible = false;                        
            CargarUsuarios();

            txbNombreUsuario.Text = string.Empty;
            txbNombreCompleto.Text = string.Empty; 
            txbContraseña1.Text = string.Empty;
            txbContraseña2.Text = string.Empty;
            chbAdmin.Checked = false;
            chbOperador.Checked = false;
            lstbUsuarios.Enabled = false;

            txbNombreUsuario.ReadOnly = false;
            txbNombreCompleto.ReadOnly = false;
            txbContraseña1.ReadOnly = false;
            txbContraseña2.ReadOnly = false;
            chbAdmin.Enabled = true;
            chbOperador.Enabled = true;

            btnGuardar.Visible = true;
            btnEliminarAplicar.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
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
                    ModificarUsuario();
                    break;
            }
        }
        private void GuardarNuevo()
        {
            if (Validar() == true)
            {
                ClientextEntities Contexto = new ClientextEntities(entityString);
                Contexto.Connection.Open();
                var Transaccion = Contexto.Connection.BeginTransaction();
                try
                {
                    var nuevo_usuario = new usuarios();
                    nuevo_usuario.nombre_usuario = txbNombreUsuario.Text.Trim().ToUpper();
                    nuevo_usuario.nombre_completo = txbNombreCompleto.Text.Trim().ToUpper();
                    nuevo_usuario.contrasenia = txbContraseña1.Text.Trim().ToUpper();
                    if (chbAdmin.Checked == true)
                        nuevo_usuario.permisos = "*";
                    if (chbOperador.Checked == true)
                        nuevo_usuario.permisos = "+";
                    nuevo_usuario.estatus = "A";

                    Contexto.usuarios.AddObject(nuevo_usuario);
                    Contexto.SaveChanges();
                    Transaccion.Commit();

                    MessageBox.Show("¡¡¡Nuevo usuario agregado con exito!!!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InicializarNuevo();
                }
                catch (Exception ex)
                {
                    Transaccion.Rollback();
                    MostrarExcepcion(ex);
                }

                if (Contexto.Connection.State != ConnectionState.Closed)
                    Contexto.Connection.Close();
            }
        }
        private bool Validar()
        {
            if (txbNombreUsuario.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe asignar un nombre de usuario...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txbNombreCompleto.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe capturar el nombre completo del usuario...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txbContraseña1.Text.Trim().Length < 5)
            {
                MessageBox.Show("Debe asignarle una contraseña al usuario de al menos 5 caracteres...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txbContraseña1.Text.Trim().ToUpper() != txbContraseña2.Text.Trim().ToUpper())
            {
                MessageBox.Show("La contraseña no coincide...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (chbAdmin.Checked == false && chbOperador.Checked == false)
            {
                MessageBox.Show("Debe seleccionar un tipo de permiso...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var sb = new StringBuilder();
            sb.AppendLine("¿Son datos correctos?");
            sb.AppendLine("Usuario:  " + txbNombreUsuario.Text.ToUpper().Trim());
            sb.AppendLine("Nombre Completo:  " + txbNombreCompleto.Text.ToUpper().Trim());
            if (chbAdmin.Checked == true)
            {
                sb.AppendLine("Privilegios:  ADMINISTRADOR");
            }
            else
            {
                sb.AppendLine("Privilegios:  OPERADOR");
            }


            var dr = MessageBox.Show(sb.ToString(),"Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return false;
            }

            return true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            InicializarModificar();
        }
        private void InicializarModificar()
        {
            InicializarNuevo();
            if (lstbUsuarios.Items.Count == 0)
            {
                MessageBox.Show("No hay usuarios en el sistema...", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pnlControles.Visible = false;
            }
            else
            {
                var usuario = (usuarios)lstbUsuarios.SelectedItem;
                txbNombreUsuario.Text = usuario.nombre_usuario;
                txbNombreCompleto.Text = usuario.nombre_completo;
                txbContraseña1.Text = usuario.contrasenia;
                txbContraseña2.Text = usuario.contrasenia;
                if (usuario.permisos == "*")
                    chbAdmin.Checked = true;
                else
                    chbOperador.Checked = true;
            }

            lstbUsuarios.Enabled = true;
            tipoAccion = TiposDeAccion.Modificar;
        }
        private void ModificarUsuario()
        {
            if (Validar() == true)
            {
                ClientextEntities Contexto = new ClientextEntities(entityString);
                Contexto.Connection.Open();
                var Transaccion = Contexto.Connection.BeginTransaction();
                try
                {
                    var user = (usuarios)lstbUsuarios.SelectedItem;
                    var usuario = Contexto.usuarios.FirstOrDefault(o => o.id_usuario == user.id_usuario);

                    usuario.nombre_usuario = txbNombreUsuario.Text.Trim().ToUpper();
                    usuario.nombre_completo = txbNombreCompleto.Text.Trim().ToUpper();
                    usuario.contrasenia = txbContraseña1.Text.Trim().ToUpper();
                    if (chbAdmin.Checked == true)
                        usuario.permisos = "*";
                    if (chbOperador.Checked == true)
                        usuario.permisos = "+";
                    usuario.estatus = "A";

                    Contexto.SaveChanges();
                    Transaccion.Commit();

                    MessageBox.Show("¡¡¡El usuario se ha modificado con exito!!!", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InicializarModificar();
                }
                catch (Exception ex)
                {
                    Transaccion.Rollback();
                    MostrarExcepcion(ex);
                }

                if (Contexto.Connection.State != ConnectionState.Closed)
                    Contexto.Connection.Close();
            }
        }

        private void lstbUsuarios_Click(object sender, EventArgs e)
        {
            var usuario = (usuarios)lstbUsuarios.SelectedItem;
            txbNombreUsuario.Text = usuario.nombre_usuario;
            txbNombreCompleto.Text = usuario.nombre_completo;
            txbContraseña1.Text = usuario.contrasenia;
            txbContraseña2.Text = usuario.contrasenia;
            if (usuario.permisos == "*")
                chbAdmin.Checked = true;
            else
                chbOperador.Checked = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            InicializarEliminar();
        }
        private void InicializarEliminar()
        {
            InicializarNuevo();

            if (lstbUsuarios.Items.Count == 0)
            {
                MessageBox.Show("No hay usuarios en el sistema...", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pnlControles.Visible = false;
            }
            else
            {
                var usuario = (usuarios)lstbUsuarios.SelectedItem;
                txbNombreUsuario.Text = usuario.nombre_usuario;
                txbNombreCompleto.Text = usuario.nombre_completo;
                txbContraseña1.Text = usuario.contrasenia;
                txbContraseña2.Text = usuario.contrasenia;
                if (usuario.permisos == "*")
                    chbAdmin.Checked = true;
                else
                    chbOperador.Checked = true;
            }

            lstbUsuarios.Enabled = true;
            txbNombreUsuario.ReadOnly = true;
            txbNombreCompleto.ReadOnly = true;
            txbContraseña1.ReadOnly = true;
            txbContraseña2.ReadOnly = true;
            chbAdmin.Enabled = false;
            chbOperador.Enabled = false;

            btnGuardar.Visible = false;
            btnEliminarAplicar.Location = btnGuardar.Location;
            btnEliminarAplicar.Visible = true;
        }
        private void btnEliminarAplicar_Click(object sender, EventArgs e)
        {
            EliminarUsuario();
        }
        private void EliminarUsuario()
        {
            if (ValidarEliminar() == true)
            {
                ClientextEntities Contexto = new ClientextEntities(entityString);
                Contexto.Connection.Open();
                var Transaccion = Contexto.Connection.BeginTransaction();
                try
                {
                    var user = (usuarios)lstbUsuarios.SelectedItem;
                    var usuario = Contexto.usuarios.FirstOrDefault(o => o.id_usuario == user.id_usuario);

                    usuario.estatus = "B";

                    Contexto.SaveChanges();
                    Transaccion.Commit();

                    MessageBox.Show("El usuario ha sido eliminado correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InicializarEliminar();
                }
                catch (Exception ex)
                {
                    Transaccion.Rollback();
                    MostrarExcepcion(ex);
                }

                if (Contexto.Connection.State != ConnectionState.Closed)
                    Contexto.Connection.Close();
            }
        }
        private bool ValidarEliminar()
        {
            var sb = new StringBuilder();
            sb.AppendLine("¿Realmente desea eliminar este usuario?");
            sb.AppendLine("Usuario:  " + txbNombreUsuario.Text.ToUpper().Trim());
            sb.AppendLine("Nombre Completo:  " + txbNombreCompleto.Text.ToUpper().Trim());
            if (chbAdmin.Checked == true)
            {
                sb.AppendLine("Privilegios:  ADMINISTRADOR");
            }
            else
            {
                sb.AppendLine("Privilegios:  OPERADOR");
            }


            var dr = MessageBox.Show(sb.ToString(), "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return false;
            }

            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClientesExternos.Entity;
using ClientesExternos.Modelos;

namespace ClientesExternos.GUIs
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            new Frm_Configuracion().ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                IniciarSesion();
            }
            catch(Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }
        private void IniciarSesion()
        {
            var username = txbUsuario.Text.Trim().ToUpper();
            var password = txbContrasenia.Text.Trim().ToUpper();

            var entityString = Properties.Settings.Default.EntityString;
            ClientextEntities Contexto = new ClientextEntities(entityString);
            var user = Contexto.usuarios.FirstOrDefault(o => o.nombre_usuario == username && o.contrasenia == password && o.estatus == "A");
            if (user != null)
            {
                DatosDeApp.usuario_en_turno = user;

                this.Hide();
                new Frm_Principal().ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error en nombre de usuario o contraseña...", "Iniciar Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Contexto.Dispose();
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

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }
    }
}

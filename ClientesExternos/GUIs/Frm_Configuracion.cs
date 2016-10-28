using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClientesExternos.GUIs
{
    public partial class Frm_Configuracion : Form
    {
        public Frm_Configuracion()
        {
            InitializeComponent();
        }

        private void Frm_Configuracion_Load(object sender, EventArgs e)
        {
            IniciarControles();
        }
        private void IniciarControles()
        {
            var Config = Properties.Settings.Default;
            txbServer.Text = Config.Server;
            txbUser.Text = Config.User;
            txbPassword.Text = Config.Pass;
            txbPort.Text = Config.Port;
        }

        private void txbPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("¿Son datos correctos?", "Guardar",  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                Guardar();
        }
        private void Guardar()
        {
            try
            {
                if (cmbDatabase.Items.Count > 0)
                {
                    var StringConn =
                    @"metadata=res://*/Entity.ModeloClientesExternos.csdl|
                           res://*/Entity.ModeloClientesExternos.ssdl|
                           res://*/Entity.ModeloClientesExternos.msl;
                  provider=MySql.Data.MySqlClient;
                  provider connection string='server={{servidor}};
                                             user id={{user}};
                                            password={{pass}};
                                                port={{port}};
                                            database={{db}};
                               Convert Zero Datetime=True;'";
                    string NewStringConn;
                    NewStringConn = StringConn.Replace("{{servidor}}", txbServer.Text);
                    NewStringConn = NewStringConn.Replace("{{user}}", txbUser.Text);
                    NewStringConn = NewStringConn.Replace("{{pass}}", txbPassword.Text);
                    NewStringConn = NewStringConn.Replace("{{port}}", txbPort.Text);
                    NewStringConn = NewStringConn.Replace("{{db}}", Convert.ToString(cmbDatabase.SelectedItem));

                    var Config = Properties.Settings.Default;
                    Config.Server = txbServer.Text;
                    Config.User = txbUser.Text;
                    Config.Pass = txbPassword.Text;
                    Config.Port = txbPort.Text;
                    Config.Database = Convert.ToString(cmbDatabase.SelectedItem);
                    Config.EntityString = NewStringConn;

                    Config.Save();

                    MessageBox.Show("La configuración se ha guardado con éxito", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Aun no se han cargado las bases de datos...", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }

        private void CargarDb()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = txbServer.Text;
            sb.UserID = txbUser.Text;
            sb.Password = txbPassword.Text;
            sb.Port = Convert.ToUInt32(txbPort.Text);

            MySqlConnection myConn = new MySqlConnection(sb.ToString());
            try
            {
                myConn.Open();
                MySqlCommand myComm = new MySqlCommand("Show Databases", myConn);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(myComm);
                DataTable dtResultado = new DataTable();
                myAdapter.Fill(dtResultado);
                foreach (DataRow row in dtResultado.Rows)
                {
                    cmbDatabase.Items.Add(row[0]);
                }
                if (cmbDatabase.Items.Count != 0)
                    cmbDatabase.SelectedIndex = 0;
                myConn.Close();
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
                if (myConn.State != ConnectionState.Closed)
                    myConn.Close();
            }
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

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDb();
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

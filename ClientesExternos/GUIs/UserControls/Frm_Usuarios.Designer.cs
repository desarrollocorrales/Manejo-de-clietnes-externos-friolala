namespace ClientesExternos.GUIs.UserControls
{
    partial class Frm_Usuarios
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Usuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstbUsuarios = new System.Windows.Forms.ListBox();
            this.lblAccion = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminarAplicar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txbNombreCompleto = new System.Windows.Forms.TextBox();
            this.txbNombreUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txbContraseña1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbContraseña2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.chbAdmin = new System.Windows.Forms.RadioButton();
            this.chbOperador = new System.Windows.Forms.RadioButton();
            this.pnlControles.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(900, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuarios de la aplicación";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(900, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "FRIOLALA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(505, 66);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 36);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModificar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(397, 66);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(102, 36);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNuevo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(305, 66);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(85, 36);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // pnlControles
            // 
            this.pnlControles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControles.Controls.Add(this.groupBox1);
            this.pnlControles.Controls.Add(this.lblAccion);
            this.pnlControles.Controls.Add(this.groupBox2);
            this.pnlControles.Location = new System.Drawing.Point(5, 110);
            this.pnlControles.Margin = new System.Windows.Forms.Padding(4);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(891, 386);
            this.pnlControles.TabIndex = 21;
            this.pnlControles.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lstbUsuarios);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 348);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuarios:";
            // 
            // lstbUsuarios
            // 
            this.lstbUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbUsuarios.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbUsuarios.FormattingEnabled = true;
            this.lstbUsuarios.ItemHeight = 18;
            this.lstbUsuarios.Location = new System.Drawing.Point(3, 22);
            this.lstbUsuarios.Name = "lstbUsuarios";
            this.lstbUsuarios.Size = new System.Drawing.Size(274, 323);
            this.lstbUsuarios.TabIndex = 9;
            this.lstbUsuarios.Click += new System.EventHandler(this.lstbUsuarios_Click);
            // 
            // lblAccion
            // 
            this.lblAccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccion.Location = new System.Drawing.Point(4, 0);
            this.lblAccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(881, 30);
            this.lblAccion.TabIndex = 6;
            this.lblAccion.Text = "Nuevo Usuario";
            this.lblAccion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txbContraseña2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txbContraseña1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnEliminarAplicar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txbNombreCompleto);
            this.groupBox2.Controls.Add(this.txbNombreUsuario);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Location = new System.Drawing.Point(294, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 345);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // btnEliminarAplicar
            // 
            this.btnEliminarAplicar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminarAplicar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAplicar.Image = global::ClientesExternos.Properties.Resources.eliminar_26;
            this.btnEliminarAplicar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarAplicar.Location = new System.Drawing.Point(191, 286);
            this.btnEliminarAplicar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarAplicar.Name = "btnEliminarAplicar";
            this.btnEliminarAplicar.Size = new System.Drawing.Size(100, 36);
            this.btnEliminarAplicar.TabIndex = 18;
            this.btnEliminarAplicar.Text = "Eliminar";
            this.btnEliminarAplicar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarAplicar.UseVisualStyleBackColor = true;
            this.btnEliminarAplicar.Visible = false;
            this.btnEliminarAplicar.Click += new System.EventHandler(this.btnEliminarAplicar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre completo:";
            // 
            // txbNombreCompleto
            // 
            this.txbNombreCompleto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNombreCompleto.Location = new System.Drawing.Point(178, 57);
            this.txbNombreCompleto.MaxLength = 255;
            this.txbNombreCompleto.MinimumSize = new System.Drawing.Size(150, 26);
            this.txbNombreCompleto.Name = "txbNombreCompleto";
            this.txbNombreCompleto.Size = new System.Drawing.Size(400, 26);
            this.txbNombreCompleto.TabIndex = 11;
            // 
            // txbNombreUsuario
            // 
            this.txbNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNombreUsuario.Location = new System.Drawing.Point(178, 25);
            this.txbNombreUsuario.MaximumSize = new System.Drawing.Size(300, 26);
            this.txbNombreUsuario.MaxLength = 20;
            this.txbNombreUsuario.MinimumSize = new System.Drawing.Size(100, 26);
            this.txbNombreUsuario.Name = "txbNombreUsuario";
            this.txbNombreUsuario.Size = new System.Drawing.Size(160, 26);
            this.txbNombreUsuario.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre de usuario:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(191, 242);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 36);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(299, 242);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 36);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txbContraseña1
            // 
            this.txbContraseña1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbContraseña1.Location = new System.Drawing.Point(178, 89);
            this.txbContraseña1.MaximumSize = new System.Drawing.Size(300, 26);
            this.txbContraseña1.MaxLength = 20;
            this.txbContraseña1.MinimumSize = new System.Drawing.Size(100, 26);
            this.txbContraseña1.Name = "txbContraseña1";
            this.txbContraseña1.PasswordChar = '*';
            this.txbContraseña1.Size = new System.Drawing.Size(160, 26);
            this.txbContraseña1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Contraseña:";
            // 
            // txbContraseña2
            // 
            this.txbContraseña2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbContraseña2.Location = new System.Drawing.Point(178, 121);
            this.txbContraseña2.MaximumSize = new System.Drawing.Size(300, 26);
            this.txbContraseña2.MaxLength = 20;
            this.txbContraseña2.MinimumSize = new System.Drawing.Size(100, 26);
            this.txbContraseña2.Name = "txbContraseña2";
            this.txbContraseña2.PasswordChar = '*';
            this.txbContraseña2.Size = new System.Drawing.Size(160, 26);
            this.txbContraseña2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 124);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Repetir contraseña:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.chbOperador);
            this.groupBox3.Controls.Add(this.chbAdmin);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(195, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 82);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Permisos:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(847, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 30);
            this.btnCerrar.TabIndex = 19;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // chbAdmin
            // 
            this.chbAdmin.AutoSize = true;
            this.chbAdmin.Location = new System.Drawing.Point(19, 25);
            this.chbAdmin.Name = "chbAdmin";
            this.chbAdmin.Size = new System.Drawing.Size(115, 22);
            this.chbAdmin.TabIndex = 14;
            this.chbAdmin.TabStop = true;
            this.chbAdmin.Text = "Administrador";
            this.chbAdmin.UseVisualStyleBackColor = true;
            // 
            // chbOperador
            // 
            this.chbOperador.AutoSize = true;
            this.chbOperador.Location = new System.Drawing.Point(19, 53);
            this.chbOperador.Name = "chbOperador";
            this.chbOperador.Size = new System.Drawing.Size(85, 22);
            this.chbOperador.TabIndex = 15;
            this.chbOperador.TabStop = true;
            this.chbOperador.Text = "Operador";
            this.chbOperador.UseVisualStyleBackColor = true;
            // 
            // Frm_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pnlControles);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Usuarios";
            this.Size = new System.Drawing.Size(900, 500);
            this.pnlControles.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstbUsuarios;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminarAplicar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbNombreCompleto;
        private System.Windows.Forms.TextBox txbNombreUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txbContraseña2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbContraseña1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.RadioButton chbOperador;
        private System.Windows.Forms.RadioButton chbAdmin;
    }
}

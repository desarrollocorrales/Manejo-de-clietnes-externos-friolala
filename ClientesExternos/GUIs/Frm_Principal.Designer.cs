﻿namespace ClientesExternos.GUIs
{
    partial class Frm_Principal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.NavBar = new DevExpress.XtraNavBar.NavBarControl();
            this.nbMenu = new DevExpress.XtraNavBar.NavBarGroup();
            this.itmArticulos = new DevExpress.XtraNavBar.NavBarItem();
            this.itmClientes = new DevExpress.XtraNavBar.NavBarItem();
            this.itmEntradas = new DevExpress.XtraNavBar.NavBarItem();
            this.itmSalidas = new DevExpress.XtraNavBar.NavBarItem();
            this.itmUsuarios = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.NavBar)).BeginInit();
            this.SuspendLayout();
            // 
            // NavBar
            // 
            this.NavBar.ActiveGroup = this.nbMenu;
            this.NavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavBar.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nbMenu});
            this.NavBar.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.itmArticulos,
            this.itmClientes,
            this.itmEntradas,
            this.itmSalidas,
            this.itmUsuarios});
            this.NavBar.Location = new System.Drawing.Point(0, 0);
            this.NavBar.Name = "NavBar";
            this.NavBar.OptionsNavPane.ExpandedWidth = 215;
            this.NavBar.Size = new System.Drawing.Size(215, 561);
            this.NavBar.TabIndex = 4;
            this.NavBar.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("Caramel");
            // 
            // nbMenu
            // 
            this.nbMenu.Caption = "Menú";
            this.nbMenu.Expanded = true;
            this.nbMenu.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.itmArticulos),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itmClientes),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itmEntradas),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itmSalidas),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itmUsuarios)});
            this.nbMenu.Name = "nbMenu";
            // 
            // itmArticulos
            // 
            this.itmArticulos.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itmArticulos.Appearance.Options.UseFont = true;
            this.itmArticulos.Caption = "Articulos";
            this.itmArticulos.Name = "itmArticulos";
            this.itmArticulos.SmallImage = global::ClientesExternos.Properties.Resources.meat_26;
            this.itmArticulos.Tag = "ARTICULOS";
            this.itmArticulos.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.itmArticulos_LinkPressed);
            // 
            // itmClientes
            // 
            this.itmClientes.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itmClientes.Appearance.Options.UseFont = true;
            this.itmClientes.Caption = "Clientes";
            this.itmClientes.Name = "itmClientes";
            this.itmClientes.SmallImage = global::ClientesExternos.Properties.Resources.client_26;
            this.itmClientes.Tag = "CLIENTES";
            this.itmClientes.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.itmClientes_LinkClicked);
            // 
            // itmEntradas
            // 
            this.itmEntradas.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itmEntradas.Appearance.Options.UseFont = true;
            this.itmEntradas.Caption = "Entradas de mercancía";
            this.itmEntradas.Name = "itmEntradas";
            this.itmEntradas.SmallImage = global::ClientesExternos.Properties.Resources.forklift;
            this.itmEntradas.Tag = "ENTRADAS";
            this.itmEntradas.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.itmEntradas_LinkClicked);
            // 
            // itmSalidas
            // 
            this.itmSalidas.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itmSalidas.Appearance.Options.UseFont = true;
            this.itmSalidas.Caption = "Salidas de mercancía";
            this.itmSalidas.Name = "itmSalidas";
            this.itmSalidas.SmallImage = global::ClientesExternos.Properties.Resources.truck;
            this.itmSalidas.Tag = "SALIDAS";
            // 
            // itmUsuarios
            // 
            this.itmUsuarios.Appearance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itmUsuarios.Appearance.Options.UseFont = true;
            this.itmUsuarios.Caption = "Usuarios";
            this.itmUsuarios.Name = "itmUsuarios";
            this.itmUsuarios.SmallImage = global::ClientesExternos.Properties.Resources.user_26;
            this.itmUsuarios.Tag = "USUARIOS";
            this.itmUsuarios.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.itmUsuarios_LinkClicked);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.NavBar);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control De Clientes Externos";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NavBar)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private DevExpress.XtraNavBar.NavBarControl NavBar;
        private DevExpress.XtraNavBar.NavBarGroup nbMenu;
        private DevExpress.XtraNavBar.NavBarItem itmArticulos;
        private DevExpress.XtraNavBar.NavBarItem itmClientes;
        private DevExpress.XtraNavBar.NavBarItem itmEntradas;
        private DevExpress.XtraNavBar.NavBarItem itmSalidas;
        private DevExpress.XtraNavBar.NavBarItem itmUsuarios;

    }
}



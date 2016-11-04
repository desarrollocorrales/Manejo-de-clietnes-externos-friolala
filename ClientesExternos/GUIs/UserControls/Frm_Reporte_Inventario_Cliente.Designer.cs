namespace ClientesExternos.GUIs.UserControls
{
    partial class Frm_Reporte_Inventario_Cliente
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gridInvCliente = new DevExpress.XtraGrid.GridControl();
            this.inventarioClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvInvCliente = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnumero_etiqueta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltarima_cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcajas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_articulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridInvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(900, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inventario por Cliente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(900, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "FRIOLALA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gridInvCliente
            // 
            this.gridInvCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridInvCliente.DataSource = this.inventarioClienteBindingSource;
            this.gridInvCliente.Location = new System.Drawing.Point(3, 107);
            this.gridInvCliente.MainView = this.gvInvCliente;
            this.gridInvCliente.Name = "gridInvCliente";
            this.gridInvCliente.Size = new System.Drawing.Size(894, 349);
            this.gridInvCliente.TabIndex = 10;
            this.gridInvCliente.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInvCliente});
            // 
            // inventarioClienteBindingSource
            // 
            this.inventarioClienteBindingSource.DataSource = typeof(ClientesExternos.Modelos.InventarioCliente);
            // 
            // gvInvCliente
            // 
            this.gvInvCliente.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvInvCliente.Appearance.FooterPanel.Options.UseFont = true;
            this.gvInvCliente.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvInvCliente.Appearance.GroupFooter.Options.UseFont = true;
            this.gvInvCliente.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnumero_etiqueta,
            this.coltarima_cliente,
            this.colcajas,
            this.colpeso,
            this.colunidad,
            this.colcodigo_articulo});
            this.gvInvCliente.GridControl = this.gridInvCliente;
            this.gvInvCliente.GroupCount = 1;
            this.gvInvCliente.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cajas", this.colcajas, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "peso", this.colpeso, "{0:#,0.00}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "numero_etiqueta", this.colnumero_etiqueta, "")});
            this.gvInvCliente.Name = "gvInvCliente";
            this.gvInvCliente.OptionsBehavior.Editable = false;
            this.gvInvCliente.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colcodigo_articulo, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvInvCliente.EndGrouping += new System.EventHandler(this.gvInvCliente_EndGrouping);
            // 
            // colnumero_etiqueta
            // 
            this.colnumero_etiqueta.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colnumero_etiqueta.AppearanceCell.Options.UseFont = true;
            this.colnumero_etiqueta.AppearanceCell.Options.UseTextOptions = true;
            this.colnumero_etiqueta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnumero_etiqueta.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colnumero_etiqueta.AppearanceHeader.Options.UseFont = true;
            this.colnumero_etiqueta.AppearanceHeader.Options.UseTextOptions = true;
            this.colnumero_etiqueta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnumero_etiqueta.Caption = "Etiqueta";
            this.colnumero_etiqueta.FieldName = "numero_etiqueta";
            this.colnumero_etiqueta.Name = "colnumero_etiqueta";
            this.colnumero_etiqueta.Visible = true;
            this.colnumero_etiqueta.VisibleIndex = 1;
            // 
            // coltarima_cliente
            // 
            this.coltarima_cliente.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coltarima_cliente.AppearanceCell.Options.UseFont = true;
            this.coltarima_cliente.AppearanceCell.Options.UseTextOptions = true;
            this.coltarima_cliente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltarima_cliente.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coltarima_cliente.AppearanceHeader.Options.UseFont = true;
            this.coltarima_cliente.AppearanceHeader.Options.UseTextOptions = true;
            this.coltarima_cliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltarima_cliente.Caption = "Tarima Cliente";
            this.coltarima_cliente.FieldName = "tarima_cliente";
            this.coltarima_cliente.Name = "coltarima_cliente";
            this.coltarima_cliente.Visible = true;
            this.coltarima_cliente.VisibleIndex = 0;
            // 
            // colcajas
            // 
            this.colcajas.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcajas.AppearanceCell.Options.UseFont = true;
            this.colcajas.AppearanceCell.Options.UseTextOptions = true;
            this.colcajas.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colcajas.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcajas.AppearanceHeader.Options.UseFont = true;
            this.colcajas.AppearanceHeader.Options.UseTextOptions = true;
            this.colcajas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colcajas.Caption = "Cajas";
            this.colcajas.FieldName = "cajas";
            this.colcajas.Name = "colcajas";
            this.colcajas.Visible = true;
            this.colcajas.VisibleIndex = 2;
            // 
            // colpeso
            // 
            this.colpeso.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colpeso.AppearanceCell.Options.UseFont = true;
            this.colpeso.AppearanceCell.Options.UseTextOptions = true;
            this.colpeso.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colpeso.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colpeso.AppearanceHeader.Options.UseFont = true;
            this.colpeso.AppearanceHeader.Options.UseTextOptions = true;
            this.colpeso.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colpeso.Caption = "Peso";
            this.colpeso.DisplayFormat.FormatString = "n";
            this.colpeso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpeso.FieldName = "peso";
            this.colpeso.Name = "colpeso";
            this.colpeso.Visible = true;
            this.colpeso.VisibleIndex = 3;
            // 
            // colunidad
            // 
            this.colunidad.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colunidad.AppearanceCell.Options.UseFont = true;
            this.colunidad.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colunidad.AppearanceHeader.Options.UseFont = true;
            this.colunidad.Caption = "Unidad";
            this.colunidad.FieldName = "unidad";
            this.colunidad.Name = "colunidad";
            this.colunidad.Visible = true;
            this.colunidad.VisibleIndex = 4;
            // 
            // colcodigo_articulo
            // 
            this.colcodigo_articulo.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcodigo_articulo.AppearanceCell.Options.UseFont = true;
            this.colcodigo_articulo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcodigo_articulo.AppearanceHeader.Options.UseFont = true;
            this.colcodigo_articulo.Caption = "Artículo";
            this.colcodigo_articulo.FieldName = "codigo_articulo";
            this.colcodigo_articulo.Name = "colcodigo_articulo";
            this.colcodigo_articulo.Visible = true;
            this.colcodigo_articulo.VisibleIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cliente:";
            // 
            // cmbClientes
            // 
            this.cmbClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(130, 71);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(598, 26);
            this.cmbClientes.TabIndex = 12;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConsultar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Image = global::ClientesExternos.Properties.Resources.search_26;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(734, 66);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 35);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImprimir.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = global::ClientesExternos.Properties.Resources.printericon_26;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(400, 462);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 35);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // Frm_Reporte_Inventario_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridInvCliente);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.Name = "Frm_Reporte_Inventario_Cliente";
            this.Size = new System.Drawing.Size(900, 500);
            this.Load += new System.EventHandler(this.Frm_Reporte_Inventario_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridInvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCerrar;
        private DevExpress.XtraGrid.GridControl gridInvCliente;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInvCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.BindingSource inventarioClienteBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_etiqueta;
        private DevExpress.XtraGrid.Columns.GridColumn coltarima_cliente;
        private DevExpress.XtraGrid.Columns.GridColumn colcajas;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso;
        private DevExpress.XtraGrid.Columns.GridColumn colunidad;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_articulo;
    }
}

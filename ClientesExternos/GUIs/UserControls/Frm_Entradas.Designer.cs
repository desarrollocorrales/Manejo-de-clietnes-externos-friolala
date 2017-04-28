namespace ClientesExternos.GUIs.UserControls
{
    partial class Frm_Entradas
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.cmbArticulos = new System.Windows.Forms.ComboBox();
            this.txbNumCajas = new System.Windows.Forms.TextBox();
            this.txbPeso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gridTarimas = new DevExpress.XtraGrid.GridControl();
            this.tarimasentradasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvTarimas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colarticulos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_cajas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_ingreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_tarima_cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtpFechaRecepcion = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbNumTarimaCliente = new System.Windows.Forms.TextBox();
            this.txbFecha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridTarimas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarimasentradasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTarimas)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(900, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "Entradas de Mercancía";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(900, 33);
            this.label2.TabIndex = 18;
            this.label2.Text = "FRIOLALA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Artículo:";
            // 
            // cmbClientes
            // 
            this.cmbClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(161, 66);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(581, 26);
            this.cmbClientes.TabIndex = 22;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            // 
            // cmbArticulos
            // 
            this.cmbArticulos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbArticulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArticulos.FormattingEnabled = true;
            this.cmbArticulos.Location = new System.Drawing.Point(161, 101);
            this.cmbArticulos.Name = "cmbArticulos";
            this.cmbArticulos.Size = new System.Drawing.Size(581, 26);
            this.cmbArticulos.TabIndex = 23;
            // 
            // txbNumCajas
            // 
            this.txbNumCajas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbNumCajas.Location = new System.Drawing.Point(161, 133);
            this.txbNumCajas.MaxLength = 3;
            this.txbNumCajas.Name = "txbNumCajas";
            this.txbNumCajas.Size = new System.Drawing.Size(121, 26);
            this.txbNumCajas.TabIndex = 24;
            this.txbNumCajas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNumCajas_KeyPress);
            // 
            // txbPeso
            // 
            this.txbPeso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbPeso.Location = new System.Drawing.Point(336, 133);
            this.txbPeso.MaxLength = 8;
            this.txbPeso.Name = "txbPeso";
            this.txbPeso.Size = new System.Drawing.Size(121, 26);
            this.txbPeso.TabIndex = 25;
            this.txbPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPeso_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Cantidad de Cajas:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "Peso:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(463, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 18);
            this.label8.TabIndex = 30;
            this.label8.Text = "Fecha de Recepción:";
            // 
            // gridTarimas
            // 
            this.gridTarimas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTarimas.DataSource = this.tarimasentradasBindingSource;
            this.gridTarimas.Location = new System.Drawing.Point(161, 201);
            this.gridTarimas.MainView = this.gvTarimas;
            this.gridTarimas.Name = "gridTarimas";
            this.gridTarimas.Size = new System.Drawing.Size(581, 255);
            this.gridTarimas.TabIndex = 31;
            this.gridTarimas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTarimas});
            // 
            // tarimasentradasBindingSource
            // 
            this.tarimasentradasBindingSource.DataSource = typeof(ClientesExternos.Entity.tarimas_entradas);
            // 
            // gvTarimas
            // 
            this.gvTarimas.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTarimas.Appearance.FooterPanel.Options.UseFont = true;
            this.gvTarimas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colarticulos,
            this.colnum_cajas,
            this.colpeso,
            this.colfecha_ingreso,
            this.colnumero_tarima_cliente});
            this.gvTarimas.GridControl = this.gridTarimas;
            this.gvTarimas.Name = "gvTarimas";
            this.gvTarimas.OptionsBehavior.Editable = false;
            this.gvTarimas.OptionsView.ShowFooter = true;
            this.gvTarimas.OptionsView.ShowGroupPanel = false;
            this.gvTarimas.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colfecha_ingreso, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colarticulos
            // 
            this.colarticulos.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colarticulos.AppearanceCell.Options.UseFont = true;
            this.colarticulos.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colarticulos.AppearanceHeader.Options.UseFont = true;
            this.colarticulos.Caption = "Artículo";
            this.colarticulos.FieldName = "articulos.nombre";
            this.colarticulos.Name = "colarticulos";
            this.colarticulos.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colarticulos.Visible = true;
            this.colarticulos.VisibleIndex = 1;
            // 
            // colnum_cajas
            // 
            this.colnum_cajas.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colnum_cajas.AppearanceCell.Options.UseFont = true;
            this.colnum_cajas.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colnum_cajas.AppearanceHeader.Options.UseFont = true;
            this.colnum_cajas.AppearanceHeader.Options.UseTextOptions = true;
            this.colnum_cajas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colnum_cajas.Caption = "Cajas";
            this.colnum_cajas.DisplayFormat.FormatString = "{0:0}";
            this.colnum_cajas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colnum_cajas.FieldName = "num_cajas";
            this.colnum_cajas.Name = "colnum_cajas";
            this.colnum_cajas.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colnum_cajas.Visible = true;
            this.colnum_cajas.VisibleIndex = 2;
            // 
            // colpeso
            // 
            this.colpeso.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colpeso.AppearanceCell.Options.UseFont = true;
            this.colpeso.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colpeso.AppearanceHeader.Options.UseFont = true;
            this.colpeso.AppearanceHeader.Options.UseTextOptions = true;
            this.colpeso.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colpeso.Caption = "Peso";
            this.colpeso.DisplayFormat.FormatString = "n";
            this.colpeso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpeso.FieldName = "peso";
            this.colpeso.Name = "colpeso";
            this.colpeso.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "peso", "{0:#,0.00}")});
            this.colpeso.Visible = true;
            this.colpeso.VisibleIndex = 3;
            // 
            // colfecha_ingreso
            // 
            this.colfecha_ingreso.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colfecha_ingreso.AppearanceCell.Options.UseFont = true;
            this.colfecha_ingreso.AppearanceCell.Options.UseTextOptions = true;
            this.colfecha_ingreso.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colfecha_ingreso.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colfecha_ingreso.AppearanceHeader.Options.UseFont = true;
            this.colfecha_ingreso.AppearanceHeader.Options.UseTextOptions = true;
            this.colfecha_ingreso.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colfecha_ingreso.Caption = "Fecha Ingreso";
            this.colfecha_ingreso.DisplayFormat.FormatString = "dd/MMM/yyyy";
            this.colfecha_ingreso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_ingreso.FieldName = "fecha_ingreso";
            this.colfecha_ingreso.Name = "colfecha_ingreso";
            this.colfecha_ingreso.Visible = true;
            this.colfecha_ingreso.VisibleIndex = 0;
            // 
            // colnumero_tarima_cliente
            // 
            this.colnumero_tarima_cliente.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colnumero_tarima_cliente.AppearanceCell.Options.UseFont = true;
            this.colnumero_tarima_cliente.AppearanceCell.Options.UseTextOptions = true;
            this.colnumero_tarima_cliente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnumero_tarima_cliente.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colnumero_tarima_cliente.AppearanceHeader.Options.UseFont = true;
            this.colnumero_tarima_cliente.AppearanceHeader.Options.UseTextOptions = true;
            this.colnumero_tarima_cliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnumero_tarima_cliente.Caption = "Tarima Cliente";
            this.colnumero_tarima_cliente.FieldName = "numero_tarima_cliente";
            this.colnumero_tarima_cliente.Name = "colnumero_tarima_cliente";
            this.colnumero_tarima_cliente.Visible = true;
            this.colnumero_tarima_cliente.VisibleIndex = 4;
            // 
            // dtpFechaRecepcion
            // 
            this.dtpFechaRecepcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFechaRecepcion.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpFechaRecepcion.CustomFormat = "dd/MMM/yyyy";
            this.dtpFechaRecepcion.Enabled = false;
            this.dtpFechaRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaRecepcion.Location = new System.Drawing.Point(758, 471);
            this.dtpFechaRecepcion.Name = "dtpFechaRecepcion";
            this.dtpFechaRecepcion.Size = new System.Drawing.Size(139, 26);
            this.dtpFechaRecepcion.TabIndex = 32;
            this.dtpFechaRecepcion.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::ClientesExternos.Properties.Resources.add_26;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(748, 201);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 35);
            this.btnAgregar.TabIndex = 33;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::ClientesExternos.Properties.Resources.eliminar_26;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(748, 242);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 35);
            this.btnEliminar.TabIndex = 34;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnImprimir.TabIndex = 35;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(95, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 36;
            this.label7.Text = "Tarimas:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(266, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 18);
            this.label9.TabIndex = 38;
            this.label9.Text = "Numero de tarima del cliente:";
            // 
            // txbNumTarimaCliente
            // 
            this.txbNumTarimaCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbNumTarimaCliente.Location = new System.Drawing.Point(466, 165);
            this.txbNumTarimaCliente.MaxLength = 50;
            this.txbNumTarimaCliente.Name = "txbNumTarimaCliente";
            this.txbNumTarimaCliente.Size = new System.Drawing.Size(276, 26);
            this.txbNumTarimaCliente.TabIndex = 37;
            // 
            // txbFecha
            // 
            this.txbFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbFecha.BackColor = System.Drawing.Color.White;
            this.txbFecha.Location = new System.Drawing.Point(603, 133);
            this.txbFecha.Name = "txbFecha";
            this.txbFecha.ReadOnly = true;
            this.txbFecha.Size = new System.Drawing.Size(139, 26);
            this.txbFecha.TabIndex = 39;
            this.txbFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Frm_Entradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.txbFecha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbNumTarimaCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtpFechaRecepcion);
            this.Controls.Add(this.gridTarimas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbPeso);
            this.Controls.Add(this.txbNumCajas);
            this.Controls.Add(this.cmbArticulos);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Entradas";
            this.Size = new System.Drawing.Size(900, 500);
            this.Load += new System.EventHandler(this.Frm_Entradas_Load);
            this.VisibleChanged += new System.EventHandler(this.Frm_Entradas_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.gridTarimas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarimasentradasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTarimas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.ComboBox cmbArticulos;
        private System.Windows.Forms.TextBox txbNumCajas;
        private System.Windows.Forms.TextBox txbPeso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraGrid.GridControl gridTarimas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTarimas;
        private System.Windows.Forms.DateTimePicker dtpFechaRecepcion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource tarimasentradasBindingSource;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbNumTarimaCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colarticulos;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_cajas;
        private DevExpress.XtraGrid.Columns.GridColumn colpeso;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_ingreso;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_tarima_cliente;
        private System.Windows.Forms.TextBox txbFecha;
    }
}

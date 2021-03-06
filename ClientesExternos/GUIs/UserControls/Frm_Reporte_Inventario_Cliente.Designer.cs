﻿namespace ClientesExternos.GUIs.UserControls
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
            this.gvInvCliente.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvInvCliente.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvInvCliente.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvInvCliente.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvInvCliente.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvInvCliente.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvInvCliente.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvInvCliente.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvInvCliente.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvInvCliente.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvInvCliente.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvInvCliente.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvInvCliente.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvInvCliente.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvInvCliente.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvInvCliente.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvInvCliente.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvInvCliente.Appearance.Empty.Options.UseBackColor = true;
            this.gvInvCliente.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvInvCliente.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvInvCliente.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvInvCliente.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvInvCliente.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvInvCliente.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvInvCliente.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvInvCliente.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvInvCliente.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvInvCliente.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvInvCliente.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvInvCliente.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvInvCliente.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvInvCliente.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvInvCliente.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvInvCliente.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvInvCliente.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvInvCliente.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvInvCliente.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvInvCliente.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvInvCliente.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvInvCliente.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvInvCliente.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvInvCliente.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvInvCliente.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvInvCliente.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvInvCliente.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvInvCliente.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvInvCliente.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvInvCliente.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvInvCliente.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvInvCliente.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvInvCliente.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvInvCliente.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvInvCliente.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvInvCliente.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvInvCliente.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvInvCliente.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvInvCliente.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvInvCliente.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvInvCliente.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvInvCliente.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvInvCliente.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvInvCliente.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvInvCliente.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvInvCliente.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvInvCliente.Appearance.GroupFooter.Options.UseFont = true;
            this.gvInvCliente.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvInvCliente.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvInvCliente.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvInvCliente.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvInvCliente.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvInvCliente.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvInvCliente.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvInvCliente.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvInvCliente.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvInvCliente.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvInvCliente.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvInvCliente.Appearance.GroupRow.Options.UseFont = true;
            this.gvInvCliente.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvInvCliente.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvInvCliente.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvInvCliente.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvInvCliente.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvInvCliente.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvInvCliente.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvInvCliente.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvInvCliente.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvInvCliente.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvInvCliente.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvInvCliente.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvInvCliente.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvInvCliente.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvInvCliente.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvInvCliente.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvInvCliente.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvInvCliente.Appearance.OddRow.Options.UseBackColor = true;
            this.gvInvCliente.Appearance.OddRow.Options.UseForeColor = true;
            this.gvInvCliente.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvInvCliente.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvInvCliente.Appearance.Preview.Options.UseBackColor = true;
            this.gvInvCliente.Appearance.Preview.Options.UseForeColor = true;
            this.gvInvCliente.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvInvCliente.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvInvCliente.Appearance.Row.Options.UseBackColor = true;
            this.gvInvCliente.Appearance.Row.Options.UseForeColor = true;
            this.gvInvCliente.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvInvCliente.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvInvCliente.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvInvCliente.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvInvCliente.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvInvCliente.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvInvCliente.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvInvCliente.Appearance.VertLine.Options.UseBackColor = true;
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
            this.gvInvCliente.OptionsView.EnableAppearanceEvenRow = true;
            this.gvInvCliente.OptionsView.EnableAppearanceOddRow = true;
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

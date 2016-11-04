namespace ClientesExternos.GUIs.UserControls
{
    partial class Frm_EntradasPorDia
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
            this.label3 = new System.Windows.Forms.Label();
            this.gridEntradasDia = new DevExpress.XtraGrid.GridControl();
            this.entradasPorDiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvEntradasDia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarimaCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroEtiqueta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo_Articulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCajas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridEntradasDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradasPorDiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEntradasDia)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fecha Inicial:";
            // 
            // gridEntradasDia
            // 
            this.gridEntradasDia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEntradasDia.DataSource = this.entradasPorDiaBindingSource;
            this.gridEntradasDia.Location = new System.Drawing.Point(3, 175);
            this.gridEntradasDia.MainView = this.gvEntradasDia;
            this.gridEntradasDia.Name = "gridEntradasDia";
            this.gridEntradasDia.Size = new System.Drawing.Size(894, 283);
            this.gridEntradasDia.TabIndex = 18;
            this.gridEntradasDia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEntradasDia});
            // 
            // entradasPorDiaBindingSource
            // 
            this.entradasPorDiaBindingSource.DataSource = typeof(ClientesExternos.Modelos.MovimientosPorDia);
            // 
            // gvEntradasDia
            // 
            this.gvEntradasDia.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEntradasDia.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvEntradasDia.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEntradasDia.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvEntradasDia.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvEntradasDia.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvEntradasDia.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvEntradasDia.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvEntradasDia.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvEntradasDia.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvEntradasDia.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvEntradasDia.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvEntradasDia.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvEntradasDia.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvEntradasDia.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvEntradasDia.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvEntradasDia.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvEntradasDia.Appearance.Empty.Options.UseBackColor = true;
            this.gvEntradasDia.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvEntradasDia.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvEntradasDia.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvEntradasDia.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvEntradasDia.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEntradasDia.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvEntradasDia.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEntradasDia.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvEntradasDia.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvEntradasDia.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvEntradasDia.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvEntradasDia.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvEntradasDia.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvEntradasDia.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvEntradasDia.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvEntradasDia.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvEntradasDia.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvEntradasDia.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvEntradasDia.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvEntradasDia.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvEntradasDia.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvEntradasDia.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvEntradasDia.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvEntradasDia.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvEntradasDia.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvEntradasDia.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvEntradasDia.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEntradasDia.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvEntradasDia.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEntradasDia.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEntradasDia.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvEntradasDia.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvEntradasDia.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvEntradasDia.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvEntradasDia.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvEntradasDia.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvEntradasDia.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvEntradasDia.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvEntradasDia.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvEntradasDia.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvEntradasDia.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvEntradasDia.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvEntradasDia.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvEntradasDia.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvEntradasDia.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvEntradasDia.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvEntradasDia.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvEntradasDia.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEntradasDia.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvEntradasDia.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvEntradasDia.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvEntradasDia.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvEntradasDia.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvEntradasDia.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvEntradasDia.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvEntradasDia.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvEntradasDia.Appearance.GroupRow.Options.UseFont = true;
            this.gvEntradasDia.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvEntradasDia.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEntradasDia.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvEntradasDia.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEntradasDia.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEntradasDia.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvEntradasDia.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvEntradasDia.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvEntradasDia.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvEntradasDia.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvEntradasDia.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvEntradasDia.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvEntradasDia.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvEntradasDia.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvEntradasDia.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvEntradasDia.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvEntradasDia.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvEntradasDia.Appearance.OddRow.Options.UseBackColor = true;
            this.gvEntradasDia.Appearance.OddRow.Options.UseForeColor = true;
            this.gvEntradasDia.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvEntradasDia.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvEntradasDia.Appearance.Preview.Options.UseBackColor = true;
            this.gvEntradasDia.Appearance.Preview.Options.UseForeColor = true;
            this.gvEntradasDia.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvEntradasDia.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvEntradasDia.Appearance.Row.Options.UseBackColor = true;
            this.gvEntradasDia.Appearance.Row.Options.UseForeColor = true;
            this.gvEntradasDia.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvEntradasDia.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvEntradasDia.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvEntradasDia.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvEntradasDia.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvEntradasDia.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvEntradasDia.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvEntradasDia.Appearance.VertLine.Options.UseBackColor = true;
            this.gvEntradasDia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCliente,
            this.colTarimaCliente,
            this.colNumeroEtiqueta,
            this.colCodigo_Articulo,
            this.colCajas,
            this.colPeso,
            this.colUnidad});
            this.gvEntradasDia.GridControl = this.gridEntradasDia;
            this.gvEntradasDia.GroupCount = 2;
            this.gvEntradasDia.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cajas", this.colCajas, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Peso", this.colPeso, "{0:#,0.00}")});
            this.gvEntradasDia.Name = "gvEntradasDia";
            this.gvEntradasDia.OptionsBehavior.Editable = false;
            this.gvEntradasDia.OptionsView.EnableAppearanceEvenRow = true;
            this.gvEntradasDia.OptionsView.EnableAppearanceOddRow = true;
            this.gvEntradasDia.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCliente, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCodigo_Articulo, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvEntradasDia.EndGrouping += new System.EventHandler(this.gvEntradasDia_EndGrouping);
            // 
            // colCliente
            // 
            this.colCliente.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCliente.AppearanceCell.Options.UseFont = true;
            this.colCliente.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCliente.AppearanceHeader.Options.UseFont = true;
            this.colCliente.FieldName = "Cliente";
            this.colCliente.Name = "colCliente";
            // 
            // colTarimaCliente
            // 
            this.colTarimaCliente.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTarimaCliente.AppearanceCell.Options.UseFont = true;
            this.colTarimaCliente.AppearanceCell.Options.UseTextOptions = true;
            this.colTarimaCliente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTarimaCliente.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTarimaCliente.AppearanceHeader.Options.UseFont = true;
            this.colTarimaCliente.AppearanceHeader.Options.UseTextOptions = true;
            this.colTarimaCliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTarimaCliente.FieldName = "TarimaCliente";
            this.colTarimaCliente.Name = "colTarimaCliente";
            this.colTarimaCliente.Visible = true;
            this.colTarimaCliente.VisibleIndex = 0;
            // 
            // colNumeroEtiqueta
            // 
            this.colNumeroEtiqueta.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNumeroEtiqueta.AppearanceCell.Options.UseFont = true;
            this.colNumeroEtiqueta.AppearanceCell.Options.UseTextOptions = true;
            this.colNumeroEtiqueta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumeroEtiqueta.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNumeroEtiqueta.AppearanceHeader.Options.UseFont = true;
            this.colNumeroEtiqueta.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumeroEtiqueta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumeroEtiqueta.Caption = "Etiqueta";
            this.colNumeroEtiqueta.FieldName = "NumeroEtiqueta";
            this.colNumeroEtiqueta.Name = "colNumeroEtiqueta";
            this.colNumeroEtiqueta.Visible = true;
            this.colNumeroEtiqueta.VisibleIndex = 1;
            // 
            // colCodigo_Articulo
            // 
            this.colCodigo_Articulo.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCodigo_Articulo.AppearanceCell.Options.UseFont = true;
            this.colCodigo_Articulo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCodigo_Articulo.AppearanceHeader.Options.UseFont = true;
            this.colCodigo_Articulo.Caption = "Artículo";
            this.colCodigo_Articulo.FieldName = "Codigo_Articulo";
            this.colCodigo_Articulo.Name = "colCodigo_Articulo";
            this.colCodigo_Articulo.Visible = true;
            this.colCodigo_Articulo.VisibleIndex = 5;
            // 
            // colCajas
            // 
            this.colCajas.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCajas.AppearanceCell.Options.UseFont = true;
            this.colCajas.AppearanceCell.Options.UseTextOptions = true;
            this.colCajas.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCajas.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCajas.AppearanceHeader.Options.UseFont = true;
            this.colCajas.AppearanceHeader.Options.UseTextOptions = true;
            this.colCajas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCajas.FieldName = "Cajas";
            this.colCajas.Name = "colCajas";
            this.colCajas.Visible = true;
            this.colCajas.VisibleIndex = 2;
            // 
            // colPeso
            // 
            this.colPeso.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPeso.AppearanceCell.Options.UseFont = true;
            this.colPeso.AppearanceCell.Options.UseTextOptions = true;
            this.colPeso.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPeso.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPeso.AppearanceHeader.Options.UseFont = true;
            this.colPeso.AppearanceHeader.Options.UseTextOptions = true;
            this.colPeso.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPeso.DisplayFormat.FormatString = "{0:#0.00}";
            this.colPeso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPeso.FieldName = "Peso";
            this.colPeso.Name = "colPeso";
            this.colPeso.Visible = true;
            this.colPeso.VisibleIndex = 3;
            // 
            // colUnidad
            // 
            this.colUnidad.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUnidad.AppearanceCell.Options.UseFont = true;
            this.colUnidad.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUnidad.AppearanceHeader.Options.UseFont = true;
            this.colUnidad.FieldName = "Unidad";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.OptionsColumn.ReadOnly = true;
            this.colUnidad.Visible = true;
            this.colUnidad.VisibleIndex = 4;
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
            this.btnCerrar.TabIndex = 17;
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
            this.label1.TabIndex = 15;
            this.label1.Text = "Entradas por día";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(900, 33);
            this.label2.TabIndex = 16;
            this.label2.Text = "FRIOLALA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImprimir.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = global::ClientesExternos.Properties.Resources.printericon_26;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(400, 464);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 35);
            this.btnImprimir.TabIndex = 22;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConsultar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Image = global::ClientesExternos.Properties.Resources.search_26;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(400, 134);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 35);
            this.btnConsultar.TabIndex = 21;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFechaInicial.CustomFormat = "dd/MMMM/2016";
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicial.Location = new System.Drawing.Point(204, 70);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaInicial.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Cliente:";
            // 
            // cmbClientes
            // 
            this.cmbClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(173, 102);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(618, 26);
            this.cmbClientes.TabIndex = 25;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFechaFinal.CustomFormat = "dd/MMMM/2016";
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFinal.Location = new System.Drawing.Point(591, 70);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaFinal.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(504, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Fecha Final:";
            // 
            // Frm_EntradasPorDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFechaInicial);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridEntradasDia);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_EntradasPorDia";
            this.Size = new System.Drawing.Size(900, 500);
            this.Load += new System.EventHandler(this.Frm_EntradasPorDia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEntradasDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradasPorDiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEntradasDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl gridEntradasDia;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEntradasDia;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.BindingSource entradasPorDiaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colTarimaCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroEtiqueta;
        private DevExpress.XtraGrid.Columns.GridColumn colCajas;
        private DevExpress.XtraGrid.Columns.GridColumn colPeso;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidad;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo_Articulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Label label5;
    }
}

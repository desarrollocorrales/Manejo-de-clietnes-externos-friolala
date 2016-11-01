namespace ClientesExternos.GUIs.UserControls
{
    partial class Frm_Salidas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbRutaEscaneo = new System.Windows.Forms.TextBox();
            this.btnBuscarEscaneo = new System.Windows.Forms.Button();
            this.gridSalidas = new DevExpress.XtraGrid.GridControl();
            this.salidasGridBindingSource = new System.Windows.Forms.BindingSource();
            this.gvSalidas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroTarima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroTarimaCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCajas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnGenerarSalida = new System.Windows.Forms.Button();
            this.ofdEscaneo = new System.Windows.Forms.OpenFileDialog();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridSalidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidasGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSalidas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(900, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "Salidas de Mercancía";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(900, 33);
            this.label2.TabIndex = 20;
            this.label2.Text = "FRIOLALA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Archivo de escaneo:";
            // 
            // txbRutaEscaneo
            // 
            this.txbRutaEscaneo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbRutaEscaneo.BackColor = System.Drawing.Color.White;
            this.txbRutaEscaneo.Location = new System.Drawing.Point(141, 66);
            this.txbRutaEscaneo.Name = "txbRutaEscaneo";
            this.txbRutaEscaneo.ReadOnly = true;
            this.txbRutaEscaneo.Size = new System.Drawing.Size(710, 26);
            this.txbRutaEscaneo.TabIndex = 22;
            // 
            // btnBuscarEscaneo
            // 
            this.btnBuscarEscaneo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarEscaneo.Location = new System.Drawing.Point(857, 66);
            this.btnBuscarEscaneo.Name = "btnBuscarEscaneo";
            this.btnBuscarEscaneo.Size = new System.Drawing.Size(40, 26);
            this.btnBuscarEscaneo.TabIndex = 23;
            this.btnBuscarEscaneo.Text = "...";
            this.btnBuscarEscaneo.UseVisualStyleBackColor = true;
            this.btnBuscarEscaneo.Click += new System.EventHandler(this.btnBuscarEscaneo_Click);
            // 
            // gridSalidas
            // 
            this.gridSalidas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSalidas.DataSource = this.salidasGridBindingSource;
            this.gridSalidas.Location = new System.Drawing.Point(3, 98);
            this.gridSalidas.MainView = this.gvSalidas;
            this.gridSalidas.Name = "gridSalidas";
            this.gridSalidas.Size = new System.Drawing.Size(894, 358);
            this.gridSalidas.TabIndex = 24;
            this.gridSalidas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSalidas});
            // 
            // salidasGridBindingSource
            // 
            this.salidasGridBindingSource.DataSource = typeof(ClientesExternos.Modelos.SalidasGrid);
            // 
            // gvSalidas
            // 
            this.gvSalidas.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvSalidas.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvSalidas.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvSalidas.Appearance.Row.Options.UseFont = true;
            this.gvSalidas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCliente,
            this.colNumeroTarima,
            this.colNumeroTarimaCliente,
            this.colCodigo,
            this.colArticulo,
            this.colCajas,
            this.colPeso,
            this.colUnidad});
            this.gvSalidas.GridControl = this.gridSalidas;
            this.gvSalidas.GroupCount = 1;
            this.gvSalidas.Name = "gvSalidas";
            this.gvSalidas.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCliente, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvSalidas.EndGrouping += new System.EventHandler(this.gvSalidas_EndGrouping);
            // 
            // colCliente
            // 
            this.colCliente.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colCliente.AppearanceCell.BackColor2 = System.Drawing.Color.Silver;
            this.colCliente.AppearanceCell.Options.UseBackColor = true;
            this.colCliente.FieldName = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.OptionsColumn.AllowEdit = false;
            // 
            // colNumeroTarima
            // 
            this.colNumeroTarima.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colNumeroTarima.AppearanceCell.BackColor2 = System.Drawing.Color.Silver;
            this.colNumeroTarima.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.colNumeroTarima.AppearanceCell.Options.UseBackColor = true;
            this.colNumeroTarima.AppearanceCell.Options.UseTextOptions = true;
            this.colNumeroTarima.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumeroTarima.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumeroTarima.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumeroTarima.FieldName = "NumeroTarima";
            this.colNumeroTarima.Name = "colNumeroTarima";
            this.colNumeroTarima.OptionsColumn.AllowEdit = false;
            this.colNumeroTarima.Visible = true;
            this.colNumeroTarima.VisibleIndex = 0;
            // 
            // colNumeroTarimaCliente
            // 
            this.colNumeroTarimaCliente.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colNumeroTarimaCliente.AppearanceCell.BackColor2 = System.Drawing.Color.Silver;
            this.colNumeroTarimaCliente.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.colNumeroTarimaCliente.AppearanceCell.Options.UseBackColor = true;
            this.colNumeroTarimaCliente.AppearanceCell.Options.UseTextOptions = true;
            this.colNumeroTarimaCliente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumeroTarimaCliente.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumeroTarimaCliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumeroTarimaCliente.Caption = "#Tarima Cliente";
            this.colNumeroTarimaCliente.FieldName = "NumeroTarimaCliente";
            this.colNumeroTarimaCliente.Name = "colNumeroTarimaCliente";
            this.colNumeroTarimaCliente.OptionsColumn.AllowEdit = false;
            this.colNumeroTarimaCliente.Visible = true;
            this.colNumeroTarimaCliente.VisibleIndex = 1;
            // 
            // colCodigo
            // 
            this.colCodigo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colCodigo.AppearanceCell.BackColor2 = System.Drawing.Color.Silver;
            this.colCodigo.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.colCodigo.AppearanceCell.Options.UseBackColor = true;
            this.colCodigo.AppearanceCell.Options.UseTextOptions = true;
            this.colCodigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodigo.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.OptionsColumn.AllowEdit = false;
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 2;
            // 
            // colArticulo
            // 
            this.colArticulo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colArticulo.AppearanceCell.BackColor2 = System.Drawing.Color.Silver;
            this.colArticulo.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.colArticulo.AppearanceCell.Options.UseBackColor = true;
            this.colArticulo.FieldName = "Articulo";
            this.colArticulo.Name = "colArticulo";
            this.colArticulo.OptionsColumn.AllowEdit = false;
            this.colArticulo.Visible = true;
            this.colArticulo.VisibleIndex = 3;
            // 
            // colCajas
            // 
            this.colCajas.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.colCajas.AppearanceCell.BackColor2 = System.Drawing.Color.LightGoldenrodYellow;
            this.colCajas.AppearanceCell.Options.UseBackColor = true;
            this.colCajas.AppearanceCell.Options.UseTextOptions = true;
            this.colCajas.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCajas.AppearanceHeader.Options.UseTextOptions = true;
            this.colCajas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCajas.FieldName = "Cajas";
            this.colCajas.Name = "colCajas";
            this.colCajas.Visible = true;
            this.colCajas.VisibleIndex = 4;
            // 
            // colPeso
            // 
            this.colPeso.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.colPeso.AppearanceCell.BackColor2 = System.Drawing.Color.LightGoldenrodYellow;
            this.colPeso.AppearanceCell.Options.UseBackColor = true;
            this.colPeso.AppearanceCell.Options.UseTextOptions = true;
            this.colPeso.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPeso.AppearanceHeader.Options.UseTextOptions = true;
            this.colPeso.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPeso.FieldName = "Peso";
            this.colPeso.Name = "colPeso";
            this.colPeso.Visible = true;
            this.colPeso.VisibleIndex = 5;
            // 
            // colUnidad
            // 
            this.colUnidad.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colUnidad.AppearanceCell.BackColor2 = System.Drawing.Color.Silver;
            this.colUnidad.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.colUnidad.AppearanceCell.Options.UseBackColor = true;
            this.colUnidad.FieldName = "Unidad";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.OptionsColumn.AllowEdit = false;
            this.colUnidad.Visible = true;
            this.colUnidad.VisibleIndex = 6;
            // 
            // btnGenerarSalida
            // 
            this.btnGenerarSalida.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGenerarSalida.Image = global::ClientesExternos.Properties.Resources.salida_26;
            this.btnGenerarSalida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarSalida.Location = new System.Drawing.Point(400, 462);
            this.btnGenerarSalida.Name = "btnGenerarSalida";
            this.btnGenerarSalida.Size = new System.Drawing.Size(135, 35);
            this.btnGenerarSalida.TabIndex = 25;
            this.btnGenerarSalida.Text = "Generar Salida";
            this.btnGenerarSalida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarSalida.UseVisualStyleBackColor = true;
            this.btnGenerarSalida.Click += new System.EventHandler(this.btnGenerarSalida_Click);
            // 
            // ofdEscaneo
            // 
            this.ofdEscaneo.FileName = "*.txt";
            this.ofdEscaneo.Filter = "Archivos de texto | *.txt";
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
            this.btnCerrar.TabIndex = 26;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Frm_Salidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGenerarSalida);
            this.Controls.Add(this.gridSalidas);
            this.Controls.Add(this.btnBuscarEscaneo);
            this.Controls.Add(this.txbRutaEscaneo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Salidas";
            this.Size = new System.Drawing.Size(900, 500);
            ((System.ComponentModel.ISupportInitialize)(this.gridSalidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidasGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSalidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbRutaEscaneo;
        private System.Windows.Forms.Button btnBuscarEscaneo;
        private DevExpress.XtraGrid.GridControl gridSalidas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSalidas;
        private System.Windows.Forms.Button btnGenerarSalida;
        private System.Windows.Forms.OpenFileDialog ofdEscaneo;
        private System.Windows.Forms.BindingSource salidasGridBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroTarima;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroTarimaCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colCajas;
        private DevExpress.XtraGrid.Columns.GridColumn colPeso;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidad;
        private System.Windows.Forms.Button btnCerrar;
    }
}

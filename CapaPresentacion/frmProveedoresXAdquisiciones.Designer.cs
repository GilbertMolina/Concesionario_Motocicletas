namespace CapaPresentacion
{
    partial class frmProveedoresXAdquisiciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedoresXAdquisiciones));
            this.lbCodProveedor = new System.Windows.Forms.Label();
            this.cbNombreProveedor = new System.Windows.Forms.ComboBox();
            this.dgvListaAdquisicionesProveedores = new System.Windows.Forms.DataGridView();
            this.lap_cod_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lap_nombre_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lap_cod_fact_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lap_cod_vechiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lap_cod_repuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lap_cantidad_unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lap_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lap_fecha_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnListaVehiculos = new System.Windows.Forms.Panel();
            this.lblListaDepartamentos = new System.Windows.Forms.Label();
            this.pnVehiculos = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btLimpiarFormulario = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.txtCodFacturaCompra = new System.Windows.Forms.TextBox();
            this.lblCodAdquisicion = new System.Windows.Forms.Label();
            this.gbAquisiciones = new System.Windows.Forms.GroupBox();
            this.btRefrescarDataGrids = new System.Windows.Forms.Button();
            this.dgvListaAdquisiciones = new System.Windows.Forms.DataGridView();
            this.cod_factura_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_repuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttbtAgregar = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtActualizar = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtEliminar = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtLimpiar = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtRefrescarListas = new System.Windows.Forms.ToolTip(this.components);
            this.txtCodProveedor = new System.Windows.Forms.TextBox();
            this.lbCodigoProveedor = new System.Windows.Forms.Label();
            this.btRefrescarFormulario = new System.Windows.Forms.Button();
            this.ttbtRefrescarFormulario = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAdquisicionesProveedores)).BeginInit();
            this.pnListaVehiculos.SuspendLayout();
            this.pnVehiculos.SuspendLayout();
            this.gbAquisiciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAdquisiciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCodProveedor
            // 
            this.lbCodProveedor.AutoSize = true;
            this.lbCodProveedor.Location = new System.Drawing.Point(7, 112);
            this.lbCodProveedor.Name = "lbCodProveedor";
            this.lbCodProveedor.Size = new System.Drawing.Size(99, 13);
            this.lbCodProveedor.TabIndex = 79;
            this.lbCodProveedor.Text = "Nombre Proveedor:";
            // 
            // cbNombreProveedor
            // 
            this.cbNombreProveedor.FormattingEnabled = true;
            this.cbNombreProveedor.Location = new System.Drawing.Point(110, 109);
            this.cbNombreProveedor.Name = "cbNombreProveedor";
            this.cbNombreProveedor.Size = new System.Drawing.Size(197, 21);
            this.cbNombreProveedor.TabIndex = 78;
            this.cbNombreProveedor.SelectedValueChanged += new System.EventHandler(this.cbNombreProveedor_SelectedValueChanged);
            // 
            // dgvListaAdquisicionesProveedores
            // 
            this.dgvListaAdquisicionesProveedores.AllowUserToAddRows = false;
            this.dgvListaAdquisicionesProveedores.AllowUserToDeleteRows = false;
            this.dgvListaAdquisicionesProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaAdquisicionesProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaAdquisicionesProveedores.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvListaAdquisicionesProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaAdquisicionesProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lap_cod_proveedor,
            this.lap_nombre_proveedor,
            this.lap_cod_fact_compra,
            this.lap_cod_vechiculo,
            this.lap_cod_repuesto,
            this.lap_cantidad_unidades,
            this.lap_valor,
            this.lap_fecha_compra});
            this.dgvListaAdquisicionesProveedores.Location = new System.Drawing.Point(323, 100);
            this.dgvListaAdquisicionesProveedores.Name = "dgvListaAdquisicionesProveedores";
            this.dgvListaAdquisicionesProveedores.ReadOnly = true;
            this.dgvListaAdquisicionesProveedores.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaAdquisicionesProveedores.Size = new System.Drawing.Size(799, 191);
            this.dgvListaAdquisicionesProveedores.TabIndex = 72;
            this.dgvListaAdquisicionesProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaAdquisicionesProveedores_CellClick);
            // 
            // lap_cod_proveedor
            // 
            this.lap_cod_proveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lap_cod_proveedor.HeaderText = "Cod. Proveedor";
            this.lap_cod_proveedor.Name = "lap_cod_proveedor";
            this.lap_cod_proveedor.ReadOnly = true;
            this.lap_cod_proveedor.Width = 97;
            // 
            // lap_nombre_proveedor
            // 
            this.lap_nombre_proveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lap_nombre_proveedor.HeaderText = "Nombre Proveedor";
            this.lap_nombre_proveedor.Name = "lap_nombre_proveedor";
            this.lap_nombre_proveedor.ReadOnly = true;
            this.lap_nombre_proveedor.Width = 111;
            // 
            // lap_cod_fact_compra
            // 
            this.lap_cod_fact_compra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lap_cod_fact_compra.HeaderText = "Cod. Factura Compra";
            this.lap_cod_fact_compra.Name = "lap_cod_fact_compra";
            this.lap_cod_fact_compra.ReadOnly = true;
            this.lap_cod_fact_compra.Width = 121;
            // 
            // lap_cod_vechiculo
            // 
            this.lap_cod_vechiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lap_cod_vechiculo.HeaderText = "Cod. Vehículo";
            this.lap_cod_vechiculo.Name = "lap_cod_vechiculo";
            this.lap_cod_vechiculo.ReadOnly = true;
            this.lap_cod_vechiculo.Width = 92;
            // 
            // lap_cod_repuesto
            // 
            this.lap_cod_repuesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lap_cod_repuesto.HeaderText = "Cod. Repuesto";
            this.lap_cod_repuesto.Name = "lap_cod_repuesto";
            this.lap_cod_repuesto.ReadOnly = true;
            this.lap_cod_repuesto.Width = 95;
            // 
            // lap_cantidad_unidades
            // 
            this.lap_cantidad_unidades.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lap_cantidad_unidades.HeaderText = "Cantidad Unidades";
            this.lap_cantidad_unidades.Name = "lap_cantidad_unidades";
            this.lap_cantidad_unidades.ReadOnly = true;
            this.lap_cantidad_unidades.Width = 112;
            // 
            // lap_valor
            // 
            this.lap_valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lap_valor.HeaderText = "Valor";
            this.lap_valor.Name = "lap_valor";
            this.lap_valor.ReadOnly = true;
            this.lap_valor.Width = 56;
            // 
            // lap_fecha_compra
            // 
            this.lap_fecha_compra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lap_fecha_compra.HeaderText = "Fecha Compra";
            this.lap_fecha_compra.Name = "lap_fecha_compra";
            this.lap_fecha_compra.ReadOnly = true;
            this.lap_fecha_compra.Width = 93;
            // 
            // pnListaVehiculos
            // 
            this.pnListaVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnListaVehiculos.Controls.Add(this.btRefrescarFormulario);
            this.pnListaVehiculos.Controls.Add(this.lblListaDepartamentos);
            this.pnListaVehiculos.Location = new System.Drawing.Point(323, 61);
            this.pnListaVehiculos.Name = "pnListaVehiculos";
            this.pnListaVehiculos.Size = new System.Drawing.Size(799, 37);
            this.pnListaVehiculos.TabIndex = 77;
            // 
            // lblListaDepartamentos
            // 
            this.lblListaDepartamentos.AutoSize = true;
            this.lblListaDepartamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaDepartamentos.Location = new System.Drawing.Point(307, 10);
            this.lblListaDepartamentos.Name = "lblListaDepartamentos";
            this.lblListaDepartamentos.Size = new System.Drawing.Size(235, 15);
            this.lblListaDepartamentos.TabIndex = 2;
            this.lblListaDepartamentos.Text = "Lista Adquisiciones de Proveedores";
            // 
            // pnVehiculos
            // 
            this.pnVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnVehiculos.Controls.Add(this.lblTitulo);
            this.pnVehiculos.Location = new System.Drawing.Point(0, 0);
            this.pnVehiculos.Name = "pnVehiculos";
            this.pnVehiculos.Size = new System.Drawing.Size(1122, 60);
            this.pnVehiculos.TabIndex = 76;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(393, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(330, 25);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Adquisiciones de proveedores";
            // 
            // btActualizar
            // 
            this.btActualizar.Enabled = false;
            this.btActualizar.Image = global::CapaPresentacion.Properties.Resources.edit;
            this.btActualizar.Location = new System.Drawing.Point(166, 178);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(37, 27);
            this.btActualizar.TabIndex = 69;
            this.btActualizar.UseVisualStyleBackColor = true;
            // 
            // btEliminar
            // 
            this.btEliminar.Image = global::CapaPresentacion.Properties.Resources.delete;
            this.btEliminar.Location = new System.Drawing.Point(220, 178);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(37, 27);
            this.btEliminar.TabIndex = 70;
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btLimpiarFormulario
            // 
            this.btLimpiarFormulario.Image = global::CapaPresentacion.Properties.Resources.clean;
            this.btLimpiarFormulario.Location = new System.Drawing.Point(270, 178);
            this.btLimpiarFormulario.Name = "btLimpiarFormulario";
            this.btLimpiarFormulario.Size = new System.Drawing.Size(37, 27);
            this.btLimpiarFormulario.TabIndex = 71;
            this.btLimpiarFormulario.UseVisualStyleBackColor = true;
            this.btLimpiarFormulario.Click += new System.EventHandler(this.btLimpiarFormulario_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Image = global::CapaPresentacion.Properties.Resources.add;
            this.btAgregar.Location = new System.Drawing.Point(110, 178);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(37, 27);
            this.btAgregar.TabIndex = 68;
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // txtCodFacturaCompra
            // 
            this.txtCodFacturaCompra.Location = new System.Drawing.Point(110, 144);
            this.txtCodFacturaCompra.Name = "txtCodFacturaCompra";
            this.txtCodFacturaCompra.ReadOnly = true;
            this.txtCodFacturaCompra.Size = new System.Drawing.Size(197, 20);
            this.txtCodFacturaCompra.TabIndex = 65;
            // 
            // lblCodAdquisicion
            // 
            this.lblCodAdquisicion.AutoSize = true;
            this.lblCodAdquisicion.Location = new System.Drawing.Point(7, 147);
            this.lblCodAdquisicion.Name = "lblCodAdquisicion";
            this.lblCodAdquisicion.Size = new System.Drawing.Size(103, 13);
            this.lblCodAdquisicion.TabIndex = 73;
            this.lblCodAdquisicion.Text = "Código Adquisición: ";
            // 
            // gbAquisiciones
            // 
            this.gbAquisiciones.Controls.Add(this.btRefrescarDataGrids);
            this.gbAquisiciones.Controls.Add(this.dgvListaAdquisiciones);
            this.gbAquisiciones.Location = new System.Drawing.Point(12, 297);
            this.gbAquisiciones.Name = "gbAquisiciones";
            this.gbAquisiciones.Size = new System.Drawing.Size(1098, 272);
            this.gbAquisiciones.TabIndex = 82;
            this.gbAquisiciones.TabStop = false;
            this.gbAquisiciones.Text = "Aquisiciones";
            // 
            // btRefrescarDataGrids
            // 
            this.btRefrescarDataGrids.Image = global::CapaPresentacion.Properties.Resources.refresh;
            this.btRefrescarDataGrids.Location = new System.Drawing.Point(1049, 236);
            this.btRefrescarDataGrids.Name = "btRefrescarDataGrids";
            this.btRefrescarDataGrids.Size = new System.Drawing.Size(37, 27);
            this.btRefrescarDataGrids.TabIndex = 19;
            this.btRefrescarDataGrids.UseVisualStyleBackColor = true;
            this.btRefrescarDataGrids.Click += new System.EventHandler(this.btRefrescarDataGrids_Click);
            // 
            // dgvListaAdquisiciones
            // 
            this.dgvListaAdquisiciones.AllowUserToAddRows = false;
            this.dgvListaAdquisiciones.AllowUserToDeleteRows = false;
            this.dgvListaAdquisiciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaAdquisiciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaAdquisiciones.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvListaAdquisiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaAdquisiciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_factura_compra,
            this.cod_vehiculo,
            this.cod_repuesto,
            this.cantidad_unidades,
            this.valor,
            this.fecha_compra});
            this.dgvListaAdquisiciones.Location = new System.Drawing.Point(14, 19);
            this.dgvListaAdquisiciones.Name = "dgvListaAdquisiciones";
            this.dgvListaAdquisiciones.ReadOnly = true;
            this.dgvListaAdquisiciones.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaAdquisiciones.Size = new System.Drawing.Size(1072, 211);
            this.dgvListaAdquisiciones.TabIndex = 12;
            this.dgvListaAdquisiciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaAdquisiciones_CellClick);
            // 
            // cod_factura_compra
            // 
            this.cod_factura_compra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cod_factura_compra.HeaderText = "Cod. Factura Compra";
            this.cod_factura_compra.Name = "cod_factura_compra";
            this.cod_factura_compra.ReadOnly = true;
            this.cod_factura_compra.Width = 121;
            // 
            // cod_vehiculo
            // 
            this.cod_vehiculo.HeaderText = "Cod. Vehículo";
            this.cod_vehiculo.Name = "cod_vehiculo";
            this.cod_vehiculo.ReadOnly = true;
            this.cod_vehiculo.Width = 92;
            // 
            // cod_repuesto
            // 
            this.cod_repuesto.HeaderText = "Cod. Repuesto";
            this.cod_repuesto.Name = "cod_repuesto";
            this.cod_repuesto.ReadOnly = true;
            this.cod_repuesto.Width = 95;
            // 
            // cantidad_unidades
            // 
            this.cantidad_unidades.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cantidad_unidades.HeaderText = "Cantidad Unidades";
            this.cantidad_unidades.Name = "cantidad_unidades";
            this.cantidad_unidades.ReadOnly = true;
            this.cantidad_unidades.Width = 112;
            // 
            // valor
            // 
            this.valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 56;
            // 
            // fecha_compra
            // 
            this.fecha_compra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fecha_compra.HeaderText = "Fecha Compra";
            this.fecha_compra.Name = "fecha_compra";
            this.fecha_compra.ReadOnly = true;
            this.fecha_compra.Width = 93;
            // 
            // txtCodProveedor
            // 
            this.txtCodProveedor.Location = new System.Drawing.Point(110, 72);
            this.txtCodProveedor.Name = "txtCodProveedor";
            this.txtCodProveedor.ReadOnly = true;
            this.txtCodProveedor.Size = new System.Drawing.Size(197, 20);
            this.txtCodProveedor.TabIndex = 83;
            // 
            // lbCodigoProveedor
            // 
            this.lbCodigoProveedor.AutoSize = true;
            this.lbCodigoProveedor.Location = new System.Drawing.Point(7, 75);
            this.lbCodigoProveedor.Name = "lbCodigoProveedor";
            this.lbCodigoProveedor.Size = new System.Drawing.Size(95, 13);
            this.lbCodigoProveedor.TabIndex = 84;
            this.lbCodigoProveedor.Text = "Código Proveedor:";
            // 
            // btRefrescarFormulario
            // 
            this.btRefrescarFormulario.Image = global::CapaPresentacion.Properties.Resources.refresh;
            this.btRefrescarFormulario.Location = new System.Drawing.Point(757, 4);
            this.btRefrescarFormulario.Name = "btRefrescarFormulario";
            this.btRefrescarFormulario.Size = new System.Drawing.Size(37, 27);
            this.btRefrescarFormulario.TabIndex = 110;
            this.btRefrescarFormulario.UseVisualStyleBackColor = true;
            this.btRefrescarFormulario.Click += new System.EventHandler(this.btRefrescarFormulario_Click);
            // 
            // frmProveedoresXAdquisiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 582);
            this.Controls.Add(this.txtCodProveedor);
            this.Controls.Add(this.lbCodigoProveedor);
            this.Controls.Add(this.gbAquisiciones);
            this.Controls.Add(this.lbCodProveedor);
            this.Controls.Add(this.cbNombreProveedor);
            this.Controls.Add(this.dgvListaAdquisicionesProveedores);
            this.Controls.Add(this.pnListaVehiculos);
            this.Controls.Add(this.pnVehiculos);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btLimpiarFormulario);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.txtCodFacturaCompra);
            this.Controls.Add(this.lblCodAdquisicion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmProveedoresXAdquisiciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adquisiciones de proveedores";
            this.Load += new System.EventHandler(this.frmProveedoresXAdquisiciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAdquisicionesProveedores)).EndInit();
            this.pnListaVehiculos.ResumeLayout(false);
            this.pnListaVehiculos.PerformLayout();
            this.pnVehiculos.ResumeLayout(false);
            this.pnVehiculos.PerformLayout();
            this.gbAquisiciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAdquisiciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodProveedor;
        private System.Windows.Forms.ComboBox cbNombreProveedor;
        private System.Windows.Forms.DataGridView dgvListaAdquisicionesProveedores;
        private System.Windows.Forms.Panel pnListaVehiculos;
        private System.Windows.Forms.Label lblListaDepartamentos;
        private System.Windows.Forms.Panel pnVehiculos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btLimpiarFormulario;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.TextBox txtCodFacturaCompra;
        private System.Windows.Forms.Label lblCodAdquisicion;
        private System.Windows.Forms.GroupBox gbAquisiciones;
        private System.Windows.Forms.DataGridView dgvListaAdquisiciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_factura_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_vehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_repuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_compra;
        private System.Windows.Forms.Button btRefrescarDataGrids;
        private System.Windows.Forms.ToolTip ttbtAgregar;
        private System.Windows.Forms.ToolTip ttbtActualizar;
        private System.Windows.Forms.ToolTip ttbtEliminar;
        private System.Windows.Forms.ToolTip ttbtLimpiar;
        private System.Windows.Forms.ToolTip ttbtRefrescarListas;
        private System.Windows.Forms.TextBox txtCodProveedor;
        private System.Windows.Forms.Label lbCodigoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn lap_cod_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn lap_nombre_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn lap_cod_fact_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn lap_cod_vechiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn lap_cod_repuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn lap_cantidad_unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn lap_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn lap_fecha_compra;
        private System.Windows.Forms.Button btRefrescarFormulario;
        private System.Windows.Forms.ToolTip ttbtRefrescarFormulario;

    }
}
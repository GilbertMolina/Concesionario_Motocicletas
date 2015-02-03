namespace CapaPresentacion
{
    partial class frmAdquisiciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdquisiciones));
            this.txtCantidadUnidades = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvListaAdquisiciones = new System.Windows.Forms.DataGridView();
            this.cod_factura_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_repuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbFechaCompra = new System.Windows.Forms.Label();
            this.lbCantidadUnidades = new System.Windows.Forms.Label();
            this.txtFechaCompra = new System.Windows.Forms.TextBox();
            this.txtCodigoFacturaCompra = new System.Windows.Forms.TextBox();
            this.lbValor = new System.Windows.Forms.Label();
            this.lblCodVehiculo = new System.Windows.Forms.Label();
            this.lbCodFacturaCompra = new System.Windows.Forms.Label();
            this.pnVehiculos = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btLimpiarFormulario = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.gbProductos = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbRepuestos = new System.Windows.Forms.RadioButton();
            this.btAgregarProducto = new System.Windows.Forms.Button();
            this.rbVehiculosUsados = new System.Windows.Forms.RadioButton();
            this.lbListaProductos = new System.Windows.Forms.Label();
            this.rbVehiculosNuevos = new System.Windows.Forms.RadioButton();
            this.dgvListaProductos = new System.Windows.Forms.DataGridView();
            this.ttbtAgregar = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtActualizar = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtEliminar = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtLimpiar = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtAgregarProducto = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtRefrescarListas = new System.Windows.Forms.ToolTip(this.components);
            this.ttrbVehiculosNuevos = new System.Windows.Forms.ToolTip(this.components);
            this.ttrbVehiculosUsados = new System.Windows.Forms.ToolTip(this.components);
            this.ttrbRepuestos = new System.Windows.Forms.ToolTip(this.components);
            this.txtCodRepuesto = new System.Windows.Forms.TextBox();
            this.lbCodRepuesto = new System.Windows.Forms.Label();
            this.txtCodVehiculo = new System.Windows.Forms.TextBox();
            this.btRefrescarDataGrids = new System.Windows.Forms.Button();
            this.btRefrescarFormulario = new System.Windows.Forms.Button();
            this.ttbtRefrescarFormulario = new System.Windows.Forms.ToolTip(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAdquisiciones)).BeginInit();
            this.pnVehiculos.SuspendLayout();
            this.gbProductos.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCantidadUnidades
            // 
            this.txtCantidadUnidades.AllowDrop = true;
            this.txtCantidadUnidades.Location = new System.Drawing.Point(151, 162);
            this.txtCantidadUnidades.MaxLength = 4;
            this.txtCantidadUnidades.Name = "txtCantidadUnidades";
            this.txtCantidadUnidades.Size = new System.Drawing.Size(197, 20);
            this.txtCantidadUnidades.TabIndex = 4;
            this.txtCantidadUnidades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracter_KeyPress);
            // 
            // txtValor
            // 
            this.txtValor.AllowDrop = true;
            this.txtValor.Location = new System.Drawing.Point(151, 196);
            this.txtValor.MaxLength = 12;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(197, 20);
            this.txtValor.TabIndex = 5;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracter_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btRefrescarFormulario);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(376, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(683, 37);
            this.panel3.TabIndex = 102;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lista Adquisiciones";
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
            this.dgvListaAdquisiciones.Location = new System.Drawing.Point(376, 100);
            this.dgvListaAdquisiciones.Name = "dgvListaAdquisiciones";
            this.dgvListaAdquisiciones.ReadOnly = true;
            this.dgvListaAdquisiciones.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaAdquisiciones.Size = new System.Drawing.Size(683, 192);
            this.dgvListaAdquisiciones.TabIndex = 11;
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
            // lbFechaCompra
            // 
            this.lbFechaCompra.AutoSize = true;
            this.lbFechaCompra.Location = new System.Drawing.Point(12, 232);
            this.lbFechaCompra.Name = "lbFechaCompra";
            this.lbFechaCompra.Size = new System.Drawing.Size(79, 13);
            this.lbFechaCompra.TabIndex = 100;
            this.lbFechaCompra.Text = "Fecha Compra:";
            // 
            // lbCantidadUnidades
            // 
            this.lbCantidadUnidades.AutoSize = true;
            this.lbCantidadUnidades.Location = new System.Drawing.Point(12, 165);
            this.lbCantidadUnidades.Name = "lbCantidadUnidades";
            this.lbCantidadUnidades.Size = new System.Drawing.Size(100, 13);
            this.lbCantidadUnidades.TabIndex = 99;
            this.lbCantidadUnidades.Text = "Cantidad Unidades:";
            // 
            // txtFechaCompra
            // 
            this.txtFechaCompra.AllowDrop = true;
            this.txtFechaCompra.Location = new System.Drawing.Point(151, 229);
            this.txtFechaCompra.MaxLength = 30;
            this.txtFechaCompra.Name = "txtFechaCompra";
            this.txtFechaCompra.ReadOnly = true;
            this.txtFechaCompra.Size = new System.Drawing.Size(197, 20);
            this.txtFechaCompra.TabIndex = 6;
            // 
            // txtCodigoFacturaCompra
            // 
            this.txtCodigoFacturaCompra.Location = new System.Drawing.Point(151, 70);
            this.txtCodigoFacturaCompra.Name = "txtCodigoFacturaCompra";
            this.txtCodigoFacturaCompra.ReadOnly = true;
            this.txtCodigoFacturaCompra.Size = new System.Drawing.Size(197, 20);
            this.txtCodigoFacturaCompra.TabIndex = 1;
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(12, 199);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(34, 13);
            this.lbValor.TabIndex = 98;
            this.lbValor.Text = "Valor:";
            // 
            // lblCodVehiculo
            // 
            this.lblCodVehiculo.AutoSize = true;
            this.lblCodVehiculo.Location = new System.Drawing.Point(12, 104);
            this.lblCodVehiculo.Name = "lblCodVehiculo";
            this.lblCodVehiculo.Size = new System.Drawing.Size(89, 13);
            this.lblCodVehiculo.TabIndex = 97;
            this.lblCodVehiculo.Text = "Código Vehículo:";
            // 
            // lbCodFacturaCompra
            // 
            this.lbCodFacturaCompra.AutoSize = true;
            this.lbCodFacturaCompra.Location = new System.Drawing.Point(12, 73);
            this.lbCodFacturaCompra.Name = "lbCodFacturaCompra";
            this.lbCodFacturaCompra.Size = new System.Drawing.Size(121, 13);
            this.lbCodFacturaCompra.TabIndex = 96;
            this.lbCodFacturaCompra.Text = "Código Factura Compra:";
            // 
            // pnVehiculos
            // 
            this.pnVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnVehiculos.Controls.Add(this.lblTitulo);
            this.pnVehiculos.Location = new System.Drawing.Point(0, 0);
            this.pnVehiculos.Name = "pnVehiculos";
            this.pnVehiculos.Size = new System.Drawing.Size(1059, 60);
            this.pnVehiculos.TabIndex = 88;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(447, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(159, 25);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Adquisiciones";
            // 
            // btActualizar
            // 
            this.btActualizar.Image = global::CapaPresentacion.Properties.Resources.edit;
            this.btActualizar.Location = new System.Drawing.Point(207, 265);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(37, 27);
            this.btActualizar.TabIndex = 8;
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Image = global::CapaPresentacion.Properties.Resources.delete;
            this.btEliminar.Location = new System.Drawing.Point(261, 265);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(37, 27);
            this.btEliminar.TabIndex = 9;
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btLimpiarFormulario
            // 
            this.btLimpiarFormulario.Image = global::CapaPresentacion.Properties.Resources.clean;
            this.btLimpiarFormulario.Location = new System.Drawing.Point(311, 265);
            this.btLimpiarFormulario.Name = "btLimpiarFormulario";
            this.btLimpiarFormulario.Size = new System.Drawing.Size(37, 27);
            this.btLimpiarFormulario.TabIndex = 10;
            this.btLimpiarFormulario.UseVisualStyleBackColor = true;
            this.btLimpiarFormulario.Click += new System.EventHandler(this.btLimpiarFormulario_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Image = global::CapaPresentacion.Properties.Resources.add;
            this.btAgregar.Location = new System.Drawing.Point(151, 265);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(37, 27);
            this.btAgregar.TabIndex = 7;
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // gbProductos
            // 
            this.gbProductos.Controls.Add(this.panel1);
            this.gbProductos.Controls.Add(this.btRefrescarDataGrids);
            this.gbProductos.Controls.Add(this.dgvListaProductos);
            this.gbProductos.Location = new System.Drawing.Point(7, 302);
            this.gbProductos.Name = "gbProductos";
            this.gbProductos.Size = new System.Drawing.Size(1045, 293);
            this.gbProductos.TabIndex = 106;
            this.gbProductos.TabStop = false;
            this.gbProductos.Text = "Productos";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbRepuestos);
            this.panel1.Controls.Add(this.btAgregarProducto);
            this.panel1.Controls.Add(this.rbVehiculosUsados);
            this.panel1.Controls.Add(this.lbListaProductos);
            this.panel1.Controls.Add(this.rbVehiculosNuevos);
            this.panel1.Location = new System.Drawing.Point(15, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 37);
            this.panel1.TabIndex = 90;
            // 
            // rbRepuestos
            // 
            this.rbRepuestos.AutoSize = true;
            this.rbRepuestos.Location = new System.Drawing.Point(248, 10);
            this.rbRepuestos.Name = "rbRepuestos";
            this.rbRepuestos.Size = new System.Drawing.Size(76, 17);
            this.rbRepuestos.TabIndex = 14;
            this.rbRepuestos.TabStop = true;
            this.rbRepuestos.Text = "Repuestos";
            this.rbRepuestos.UseVisualStyleBackColor = true;
            this.rbRepuestos.Click += new System.EventHandler(this.rbRepuestos_Click);
            // 
            // btAgregarProducto
            // 
            this.btAgregarProducto.Image = global::CapaPresentacion.Properties.Resources.add;
            this.btAgregarProducto.Location = new System.Drawing.Point(971, 5);
            this.btAgregarProducto.Name = "btAgregarProducto";
            this.btAgregarProducto.Size = new System.Drawing.Size(37, 27);
            this.btAgregarProducto.TabIndex = 15;
            this.btAgregarProducto.UseVisualStyleBackColor = true;
            this.btAgregarProducto.Click += new System.EventHandler(this.btAgregarProducto_Click);
            // 
            // rbVehiculosUsados
            // 
            this.rbVehiculosUsados.AutoSize = true;
            this.rbVehiculosUsados.Location = new System.Drawing.Point(130, 9);
            this.rbVehiculosUsados.Name = "rbVehiculosUsados";
            this.rbVehiculosUsados.Size = new System.Drawing.Size(112, 17);
            this.rbVehiculosUsados.TabIndex = 13;
            this.rbVehiculosUsados.TabStop = true;
            this.rbVehiculosUsados.Text = "Vehículos Usados";
            this.rbVehiculosUsados.UseVisualStyleBackColor = true;
            this.rbVehiculosUsados.Click += new System.EventHandler(this.rbVehiculosUsados_Click);
            // 
            // lbListaProductos
            // 
            this.lbListaProductos.AutoSize = true;
            this.lbListaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListaProductos.Location = new System.Drawing.Point(451, 9);
            this.lbListaProductos.Name = "lbListaProductos";
            this.lbListaProductos.Size = new System.Drawing.Size(106, 15);
            this.lbListaProductos.TabIndex = 2;
            this.lbListaProductos.Text = "Lista Productos";
            // 
            // rbVehiculosNuevos
            // 
            this.rbVehiculosNuevos.AutoSize = true;
            this.rbVehiculosNuevos.Location = new System.Drawing.Point(11, 9);
            this.rbVehiculosNuevos.Name = "rbVehiculosNuevos";
            this.rbVehiculosNuevos.Size = new System.Drawing.Size(113, 17);
            this.rbVehiculosNuevos.TabIndex = 12;
            this.rbVehiculosNuevos.TabStop = true;
            this.rbVehiculosNuevos.Text = "Vehículos Nuevos";
            this.rbVehiculosNuevos.UseVisualStyleBackColor = true;
            this.rbVehiculosNuevos.Click += new System.EventHandler(this.rbVehiculosNuevos_Click);
            // 
            // dgvListaProductos
            // 
            this.dgvListaProductos.AllowUserToAddRows = false;
            this.dgvListaProductos.AllowUserToDeleteRows = false;
            this.dgvListaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaProductos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProductos.Location = new System.Drawing.Point(15, 57);
            this.dgvListaProductos.Name = "dgvListaProductos";
            this.dgvListaProductos.ReadOnly = true;
            this.dgvListaProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaProductos.Size = new System.Drawing.Size(1013, 196);
            this.dgvListaProductos.TabIndex = 16;
            this.dgvListaProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProductos_CellClick);
            // 
            // txtCodRepuesto
            // 
            this.txtCodRepuesto.AllowDrop = true;
            this.txtCodRepuesto.Location = new System.Drawing.Point(151, 132);
            this.txtCodRepuesto.MaxLength = 30;
            this.txtCodRepuesto.Name = "txtCodRepuesto";
            this.txtCodRepuesto.ReadOnly = true;
            this.txtCodRepuesto.Size = new System.Drawing.Size(196, 20);
            this.txtCodRepuesto.TabIndex = 3;
            // 
            // lbCodRepuesto
            // 
            this.lbCodRepuesto.AutoSize = true;
            this.lbCodRepuesto.Location = new System.Drawing.Point(12, 135);
            this.lbCodRepuesto.Name = "lbCodRepuesto";
            this.lbCodRepuesto.Size = new System.Drawing.Size(92, 13);
            this.lbCodRepuesto.TabIndex = 108;
            this.lbCodRepuesto.Text = "Código Repuesto:";
            // 
            // txtCodVehiculo
            // 
            this.txtCodVehiculo.AllowDrop = true;
            this.txtCodVehiculo.Location = new System.Drawing.Point(151, 101);
            this.txtCodVehiculo.MaxLength = 30;
            this.txtCodVehiculo.Name = "txtCodVehiculo";
            this.txtCodVehiculo.ReadOnly = true;
            this.txtCodVehiculo.Size = new System.Drawing.Size(196, 20);
            this.txtCodVehiculo.TabIndex = 2;
            // 
            // btRefrescarDataGrids
            // 
            this.btRefrescarDataGrids.Image = global::CapaPresentacion.Properties.Resources.refresh;
            this.btRefrescarDataGrids.Location = new System.Drawing.Point(991, 260);
            this.btRefrescarDataGrids.Name = "btRefrescarDataGrids";
            this.btRefrescarDataGrids.Size = new System.Drawing.Size(37, 27);
            this.btRefrescarDataGrids.TabIndex = 17;
            this.btRefrescarDataGrids.UseVisualStyleBackColor = true;
            this.btRefrescarDataGrids.Click += new System.EventHandler(this.btRefrescarDataGrids_Click);
            // 
            // btRefrescarFormulario
            // 
            this.btRefrescarFormulario.Image = global::CapaPresentacion.Properties.Resources.refresh;
            this.btRefrescarFormulario.Location = new System.Drawing.Point(641, 3);
            this.btRefrescarFormulario.Name = "btRefrescarFormulario";
            this.btRefrescarFormulario.Size = new System.Drawing.Size(37, 27);
            this.btRefrescarFormulario.TabIndex = 109;
            this.btRefrescarFormulario.UseVisualStyleBackColor = true;
            this.btRefrescarFormulario.Click += new System.EventHandler(this.btRefrescarFormulario_Click);
            // 
            // frmAdquisiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 610);
            this.Controls.Add(this.txtCodRepuesto);
            this.Controls.Add(this.lbCodRepuesto);
            this.Controls.Add(this.gbProductos);
            this.Controls.Add(this.txtCantidadUnidades);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvListaAdquisiciones);
            this.Controls.Add(this.lbFechaCompra);
            this.Controls.Add(this.lbCantidadUnidades);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btLimpiarFormulario);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.txtFechaCompra);
            this.Controls.Add(this.txtCodVehiculo);
            this.Controls.Add(this.txtCodigoFacturaCompra);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.lblCodVehiculo);
            this.Controls.Add(this.lbCodFacturaCompra);
            this.Controls.Add(this.pnVehiculos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAdquisiciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adquisiciones";
            this.Load += new System.EventHandler(this.frmAdquisiciones_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAdquisiciones)).EndInit();
            this.pnVehiculos.ResumeLayout(false);
            this.pnVehiculos.PerformLayout();
            this.gbProductos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCantidadUnidades;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvListaAdquisiciones;
        private System.Windows.Forms.Label lbFechaCompra;
        private System.Windows.Forms.Label lbCantidadUnidades;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btLimpiarFormulario;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.TextBox txtFechaCompra;
        private System.Windows.Forms.TextBox txtCodigoFacturaCompra;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label lblCodVehiculo;
        private System.Windows.Forms.Label lbCodFacturaCompra;
        private System.Windows.Forms.Panel pnVehiculos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbRepuestos;
        private System.Windows.Forms.Button btAgregarProducto;
        private System.Windows.Forms.RadioButton rbVehiculosUsados;
        private System.Windows.Forms.Label lbListaProductos;
        private System.Windows.Forms.RadioButton rbVehiculosNuevos;
        private System.Windows.Forms.DataGridView dgvListaProductos;
        private System.Windows.Forms.ToolTip ttbtAgregar;
        private System.Windows.Forms.ToolTip ttbtActualizar;
        private System.Windows.Forms.ToolTip ttbtEliminar;
        private System.Windows.Forms.ToolTip ttbtLimpiar;
        private System.Windows.Forms.ToolTip ttbtAgregarProducto;
        private System.Windows.Forms.ToolTip ttbtRefrescarListas;
        private System.Windows.Forms.ToolTip ttrbVehiculosNuevos;
        private System.Windows.Forms.ToolTip ttrbVehiculosUsados;
        private System.Windows.Forms.ToolTip ttrbRepuestos;
        private System.Windows.Forms.TextBox txtCodRepuesto;
        private System.Windows.Forms.Label lbCodRepuesto;
        private System.Windows.Forms.TextBox txtCodVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_factura_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_vehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_repuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_compra;
        private System.Windows.Forms.Button btRefrescarFormulario;
        private System.Windows.Forms.Button btRefrescarDataGrids;
        private System.Windows.Forms.ToolTip ttbtRefrescarFormulario;
    }
}
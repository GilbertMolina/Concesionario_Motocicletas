namespace CapaPresentacion
{
    partial class frmVehiculoNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehiculoNuevo));
            this.pnVehiculos = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnListaVehiculos = new System.Windows.Forms.Panel();
            this.lblListaVehiculo = new System.Windows.Forms.Label();
            this.dgvListaVehiculosNuevos = new System.Windows.Forms.DataGridView();
            this.cod_vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.garantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primer_mantenimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especificaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btLimpiarFormulario = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.txtEspecificaciones = new System.Windows.Forms.TextBox();
            this.txtPrimerMantenimiento = new System.Windows.Forms.TextBox();
            this.txtGarantia = new System.Windows.Forms.TextBox();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtCodigoVehiculo = new System.Windows.Forms.TextBox();
            this.lbPrimerMantenimiento = new System.Windows.Forms.Label();
            this.lblEspecificaciones = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblGarantia = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCodVehiculo = new System.Windows.Forms.Label();
            this.ttbtAgregar = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtActualizar = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtEliminar = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtLimpiar = new System.Windows.Forms.ToolTip(this.components);
            this.btRefrescarFormulario = new System.Windows.Forms.Button();
            this.ttbtRefrescarFormulario = new System.Windows.Forms.ToolTip(this.components);
            this.pnVehiculos.SuspendLayout();
            this.pnListaVehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVehiculosNuevos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnVehiculos
            // 
            this.pnVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnVehiculos.Controls.Add(this.lblTitulo);
            this.pnVehiculos.Location = new System.Drawing.Point(0, 1);
            this.pnVehiculos.Name = "pnVehiculos";
            this.pnVehiculos.Size = new System.Drawing.Size(1104, 60);
            this.pnVehiculos.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(438, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(201, 25);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Vehículos Nuevos";
            // 
            // pnListaVehiculos
            // 
            this.pnListaVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnListaVehiculos.Controls.Add(this.btRefrescarFormulario);
            this.pnListaVehiculos.Controls.Add(this.lblListaVehiculo);
            this.pnListaVehiculos.Location = new System.Drawing.Point(335, 62);
            this.pnListaVehiculos.Name = "pnListaVehiculos";
            this.pnListaVehiculos.Size = new System.Drawing.Size(769, 37);
            this.pnListaVehiculos.TabIndex = 15;
            // 
            // lblListaVehiculo
            // 
            this.lblListaVehiculo.AutoSize = true;
            this.lblListaVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaVehiculo.Location = new System.Drawing.Point(312, 9);
            this.lblListaVehiculo.Name = "lblListaVehiculo";
            this.lblListaVehiculo.Size = new System.Drawing.Size(156, 15);
            this.lblListaVehiculo.TabIndex = 2;
            this.lblListaVehiculo.Text = "Lista Vehículos Usados";
            // 
            // dgvListaVehiculosNuevos
            // 
            this.dgvListaVehiculosNuevos.AllowUserToAddRows = false;
            this.dgvListaVehiculosNuevos.AllowUserToDeleteRows = false;
            this.dgvListaVehiculosNuevos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaVehiculosNuevos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaVehiculosNuevos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvListaVehiculosNuevos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaVehiculosNuevos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_vehiculo,
            this.marca,
            this.modelo,
            this.color,
            this.precio_unitario,
            this.garantia,
            this.primer_mantenimiento,
            this.especificaciones});
            this.dgvListaVehiculosNuevos.Location = new System.Drawing.Point(335, 100);
            this.dgvListaVehiculosNuevos.Name = "dgvListaVehiculosNuevos";
            this.dgvListaVehiculosNuevos.ReadOnly = true;
            this.dgvListaVehiculosNuevos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaVehiculosNuevos.Size = new System.Drawing.Size(769, 303);
            this.dgvListaVehiculosNuevos.TabIndex = 13;
            this.dgvListaVehiculosNuevos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaVehiculosNuevos_CellClick);
            // 
            // cod_vehiculo
            // 
            this.cod_vehiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cod_vehiculo.HeaderText = "Cod. Vehículo";
            this.cod_vehiculo.Name = "cod_vehiculo";
            this.cod_vehiculo.ReadOnly = true;
            this.cod_vehiculo.Width = 92;
            // 
            // marca
            // 
            this.marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            this.marca.Width = 62;
            // 
            // modelo
            // 
            this.modelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            this.modelo.Width = 67;
            // 
            // color
            // 
            this.color.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            this.color.Width = 56;
            // 
            // precio_unitario
            // 
            this.precio_unitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.precio_unitario.HeaderText = "Precio Unitario";
            this.precio_unitario.Name = "precio_unitario";
            this.precio_unitario.ReadOnly = true;
            this.precio_unitario.Width = 93;
            // 
            // garantia
            // 
            this.garantia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.garantia.HeaderText = "Garantía";
            this.garantia.Name = "garantia";
            this.garantia.ReadOnly = true;
            this.garantia.Width = 74;
            // 
            // primer_mantenimiento
            // 
            this.primer_mantenimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.primer_mantenimiento.HeaderText = "Primer Mantenimiento";
            this.primer_mantenimiento.Name = "primer_mantenimiento";
            this.primer_mantenimiento.ReadOnly = true;
            this.primer_mantenimiento.Width = 122;
            // 
            // especificaciones
            // 
            this.especificaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.especificaciones.HeaderText = "Especificaciones";
            this.especificaciones.Name = "especificaciones";
            this.especificaciones.ReadOnly = true;
            this.especificaciones.Width = 112;
            // 
            // btActualizar
            // 
            this.btActualizar.Image = global::CapaPresentacion.Properties.Resources.edit;
            this.btActualizar.Location = new System.Drawing.Point(180, 376);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(37, 27);
            this.btActualizar.TabIndex = 10;
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Image = global::CapaPresentacion.Properties.Resources.delete;
            this.btEliminar.Location = new System.Drawing.Point(234, 376);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(37, 27);
            this.btEliminar.TabIndex = 11;
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btLimpiarFormulario
            // 
            this.btLimpiarFormulario.Image = global::CapaPresentacion.Properties.Resources.clean;
            this.btLimpiarFormulario.Location = new System.Drawing.Point(284, 376);
            this.btLimpiarFormulario.Name = "btLimpiarFormulario";
            this.btLimpiarFormulario.Size = new System.Drawing.Size(37, 27);
            this.btLimpiarFormulario.TabIndex = 12;
            this.btLimpiarFormulario.UseVisualStyleBackColor = true;
            this.btLimpiarFormulario.Click += new System.EventHandler(this.btLimpiarFormulario_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Image = global::CapaPresentacion.Properties.Resources.add;
            this.btAgregar.Location = new System.Drawing.Point(124, 376);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(37, 27);
            this.btAgregar.TabIndex = 9;
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // txtEspecificaciones
            // 
            this.txtEspecificaciones.AllowDrop = true;
            this.txtEspecificaciones.Location = new System.Drawing.Point(124, 295);
            this.txtEspecificaciones.MaxLength = 190;
            this.txtEspecificaciones.Multiline = true;
            this.txtEspecificaciones.Name = "txtEspecificaciones";
            this.txtEspecificaciones.Size = new System.Drawing.Size(197, 66);
            this.txtEspecificaciones.TabIndex = 8;
            // 
            // txtPrimerMantenimiento
            // 
            this.txtPrimerMantenimiento.AllowDrop = true;
            this.txtPrimerMantenimiento.Location = new System.Drawing.Point(124, 264);
            this.txtPrimerMantenimiento.MaxLength = 45;
            this.txtPrimerMantenimiento.Name = "txtPrimerMantenimiento";
            this.txtPrimerMantenimiento.Size = new System.Drawing.Size(197, 20);
            this.txtPrimerMantenimiento.TabIndex = 7;
            // 
            // txtGarantia
            // 
            this.txtGarantia.AllowDrop = true;
            this.txtGarantia.Location = new System.Drawing.Point(124, 228);
            this.txtGarantia.MaxLength = 45;
            this.txtGarantia.Name = "txtGarantia";
            this.txtGarantia.Size = new System.Drawing.Size(197, 20);
            this.txtGarantia.TabIndex = 6;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.AllowDrop = true;
            this.txtPrecioUnitario.Location = new System.Drawing.Point(124, 198);
            this.txtPrecioUnitario.MaxLength = 12;
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(197, 20);
            this.txtPrecioUnitario.TabIndex = 5;
            this.txtPrecioUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracter_KeyPress);
            // 
            // txtColor
            // 
            this.txtColor.AllowDrop = true;
            this.txtColor.Location = new System.Drawing.Point(124, 164);
            this.txtColor.MaxLength = 15;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(197, 20);
            this.txtColor.TabIndex = 4;
            // 
            // txtModelo
            // 
            this.txtModelo.AllowDrop = true;
            this.txtModelo.Location = new System.Drawing.Point(124, 131);
            this.txtModelo.MaxLength = 25;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(197, 20);
            this.txtModelo.TabIndex = 3;
            // 
            // txtMarca
            // 
            this.txtMarca.AllowDrop = true;
            this.txtMarca.Location = new System.Drawing.Point(124, 100);
            this.txtMarca.MaxLength = 25;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(197, 20);
            this.txtMarca.TabIndex = 2;
            // 
            // txtCodigoVehiculo
            // 
            this.txtCodigoVehiculo.Location = new System.Drawing.Point(124, 69);
            this.txtCodigoVehiculo.Name = "txtCodigoVehiculo";
            this.txtCodigoVehiculo.ReadOnly = true;
            this.txtCodigoVehiculo.Size = new System.Drawing.Size(197, 20);
            this.txtCodigoVehiculo.TabIndex = 1;
            // 
            // lbPrimerMantenimiento
            // 
            this.lbPrimerMantenimiento.AutoSize = true;
            this.lbPrimerMantenimiento.Location = new System.Drawing.Point(12, 267);
            this.lbPrimerMantenimiento.Name = "lbPrimerMantenimiento";
            this.lbPrimerMantenimiento.Size = new System.Drawing.Size(111, 13);
            this.lbPrimerMantenimiento.TabIndex = 53;
            this.lbPrimerMantenimiento.Text = "Primer Mantenimiento:";
            // 
            // lblEspecificaciones
            // 
            this.lblEspecificaciones.AutoSize = true;
            this.lblEspecificaciones.Location = new System.Drawing.Point(12, 298);
            this.lblEspecificaciones.Name = "lblEspecificaciones";
            this.lblEspecificaciones.Size = new System.Drawing.Size(90, 13);
            this.lblEspecificaciones.TabIndex = 52;
            this.lblEspecificaciones.Text = "Especificaciones:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(12, 167);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 51;
            this.lblColor.Text = "Color:";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(12, 201);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(79, 13);
            this.lblPrecioUnitario.TabIndex = 50;
            this.lblPrecioUnitario.Text = "Precio Unitario:";
            // 
            // lblGarantia
            // 
            this.lblGarantia.AutoSize = true;
            this.lblGarantia.Location = new System.Drawing.Point(12, 231);
            this.lblGarantia.Name = "lblGarantia";
            this.lblGarantia.Size = new System.Drawing.Size(52, 13);
            this.lblGarantia.TabIndex = 49;
            this.lblGarantia.Text = "Garantía:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(12, 134);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 48;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(12, 103);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 47;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCodVehiculo
            // 
            this.lblCodVehiculo.AutoSize = true;
            this.lblCodVehiculo.Location = new System.Drawing.Point(12, 72);
            this.lblCodVehiculo.Name = "lblCodVehiculo";
            this.lblCodVehiculo.Size = new System.Drawing.Size(89, 13);
            this.lblCodVehiculo.TabIndex = 46;
            this.lblCodVehiculo.Text = "Código Vehículo:";
            // 
            // btRefrescarFormulario
            // 
            this.btRefrescarFormulario.Image = global::CapaPresentacion.Properties.Resources.refresh;
            this.btRefrescarFormulario.Location = new System.Drawing.Point(727, 3);
            this.btRefrescarFormulario.Name = "btRefrescarFormulario";
            this.btRefrescarFormulario.Size = new System.Drawing.Size(37, 27);
            this.btRefrescarFormulario.TabIndex = 110;
            this.btRefrescarFormulario.UseVisualStyleBackColor = true;
            this.btRefrescarFormulario.Click += new System.EventHandler(this.btRefrescarFormulario_Click);
            // 
            // frmVehiculoNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 418);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btLimpiarFormulario);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.txtEspecificaciones);
            this.Controls.Add(this.txtPrimerMantenimiento);
            this.Controls.Add(this.txtGarantia);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtCodigoVehiculo);
            this.Controls.Add(this.lbPrimerMantenimiento);
            this.Controls.Add(this.lblEspecificaciones);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblPrecioUnitario);
            this.Controls.Add(this.lblGarantia);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCodVehiculo);
            this.Controls.Add(this.dgvListaVehiculosNuevos);
            this.Controls.Add(this.pnListaVehiculos);
            this.Controls.Add(this.pnVehiculos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVehiculoNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehículos Nuevos";
            this.Load += new System.EventHandler(this.frmVehiculoNuevo_Load);
            this.pnVehiculos.ResumeLayout(false);
            this.pnVehiculos.PerformLayout();
            this.pnListaVehiculos.ResumeLayout(false);
            this.pnListaVehiculos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVehiculosNuevos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnVehiculos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnListaVehiculos;
        private System.Windows.Forms.Label lblListaVehiculo;
        private System.Windows.Forms.DataGridView dgvListaVehiculosNuevos;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btLimpiarFormulario;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.TextBox txtEspecificaciones;
        private System.Windows.Forms.TextBox txtPrimerMantenimiento;
        private System.Windows.Forms.TextBox txtGarantia;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtCodigoVehiculo;
        private System.Windows.Forms.Label lbPrimerMantenimiento;
        private System.Windows.Forms.Label lblEspecificaciones;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblGarantia;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCodVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_vehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn garantia;
        private System.Windows.Forms.DataGridViewTextBoxColumn primer_mantenimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn especificaciones;
        private System.Windows.Forms.ToolTip ttbtAgregar;
        private System.Windows.Forms.ToolTip ttbtActualizar;
        private System.Windows.Forms.ToolTip ttbtEliminar;
        private System.Windows.Forms.ToolTip ttbtLimpiar;
        private System.Windows.Forms.Button btRefrescarFormulario;
        private System.Windows.Forms.ToolTip ttbtRefrescarFormulario;
    }
}
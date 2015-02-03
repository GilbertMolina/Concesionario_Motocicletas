namespace CapaPresentacion
{
    partial class frmServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServicios));
            this.btActualizar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btLimpiarFormulario = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtCodigoServicio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCodMecánico = new System.Windows.Forms.Label();
            this.lblCodServicio = new System.Windows.Forms.Label();
            this.dgvListaServicios = new System.Windows.Forms.DataGridView();
            this.cod_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnListaProveedores = new System.Windows.Forms.Panel();
            this.lblListaProveedores = new System.Windows.Forms.Label();
            this.pnProveedores = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbMecanicos = new System.Windows.Forms.ComboBox();
            this.ttbtAgregar = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtActualizar = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtEliminar = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtLimpiar = new System.Windows.Forms.ToolTip(this.components);
            this.btRefrescarFormulario = new System.Windows.Forms.Button();
            this.ttbtRefrescarFormulario = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaServicios)).BeginInit();
            this.pnListaProveedores.SuspendLayout();
            this.pnProveedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // btActualizar
            // 
            this.btActualizar.Image = global::CapaPresentacion.Properties.Resources.edit;
            this.btActualizar.Location = new System.Drawing.Point(185, 273);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(37, 27);
            this.btActualizar.TabIndex = 97;
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Image = global::CapaPresentacion.Properties.Resources.delete;
            this.btEliminar.Location = new System.Drawing.Point(239, 273);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(37, 27);
            this.btEliminar.TabIndex = 98;
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btLimpiarFormulario
            // 
            this.btLimpiarFormulario.Image = global::CapaPresentacion.Properties.Resources.clean;
            this.btLimpiarFormulario.Location = new System.Drawing.Point(289, 273);
            this.btLimpiarFormulario.Name = "btLimpiarFormulario";
            this.btLimpiarFormulario.Size = new System.Drawing.Size(37, 27);
            this.btLimpiarFormulario.TabIndex = 99;
            this.btLimpiarFormulario.UseVisualStyleBackColor = true;
            this.btLimpiarFormulario.Click += new System.EventHandler(this.btLimpiarFormulario_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Image = global::CapaPresentacion.Properties.Resources.add;
            this.btAgregar.Location = new System.Drawing.Point(129, 273);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(37, 27);
            this.btAgregar.TabIndex = 96;
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AllowDrop = true;
            this.txtDescripcion.Location = new System.Drawing.Point(129, 198);
            this.txtDescripcion.MaxLength = 90;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(197, 66);
            this.txtDescripcion.TabIndex = 95;
            // 
            // txtPrecio
            // 
            this.txtPrecio.AllowDrop = true;
            this.txtPrecio.Location = new System.Drawing.Point(129, 164);
            this.txtPrecio.MaxLength = 12;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(197, 20);
            this.txtPrecio.TabIndex = 94;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracter_KeyPress);
            // 
            // txtTipo
            // 
            this.txtTipo.AllowDrop = true;
            this.txtTipo.Location = new System.Drawing.Point(129, 135);
            this.txtTipo.MaxLength = 45;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(197, 20);
            this.txtTipo.TabIndex = 93;
            // 
            // txtCodigoServicio
            // 
            this.txtCodigoServicio.Location = new System.Drawing.Point(129, 69);
            this.txtCodigoServicio.Name = "txtCodigoServicio";
            this.txtCodigoServicio.ReadOnly = true;
            this.txtCodigoServicio.Size = new System.Drawing.Size(197, 20);
            this.txtCodigoServicio.TabIndex = 75;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(13, 167);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 90;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(13, 201);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 89;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblCodMecánico
            // 
            this.lblCodMecánico.AutoSize = true;
            this.lblCodMecánico.Location = new System.Drawing.Point(13, 103);
            this.lblCodMecánico.Name = "lblCodMecánico";
            this.lblCodMecánico.Size = new System.Drawing.Size(112, 13);
            this.lblCodMecánico.TabIndex = 88;
            this.lblCodMecánico.Text = "Mecánico Encargado:";
            // 
            // lblCodServicio
            // 
            this.lblCodServicio.AutoSize = true;
            this.lblCodServicio.Location = new System.Drawing.Point(13, 72);
            this.lblCodServicio.Name = "lblCodServicio";
            this.lblCodServicio.Size = new System.Drawing.Size(84, 13);
            this.lblCodServicio.TabIndex = 87;
            this.lblCodServicio.Text = "Código Servicio:";
            // 
            // dgvListaServicios
            // 
            this.dgvListaServicios.AllowUserToAddRows = false;
            this.dgvListaServicios.AllowUserToDeleteRows = false;
            this.dgvListaServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaServicios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaServicios.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvListaServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_servicio,
            this.Cod_Empleado,
            this.tipo,
            this.Precio,
            this.descripcion});
            this.dgvListaServicios.Location = new System.Drawing.Point(339, 99);
            this.dgvListaServicios.Name = "dgvListaServicios";
            this.dgvListaServicios.ReadOnly = true;
            this.dgvListaServicios.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaServicios.Size = new System.Drawing.Size(521, 201);
            this.dgvListaServicios.TabIndex = 85;
            this.dgvListaServicios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaServicios_CellClick);
            // 
            // cod_servicio
            // 
            this.cod_servicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cod_servicio.HeaderText = "Cod. Servicio";
            this.cod_servicio.Name = "cod_servicio";
            this.cod_servicio.ReadOnly = true;
            this.cod_servicio.Width = 87;
            // 
            // Cod_Empleado
            // 
            this.Cod_Empleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cod_Empleado.HeaderText = "Empleado Encargado";
            this.Cod_Empleado.Name = "Cod_Empleado";
            this.Cod_Empleado.ReadOnly = true;
            this.Cod_Empleado.Width = 123;
            // 
            // tipo
            // 
            this.tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 53;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 62;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 88;
            // 
            // pnListaProveedores
            // 
            this.pnListaProveedores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnListaProveedores.Controls.Add(this.btRefrescarFormulario);
            this.pnListaProveedores.Controls.Add(this.lblListaProveedores);
            this.pnListaProveedores.Location = new System.Drawing.Point(339, 61);
            this.pnListaProveedores.Name = "pnListaProveedores";
            this.pnListaProveedores.Size = new System.Drawing.Size(521, 37);
            this.pnListaProveedores.TabIndex = 86;
            // 
            // lblListaProveedores
            // 
            this.lblListaProveedores.AutoSize = true;
            this.lblListaProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaProveedores.Location = new System.Drawing.Point(233, 7);
            this.lblListaProveedores.Name = "lblListaProveedores";
            this.lblListaProveedores.Size = new System.Drawing.Size(100, 15);
            this.lblListaProveedores.TabIndex = 2;
            this.lblListaProveedores.Text = "Lista Servicios";
            // 
            // pnProveedores
            // 
            this.pnProveedores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnProveedores.Controls.Add(this.lblTitulo);
            this.pnProveedores.Location = new System.Drawing.Point(0, 0);
            this.pnProveedores.Name = "pnProveedores";
            this.pnProveedores.Size = new System.Drawing.Size(860, 60);
            this.pnProveedores.TabIndex = 80;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(393, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(109, 25);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Servicios";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(13, 138);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 91;
            this.lblTipo.Text = "Tipo:";
            // 
            // cbMecanicos
            // 
            this.cbMecanicos.FormattingEnabled = true;
            this.cbMecanicos.Location = new System.Drawing.Point(129, 100);
            this.cbMecanicos.Name = "cbMecanicos";
            this.cbMecanicos.Size = new System.Drawing.Size(197, 21);
            this.cbMecanicos.TabIndex = 92;
            this.cbMecanicos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracter_KeyPress);
            // 
            // btRefrescarFormulario
            // 
            this.btRefrescarFormulario.Image = global::CapaPresentacion.Properties.Resources.refresh;
            this.btRefrescarFormulario.Location = new System.Drawing.Point(479, 3);
            this.btRefrescarFormulario.Name = "btRefrescarFormulario";
            this.btRefrescarFormulario.Size = new System.Drawing.Size(37, 27);
            this.btRefrescarFormulario.TabIndex = 110;
            this.btRefrescarFormulario.UseVisualStyleBackColor = true;
            this.btRefrescarFormulario.Click += new System.EventHandler(this.btRefrescarFormulario_Click);
            // 
            // frmServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 316);
            this.Controls.Add(this.cbMecanicos);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btLimpiarFormulario);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtCodigoServicio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCodMecánico);
            this.Controls.Add(this.lblCodServicio);
            this.Controls.Add(this.dgvListaServicios);
            this.Controls.Add(this.pnListaProveedores);
            this.Controls.Add(this.pnProveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmServicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicios";
            this.Load += new System.EventHandler(this.frmServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaServicios)).EndInit();
            this.pnListaProveedores.ResumeLayout(false);
            this.pnListaProveedores.PerformLayout();
            this.pnProveedores.ResumeLayout(false);
            this.pnProveedores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btLimpiarFormulario;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtCodigoServicio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCodMecánico;
        private System.Windows.Forms.Label lblCodServicio;
        private System.Windows.Forms.DataGridView dgvListaServicios;
        private System.Windows.Forms.Panel pnListaProveedores;
        private System.Windows.Forms.Label lblListaProveedores;
        private System.Windows.Forms.Panel pnProveedores;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbMecanicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.ToolTip ttbtAgregar;
        private System.Windows.Forms.ToolTip ttbtActualizar;
        private System.Windows.Forms.ToolTip ttbtEliminar;
        private System.Windows.Forms.ToolTip ttbtLimpiar;
        private System.Windows.Forms.Button btRefrescarFormulario;
        private System.Windows.Forms.ToolTip ttbtRefrescarFormulario;
    }
}
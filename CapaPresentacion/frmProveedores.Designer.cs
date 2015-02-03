namespace CapaPresentacion
{
    partial class frmProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedores));
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedulaJuridica = new System.Windows.Forms.TextBox();
            this.txtCodigoProveedor = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCedulaJuridica = new System.Windows.Forms.Label();
            this.lblCodProveedor = new System.Windows.Forms.Label();
            this.dgvListaProveedores = new System.Windows.Forms.DataGridView();
            this.cod_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula_Juridica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razon_Social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnListaProveedores = new System.Windows.Forms.Panel();
            this.lblListaProveedores = new System.Windows.Forms.Label();
            this.pnProveedores = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btLimpiarFormulario = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.ttbtAgregar = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtActualizar = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtEliminar = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtLimpiar = new System.Windows.Forms.ToolTip(this.components);
            this.btRefrescarFormulario = new System.Windows.Forms.Button();
            this.ttbtRefrescarFormulario = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProveedores)).BeginInit();
            this.pnListaProveedores.SuspendLayout();
            this.pnProveedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AllowDrop = true;
            this.txtDescripcion.Location = new System.Drawing.Point(145, 198);
            this.txtDescripcion.MaxLength = 190;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(197, 66);
            this.txtDescripcion.TabIndex = 79;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.AllowDrop = true;
            this.txtRazonSocial.Location = new System.Drawing.Point(145, 164);
            this.txtRazonSocial.MaxLength = 190;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(197, 20);
            this.txtRazonSocial.TabIndex = 78;
            // 
            // txtNombre
            // 
            this.txtNombre.AllowDrop = true;
            this.txtNombre.Location = new System.Drawing.Point(145, 131);
            this.txtNombre.MaxLength = 45;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(197, 20);
            this.txtNombre.TabIndex = 77;
            // 
            // txtCedulaJuridica
            // 
            this.txtCedulaJuridica.AllowDrop = true;
            this.txtCedulaJuridica.Location = new System.Drawing.Point(145, 100);
            this.txtCedulaJuridica.MaxLength = 45;
            this.txtCedulaJuridica.Name = "txtCedulaJuridica";
            this.txtCedulaJuridica.Size = new System.Drawing.Size(197, 20);
            this.txtCedulaJuridica.TabIndex = 76;
            this.txtCedulaJuridica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracter_KeyPress);
            // 
            // txtCodigoProveedor
            // 
            this.txtCodigoProveedor.Location = new System.Drawing.Point(145, 69);
            this.txtCodigoProveedor.Name = "txtCodigoProveedor";
            this.txtCodigoProveedor.ReadOnly = true;
            this.txtCodigoProveedor.Size = new System.Drawing.Size(197, 20);
            this.txtCodigoProveedor.TabIndex = 75;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(13, 167);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(73, 13);
            this.lblRazonSocial.TabIndex = 91;
            this.lblRazonSocial.Text = "Razon Social:";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(13, 201);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(124, 13);
            this.lblPrecioUnitario.TabIndex = 90;
            this.lblPrecioUnitario.Text = "Descripcion del Servicio:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 134);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 89;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCedulaJuridica
            // 
            this.lblCedulaJuridica.AutoSize = true;
            this.lblCedulaJuridica.Location = new System.Drawing.Point(13, 103);
            this.lblCedulaJuridica.Name = "lblCedulaJuridica";
            this.lblCedulaJuridica.Size = new System.Drawing.Size(82, 13);
            this.lblCedulaJuridica.TabIndex = 88;
            this.lblCedulaJuridica.Text = "Cedula Juridica:";
            // 
            // lblCodProveedor
            // 
            this.lblCodProveedor.AutoSize = true;
            this.lblCodProveedor.Location = new System.Drawing.Point(13, 72);
            this.lblCodProveedor.Name = "lblCodProveedor";
            this.lblCodProveedor.Size = new System.Drawing.Size(95, 13);
            this.lblCodProveedor.TabIndex = 87;
            this.lblCodProveedor.Text = "Código Proveedor:";
            // 
            // dgvListaProveedores
            // 
            this.dgvListaProveedores.AllowUserToAddRows = false;
            this.dgvListaProveedores.AllowUserToDeleteRows = false;
            this.dgvListaProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaProveedores.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvListaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_proveedor,
            this.Cedula_Juridica,
            this.nombre,
            this.Razon_Social,
            this.descripcion_servicio});
            this.dgvListaProveedores.Location = new System.Drawing.Point(354, 99);
            this.dgvListaProveedores.Name = "dgvListaProveedores";
            this.dgvListaProveedores.ReadOnly = true;
            this.dgvListaProveedores.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaProveedores.Size = new System.Drawing.Size(534, 201);
            this.dgvListaProveedores.TabIndex = 85;
            this.dgvListaProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProveedores_CellClick);
            // 
            // cod_proveedor
            // 
            this.cod_proveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cod_proveedor.HeaderText = "Cod. Proveedor";
            this.cod_proveedor.Name = "cod_proveedor";
            this.cod_proveedor.ReadOnly = true;
            this.cod_proveedor.Width = 97;
            // 
            // Cedula_Juridica
            // 
            this.Cedula_Juridica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cedula_Juridica.HeaderText = "Cedula Jurídica";
            this.Cedula_Juridica.Name = "Cedula_Juridica";
            this.Cedula_Juridica.ReadOnly = true;
            this.Cedula_Juridica.Width = 97;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 69;
            // 
            // Razon_Social
            // 
            this.Razon_Social.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Razon_Social.HeaderText = "Razon Social";
            this.Razon_Social.Name = "Razon_Social";
            this.Razon_Social.ReadOnly = true;
            this.Razon_Social.Width = 87;
            // 
            // descripcion_servicio
            // 
            this.descripcion_servicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descripcion_servicio.HeaderText = "Descripción del Servicio";
            this.descripcion_servicio.Name = "descripcion_servicio";
            this.descripcion_servicio.ReadOnly = true;
            this.descripcion_servicio.Width = 99;
            // 
            // pnListaProveedores
            // 
            this.pnListaProveedores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnListaProveedores.Controls.Add(this.btRefrescarFormulario);
            this.pnListaProveedores.Controls.Add(this.lblListaProveedores);
            this.pnListaProveedores.Location = new System.Drawing.Point(354, 61);
            this.pnListaProveedores.Name = "pnListaProveedores";
            this.pnListaProveedores.Size = new System.Drawing.Size(534, 37);
            this.pnListaProveedores.TabIndex = 86;
            // 
            // lblListaProveedores
            // 
            this.lblListaProveedores.AutoSize = true;
            this.lblListaProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaProveedores.Location = new System.Drawing.Point(214, 8);
            this.lblListaProveedores.Name = "lblListaProveedores";
            this.lblListaProveedores.Size = new System.Drawing.Size(122, 15);
            this.lblListaProveedores.TabIndex = 2;
            this.lblListaProveedores.Text = "Lista Proveedores";
            // 
            // pnProveedores
            // 
            this.pnProveedores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnProveedores.Controls.Add(this.lblTitulo);
            this.pnProveedores.Location = new System.Drawing.Point(0, 0);
            this.pnProveedores.Name = "pnProveedores";
            this.pnProveedores.Size = new System.Drawing.Size(888, 60);
            this.pnProveedores.TabIndex = 80;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(375, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(145, 25);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Proveedores";
            // 
            // btActualizar
            // 
            this.btActualizar.Image = global::CapaPresentacion.Properties.Resources.edit;
            this.btActualizar.Location = new System.Drawing.Point(201, 273);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(37, 27);
            this.btActualizar.TabIndex = 82;
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Image = global::CapaPresentacion.Properties.Resources.delete;
            this.btEliminar.Location = new System.Drawing.Point(255, 273);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(37, 27);
            this.btEliminar.TabIndex = 83;
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btLimpiarFormulario
            // 
            this.btLimpiarFormulario.Image = global::CapaPresentacion.Properties.Resources.clean;
            this.btLimpiarFormulario.Location = new System.Drawing.Point(305, 273);
            this.btLimpiarFormulario.Name = "btLimpiarFormulario";
            this.btLimpiarFormulario.Size = new System.Drawing.Size(37, 27);
            this.btLimpiarFormulario.TabIndex = 84;
            this.btLimpiarFormulario.UseVisualStyleBackColor = true;
            this.btLimpiarFormulario.Click += new System.EventHandler(this.btLimpiarFormulario_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Image = global::CapaPresentacion.Properties.Resources.add;
            this.btAgregar.Location = new System.Drawing.Point(145, 273);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(37, 27);
            this.btAgregar.TabIndex = 81;
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btRefrescarFormulario
            // 
            this.btRefrescarFormulario.Image = global::CapaPresentacion.Properties.Resources.refresh;
            this.btRefrescarFormulario.Location = new System.Drawing.Point(492, 4);
            this.btRefrescarFormulario.Name = "btRefrescarFormulario";
            this.btRefrescarFormulario.Size = new System.Drawing.Size(37, 27);
            this.btRefrescarFormulario.TabIndex = 110;
            this.btRefrescarFormulario.UseVisualStyleBackColor = true;
            this.btRefrescarFormulario.Click += new System.EventHandler(this.btRefrescarFormulario_Click);
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 323);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btLimpiarFormulario);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCedulaJuridica);
            this.Controls.Add(this.txtCodigoProveedor);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.lblPrecioUnitario);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCedulaJuridica);
            this.Controls.Add(this.lblCodProveedor);
            this.Controls.Add(this.dgvListaProveedores);
            this.Controls.Add(this.pnListaProveedores);
            this.Controls.Add(this.pnProveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProveedores)).EndInit();
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
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCedulaJuridica;
        private System.Windows.Forms.TextBox txtCodigoProveedor;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCedulaJuridica;
        private System.Windows.Forms.Label lblCodProveedor;
        private System.Windows.Forms.DataGridView dgvListaProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula_Juridica;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razon_Social;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_servicio;
        private System.Windows.Forms.Panel pnListaProveedores;
        private System.Windows.Forms.Label lblListaProveedores;
        private System.Windows.Forms.Panel pnProveedores;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ToolTip ttbtAgregar;
        private System.Windows.Forms.ToolTip ttbtActualizar;
        private System.Windows.Forms.ToolTip ttbtEliminar;
        private System.Windows.Forms.ToolTip ttbtLimpiar;
        private System.Windows.Forms.Button btRefrescarFormulario;
        private System.Windows.Forms.ToolTip ttbtRefrescarFormulario;
    }
}
namespace CapaPresentacion
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.dgvListaClientes = new System.Windows.Forms.DataGridView();
            this.cod_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnListaProveedores = new System.Windows.Forms.Panel();
            this.lblListaClientes = new System.Windows.Forms.Label();
            this.pnProveedores = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lblciudad = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).BeginInit();
            this.pnListaProveedores.SuspendLayout();
            this.pnProveedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtApellidos
            // 
            this.txtApellidos.AllowDrop = true;
            this.txtApellidos.Location = new System.Drawing.Point(96, 160);
            this.txtApellidos.MaxLength = 45;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(197, 20);
            this.txtApellidos.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.AllowDrop = true;
            this.txtNombre.Location = new System.Drawing.Point(96, 127);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(197, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtCedula
            // 
            this.txtCedula.AllowDrop = true;
            this.txtCedula.Location = new System.Drawing.Point(96, 96);
            this.txtCedula.MaxLength = 40;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(197, 20);
            this.txtCedula.TabIndex = 2;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracter_KeyPress);
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Location = new System.Drawing.Point(96, 65);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.ReadOnly = true;
            this.txtCodigoCliente.Size = new System.Drawing.Size(197, 20);
            this.txtCodigoCliente.TabIndex = 1;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(12, 163);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(52, 13);
            this.lblApellidos.TabIndex = 91;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(12, 197);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(52, 13);
            this.lblPrecioUnitario.TabIndex = 90;
            this.lblPrecioUnitario.Text = "Telefono:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 130);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 89;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(12, 99);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(43, 13);
            this.lblCedula.TabIndex = 88;
            this.lblCedula.Text = "Cedula:";
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.Location = new System.Drawing.Point(12, 68);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(78, 13);
            this.lblCodCliente.TabIndex = 87;
            this.lblCodCliente.Text = "Código Cliente:";
            // 
            // dgvListaClientes
            // 
            this.dgvListaClientes.AllowUserToAddRows = false;
            this.dgvListaClientes.AllowUserToDeleteRows = false;
            this.dgvListaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaClientes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_cliente,
            this.Cedula,
            this.nombre,
            this.Apellidos,
            this.telefono,
            this.direccion,
            this.ciudad});
            this.dgvListaClientes.Location = new System.Drawing.Point(305, 99);
            this.dgvListaClientes.Name = "dgvListaClientes";
            this.dgvListaClientes.ReadOnly = true;
            this.dgvListaClientes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaClientes.Size = new System.Drawing.Size(565, 222);
            this.dgvListaClientes.TabIndex = 12;
            this.dgvListaClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaClientes_CellClick);
            // 
            // cod_cliente
            // 
            this.cod_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cod_cliente.HeaderText = "Cod. Cliente";
            this.cod_cliente.Name = "cod_cliente";
            this.cod_cliente.ReadOnly = true;
            this.cod_cliente.Width = 89;
            // 
            // Cedula
            // 
            this.Cedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cedula.HeaderText = "Cedula ";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            this.Cedula.Width = 68;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 69;
            // 
            // Apellidos
            // 
            this.Apellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 74;
            // 
            // telefono
            // 
            this.telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 74;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 77;
            // 
            // ciudad
            // 
            this.ciudad.HeaderText = "Ciudad";
            this.ciudad.Name = "ciudad";
            this.ciudad.ReadOnly = true;
            this.ciudad.Width = 65;
            // 
            // pnListaProveedores
            // 
            this.pnListaProveedores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnListaProveedores.Controls.Add(this.btRefrescarFormulario);
            this.pnListaProveedores.Controls.Add(this.lblListaClientes);
            this.pnListaProveedores.Location = new System.Drawing.Point(305, 61);
            this.pnListaProveedores.Name = "pnListaProveedores";
            this.pnListaProveedores.Size = new System.Drawing.Size(565, 37);
            this.pnListaProveedores.TabIndex = 86;
            // 
            // lblListaClientes
            // 
            this.lblListaClientes.AutoSize = true;
            this.lblListaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaClientes.Location = new System.Drawing.Point(245, 9);
            this.lblListaClientes.Name = "lblListaClientes";
            this.lblListaClientes.Size = new System.Drawing.Size(94, 15);
            this.lblListaClientes.TabIndex = 2;
            this.lblListaClientes.Text = "Lista Clientes";
            // 
            // pnProveedores
            // 
            this.pnProveedores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnProveedores.Controls.Add(this.lblTitulo);
            this.pnProveedores.Location = new System.Drawing.Point(0, 0);
            this.pnProveedores.Name = "pnProveedores";
            this.pnProveedores.Size = new System.Drawing.Size(870, 60);
            this.pnProveedores.TabIndex = 75;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(393, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(98, 25);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Clientes";
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Location = new System.Drawing.Point(12, 229);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(55, 13);
            this.lbldireccion.TabIndex = 92;
            this.lbldireccion.Text = "Direccion:";
            // 
            // lblciudad
            // 
            this.lblciudad.AutoSize = true;
            this.lblciudad.Location = new System.Drawing.Point(12, 261);
            this.lblciudad.Name = "lblciudad";
            this.lblciudad.Size = new System.Drawing.Size(46, 13);
            this.lblciudad.TabIndex = 93;
            this.lblciudad.Text = "Ciudad: ";
            // 
            // txtTelefono
            // 
            this.txtTelefono.AllowDrop = true;
            this.txtTelefono.Location = new System.Drawing.Point(96, 194);
            this.txtTelefono.MaxLength = 8;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(197, 20);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracter_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.AllowDrop = true;
            this.txtDireccion.Location = new System.Drawing.Point(96, 226);
            this.txtDireccion.MaxLength = 190;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(197, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtCiudad
            // 
            this.txtCiudad.AllowDrop = true;
            this.txtCiudad.Location = new System.Drawing.Point(96, 258);
            this.txtCiudad.MaxLength = 45;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(197, 20);
            this.txtCiudad.TabIndex = 7;
            // 
            // btActualizar
            // 
            this.btActualizar.Image = global::CapaPresentacion.Properties.Resources.edit;
            this.btActualizar.Location = new System.Drawing.Point(152, 294);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(37, 27);
            this.btActualizar.TabIndex = 9;
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Image = global::CapaPresentacion.Properties.Resources.delete;
            this.btEliminar.Location = new System.Drawing.Point(206, 294);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(37, 27);
            this.btEliminar.TabIndex = 10;
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btLimpiarFormulario
            // 
            this.btLimpiarFormulario.Image = global::CapaPresentacion.Properties.Resources.clean;
            this.btLimpiarFormulario.Location = new System.Drawing.Point(256, 294);
            this.btLimpiarFormulario.Name = "btLimpiarFormulario";
            this.btLimpiarFormulario.Size = new System.Drawing.Size(37, 27);
            this.btLimpiarFormulario.TabIndex = 11;
            this.btLimpiarFormulario.UseVisualStyleBackColor = true;
            this.btLimpiarFormulario.Click += new System.EventHandler(this.btLimpiarFormulario_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Image = global::CapaPresentacion.Properties.Resources.add;
            this.btAgregar.Location = new System.Drawing.Point(96, 294);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(37, 27);
            this.btAgregar.TabIndex = 8;
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btRefrescarFormulario
            // 
            this.btRefrescarFormulario.Image = global::CapaPresentacion.Properties.Resources.refresh;
            this.btRefrescarFormulario.Location = new System.Drawing.Point(523, 4);
            this.btRefrescarFormulario.Name = "btRefrescarFormulario";
            this.btRefrescarFormulario.Size = new System.Drawing.Size(37, 27);
            this.btRefrescarFormulario.TabIndex = 110;
            this.btRefrescarFormulario.UseVisualStyleBackColor = true;
            this.btRefrescarFormulario.Click += new System.EventHandler(this.btRefrescarFormulario_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 332);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblciudad);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btLimpiarFormulario);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtCodigoCliente);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblPrecioUnitario);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblCodCliente);
            this.Controls.Add(this.dgvListaClientes);
            this.Controls.Add(this.pnListaProveedores);
            this.Controls.Add(this.pnProveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).EndInit();
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
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblCodCliente;
        private System.Windows.Forms.DataGridView dgvListaClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad;
        private System.Windows.Forms.Panel pnListaProveedores;
        private System.Windows.Forms.Label lblListaClientes;
        private System.Windows.Forms.Panel pnProveedores;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lblciudad;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.ToolTip ttbtAgregar;
        private System.Windows.Forms.ToolTip ttbtActualizar;
        private System.Windows.Forms.ToolTip ttbtEliminar;
        private System.Windows.Forms.ToolTip ttbtLimpiar;
        private System.Windows.Forms.Button btRefrescarFormulario;
        private System.Windows.Forms.ToolTip ttbtRefrescarFormulario;
    }
}
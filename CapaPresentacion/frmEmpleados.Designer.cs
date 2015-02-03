namespace CapaPresentacion
{
    partial class frmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleados));
            this.txtFecha_Contrato = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.lbSalario = new System.Windows.Forms.Label();
            this.lblFecha_Contrato = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombreDepartamento = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblCodEmpleado = new System.Windows.Forms.Label();
            this.dgvListaEmpleados = new System.Windows.Forms.DataGridView();
            this.cod_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_despido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnListaVehiculos = new System.Windows.Forms.Panel();
            this.rbEmpleadosInactivos = new System.Windows.Forms.RadioButton();
            this.rbEmpleadosActivos = new System.Windows.Forms.RadioButton();
            this.lblListaEmpleados = new System.Windows.Forms.Label();
            this.pnVehiculos = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtFecha_Despido = new System.Windows.Forms.TextBox();
            this.lbFecha_Despido = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.cbNombreDepartamento = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btLimpiarFormulario = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.ttbtAgregar = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtActualizar = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtEliminar = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtLimpiar = new System.Windows.Forms.ToolTip(this.components);
            this.ttrbActivos = new System.Windows.Forms.ToolTip(this.components);
            this.ttrbInactivos = new System.Windows.Forms.ToolTip(this.components);
            this.btRefrescarFormulario = new System.Windows.Forms.Button();
            this.ttbtRefrescarFormulario = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleados)).BeginInit();
            this.pnListaVehiculos.SuspendLayout();
            this.pnVehiculos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFecha_Contrato
            // 
            this.txtFecha_Contrato.AllowDrop = true;
            this.txtFecha_Contrato.Location = new System.Drawing.Point(132, 323);
            this.txtFecha_Contrato.MaxLength = 200;
            this.txtFecha_Contrato.Name = "txtFecha_Contrato";
            this.txtFecha_Contrato.ReadOnly = true;
            this.txtFecha_Contrato.Size = new System.Drawing.Size(197, 20);
            this.txtFecha_Contrato.TabIndex = 9;
            // 
            // txtSalario
            // 
            this.txtSalario.AllowDrop = true;
            this.txtSalario.Location = new System.Drawing.Point(132, 292);
            this.txtSalario.MaxLength = 12;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(197, 20);
            this.txtSalario.TabIndex = 8;
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracter_KeyPress);
            // 
            // txtCorreo
            // 
            this.txtCorreo.AllowDrop = true;
            this.txtCorreo.Location = new System.Drawing.Point(132, 227);
            this.txtCorreo.MaxLength = 35;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(197, 20);
            this.txtCorreo.TabIndex = 6;
            // 
            // txtApellidos
            // 
            this.txtApellidos.AllowDrop = true;
            this.txtApellidos.Location = new System.Drawing.Point(132, 163);
            this.txtApellidos.MaxLength = 45;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(197, 20);
            this.txtApellidos.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.AllowDrop = true;
            this.txtNombre.Location = new System.Drawing.Point(132, 130);
            this.txtNombre.MaxLength = 15;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(197, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtCedula
            // 
            this.txtCedula.AllowDrop = true;
            this.txtCedula.Location = new System.Drawing.Point(132, 99);
            this.txtCedula.MaxLength = 45;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(197, 20);
            this.txtCedula.TabIndex = 2;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracter_KeyPress);
            // 
            // txtCodigoEmpleado
            // 
            this.txtCodigoEmpleado.Location = new System.Drawing.Point(132, 68);
            this.txtCodigoEmpleado.Name = "txtCodigoEmpleado";
            this.txtCodigoEmpleado.ReadOnly = true;
            this.txtCodigoEmpleado.Size = new System.Drawing.Size(197, 20);
            this.txtCodigoEmpleado.TabIndex = 1;
            // 
            // lbSalario
            // 
            this.lbSalario.AutoSize = true;
            this.lbSalario.Location = new System.Drawing.Point(12, 292);
            this.lbSalario.Name = "lbSalario";
            this.lbSalario.Size = new System.Drawing.Size(42, 13);
            this.lbSalario.TabIndex = 76;
            this.lbSalario.Text = "Salario:";
            // 
            // lblFecha_Contrato
            // 
            this.lblFecha_Contrato.AutoSize = true;
            this.lblFecha_Contrato.Location = new System.Drawing.Point(12, 326);
            this.lblFecha_Contrato.Name = "lblFecha_Contrato";
            this.lblFecha_Contrato.Size = new System.Drawing.Size(83, 13);
            this.lblFecha_Contrato.TabIndex = 75;
            this.lblFecha_Contrato.Text = "Fecha Contrato:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(12, 166);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(52, 13);
            this.lblApellidos.TabIndex = 74;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblNombreDepartamento
            // 
            this.lblNombreDepartamento.AutoSize = true;
            this.lblNombreDepartamento.Location = new System.Drawing.Point(12, 200);
            this.lblNombreDepartamento.Name = "lblNombreDepartamento";
            this.lblNombreDepartamento.Size = new System.Drawing.Size(117, 13);
            this.lblNombreDepartamento.TabIndex = 73;
            this.lblNombreDepartamento.Text = "Nombre Departamento:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(12, 230);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(41, 13);
            this.lblCorreo.TabIndex = 72;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 133);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 71;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(12, 102);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(43, 13);
            this.lblCedula.TabIndex = 70;
            this.lblCedula.Text = "Cédula:";
            // 
            // lblCodEmpleado
            // 
            this.lblCodEmpleado.AutoSize = true;
            this.lblCodEmpleado.Location = new System.Drawing.Point(12, 71);
            this.lblCodEmpleado.Name = "lblCodEmpleado";
            this.lblCodEmpleado.Size = new System.Drawing.Size(93, 13);
            this.lblCodEmpleado.TabIndex = 69;
            this.lblCodEmpleado.Text = "Código Empleado:";
            // 
            // dgvListaEmpleados
            // 
            this.dgvListaEmpleados.AllowUserToAddRows = false;
            this.dgvListaEmpleados.AllowUserToDeleteRows = false;
            this.dgvListaEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaEmpleados.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvListaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_empleado,
            this.cedula,
            this.nombre_empleado,
            this.apellidos,
            this.nombre_departamento,
            this.telefono,
            this.correo,
            this.salario,
            this.fecha_contrato,
            this.fecha_despido,
            this.estado});
            this.dgvListaEmpleados.Location = new System.Drawing.Point(344, 99);
            this.dgvListaEmpleados.Name = "dgvListaEmpleados";
            this.dgvListaEmpleados.ReadOnly = true;
            this.dgvListaEmpleados.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaEmpleados.Size = new System.Drawing.Size(910, 352);
            this.dgvListaEmpleados.TabIndex = 16;
            this.dgvListaEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaEmpleados_CellClick);
            // 
            // cod_empleado
            // 
            this.cod_empleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cod_empleado.HeaderText = "Cod. Empleado";
            this.cod_empleado.Name = "cod_empleado";
            this.cod_empleado.ReadOnly = true;
            this.cod_empleado.Width = 96;
            // 
            // cedula
            // 
            this.cedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cedula.HeaderText = "Cédula";
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            this.cedula.Width = 65;
            // 
            // nombre_empleado
            // 
            this.nombre_empleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombre_empleado.HeaderText = "Nombre";
            this.nombre_empleado.Name = "nombre_empleado";
            this.nombre_empleado.ReadOnly = true;
            this.nombre_empleado.Width = 69;
            // 
            // apellidos
            // 
            this.apellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.apellidos.HeaderText = "Apellidos";
            this.apellidos.Name = "apellidos";
            this.apellidos.ReadOnly = true;
            this.apellidos.Width = 74;
            // 
            // nombre_departamento
            // 
            this.nombre_departamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombre_departamento.HeaderText = "Nombre Departamento";
            this.nombre_departamento.Name = "nombre_departamento";
            this.nombre_departamento.ReadOnly = true;
            this.nombre_departamento.Width = 127;
            // 
            // telefono
            // 
            this.telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 74;
            // 
            // correo
            // 
            this.correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            this.correo.Width = 63;
            // 
            // salario
            // 
            this.salario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.salario.HeaderText = "Salario";
            this.salario.Name = "salario";
            this.salario.ReadOnly = true;
            this.salario.Width = 64;
            // 
            // fecha_contrato
            // 
            this.fecha_contrato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fecha_contrato.HeaderText = "Fecha Contrato";
            this.fecha_contrato.Name = "fecha_contrato";
            this.fecha_contrato.ReadOnly = true;
            this.fecha_contrato.Width = 96;
            // 
            // fecha_despido
            // 
            this.fecha_despido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fecha_despido.HeaderText = "Fecha Despido";
            this.fecha_despido.Name = "fecha_despido";
            this.fecha_despido.ReadOnly = true;
            this.fecha_despido.Width = 96;
            // 
            // estado
            // 
            this.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 65;
            // 
            // pnListaVehiculos
            // 
            this.pnListaVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnListaVehiculos.Controls.Add(this.btRefrescarFormulario);
            this.pnListaVehiculos.Controls.Add(this.rbEmpleadosInactivos);
            this.pnListaVehiculos.Controls.Add(this.rbEmpleadosActivos);
            this.pnListaVehiculos.Controls.Add(this.lblListaEmpleados);
            this.pnListaVehiculos.Location = new System.Drawing.Point(344, 61);
            this.pnListaVehiculos.Name = "pnListaVehiculos";
            this.pnListaVehiculos.Size = new System.Drawing.Size(910, 37);
            this.pnListaVehiculos.TabIndex = 68;
            // 
            // rbEmpleadosInactivos
            // 
            this.rbEmpleadosInactivos.AutoSize = true;
            this.rbEmpleadosInactivos.Location = new System.Drawing.Point(79, 9);
            this.rbEmpleadosInactivos.Name = "rbEmpleadosInactivos";
            this.rbEmpleadosInactivos.Size = new System.Drawing.Size(68, 17);
            this.rbEmpleadosInactivos.TabIndex = 4;
            this.rbEmpleadosInactivos.TabStop = true;
            this.rbEmpleadosInactivos.Text = "Inactivos";
            this.rbEmpleadosInactivos.UseVisualStyleBackColor = true;
            this.rbEmpleadosInactivos.Click += new System.EventHandler(this.rbEmpleadosInactivos_Click);
            // 
            // rbEmpleadosActivos
            // 
            this.rbEmpleadosActivos.AutoSize = true;
            this.rbEmpleadosActivos.Location = new System.Drawing.Point(13, 9);
            this.rbEmpleadosActivos.Name = "rbEmpleadosActivos";
            this.rbEmpleadosActivos.Size = new System.Drawing.Size(60, 17);
            this.rbEmpleadosActivos.TabIndex = 3;
            this.rbEmpleadosActivos.TabStop = true;
            this.rbEmpleadosActivos.Text = "Activos";
            this.rbEmpleadosActivos.UseVisualStyleBackColor = true;
            this.rbEmpleadosActivos.Click += new System.EventHandler(this.rbEmpleadosActivos_Click);
            // 
            // lblListaEmpleados
            // 
            this.lblListaEmpleados.AutoSize = true;
            this.lblListaEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaEmpleados.Location = new System.Drawing.Point(413, 9);
            this.lblListaEmpleados.Name = "lblListaEmpleados";
            this.lblListaEmpleados.Size = new System.Drawing.Size(114, 15);
            this.lblListaEmpleados.TabIndex = 2;
            this.lblListaEmpleados.Text = "Lista Empleados";
            // 
            // pnVehiculos
            // 
            this.pnVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnVehiculos.Controls.Add(this.lblTitulo);
            this.pnVehiculos.Location = new System.Drawing.Point(0, 0);
            this.pnVehiculos.Name = "pnVehiculos";
            this.pnVehiculos.Size = new System.Drawing.Size(1254, 60);
            this.pnVehiculos.TabIndex = 54;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(568, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(128, 25);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Empleados";
            // 
            // txtFecha_Despido
            // 
            this.txtFecha_Despido.AllowDrop = true;
            this.txtFecha_Despido.Location = new System.Drawing.Point(132, 355);
            this.txtFecha_Despido.MaxLength = 200;
            this.txtFecha_Despido.Name = "txtFecha_Despido";
            this.txtFecha_Despido.ReadOnly = true;
            this.txtFecha_Despido.Size = new System.Drawing.Size(197, 20);
            this.txtFecha_Despido.TabIndex = 10;
            // 
            // lbFecha_Despido
            // 
            this.lbFecha_Despido.AutoSize = true;
            this.lbFecha_Despido.Location = new System.Drawing.Point(12, 358);
            this.lbFecha_Despido.Name = "lbFecha_Despido";
            this.lbFecha_Despido.Size = new System.Drawing.Size(82, 13);
            this.lbFecha_Despido.TabIndex = 78;
            this.lbFecha_Despido.Text = "Fecha Despido:";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(12, 393);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(43, 13);
            this.lbEstado.TabIndex = 80;
            this.lbEstado.Text = "Estado:";
            // 
            // cbNombreDepartamento
            // 
            this.cbNombreDepartamento.FormattingEnabled = true;
            this.cbNombreDepartamento.Location = new System.Drawing.Point(132, 197);
            this.cbNombreDepartamento.MaxLength = 10;
            this.cbNombreDepartamento.Name = "cbNombreDepartamento";
            this.cbNombreDepartamento.Size = new System.Drawing.Size(197, 21);
            this.cbNombreDepartamento.TabIndex = 5;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(132, 390);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(197, 21);
            this.cbEstado.TabIndex = 11;
            this.cbEstado.SelectedValueChanged += new System.EventHandler(this.cbEstado_SelectedValueChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.AllowDrop = true;
            this.txtTelefono.Location = new System.Drawing.Point(132, 258);
            this.txtTelefono.MaxLength = 8;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(197, 20);
            this.txtTelefono.TabIndex = 7;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracter_KeyPress);
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(12, 261);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(52, 13);
            this.lbTelefono.TabIndex = 82;
            this.lbTelefono.Text = "Teléfono:";
            // 
            // btEliminar
            // 
            this.btEliminar.Image = global::CapaPresentacion.Properties.Resources.delete;
            this.btEliminar.Location = new System.Drawing.Point(239, 424);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(37, 27);
            this.btEliminar.TabIndex = 14;
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btActualizar
            // 
            this.btActualizar.Image = global::CapaPresentacion.Properties.Resources.edit;
            this.btActualizar.Location = new System.Drawing.Point(186, 424);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(37, 27);
            this.btActualizar.TabIndex = 13;
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btLimpiarFormulario
            // 
            this.btLimpiarFormulario.Image = global::CapaPresentacion.Properties.Resources.clean;
            this.btLimpiarFormulario.Location = new System.Drawing.Point(292, 424);
            this.btLimpiarFormulario.Name = "btLimpiarFormulario";
            this.btLimpiarFormulario.Size = new System.Drawing.Size(37, 27);
            this.btLimpiarFormulario.TabIndex = 15;
            this.btLimpiarFormulario.UseVisualStyleBackColor = true;
            this.btLimpiarFormulario.Click += new System.EventHandler(this.btLimpiarFormulario_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Image = global::CapaPresentacion.Properties.Resources.add;
            this.btAgregar.Location = new System.Drawing.Point(132, 424);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(37, 27);
            this.btAgregar.TabIndex = 12;
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btRefrescarFormulario
            // 
            this.btRefrescarFormulario.Image = global::CapaPresentacion.Properties.Resources.refresh;
            this.btRefrescarFormulario.Location = new System.Drawing.Point(868, 5);
            this.btRefrescarFormulario.Name = "btRefrescarFormulario";
            this.btRefrescarFormulario.Size = new System.Drawing.Size(37, 27);
            this.btRefrescarFormulario.TabIndex = 110;
            this.btRefrescarFormulario.UseVisualStyleBackColor = true;
            this.btRefrescarFormulario.Click += new System.EventHandler(this.btRefrescarFormulario_Click);
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 463);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.cbNombreDepartamento);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.txtFecha_Despido);
            this.Controls.Add(this.lbFecha_Despido);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btLimpiarFormulario);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.txtFecha_Contrato);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtCodigoEmpleado);
            this.Controls.Add(this.lbSalario);
            this.Controls.Add(this.lblFecha_Contrato);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombreDepartamento);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblCodEmpleado);
            this.Controls.Add(this.dgvListaEmpleados);
            this.Controls.Add(this.pnListaVehiculos);
            this.Controls.Add(this.pnVehiculos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleados)).EndInit();
            this.pnListaVehiculos.ResumeLayout(false);
            this.pnListaVehiculos.PerformLayout();
            this.pnVehiculos.ResumeLayout(false);
            this.pnVehiculos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btLimpiarFormulario;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.TextBox txtFecha_Contrato;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtCodigoEmpleado;
        private System.Windows.Forms.Label lbSalario;
        private System.Windows.Forms.Label lblFecha_Contrato;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombreDepartamento;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblCodEmpleado;
        private System.Windows.Forms.DataGridView dgvListaEmpleados;
        private System.Windows.Forms.Panel pnListaVehiculos;
        private System.Windows.Forms.Label lblListaEmpleados;
        private System.Windows.Forms.Panel pnVehiculos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtFecha_Despido;
        private System.Windows.Forms.Label lbFecha_Despido;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.ComboBox cbNombreDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_despido;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.RadioButton rbEmpleadosInactivos;
        private System.Windows.Forms.RadioButton rbEmpleadosActivos;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.ToolTip ttbtAgregar;
        private System.Windows.Forms.ToolTip ttbtActualizar;
        private System.Windows.Forms.ToolTip ttbtEliminar;
        private System.Windows.Forms.ToolTip ttbtLimpiar;
        private System.Windows.Forms.ToolTip ttrbActivos;
        private System.Windows.Forms.ToolTip ttrbInactivos;
        private System.Windows.Forms.Button btRefrescarFormulario;
        private System.Windows.Forms.ToolTip ttbtRefrescarFormulario;
    }
}
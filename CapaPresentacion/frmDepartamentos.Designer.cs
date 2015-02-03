namespace CapaPresentacion
{
    partial class frmDepartamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartamentos));
            this.btActualizar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btLimpiarFormulario = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.txtCodAdministrador = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigoDepartamento = new System.Windows.Forms.TextBox();
            this.lblCodAdministrador = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodDepartamento = new System.Windows.Forms.Label();
            this.pnVehiculos = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnListaVehiculos = new System.Windows.Forms.Panel();
            this.lblListaDepartamentos = new System.Windows.Forms.Label();
            this.dgvListaDepartamentos = new System.Windows.Forms.DataGridView();
            this.cod_departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_administrador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_administrador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbNombreAdministrador = new System.Windows.Forms.ComboBox();
            this.lbNombreAdministrador = new System.Windows.Forms.Label();
            this.lbQuitarAdministrador = new System.Windows.Forms.Label();
            this.chbQuitarAdministrador = new System.Windows.Forms.CheckBox();
            this.ttbtAgregar = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtActualizar = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtEliminar = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtLimpiar = new System.Windows.Forms.ToolTip(this.components);
            this.btRefrescarFormulario = new System.Windows.Forms.Button();
            this.ttbtRefrescarFormulario = new System.Windows.Forms.ToolTip(this.components);
            this.pnVehiculos.SuspendLayout();
            this.pnListaVehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // btActualizar
            // 
            this.btActualizar.Image = global::CapaPresentacion.Properties.Resources.edit;
            this.btActualizar.Location = new System.Drawing.Point(207, 234);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(37, 27);
            this.btActualizar.TabIndex = 5;
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Image = global::CapaPresentacion.Properties.Resources.delete;
            this.btEliminar.Location = new System.Drawing.Point(261, 234);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(37, 27);
            this.btEliminar.TabIndex = 6;
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btLimpiarFormulario
            // 
            this.btLimpiarFormulario.Image = global::CapaPresentacion.Properties.Resources.clean;
            this.btLimpiarFormulario.Location = new System.Drawing.Point(311, 234);
            this.btLimpiarFormulario.Name = "btLimpiarFormulario";
            this.btLimpiarFormulario.Size = new System.Drawing.Size(37, 27);
            this.btLimpiarFormulario.TabIndex = 7;
            this.btLimpiarFormulario.UseVisualStyleBackColor = true;
            this.btLimpiarFormulario.Click += new System.EventHandler(this.btLimpiarFormulario_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Image = global::CapaPresentacion.Properties.Resources.add;
            this.btAgregar.Location = new System.Drawing.Point(151, 234);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(37, 27);
            this.btAgregar.TabIndex = 4;
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // txtCodAdministrador
            // 
            this.txtCodAdministrador.AllowDrop = true;
            this.txtCodAdministrador.Location = new System.Drawing.Point(151, 165);
            this.txtCodAdministrador.MaxLength = 30;
            this.txtCodAdministrador.Name = "txtCodAdministrador";
            this.txtCodAdministrador.ReadOnly = true;
            this.txtCodAdministrador.Size = new System.Drawing.Size(197, 20);
            this.txtCodAdministrador.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.AllowDrop = true;
            this.txtNombre.Location = new System.Drawing.Point(151, 101);
            this.txtNombre.MaxLength = 45;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(197, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtCodigoDepartamento
            // 
            this.txtCodigoDepartamento.Location = new System.Drawing.Point(151, 70);
            this.txtCodigoDepartamento.Name = "txtCodigoDepartamento";
            this.txtCodigoDepartamento.ReadOnly = true;
            this.txtCodigoDepartamento.Size = new System.Drawing.Size(197, 20);
            this.txtCodigoDepartamento.TabIndex = 1;
            // 
            // lblCodAdministrador
            // 
            this.lblCodAdministrador.AutoSize = true;
            this.lblCodAdministrador.Location = new System.Drawing.Point(12, 168);
            this.lblCodAdministrador.Name = "lblCodAdministrador";
            this.lblCodAdministrador.Size = new System.Drawing.Size(126, 13);
            this.lblCodAdministrador.TabIndex = 58;
            this.lblCodAdministrador.Text = "Código del Administrador:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 104);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 57;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodDepartamento
            // 
            this.lblCodDepartamento.AutoSize = true;
            this.lblCodDepartamento.Location = new System.Drawing.Point(12, 73);
            this.lblCodDepartamento.Name = "lblCodDepartamento";
            this.lblCodDepartamento.Size = new System.Drawing.Size(113, 13);
            this.lblCodDepartamento.TabIndex = 56;
            this.lblCodDepartamento.Text = "Código Departamento:";
            // 
            // pnVehiculos
            // 
            this.pnVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnVehiculos.Controls.Add(this.lblTitulo);
            this.pnVehiculos.Location = new System.Drawing.Point(0, 0);
            this.pnVehiculos.Name = "pnVehiculos";
            this.pnVehiculos.Size = new System.Drawing.Size(816, 60);
            this.pnVehiculos.TabIndex = 59;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(305, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(171, 25);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Departamentos";
            // 
            // pnListaVehiculos
            // 
            this.pnListaVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnListaVehiculos.Controls.Add(this.btRefrescarFormulario);
            this.pnListaVehiculos.Controls.Add(this.lblListaDepartamentos);
            this.pnListaVehiculos.Location = new System.Drawing.Point(361, 61);
            this.pnListaVehiculos.Name = "pnListaVehiculos";
            this.pnListaVehiculos.Size = new System.Drawing.Size(455, 37);
            this.pnListaVehiculos.TabIndex = 60;
            // 
            // lblListaDepartamentos
            // 
            this.lblListaDepartamentos.AutoSize = true;
            this.lblListaDepartamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaDepartamentos.Location = new System.Drawing.Point(156, 9);
            this.lblListaDepartamentos.Name = "lblListaDepartamentos";
            this.lblListaDepartamentos.Size = new System.Drawing.Size(140, 15);
            this.lblListaDepartamentos.TabIndex = 2;
            this.lblListaDepartamentos.Text = "Lista Departamentos";
            // 
            // dgvListaDepartamentos
            // 
            this.dgvListaDepartamentos.AllowUserToAddRows = false;
            this.dgvListaDepartamentos.AllowUserToDeleteRows = false;
            this.dgvListaDepartamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaDepartamentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaDepartamentos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvListaDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDepartamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_departamento,
            this.nombre,
            this.cod_administrador,
            this.nombre_administrador});
            this.dgvListaDepartamentos.Location = new System.Drawing.Point(361, 100);
            this.dgvListaDepartamentos.Name = "dgvListaDepartamentos";
            this.dgvListaDepartamentos.ReadOnly = true;
            this.dgvListaDepartamentos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaDepartamentos.Size = new System.Drawing.Size(455, 236);
            this.dgvListaDepartamentos.TabIndex = 8;
            this.dgvListaDepartamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaDepartamentos_CellClick);
            // 
            // cod_departamento
            // 
            this.cod_departamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cod_departamento.HeaderText = "Cod. Departamento";
            this.cod_departamento.Name = "cod_departamento";
            this.cod_departamento.ReadOnly = true;
            this.cod_departamento.Width = 114;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 69;
            // 
            // cod_administrador
            // 
            this.cod_administrador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cod_administrador.HeaderText = "Cod. Administrador";
            this.cod_administrador.Name = "cod_administrador";
            this.cod_administrador.ReadOnly = true;
            this.cod_administrador.Width = 110;
            // 
            // nombre_administrador
            // 
            this.nombre_administrador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombre_administrador.HeaderText = "Administrador";
            this.nombre_administrador.Name = "nombre_administrador";
            this.nombre_administrador.ReadOnly = true;
            this.nombre_administrador.Width = 95;
            // 
            // cbNombreAdministrador
            // 
            this.cbNombreAdministrador.FormattingEnabled = true;
            this.cbNombreAdministrador.Location = new System.Drawing.Point(151, 131);
            this.cbNombreAdministrador.Name = "cbNombreAdministrador";
            this.cbNombreAdministrador.Size = new System.Drawing.Size(197, 21);
            this.cbNombreAdministrador.TabIndex = 61;
            this.cbNombreAdministrador.SelectedValueChanged += new System.EventHandler(this.cbNombreAdministrador_SelectedValueChanged);
            // 
            // lbNombreAdministrador
            // 
            this.lbNombreAdministrador.AutoSize = true;
            this.lbNombreAdministrador.Location = new System.Drawing.Point(12, 134);
            this.lbNombreAdministrador.Name = "lbNombreAdministrador";
            this.lbNombreAdministrador.Size = new System.Drawing.Size(139, 13);
            this.lbNombreAdministrador.TabIndex = 62;
            this.lbNombreAdministrador.Text = "Administradores disponibles:";
            // 
            // lbQuitarAdministrador
            // 
            this.lbQuitarAdministrador.AutoSize = true;
            this.lbQuitarAdministrador.Location = new System.Drawing.Point(12, 201);
            this.lbQuitarAdministrador.Name = "lbQuitarAdministrador";
            this.lbQuitarAdministrador.Size = new System.Drawing.Size(104, 13);
            this.lbQuitarAdministrador.TabIndex = 63;
            this.lbQuitarAdministrador.Text = "Quitar Administrador:";
            // 
            // chbQuitarAdministrador
            // 
            this.chbQuitarAdministrador.AutoSize = true;
            this.chbQuitarAdministrador.Location = new System.Drawing.Point(151, 201);
            this.chbQuitarAdministrador.Name = "chbQuitarAdministrador";
            this.chbQuitarAdministrador.Size = new System.Drawing.Size(15, 14);
            this.chbQuitarAdministrador.TabIndex = 64;
            this.chbQuitarAdministrador.UseVisualStyleBackColor = true;
            this.chbQuitarAdministrador.CheckedChanged += new System.EventHandler(this.chbQuitarAdministrador_CheckedChanged);
            // 
            // btRefrescarFormulario
            // 
            this.btRefrescarFormulario.Image = global::CapaPresentacion.Properties.Resources.refresh;
            this.btRefrescarFormulario.Location = new System.Drawing.Point(413, 3);
            this.btRefrescarFormulario.Name = "btRefrescarFormulario";
            this.btRefrescarFormulario.Size = new System.Drawing.Size(37, 27);
            this.btRefrescarFormulario.TabIndex = 110;
            this.btRefrescarFormulario.UseVisualStyleBackColor = true;
            this.btRefrescarFormulario.Click += new System.EventHandler(this.btRefrescarFormulario_Click);
            // 
            // frmDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 348);
            this.Controls.Add(this.chbQuitarAdministrador);
            this.Controls.Add(this.lbQuitarAdministrador);
            this.Controls.Add(this.lbNombreAdministrador);
            this.Controls.Add(this.cbNombreAdministrador);
            this.Controls.Add(this.dgvListaDepartamentos);
            this.Controls.Add(this.pnListaVehiculos);
            this.Controls.Add(this.pnVehiculos);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btLimpiarFormulario);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.txtCodAdministrador);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigoDepartamento);
            this.Controls.Add(this.lblCodAdministrador);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodDepartamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDepartamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departamentos";
            this.Load += new System.EventHandler(this.frmDepartamentos_Load);
            this.pnVehiculos.ResumeLayout(false);
            this.pnVehiculos.PerformLayout();
            this.pnListaVehiculos.ResumeLayout(false);
            this.pnListaVehiculos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDepartamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btLimpiarFormulario;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.TextBox txtCodAdministrador;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigoDepartamento;
        private System.Windows.Forms.Label lblCodAdministrador;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodDepartamento;
        private System.Windows.Forms.Panel pnVehiculos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnListaVehiculos;
        private System.Windows.Forms.Label lblListaDepartamentos;
        private System.Windows.Forms.DataGridView dgvListaDepartamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_administrador;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_administrador;
        private System.Windows.Forms.ComboBox cbNombreAdministrador;
        private System.Windows.Forms.Label lbNombreAdministrador;
        private System.Windows.Forms.Label lbQuitarAdministrador;
        private System.Windows.Forms.CheckBox chbQuitarAdministrador;
        private System.Windows.Forms.ToolTip ttbtAgregar;
        private System.Windows.Forms.ToolTip ttbtActualizar;
        private System.Windows.Forms.ToolTip ttbtEliminar;
        private System.Windows.Forms.ToolTip ttbtLimpiar;
        private System.Windows.Forms.Button btRefrescarFormulario;
        private System.Windows.Forms.ToolTip ttbtRefrescarFormulario;
    }
}
namespace CapaPresentacion
{
    partial class frmVehiculoUsado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehiculoUsado));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lbNumeroPlaca = new System.Windows.Forms.Label();
            this.lblEspecificaciones = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblGarantia = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCodVehiculo = new System.Windows.Forms.Label();
            this.lbKilometraje = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.txtCodigoVehiculo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.txtGarantia = new System.Windows.Forms.TextBox();
            this.txtKilometraje = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtEspecificaciones = new System.Windows.Forms.TextBox();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btLimpiarFormulario = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.lblListaVehiculo = new System.Windows.Forms.Label();
            this.pnListaVehiculos = new System.Windows.Forms.Panel();
            this.dgvListaVehiculosUsados = new System.Windows.Forms.DataGridView();
            this.cod_vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.garantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilometraje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especificaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNumeroPlaca = new System.Windows.Forms.TextBox();
            this.ttbtAgregar = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtActualizar = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtEliminar = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtLimpiar = new System.Windows.Forms.ToolTip(this.components);
            this.btRefrescarFormulario = new System.Windows.Forms.Button();
            this.ttbtRefrescarFormulario = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.pnListaVehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVehiculosUsados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 60);
            this.panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(467, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(201, 25);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Vehículos Usados";
            // 
            // lbNumeroPlaca
            // 
            this.lbNumeroPlaca.AutoSize = true;
            this.lbNumeroPlaca.Location = new System.Drawing.Point(18, 322);
            this.lbNumeroPlaca.Name = "lbNumeroPlaca";
            this.lbNumeroPlaca.Size = new System.Drawing.Size(92, 13);
            this.lbNumeroPlaca.TabIndex = 29;
            this.lbNumeroPlaca.Text = "Numero de Placa:";
            // 
            // lblEspecificaciones
            // 
            this.lblEspecificaciones.AutoSize = true;
            this.lblEspecificaciones.Location = new System.Drawing.Point(18, 357);
            this.lblEspecificaciones.Name = "lblEspecificaciones";
            this.lblEspecificaciones.Size = new System.Drawing.Size(90, 13);
            this.lblEspecificaciones.TabIndex = 28;
            this.lblEspecificaciones.Text = "Especificaciones:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(18, 166);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 27;
            this.lblColor.Text = "Color:";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(18, 200);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(79, 13);
            this.lblPrecioUnitario.TabIndex = 26;
            this.lblPrecioUnitario.Text = "Precio Unitario:";
            // 
            // lblGarantia
            // 
            this.lblGarantia.AutoSize = true;
            this.lblGarantia.Location = new System.Drawing.Point(18, 230);
            this.lblGarantia.Name = "lblGarantia";
            this.lblGarantia.Size = new System.Drawing.Size(52, 13);
            this.lblGarantia.TabIndex = 25;
            this.lblGarantia.Text = "Garantía:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(18, 133);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 24;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(18, 102);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 23;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCodVehiculo
            // 
            this.lblCodVehiculo.AutoSize = true;
            this.lblCodVehiculo.Location = new System.Drawing.Point(18, 71);
            this.lblCodVehiculo.Name = "lblCodVehiculo";
            this.lblCodVehiculo.Size = new System.Drawing.Size(89, 13);
            this.lblCodVehiculo.TabIndex = 22;
            this.lblCodVehiculo.Text = "Código Vehículo:";
            // 
            // lbKilometraje
            // 
            this.lbKilometraje.AutoSize = true;
            this.lbKilometraje.Location = new System.Drawing.Point(18, 293);
            this.lbKilometraje.Name = "lbKilometraje";
            this.lbKilometraje.Size = new System.Drawing.Size(61, 13);
            this.lbKilometraje.TabIndex = 30;
            this.lbKilometraje.Text = "Kilometraje:";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(18, 261);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(43, 13);
            this.lbEstado.TabIndex = 31;
            this.lbEstado.Text = "Estado:";
            // 
            // txtCodigoVehiculo
            // 
            this.txtCodigoVehiculo.Location = new System.Drawing.Point(113, 68);
            this.txtCodigoVehiculo.Name = "txtCodigoVehiculo";
            this.txtCodigoVehiculo.ReadOnly = true;
            this.txtCodigoVehiculo.Size = new System.Drawing.Size(197, 20);
            this.txtCodigoVehiculo.TabIndex = 1;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(113, 99);
            this.txtMarca.MaxLength = 25;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(197, 20);
            this.txtMarca.TabIndex = 2;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(113, 130);
            this.txtModelo.MaxLength = 25;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(197, 20);
            this.txtModelo.TabIndex = 3;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(113, 163);
            this.txtColor.MaxLength = 15;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(197, 20);
            this.txtColor.TabIndex = 4;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(113, 197);
            this.txtPrecioUnitario.MaxLength = 12;
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(197, 20);
            this.txtPrecioUnitario.TabIndex = 5;
            this.txtPrecioUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracter_KeyPress);
            // 
            // txtGarantia
            // 
            this.txtGarantia.Location = new System.Drawing.Point(113, 227);
            this.txtGarantia.MaxLength = 45;
            this.txtGarantia.Name = "txtGarantia";
            this.txtGarantia.Size = new System.Drawing.Size(197, 20);
            this.txtGarantia.TabIndex = 6;
            // 
            // txtKilometraje
            // 
            this.txtKilometraje.Location = new System.Drawing.Point(113, 290);
            this.txtKilometraje.MaxLength = 8;
            this.txtKilometraje.Name = "txtKilometraje";
            this.txtKilometraje.Size = new System.Drawing.Size(197, 20);
            this.txtKilometraje.TabIndex = 8;
            this.txtKilometraje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracter_KeyPress);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(113, 258);
            this.txtEstado.MaxLength = 15;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(197, 20);
            this.txtEstado.TabIndex = 7;
            // 
            // txtEspecificaciones
            // 
            this.txtEspecificaciones.Location = new System.Drawing.Point(113, 354);
            this.txtEspecificaciones.MaxLength = 190;
            this.txtEspecificaciones.Multiline = true;
            this.txtEspecificaciones.Name = "txtEspecificaciones";
            this.txtEspecificaciones.Size = new System.Drawing.Size(197, 66);
            this.txtEspecificaciones.TabIndex = 10;
            // 
            // btActualizar
            // 
            this.btActualizar.Image = global::CapaPresentacion.Properties.Resources.edit;
            this.btActualizar.Location = new System.Drawing.Point(169, 435);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(37, 27);
            this.btActualizar.TabIndex = 12;
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Image = global::CapaPresentacion.Properties.Resources.delete;
            this.btEliminar.Location = new System.Drawing.Point(223, 435);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(37, 27);
            this.btEliminar.TabIndex = 13;
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btLimpiarFormulario
            // 
            this.btLimpiarFormulario.Image = global::CapaPresentacion.Properties.Resources.clean;
            this.btLimpiarFormulario.Location = new System.Drawing.Point(273, 435);
            this.btLimpiarFormulario.Name = "btLimpiarFormulario";
            this.btLimpiarFormulario.Size = new System.Drawing.Size(37, 27);
            this.btLimpiarFormulario.TabIndex = 14;
            this.btLimpiarFormulario.UseVisualStyleBackColor = true;
            this.btLimpiarFormulario.Click += new System.EventHandler(this.btLimpiarFormulario_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Image = global::CapaPresentacion.Properties.Resources.add;
            this.btAgregar.Location = new System.Drawing.Point(113, 435);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(37, 27);
            this.btAgregar.TabIndex = 11;
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // lblListaVehiculo
            // 
            this.lblListaVehiculo.AutoSize = true;
            this.lblListaVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaVehiculo.Location = new System.Drawing.Point(345, 8);
            this.lblListaVehiculo.Name = "lblListaVehiculo";
            this.lblListaVehiculo.Size = new System.Drawing.Size(156, 15);
            this.lblListaVehiculo.TabIndex = 2;
            this.lblListaVehiculo.Text = "Lista Vehículos Usados";
            // 
            // pnListaVehiculos
            // 
            this.pnListaVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnListaVehiculos.Controls.Add(this.btRefrescarFormulario);
            this.pnListaVehiculos.Controls.Add(this.lblListaVehiculo);
            this.pnListaVehiculos.Location = new System.Drawing.Point(331, 62);
            this.pnListaVehiculos.Name = "pnListaVehiculos";
            this.pnListaVehiculos.Size = new System.Drawing.Size(827, 37);
            this.pnListaVehiculos.TabIndex = 46;
            // 
            // dgvListaVehiculosUsados
            // 
            this.dgvListaVehiculosUsados.AllowUserToAddRows = false;
            this.dgvListaVehiculosUsados.AllowUserToDeleteRows = false;
            this.dgvListaVehiculosUsados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaVehiculosUsados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaVehiculosUsados.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvListaVehiculosUsados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaVehiculosUsados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_vehiculo,
            this.dataGridViewTextBoxColumn1,
            this.modelo,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.garantia,
            this.Estado,
            this.Kilometraje,
            this.Numero_Placa,
            this.especificaciones});
            this.dgvListaVehiculosUsados.Location = new System.Drawing.Point(331, 99);
            this.dgvListaVehiculosUsados.Name = "dgvListaVehiculosUsados";
            this.dgvListaVehiculosUsados.ReadOnly = true;
            this.dgvListaVehiculosUsados.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaVehiculosUsados.Size = new System.Drawing.Size(827, 363);
            this.dgvListaVehiculosUsados.TabIndex = 47;
            this.dgvListaVehiculosUsados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaVehiculosUsados_CellContentClick);
            this.dgvListaVehiculosUsados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaVehiculosUsados_CellContentClick);
            // 
            // cod_vehiculo
            // 
            this.cod_vehiculo.HeaderText = "Cod. Vehículo";
            this.cod_vehiculo.Name = "cod_vehiculo";
            this.cod_vehiculo.ReadOnly = true;
            this.cod_vehiculo.Width = 92;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 62;
            // 
            // modelo
            // 
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            this.modelo.Width = 67;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Color";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 56;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio Unitario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 93;
            // 
            // garantia
            // 
            this.garantia.HeaderText = "Garantía";
            this.garantia.Name = "garantia";
            this.garantia.ReadOnly = true;
            this.garantia.Width = 74;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 65;
            // 
            // Kilometraje
            // 
            this.Kilometraje.HeaderText = "Kilometraje";
            this.Kilometraje.Name = "Kilometraje";
            this.Kilometraje.ReadOnly = true;
            this.Kilometraje.Width = 83;
            // 
            // Numero_Placa
            // 
            this.Numero_Placa.HeaderText = "Numero de Placa";
            this.Numero_Placa.Name = "Numero_Placa";
            this.Numero_Placa.ReadOnly = true;
            this.Numero_Placa.Width = 80;
            // 
            // especificaciones
            // 
            this.especificaciones.HeaderText = "Especificaciones";
            this.especificaciones.Name = "especificaciones";
            this.especificaciones.ReadOnly = true;
            this.especificaciones.Width = 112;
            // 
            // txtNumeroPlaca
            // 
            this.txtNumeroPlaca.Location = new System.Drawing.Point(113, 319);
            this.txtNumeroPlaca.MaxLength = 8;
            this.txtNumeroPlaca.Name = "txtNumeroPlaca";
            this.txtNumeroPlaca.Size = new System.Drawing.Size(197, 20);
            this.txtNumeroPlaca.TabIndex = 9;
            // 
            // btRefrescarFormulario
            // 
            this.btRefrescarFormulario.Image = global::CapaPresentacion.Properties.Resources.refresh;
            this.btRefrescarFormulario.Location = new System.Drawing.Point(785, 3);
            this.btRefrescarFormulario.Name = "btRefrescarFormulario";
            this.btRefrescarFormulario.Size = new System.Drawing.Size(37, 27);
            this.btRefrescarFormulario.TabIndex = 110;
            this.btRefrescarFormulario.UseVisualStyleBackColor = true;
            this.btRefrescarFormulario.Click += new System.EventHandler(this.btRefrescarFormulario_Click);
            // 
            // frmVehiculoUsado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 480);
            this.Controls.Add(this.dgvListaVehiculosUsados);
            this.Controls.Add(this.pnListaVehiculos);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btLimpiarFormulario);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.txtEspecificaciones);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtKilometraje);
            this.Controls.Add(this.txtNumeroPlaca);
            this.Controls.Add(this.txtGarantia);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtCodigoVehiculo);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.lbKilometraje);
            this.Controls.Add(this.lbNumeroPlaca);
            this.Controls.Add(this.lblEspecificaciones);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblPrecioUnitario);
            this.Controls.Add(this.lblGarantia);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCodVehiculo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVehiculoUsado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehículos Usados";
            this.Load += new System.EventHandler(this.frmVehiculoUsado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnListaVehiculos.ResumeLayout(false);
            this.pnListaVehiculos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVehiculosUsados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lbNumeroPlaca;
        private System.Windows.Forms.Label lblEspecificaciones;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblGarantia;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCodVehiculo;
        private System.Windows.Forms.Label lbKilometraje;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.TextBox txtCodigoVehiculo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.TextBox txtGarantia;
        private System.Windows.Forms.TextBox txtKilometraje;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtEspecificaciones;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btLimpiarFormulario;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Label lblListaVehiculo;
        private System.Windows.Forms.Panel pnListaVehiculos;
        private System.Windows.Forms.DataGridView dgvListaVehiculosUsados;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_vehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn garantia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilometraje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn especificaciones;
        private System.Windows.Forms.TextBox txtNumeroPlaca;
        private System.Windows.Forms.ToolTip ttbtAgregar;
        private System.Windows.Forms.ToolTip ttbtActualizar;
        private System.Windows.Forms.ToolTip ttbtEliminar;
        private System.Windows.Forms.ToolTip ttbtLimpiar;
        private System.Windows.Forms.Button btRefrescarFormulario;
        private System.Windows.Forms.ToolTip ttbtRefrescarFormulario;
    }
}
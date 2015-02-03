namespace CapaPresentacion
{
    partial class frmRepuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepuestos));
            this.btActualizar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btLimpiarFormulario = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio_Unitario = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtCodigoRepuesto = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblCodRepuesto = new System.Windows.Forms.Label();
            this.dgvListaRepuestos = new System.Windows.Forms.DataGridView();
            this.cod_repuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnListaProveedores = new System.Windows.Forms.Panel();
            this.lblListaProveedores = new System.Windows.Forms.Label();
            this.pnProveedores = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ttbtAgregar = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtActualizar = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtEliminar = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtLimpiar = new System.Windows.Forms.ToolTip(this.components);
            this.btRefrescarFormulario = new System.Windows.Forms.Button();
            this.ttbtRefrescarFormulario = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRepuestos)).BeginInit();
            this.pnListaProveedores.SuspendLayout();
            this.pnProveedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // btActualizar
            // 
            this.btActualizar.Image = global::CapaPresentacion.Properties.Resources.edit;
            this.btActualizar.Location = new System.Drawing.Point(200, 248);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(37, 27);
            this.btActualizar.TabIndex = 82;
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Image = global::CapaPresentacion.Properties.Resources.delete;
            this.btEliminar.Location = new System.Drawing.Point(254, 248);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(37, 27);
            this.btEliminar.TabIndex = 83;
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btLimpiarFormulario
            // 
            this.btLimpiarFormulario.Image = global::CapaPresentacion.Properties.Resources.clean;
            this.btLimpiarFormulario.Location = new System.Drawing.Point(304, 248);
            this.btLimpiarFormulario.Name = "btLimpiarFormulario";
            this.btLimpiarFormulario.Size = new System.Drawing.Size(37, 27);
            this.btLimpiarFormulario.TabIndex = 84;
            this.btLimpiarFormulario.UseVisualStyleBackColor = true;
            this.btLimpiarFormulario.Click += new System.EventHandler(this.btLimpiarFormulario_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Image = global::CapaPresentacion.Properties.Resources.add;
            this.btAgregar.Location = new System.Drawing.Point(144, 248);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(37, 27);
            this.btAgregar.TabIndex = 81;
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AllowDrop = true;
            this.txtDescripcion.Location = new System.Drawing.Point(144, 167);
            this.txtDescripcion.MaxLength = 90;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(197, 66);
            this.txtDescripcion.TabIndex = 79;
            // 
            // txtPrecio_Unitario
            // 
            this.txtPrecio_Unitario.AllowDrop = true;
            this.txtPrecio_Unitario.Location = new System.Drawing.Point(144, 131);
            this.txtPrecio_Unitario.MaxLength = 12;
            this.txtPrecio_Unitario.Name = "txtPrecio_Unitario";
            this.txtPrecio_Unitario.Size = new System.Drawing.Size(197, 20);
            this.txtPrecio_Unitario.TabIndex = 77;
            this.txtPrecio_Unitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaracter_KeyPress);
            // 
            // txtTipo
            // 
            this.txtTipo.AllowDrop = true;
            this.txtTipo.Location = new System.Drawing.Point(144, 100);
            this.txtTipo.MaxLength = 75;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(197, 20);
            this.txtTipo.TabIndex = 76;
            // 
            // txtCodigoRepuesto
            // 
            this.txtCodigoRepuesto.Location = new System.Drawing.Point(144, 69);
            this.txtCodigoRepuesto.Name = "txtCodigoRepuesto";
            this.txtCodigoRepuesto.ReadOnly = true;
            this.txtCodigoRepuesto.Size = new System.Drawing.Size(197, 20);
            this.txtCodigoRepuesto.TabIndex = 75;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 170);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 90;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(12, 134);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(79, 13);
            this.lblPrecioUnitario.TabIndex = 89;
            this.lblPrecioUnitario.Text = "Precio Unitario:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(12, 103);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 88;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblCodRepuesto
            // 
            this.lblCodRepuesto.AutoSize = true;
            this.lblCodRepuesto.Location = new System.Drawing.Point(12, 72);
            this.lblCodRepuesto.Name = "lblCodRepuesto";
            this.lblCodRepuesto.Size = new System.Drawing.Size(92, 13);
            this.lblCodRepuesto.TabIndex = 87;
            this.lblCodRepuesto.Text = "Código Repuesto:";
            // 
            // dgvListaRepuestos
            // 
            this.dgvListaRepuestos.AllowUserToAddRows = false;
            this.dgvListaRepuestos.AllowUserToDeleteRows = false;
            this.dgvListaRepuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaRepuestos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaRepuestos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvListaRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaRepuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_repuesto,
            this.tipo,
            this.precio_unitario,
            this.descripcion});
            this.dgvListaRepuestos.Location = new System.Drawing.Point(353, 99);
            this.dgvListaRepuestos.Name = "dgvListaRepuestos";
            this.dgvListaRepuestos.ReadOnly = true;
            this.dgvListaRepuestos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaRepuestos.Size = new System.Drawing.Size(458, 176);
            this.dgvListaRepuestos.TabIndex = 85;
            this.dgvListaRepuestos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaRepuestos_CellClick);
            // 
            // cod_repuesto
            // 
            this.cod_repuesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cod_repuesto.HeaderText = "Cod. Repuesto";
            this.cod_repuesto.Name = "cod_repuesto";
            this.cod_repuesto.ReadOnly = true;
            this.cod_repuesto.Width = 95;
            // 
            // tipo
            // 
            this.tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 53;
            // 
            // precio_unitario
            // 
            this.precio_unitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.precio_unitario.HeaderText = "Precio Unitario";
            this.precio_unitario.Name = "precio_unitario";
            this.precio_unitario.ReadOnly = true;
            this.precio_unitario.Width = 93;
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
            this.pnListaProveedores.Location = new System.Drawing.Point(353, 61);
            this.pnListaProveedores.Name = "pnListaProveedores";
            this.pnListaProveedores.Size = new System.Drawing.Size(458, 37);
            this.pnListaProveedores.TabIndex = 86;
            // 
            // lblListaProveedores
            // 
            this.lblListaProveedores.AutoSize = true;
            this.lblListaProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaProveedores.Location = new System.Drawing.Point(176, 10);
            this.lblListaProveedores.Name = "lblListaProveedores";
            this.lblListaProveedores.Size = new System.Drawing.Size(110, 15);
            this.lblListaProveedores.TabIndex = 2;
            this.lblListaProveedores.Text = "Lista Repuestos";
            // 
            // pnProveedores
            // 
            this.pnProveedores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnProveedores.Controls.Add(this.lblTitulo);
            this.pnProveedores.Location = new System.Drawing.Point(-1, 0);
            this.pnProveedores.Name = "pnProveedores";
            this.pnProveedores.Size = new System.Drawing.Size(812, 60);
            this.pnProveedores.TabIndex = 80;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(348, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(124, 25);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Repuestos";
            // 
            // btRefrescarFormulario
            // 
            this.btRefrescarFormulario.Image = global::CapaPresentacion.Properties.Resources.refresh;
            this.btRefrescarFormulario.Location = new System.Drawing.Point(416, 3);
            this.btRefrescarFormulario.Name = "btRefrescarFormulario";
            this.btRefrescarFormulario.Size = new System.Drawing.Size(37, 27);
            this.btRefrescarFormulario.TabIndex = 110;
            this.btRefrescarFormulario.UseVisualStyleBackColor = true;
            this.btRefrescarFormulario.Click += new System.EventHandler(this.btRefrescarFormulario_Click);
            // 
            // frmRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 288);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btLimpiarFormulario);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtPrecio_Unitario);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtCodigoRepuesto);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblPrecioUnitario);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblCodRepuesto);
            this.Controls.Add(this.dgvListaRepuestos);
            this.Controls.Add(this.pnListaProveedores);
            this.Controls.Add(this.pnProveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRepuestos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repuestos";
            this.Load += new System.EventHandler(this.frmRepuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRepuestos)).EndInit();
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
        private System.Windows.Forms.TextBox txtPrecio_Unitario;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtCodigoRepuesto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblCodRepuesto;
        private System.Windows.Forms.DataGridView dgvListaRepuestos;
        private System.Windows.Forms.Panel pnListaProveedores;
        private System.Windows.Forms.Label lblListaProveedores;
        private System.Windows.Forms.Panel pnProveedores;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_repuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.ToolTip ttbtAgregar;
        private System.Windows.Forms.ToolTip ttbtActualizar;
        private System.Windows.Forms.ToolTip ttbtEliminar;
        private System.Windows.Forms.ToolTip ttbtLimpiar;
        private System.Windows.Forms.Button btRefrescarFormulario;
        private System.Windows.Forms.ToolTip ttbtRefrescarFormulario;
    }
}
namespace CapaPresentacion
{
    partial class frmFacturaVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturaVenta));
            this.btActualizar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btLimpiarFormulario = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.txtCodigoFactura = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCedulaJuridica = new System.Windows.Forms.Label();
            this.lblCodProveedor = new System.Windows.Forms.Label();
            this.dgvListaFacturas = new System.Windows.Forms.DataGridView();
            this.cod_factura_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnListaProveedores = new System.Windows.Forms.Panel();
            this.lblListaProveedores = new System.Windows.Forms.Label();
            this.pnProveedores = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFechaVenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEmpleado = new System.Windows.Forms.ComboBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFacturas)).BeginInit();
            this.pnListaProveedores.SuspendLayout();
            this.pnProveedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // btActualizar
            // 
            this.btActualizar.Image = global::CapaPresentacion.Properties.Resources.edit;
            this.btActualizar.Location = new System.Drawing.Point(213, 485);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(37, 27);
            this.btActualizar.TabIndex = 99;
            this.btActualizar.UseVisualStyleBackColor = true;
            // 
            // btEliminar
            // 
            this.btEliminar.Image = global::CapaPresentacion.Properties.Resources.delete;
            this.btEliminar.Location = new System.Drawing.Point(267, 485);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(37, 27);
            this.btEliminar.TabIndex = 100;
            this.btEliminar.UseVisualStyleBackColor = true;
            // 
            // btLimpiarFormulario
            // 
            this.btLimpiarFormulario.Image = global::CapaPresentacion.Properties.Resources.clean;
            this.btLimpiarFormulario.Location = new System.Drawing.Point(317, 485);
            this.btLimpiarFormulario.Name = "btLimpiarFormulario";
            this.btLimpiarFormulario.Size = new System.Drawing.Size(37, 27);
            this.btLimpiarFormulario.TabIndex = 101;
            this.btLimpiarFormulario.UseVisualStyleBackColor = true;
            // 
            // btAgregar
            // 
            this.btAgregar.Image = global::CapaPresentacion.Properties.Resources.add;
            this.btAgregar.Location = new System.Drawing.Point(157, 485);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(37, 27);
            this.btAgregar.TabIndex = 98;
            this.btAgregar.UseVisualStyleBackColor = true;
            // 
            // txtComentarios
            // 
            this.txtComentarios.AllowDrop = true;
            this.txtComentarios.Location = new System.Drawing.Point(157, 413);
            this.txtComentarios.MaxLength = 190;
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(197, 66);
            this.txtComentarios.TabIndex = 96;
            // 
            // txtCodigoFactura
            // 
            this.txtCodigoFactura.Location = new System.Drawing.Point(157, 81);
            this.txtCodigoFactura.Name = "txtCodigoFactura";
            this.txtCodigoFactura.ReadOnly = true;
            this.txtCodigoFactura.Size = new System.Drawing.Size(197, 20);
            this.txtCodigoFactura.TabIndex = 92;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(25, 209);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(89, 13);
            this.lblRazonSocial.TabIndex = 108;
            this.lblRazonSocial.Text = "Codigo Producto:";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(25, 416);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(68, 13);
            this.lblPrecioUnitario.TabIndex = 107;
            this.lblPrecioUnitario.Text = "Comentarios:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(25, 146);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 13);
            this.lblNombre.TabIndex = 106;
            this.lblNombre.Text = "Codigo Cliente:";
            // 
            // lblCedulaJuridica
            // 
            this.lblCedulaJuridica.AutoSize = true;
            this.lblCedulaJuridica.Location = new System.Drawing.Point(25, 115);
            this.lblCedulaJuridica.Name = "lblCedulaJuridica";
            this.lblCedulaJuridica.Size = new System.Drawing.Size(93, 13);
            this.lblCedulaJuridica.TabIndex = 105;
            this.lblCedulaJuridica.Text = "Codigo Empleado:";
            // 
            // lblCodProveedor
            // 
            this.lblCodProveedor.AutoSize = true;
            this.lblCodProveedor.Location = new System.Drawing.Point(25, 84);
            this.lblCodProveedor.Name = "lblCodProveedor";
            this.lblCodProveedor.Size = new System.Drawing.Size(82, 13);
            this.lblCodProveedor.TabIndex = 104;
            this.lblCodProveedor.Text = "Código Factura:";
            // 
            // dgvListaFacturas
            // 
            this.dgvListaFacturas.AllowUserToAddRows = false;
            this.dgvListaFacturas.AllowUserToDeleteRows = false;
            this.dgvListaFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaFacturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaFacturas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvListaFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_factura_venta,
            this.Cod_Empleado,
            this.cod_cliente,
            this.fecha_venta,
            this.total});
            this.dgvListaFacturas.Location = new System.Drawing.Point(366, 111);
            this.dgvListaFacturas.Name = "dgvListaFacturas";
            this.dgvListaFacturas.ReadOnly = true;
            this.dgvListaFacturas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaFacturas.Size = new System.Drawing.Size(491, 283);
            this.dgvListaFacturas.TabIndex = 102;
            // 
            // cod_factura_venta
            // 
            this.cod_factura_venta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cod_factura_venta.HeaderText = "Cod. Factura";
            this.cod_factura_venta.Name = "cod_factura_venta";
            this.cod_factura_venta.ReadOnly = true;
            this.cod_factura_venta.Width = 86;
            // 
            // Cod_Empleado
            // 
            this.Cod_Empleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cod_Empleado.HeaderText = "Codigo Empleado";
            this.Cod_Empleado.Name = "Cod_Empleado";
            this.Cod_Empleado.ReadOnly = true;
            this.Cod_Empleado.Width = 105;
            // 
            // cod_cliente
            // 
            this.cod_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cod_cliente.HeaderText = "Codigo Cliente";
            this.cod_cliente.Name = "cod_cliente";
            this.cod_cliente.ReadOnly = true;
            this.cod_cliente.Width = 92;
            // 
            // fecha_venta
            // 
            this.fecha_venta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fecha_venta.HeaderText = "Fecha Venta";
            this.fecha_venta.Name = "fecha_venta";
            this.fecha_venta.ReadOnly = true;
            this.fecha_venta.Width = 86;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 56;
            // 
            // pnListaProveedores
            // 
            this.pnListaProveedores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnListaProveedores.Controls.Add(this.lblListaProveedores);
            this.pnListaProveedores.Location = new System.Drawing.Point(366, 73);
            this.pnListaProveedores.Name = "pnListaProveedores";
            this.pnListaProveedores.Size = new System.Drawing.Size(491, 37);
            this.pnListaProveedores.TabIndex = 103;
            // 
            // lblListaProveedores
            // 
            this.lblListaProveedores.AutoSize = true;
            this.lblListaProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaProveedores.Location = new System.Drawing.Point(175, 9);
            this.lblListaProveedores.Name = "lblListaProveedores";
            this.lblListaProveedores.Size = new System.Drawing.Size(97, 15);
            this.lblListaProveedores.TabIndex = 2;
            this.lblListaProveedores.Text = "Lista Facturas";
            // 
            // pnProveedores
            // 
            this.pnProveedores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnProveedores.Controls.Add(this.lblTitulo);
            this.pnProveedores.Location = new System.Drawing.Point(12, 12);
            this.pnProveedores.Name = "pnProveedores";
            this.pnProveedores.Size = new System.Drawing.Size(845, 60);
            this.pnProveedores.TabIndex = 97;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(348, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(92, 25);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Factura";
            // 
            // txtCantidad
            // 
            this.txtCantidad.AllowDrop = true;
            this.txtCantidad.Location = new System.Drawing.Point(157, 242);
            this.txtCantidad.MaxLength = 190;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(197, 20);
            this.txtCantidad.TabIndex = 109;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 110;
            this.label1.Text = "Cantidad:";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.AllowDrop = true;
            this.txtPrecioUnitario.Location = new System.Drawing.Point(157, 268);
            this.txtPrecioUnitario.MaxLength = 190;
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.ReadOnly = true;
            this.txtPrecioUnitario.Size = new System.Drawing.Size(197, 20);
            this.txtPrecioUnitario.TabIndex = 111;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 112;
            this.label2.Text = "Precio Unitario:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.AllowDrop = true;
            this.txtSubtotal.Location = new System.Drawing.Point(157, 337);
            this.txtSubtotal.MaxLength = 190;
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(197, 20);
            this.txtSubtotal.TabIndex = 113;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 114;
            this.label3.Text = "Subtotal:";
            // 
            // txtFechaVenta
            // 
            this.txtFechaVenta.AllowDrop = true;
            this.txtFechaVenta.Location = new System.Drawing.Point(157, 304);
            this.txtFechaVenta.MaxLength = 190;
            this.txtFechaVenta.Name = "txtFechaVenta";
            this.txtFechaVenta.ReadOnly = true;
            this.txtFechaVenta.Size = new System.Drawing.Size(197, 20);
            this.txtFechaVenta.TabIndex = 115;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 116;
            this.label4.Text = "Fecha Venta:";
            // 
            // txtTotal
            // 
            this.txtTotal.AllowDrop = true;
            this.txtTotal.Location = new System.Drawing.Point(157, 374);
            this.txtTotal.MaxLength = 190;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(197, 20);
            this.txtTotal.TabIndex = 117;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 118;
            this.label5.Text = "Total:";
            // 
            // cbEmpleado
            // 
            this.cbEmpleado.FormattingEnabled = true;
            this.cbEmpleado.Location = new System.Drawing.Point(157, 115);
            this.cbEmpleado.Name = "cbEmpleado";
            this.cbEmpleado.Size = new System.Drawing.Size(197, 21);
            this.cbEmpleado.TabIndex = 119;
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(157, 146);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(197, 21);
            this.cbCliente.TabIndex = 120;
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(157, 209);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(197, 21);
            this.cbProducto.TabIndex = 121;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Vehiculo Nuevo",
            "Vehiculo Usado",
            "Repuesto",
            "Servicio"});
            this.cbTipo.Location = new System.Drawing.Point(157, 173);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(197, 21);
            this.cbTipo.TabIndex = 123;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 122;
            this.label6.Text = "Tipo Producto:";
            // 
            // frmFacturaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 518);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.cbEmpleado);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFechaVenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btLimpiarFormulario);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.txtComentarios);
            this.Controls.Add(this.txtCodigoFactura);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.lblPrecioUnitario);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCedulaJuridica);
            this.Controls.Add(this.lblCodProveedor);
            this.Controls.Add(this.dgvListaFacturas);
            this.Controls.Add(this.pnListaProveedores);
            this.Controls.Add(this.pnProveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFacturaVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas de Venta";
            this.Load += new System.EventHandler(this.frmFacturaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFacturas)).EndInit();
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
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.TextBox txtCodigoFactura;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCedulaJuridica;
        private System.Windows.Forms.Label lblCodProveedor;
        private System.Windows.Forms.DataGridView dgvListaFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_factura_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Panel pnListaProveedores;
        private System.Windows.Forms.Label lblListaProveedores;
        private System.Windows.Forms.Panel pnProveedores;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFechaVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbEmpleado;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label6;
    }
}
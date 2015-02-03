using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Objetos;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmFacturaVenta : Form
    {
        public frmFacturaVenta()
        {
            InitializeComponent();
        }
        int control = 0;
        int precio = 0;

        private void frmFacturaVenta_Load(object sender, EventArgs e)
        {
            txtFechaVenta.Text = DateTime.Now.ToString().Split(' ')[0].Trim();
           cargarComboBoxes();
           llenarDataGrigView();
        }


        private void dgvListaFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarCamposDelDataGridView();
        }

        public void agregarFactura()
        {
            objFacturaVenta objFacturaVenta = new objFacturaVenta();
            objDetalleVenta objDetalleVenta = new objDetalleVenta();
            cnDetalleVenta cnDetalleVenta = new cnDetalleVenta();
            cnFacturaVenta cnFacturaVenta = new cnFacturaVenta();

            if (validarCamposLlenos(control))
            {
                objFacturaVenta.Cod_Empleado = Convert.ToInt32(cbEmpleado.SelectedValue);
                objFacturaVenta.Cod_Cliente = Convert.ToInt32(cbCliente.SelectedValue);
                objFacturaVenta.Fecha_Venta = Convert.ToDateTime(txtFechaVenta);
                objDetalleVenta.Cod_Producto = Convert.ToString(cbProducto.SelectedValue);
                objDetalleVenta.Cantidad = Convert.ToInt32(txtCantidad.Text);
                objDetalleVenta.Precio_Unitario = Convert.ToInt32(txtPrecioUnitario.Text);
                objDetalleVenta.Subtotal = Convert.ToInt32(txtSubtotal.Text);
                objDetalleVenta.Comentarios = txtComentarios.Text;

                if (cnFacturaVenta.insertarFactura(objFacturaVenta, objDetalleVenta))
                {
                    llenarDataGrigView();

                    btAgregar.Enabled = true;
                    btActualizar.Enabled = false;
                    btEliminar.Enabled = false;
                    btLimpiarFormulario.Enabled = true;

                    limpiarCamposFormulario();
                    control = 0;
                }
                else
                {
                    txtComentarios.BackColor = Color.Tomato;
                }
            }
            else
            {
                MessageBox.Show("Debe digitar los campos del formulario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void actualizarFactura()
        {
            objFacturaVenta objFacturaVenta = new objFacturaVenta();
            cnFacturaVenta cnFacturaVenta = new cnFacturaVenta();

            if (validarCamposLlenos(control))
            {
                DialogResult eleccionActualizar = MessageBox.Show("¿Desea actualizar la factura seleccionada?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eleccionActualizar == DialogResult.Yes)
                {

                    cnFacturaVenta.actualizarFactura(objFacturaVenta);

                    llenarDataGrigView();

                    cbEmpleado.Enabled = true;
                    cbCliente.Enabled = true;
                    txtFechaVenta.Text = DateTime.Now.ToString().Split(' ')[0].Trim();

                    btAgregar.Enabled = true;
                    btActualizar.Enabled = false;
                    btEliminar.Enabled = false;

                    limpiarCamposFormulario();
                    control = 0;
                }
            }
            else
            {
                MessageBox.Show("Debe de cargar primero una factura de la lista de facturas", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void eliminarFactura()
        {
            objFacturaVenta objFacturaVenta = new objFacturaVenta();
            cnFacturaVenta cnFacturaVenta = new cnFacturaVenta();


            DialogResult eleccionBorrar = MessageBox.Show("¿Desea eliminar la factura seleccionada?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (eleccionBorrar == DialogResult.Yes)
            {
                objFacturaVenta.Cod_Fact_Venta = Convert.ToInt32(dgvListaFacturas.CurrentRow.Cells[0].Value);
                cnFacturaVenta.eliminarFactura(objFacturaVenta);

                llenarDataGrigView();

                cbEmpleado.Enabled = true;
                cbCliente.Enabled = true;

                btAgregar.Enabled = true;
                btActualizar.Enabled = false;
                btEliminar.Enabled = false;

                limpiarCamposFormulario();
            }
        }

        public void llenarDataGrigView()
        {
            cnFacturaVenta cnFacturaVenta = new cnFacturaVenta();
            DataTable tablaFacturas = new DataTable();

            dgvListaFacturas.Rows.Clear();


            tablaFacturas = cnFacturaVenta.consultarFacturas();

            for (int i = 0; i < tablaFacturas.Rows.Count; i++)
            {
                dgvListaFacturas.Rows.Add(tablaFacturas.Rows[i][0], tablaFacturas.Rows[i][1], tablaFacturas.Rows[i][2],
                                                 tablaFacturas.Rows[i][3], tablaFacturas.Rows[i][4]);
            }
        }

        public void cargarComboBoxes()
        {
            cnEmpleados cnEmpleado = new cnEmpleados();
            cnClientes cnClientes = new cnClientes();
            cnFacturaVenta cnFacturaVenta = new cnFacturaVenta();
            DataTable TablaEmpleados = new DataTable();
            DataTable TablaClientes = new DataTable();
            cnVehiculoNuevo cnVehiculoNuevo = new cnVehiculoNuevo();

            //Carga Empleados
            if (cnEmpleado.consultarEmpleadosTaller().Rows.Count > 0)
            {
                cbEmpleado.DataSource = cnEmpleado.consultarEmpleadosTaller();
                cbEmpleado.DisplayMember = "nombre_empleado";
                cbEmpleado.ValueMember = "cod_empleado";
            }
            else
            {
                cbEmpleado.DataSource = null;
                cbEmpleado.DisplayMember = "";
                cbEmpleado.ValueMember = "";
            }

            //Carga clientes
            if (cnClientes.consultarClientes().Rows.Count > 0)
            {
                cbCliente.DataSource = cnClientes.consultarClientes();
                cbCliente.DisplayMember = "NOMBRE";
                cbCliente.ValueMember = "COD_CLIENTE";
            }
            else
            {
                cbCliente.DataSource = null;
                cbCliente.DisplayMember = "";
                cbCliente.ValueMember = "";
            }

        }

        public void cargarSegundoCombo()
        {
            cnVehiculoNuevo cnVehiculoNuevo = new cnVehiculoNuevo();
            cnVehiculoUsado cnVehiculoUsado = new cnVehiculoUsado();
            cnServicios cnServicios = new cnServicios();
            cnRepuestos cnRepuestos = new cnRepuestos();
            cnFacturaVenta cnFacturaVenta = new cnFacturaVenta();
            //Carga Productos
            if (cbTipo.SelectedItem == "Vehiculo Nuevo")
            {
                cbProducto.DataSource = cnFacturaVenta.consultarVehiculoUsado();
                cbProducto.DisplayMember = "Cod_Vehiculo";
                cbProducto.ValueMember = "Cod_Vehiculo";

            }
            else if (cbTipo.SelectedItem == "Vehiculo Usado")
            {
                cbProducto.DataSource = cnFacturaVenta.consultarVehiculoUsado();
                cbProducto.DisplayMember = "Cod_Vehiculo";
                cbProducto.ValueMember = "Cod_Vehiculo";
            }
            else if (cbTipo.SelectedItem == "Servicio")
            {
                cbProducto.DataSource = cnServicios.consultarServicio();
                cbProducto.DisplayMember = "descripcion";
                cbProducto.ValueMember = "cod_servicio";
            }
            else if (cbTipo.SelectedItem == "Repuesto")
            {
                cbProducto.DataSource = cnFacturaVenta.consultarRepuestosFactura();
                cbProducto.DisplayMember = "descripcion";
                cbProducto.ValueMember = "cod_repuesto";
            }
        }

        public void cargarCamposDelDataGridView()
        {
            if (dgvListaFacturas.CurrentRow.Cells[0].Value.ToString() != "")
            {
                DialogResult eleccionCargar = MessageBox.Show("¿Desea cargar la factura seleccionada al formulario?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eleccionCargar == DialogResult.Yes)
                {
                    txtCodigoFactura.Text = dgvListaFacturas.CurrentRow.Cells[0].Value.ToString();
                    cbEmpleado.SelectedItem = dgvListaFacturas.CurrentRow.Cells[1].Value.ToString();
                    cbCliente.SelectedItem = dgvListaFacturas.CurrentRow.Cells[2].Value.ToString();
                    txtFechaVenta.Text = dgvListaFacturas.CurrentRow.Cells[3].Value.ToString();
                    txtTotal.Text = dgvListaFacturas.CurrentRow.Cells[4].Value.ToString();

                    cbCliente.Enabled = false;
                    txtCantidad.Enabled = false;
                    txtPrecioUnitario.Enabled = false;
                    txtSubtotal.Enabled = false;
                    txtComentarios.Enabled = false;

                    btAgregar.Enabled = false;
                    btActualizar.Enabled = true;
                    btEliminar.Enabled = true;
                    btLimpiarFormulario.Enabled = true;
                    control = 1;
                }
            }
        }

        public Boolean validarCamposLlenos(int cont)
        {
            Boolean camposCompletados = false;
            if (cont == 0)
            {
                if (txtFechaVenta.Text != "" && txtCantidad.Text != "" && txtPrecioUnitario.Text != "" && txtComentarios.Text != "" && txtSubtotal.Text != "")
                {
                    camposCompletados = true;
                }
            }
            else
            {
                camposCompletados = true;

            }
            return camposCompletados;
        }

        public void limpiarCamposFormulario()
        {
            txtCantidad.Text = "";
            txtPrecioUnitario.Text = "";
            txtFechaVenta.Text = DateTime.Now.ToString().Split(' ')[0].Trim();
            txtSubtotal.Text = "";
            txtTotal.Text = "";
            txtComentarios.Text = "";


            cbCliente.Enabled = true;
            txtCantidad.Enabled = true;
            txtPrecioUnitario.Enabled = true;
            txtSubtotal.Enabled = true;
            txtComentarios.Enabled = true;

            txtComentarios.BackColor = Color.White;

            btAgregar.Enabled = true;
            btActualizar.Enabled = false;
            btEliminar.Enabled = false;
            btLimpiarFormulario.Enabled = true;
        }

        //Metodo para validar el ingreso de letras en los textbox
        private void txtCaracter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarSegundoCombo();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (cbProducto.SelectedValue != null )
            {
                if (txtCantidad.Text != " " && txtCantidad != null)
                {
                    //cnpro
                }
            }
        }
    }
}

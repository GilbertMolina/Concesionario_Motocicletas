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
    public partial class frmAdquisiciones : Form
    {
        Boolean productoCargado = false;
        public frmAdquisiciones()
        {
            InitializeComponent();
        }

        private void frmAdquisiciones_Load(object sender, EventArgs e)
        {
            cargarFormulario();
        }

        private void dgvListaAdquisiciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarCamposDelDataGridViewListaAdquisiciones();
        }

        private void dgvListaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarCamposDelDataGridViewListaProductos();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            agregarAdquisicion();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            actualizarAdquisicion();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            eliminarAdquisicion();
        }

        private void btLimpiarFormulario_Click(object sender, EventArgs e)
        {
            limpiarCamposFormulario();
        }

        private void btRefrescarFormulario_Click(object sender, EventArgs e)
        {
            cargarFormulario();
        }

        private void btAgregarProducto_Click(object sender, EventArgs e)
        {
            if (rbVehiculosNuevos.Checked)
            {
                frmVehiculoNuevo formularioVehiculoNuevo = new frmVehiculoNuevo();
                formularioVehiculoNuevo.Show();
            }
            else if (rbVehiculosUsados.Checked)
            {
                frmVehiculoUsado formularioVehiculoUsado = new frmVehiculoUsado();
                formularioVehiculoUsado.Show();
            }
            else if (rbRepuestos.Checked)
            {
                frmRepuestos formulariofrmRepuestos = new frmRepuestos();
                formulariofrmRepuestos.Show();
            }
        }

        private void btRefrescarDataGrids_Click(object sender, EventArgs e)
        {
            llenarDataGrigViewProductos();
        }

        public void cargarFormulario()
        {
            btAgregar.Enabled = true;
            btActualizar.Enabled = false;
            btEliminar.Enabled = false;
            btLimpiarFormulario.Enabled = true;

            rbVehiculosNuevos.Checked = true;

            llenarDataGrigViewAdquisiciones();

            llenarDataGrigViewProductos();

            txtFechaCompra.Text = DateTime.Now.ToString().Split(' ')[0].Trim();

            cargarToolTips();
        }

        public void agregarAdquisicion()
        {
            objAdquisiciones objAdquisicion = new objAdquisiciones();
            cnAdquisiciones cnAdquisicion = new cnAdquisiciones();

            if (validarCamposLlenos())
            {
                if (txtCodVehiculo.Text != "")
                {
                    objAdquisicion.Cod_Vehiculo = txtCodVehiculo.Text;
                    objAdquisicion.Cod_Repuesto = "";
                    objAdquisicion.Cantidad_Unidades = Convert.ToInt32(txtCantidadUnidades.Text);
                    objAdquisicion.Valor = Convert.ToDouble(txtValor.Text);
                    objAdquisicion.Fecha_Compra = Convert.ToDateTime(txtFechaCompra.Text);

                    if (cnAdquisicion.insertarAdquisicion(objAdquisicion, 1))
                    {
                        llenarDataGrigViewAdquisiciones();

                        btAgregar.Enabled = true;
                        btActualizar.Enabled = false;
                        btEliminar.Enabled = false;
                        btLimpiarFormulario.Enabled = true;

                        limpiarCamposFormulario();
                    }
                    else
                    {
                        if (txtCodVehiculo.Text == "")
                        {
                            txtCodVehiculo.BackColor = Color.Tomato;
                        }
                        else
                        {
                            txtCodRepuesto.BackColor = Color.Tomato;
                        }
                        txtFechaCompra.BackColor = Color.Tomato;
                    }
                }
                else
                {
                    objAdquisicion.Cod_Vehiculo = "";
                    objAdquisicion.Cod_Repuesto = txtCodRepuesto.Text;
                    objAdquisicion.Cantidad_Unidades = Convert.ToInt32(txtCantidadUnidades.Text);
                    objAdquisicion.Valor = Convert.ToDouble(txtValor.Text);
                    objAdquisicion.Fecha_Compra = Convert.ToDateTime(txtFechaCompra.Text);

                    if (cnAdquisicion.insertarAdquisicion(objAdquisicion, 2))
                    {
                        llenarDataGrigViewAdquisiciones();

                        btAgregar.Enabled = true;
                        btActualizar.Enabled = false;
                        btEliminar.Enabled = false;
                        btLimpiarFormulario.Enabled = true;

                        limpiarCamposFormulario();
                    }
                    else
                    {
                        if (txtCodVehiculo.Text == "")
                        {
                            txtCodVehiculo.BackColor = Color.Tomato;
                        }
                        else
                        {
                            txtCodRepuesto.BackColor = Color.Tomato;
                        }
                        txtFechaCompra.BackColor = Color.Tomato;
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe digitar los campos del formulario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public void actualizarAdquisicion()
        {
            objAdquisiciones objAdquisicion = new objAdquisiciones();
            cnAdquisiciones cnAdquisicion = new cnAdquisiciones();

            if (validarCamposLlenos())
            {
                DialogResult eleccionActualizar = MessageBox.Show("¿Desea actualizar el adquisición seleccionada?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eleccionActualizar == DialogResult.Yes)
                {
                    objAdquisicion.Cod_Fact_Compra = Convert.ToInt32(txtCodigoFacturaCompra.Text);
                    objAdquisicion.Cantidad_Unidades = Convert.ToInt32(txtCantidadUnidades.Text);
                    objAdquisicion.Valor = Convert.ToDouble(txtValor.Text);

                    cnAdquisicion.actualizarAdquisicion(objAdquisicion);

                    llenarDataGrigViewAdquisiciones();

                    btAgregar.Enabled = true;
                    btActualizar.Enabled = false;
                    btEliminar.Enabled = false;

                    limpiarCamposFormulario();
                }
            }
            else
            {
                MessageBox.Show("Debe de cargar primero una adquisición de la lista de adquisiciones", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void eliminarAdquisicion()
        {
            objAdquisiciones objAdquisicion = new objAdquisiciones();
            cnAdquisiciones cnAdquisicion = new cnAdquisiciones();

            if (validarCamposLlenos())
            {
                DialogResult eleccionActualizar = MessageBox.Show("¿Desea eliminar el adquisición seleccionada?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eleccionActualizar == DialogResult.Yes)
                {
                    objAdquisicion.Cod_Fact_Compra = Convert.ToInt32(txtCodigoFacturaCompra.Text);

                    cnAdquisicion.eliminarAdquisicion(objAdquisicion);

                    llenarDataGrigViewAdquisiciones();

                    btAgregar.Enabled = true;
                    btActualizar.Enabled = false;
                    btEliminar.Enabled = false;

                    limpiarCamposFormulario();
                }
            }
            else
            {
                MessageBox.Show("Debe de cargar primero una adquisición de la lista de adquisiciones", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void llenarDataGrigViewAdquisiciones()
        {
            cnAdquisiciones cnAdquisicion = new cnAdquisiciones();
            DataTable tablaAdquisiciones = new DataTable();

            dgvListaAdquisiciones.Rows.Clear();

            dgvListaAdquisiciones.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            tablaAdquisiciones = cnAdquisicion.consultarAdquisiciones();

            for (int i = 0; i < tablaAdquisiciones.Rows.Count; i++)
            {
                String solamenteFechaCompra = tablaAdquisiciones.Rows[i][5].ToString().Split(' ')[0].Trim();
                String cod_vehiculo = "N/A";
                String cod_repuesto = "N/A";

                if (tablaAdquisiciones.Rows[i][1].ToString() != "")
                {
                    cod_vehiculo = tablaAdquisiciones.Rows[i][1].ToString();
                }
                else if (tablaAdquisiciones.Rows[i][2].ToString() != "")
                {
                    cod_repuesto = tablaAdquisiciones.Rows[i][2].ToString();
                }

                dgvListaAdquisiciones.Rows.Add(tablaAdquisiciones.Rows[i][0], cod_vehiculo, cod_repuesto,
                                               tablaAdquisiciones.Rows[i][3], tablaAdquisiciones.Rows[i][4], solamenteFechaCompra);
            }
        }

        public void llenarDataGrigViewProductos()
        {
            cnAdquisiciones cnAdquisicion = new cnAdquisiciones();
            DataTable TablaProductos = new DataTable();

            dgvListaProductos.DataSource = null;
            dgvListaProductos.Rows.Clear();

            dgvListaProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            if (rbVehiculosNuevos.Checked)
            {
                TablaProductos = cnAdquisicion.consultarProductos(1);
            }
            else if (rbVehiculosUsados.Checked)
            {
                TablaProductos = cnAdquisicion.consultarProductos(2);
            }
            else if (rbRepuestos.Checked)
            {
                TablaProductos = cnAdquisicion.consultarProductos(3);
            }
            dgvListaProductos.DataSource = TablaProductos;
        }

        public void cargarCamposDelDataGridViewListaAdquisiciones()
        {
            if (dgvListaAdquisiciones.CurrentRow.Cells[0].Value.ToString() != "")
            {
                DialogResult eleccionCargar = MessageBox.Show("¿Desea cargar el producto seleccionado al formulario?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eleccionCargar == DialogResult.Yes)
                {
                    txtCodigoFacturaCompra.Text = dgvListaAdquisiciones.CurrentRow.Cells[0].Value.ToString();
                    txtCodVehiculo.Text = dgvListaAdquisiciones.CurrentRow.Cells[1].Value.ToString();
                    txtCodRepuesto.Text = dgvListaAdquisiciones.CurrentRow.Cells[2].Value.ToString();
                    txtCantidadUnidades.Text = dgvListaAdquisiciones.CurrentRow.Cells[3].Value.ToString();
                    txtValor.Text = dgvListaAdquisiciones.CurrentRow.Cells[4].Value.ToString();
                    txtFechaCompra.Text = dgvListaAdquisiciones.CurrentRow.Cells[5].Value.ToString();

                    btAgregar.Enabled = false;
                    btActualizar.Enabled = true;
                    btEliminar.Enabled = true;
                    btLimpiarFormulario.Enabled = true;
                }
            }
            productoCargado = true;
        }

        public void cargarCamposDelDataGridViewListaProductos()
        {
            if (productoCargado == false)
            {
                if (dgvListaProductos.CurrentRow.Cells[0].Value.ToString() != "")
                {
                    DialogResult eleccionCargar = MessageBox.Show("¿Desea cargar el producto seleccionado al formulario?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (eleccionCargar == DialogResult.Yes)
                    {
                        if (rbVehiculosNuevos.Checked)
                        {
                            txtCodVehiculo.Text = dgvListaProductos.CurrentRow.Cells[0].Value.ToString();
                            txtCodRepuesto.Text = "";
                        }
                        else if (rbVehiculosUsados.Checked)
                        {
                            txtCodVehiculo.Text = dgvListaProductos.CurrentRow.Cells[0].Value.ToString();
                            txtCodRepuesto.Text = "";
                        }
                        else if (rbRepuestos.Checked)
                        {
                            txtCodVehiculo.Text = "";
                            txtCodRepuesto.Text = dgvListaProductos.CurrentRow.Cells[0].Value.ToString();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("El campo producto no puede ser modificado, dado que fue cargado de la lista de adquisiciones.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public Boolean validarCamposLlenos()
        {
            Boolean camposCompletados = false;
            if ((txtCodVehiculo.Text != "" || txtCodRepuesto.Text != "") && txtCantidadUnidades.Text != "" && txtValor.Text != "")
            {
                camposCompletados = true;
            }
            return camposCompletados;
        }

        public void limpiarCamposFormulario()
        {
            txtCodigoFacturaCompra.Text = "";
            txtCodVehiculo.Text = "";
            txtCodRepuesto.Text = "";
            txtCantidadUnidades.Text = "";
            txtValor.Text = "";
            txtFechaCompra.Text = "";

            btAgregar.Enabled = true;
            btActualizar.Enabled = false;
            btEliminar.Enabled = false;
            btLimpiarFormulario.Enabled = true;

            productoCargado = false;

            txtFechaCompra.Text = DateTime.Now.ToString().Split(' ')[0].Trim();
        }

        public void cargarToolTips()
        {
            this.ttbtAgregar.SetToolTip(btAgregar, "Agregar adquisición");
            this.ttbtAgregar.IsBalloon = true;
            this.ttbtActualizar.SetToolTip(btActualizar, "Actualizar adquisición");
            this.ttbtActualizar.IsBalloon = true;
            this.ttbtEliminar.SetToolTip(btEliminar, "Eliminar adquisición");
            this.ttbtEliminar.IsBalloon = true;
            this.ttbtLimpiar.SetToolTip(btLimpiarFormulario, "Limpiar datos del formulario");
            this.ttbtLimpiar.IsBalloon = true;
            this.ttbtAgregarProducto.SetToolTip(btAgregarProducto, "Desplegar formulario de agregar vehículo nuevo");
            this.ttbtAgregarProducto.IsBalloon = true;
            this.ttbtRefrescarListas.SetToolTip(btRefrescarDataGrids, "Refrescar listas");
            this.ttbtRefrescarListas.IsBalloon = true;
            this.ttrbVehiculosNuevos.SetToolTip(rbVehiculosNuevos, "Mostrar vehículos nuevos");
            this.ttrbVehiculosNuevos.IsBalloon = true;
            this.ttrbVehiculosUsados.SetToolTip(rbVehiculosUsados, "Mostrar vehículos usados");
            this.ttrbVehiculosUsados.IsBalloon = true;
            this.ttrbRepuestos.SetToolTip(rbRepuestos, "Mostrar repuestos");
            this.ttrbRepuestos.IsBalloon = true;
            this.ttbtRefrescarFormulario.SetToolTip(btRefrescarFormulario, "Actualizar todo el formulario");
            this.ttbtRefrescarFormulario.IsBalloon = true;
        }

        private void rbVehiculosNuevos_Click(object sender, EventArgs e)
        {
            rbVehiculosUsados.Checked = false;
            rbRepuestos.Checked = false;
            llenarDataGrigViewProductos();
            this.ttbtAgregarProducto.SetToolTip(btAgregarProducto, "Desplegar formulario de agregar vehículo nuevo");
            this.ttbtAgregarProducto.IsBalloon = true;
        }

        private void rbVehiculosUsados_Click(object sender, EventArgs e)
        {
            rbVehiculosNuevos.Checked = false;
            rbRepuestos.Checked = false;
            llenarDataGrigViewProductos();
            this.ttbtAgregarProducto.SetToolTip(btAgregarProducto, "Desplegar formulario de agregar vehículo usado");
            this.ttbtAgregarProducto.IsBalloon = true;
        }

        private void rbRepuestos_Click(object sender, EventArgs e)
        {
            rbVehiculosNuevos.Checked = false;
            rbVehiculosUsados.Checked = false;
            llenarDataGrigViewProductos();
            this.ttbtAgregarProducto.SetToolTip(btAgregarProducto, "Desplegar formulario de agregar repuesto");
            this.ttbtAgregarProducto.IsBalloon = true;
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

    }
}

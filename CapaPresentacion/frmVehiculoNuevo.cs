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
    public partial class frmVehiculoNuevo : Form
    {
        public frmVehiculoNuevo()
        {
            InitializeComponent();
        }

        private void frmVehiculoNuevo_Load(object sender, EventArgs e)
        {
            cargarFormulario();
        }

        private void dgvListaVehiculosNuevos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarCamposDelDataGridView();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            agregarVehiculoNuevo();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            actualizarVehiculoNuevo();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            eliminarVehiculoNuevo();
        }

        private void btLimpiarFormulario_Click(object sender, EventArgs e)
        {
            limpiarCamposFormulario();
        }

        private void btRefrescarFormulario_Click(object sender, EventArgs e)
        {
            cargarFormulario();
        }

        public void cargarFormulario()
        {
            btAgregar.Enabled = true;
            btActualizar.Enabled = false;
            btEliminar.Enabled = false;
            btLimpiarFormulario.Enabled = true;

            llenarDataGrigView();

            cargarToolTips();
        }

        public void agregarVehiculoNuevo()
        {
            objVehiculoNuevo objVehiculosNuevos = new objVehiculoNuevo();
            cnVehiculoNuevo cnVehiculosNuevos = new cnVehiculoNuevo();

            if (validarCamposLlenos())
            {
                objVehiculosNuevos.Marca = txtMarca.Text;
                objVehiculosNuevos.Modelo = txtModelo.Text;
                objVehiculosNuevos.Color = txtColor.Text;
                objVehiculosNuevos.Precio_Unitario = Convert.ToDouble(txtPrecioUnitario.Text);
                objVehiculosNuevos.Garantia = txtGarantia.Text;
                objVehiculosNuevos.Primer_Mantenimiento = txtPrimerMantenimiento.Text;
                objVehiculosNuevos.Especificaciones = txtEspecificaciones.Text;

                if (cnVehiculosNuevos.insertarVehiculoNuevo(objVehiculosNuevos))
                {
                    llenarDataGrigView();

                    btAgregar.Enabled = true;
                    btActualizar.Enabled = false;
                    btEliminar.Enabled = false;
                    btLimpiarFormulario.Enabled = true;

                    limpiarCamposFormulario();
                }
                else
                {
                    txtMarca.BackColor = Color.Tomato;
                    txtModelo.BackColor = Color.Tomato;
                    txtColor.BackColor = Color.Tomato;
                }
            }
            else
            {
                MessageBox.Show("Debe digitar los campos del formulario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void actualizarVehiculoNuevo()
        {
            objVehiculoNuevo objVehiculosNuevos = new objVehiculoNuevo();
            cnVehiculoNuevo cnVehiculosNuevos = new cnVehiculoNuevo();

            if (validarCamposLlenos())
            {
                DialogResult eleccionActualizar = MessageBox.Show("¿Desea actualizar el vehículo seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eleccionActualizar == DialogResult.Yes)
                {
                    objVehiculosNuevos.Cod_Vehiculo = txtCodigoVehiculo.Text;
                    objVehiculosNuevos.Marca = txtMarca.Text;
                    objVehiculosNuevos.Modelo = txtModelo.Text;
                    objVehiculosNuevos.Color = txtColor.Text;
                    objVehiculosNuevos.Precio_Unitario = Convert.ToDouble(txtPrecioUnitario.Text);
                    objVehiculosNuevos.Garantia = txtGarantia.Text;
                    objVehiculosNuevos.Primer_Mantenimiento = txtPrimerMantenimiento.Text;
                    objVehiculosNuevos.Especificaciones = txtEspecificaciones.Text;

                    cnVehiculosNuevos.actualizarVehiculoNuevo(objVehiculosNuevos);

                    llenarDataGrigView();

                    txtMarca.Enabled = true;
                    txtModelo.Enabled = true;
                    txtColor.Enabled = true;

                    btAgregar.Enabled = true;
                    btActualizar.Enabled = false;
                    btEliminar.Enabled = false;

                    limpiarCamposFormulario();
                }
            }
            else
            {
                MessageBox.Show("Debe de cargar primero un vehículo de la lista de vehículos nuevos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void eliminarVehiculoNuevo()
        {
            objVehiculoNuevo objVehiculosNuevos = new objVehiculoNuevo();
            cnVehiculoNuevo cnVehiculosNuevos = new cnVehiculoNuevo();

            DialogResult eleccionBorrar = MessageBox.Show("¿Desea eliminar el vehículo seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (eleccionBorrar == DialogResult.Yes)
            {
                objVehiculosNuevos.Cod_Vehiculo = dgvListaVehiculosNuevos.CurrentRow.Cells[0].Value.ToString();
                cnVehiculosNuevos.eliminarVehiculoNuevo(objVehiculosNuevos);

                llenarDataGrigView();

                txtMarca.Enabled = true;
                txtModelo.Enabled = true;
                txtColor.Enabled = true;

                btAgregar.Enabled = true;
                btActualizar.Enabled = false;
                btEliminar.Enabled = false;

                limpiarCamposFormulario();
            }
        }

        public void llenarDataGrigView()
        {
            cnVehiculoNuevo cnVehiculosNuevos = new cnVehiculoNuevo();
            DataTable tablaVehiculos = new DataTable();

            dgvListaVehiculosNuevos.Rows.Clear();

            dgvListaVehiculosNuevos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            tablaVehiculos = cnVehiculosNuevos.consultarVehiculosNuevos();

            for (int i = 0; i < tablaVehiculos.Rows.Count; i++)
            {
                dgvListaVehiculosNuevos.Rows.Add(tablaVehiculos.Rows[i][0], tablaVehiculos.Rows[i][1], tablaVehiculos.Rows[i][2],
                                                 tablaVehiculos.Rows[i][3], tablaVehiculos.Rows[i][4], tablaVehiculos.Rows[i][5],
                                                 tablaVehiculos.Rows[i][6], tablaVehiculos.Rows[i][7]);
            }
        }

        public void cargarCamposDelDataGridView()
        {
            if (dgvListaVehiculosNuevos.CurrentRow.Cells[0].Value.ToString() != "")
            {
                DialogResult eleccionCargar = MessageBox.Show("¿Desea cargar el vehículo seleccionado al formulario?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eleccionCargar == DialogResult.Yes)
                {
                    txtCodigoVehiculo.Text = dgvListaVehiculosNuevos.CurrentRow.Cells[0].Value.ToString();
                    txtMarca.Text = dgvListaVehiculosNuevos.CurrentRow.Cells[1].Value.ToString();
                    txtModelo.Text = dgvListaVehiculosNuevos.CurrentRow.Cells[2].Value.ToString();
                    txtColor.Text = dgvListaVehiculosNuevos.CurrentRow.Cells[3].Value.ToString();
                    txtPrecioUnitario.Text = dgvListaVehiculosNuevos.CurrentRow.Cells[4].Value.ToString();
                    txtGarantia.Text = dgvListaVehiculosNuevos.CurrentRow.Cells[5].Value.ToString();
                    txtPrimerMantenimiento.Text = dgvListaVehiculosNuevos.CurrentRow.Cells[6].Value.ToString();
                    txtEspecificaciones.Text = dgvListaVehiculosNuevos.CurrentRow.Cells[7].Value.ToString();

                    txtMarca.Enabled = false;
                    txtModelo.Enabled = false;
                    txtColor.Enabled = false;

                    btAgregar.Enabled = false;
                    btActualizar.Enabled = true;
                    btEliminar.Enabled = true;
                    btLimpiarFormulario.Enabled = true;
                }
            }
        }

        public Boolean validarCamposLlenos()
        {
            Boolean camposCompletados = false;
            if (txtMarca.Text != "" && txtModelo.Text != "" && txtColor.Text != "" && txtPrecioUnitario.Text != "" && 
                txtGarantia.Text != "" && txtPrimerMantenimiento.Text != "" && txtEspecificaciones.Text != "")
            {
                camposCompletados = true;
            }
            return camposCompletados;
        }

        public void limpiarCamposFormulario()
        {
            txtCodigoVehiculo.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtColor.Text = "";
            txtPrecioUnitario.Text = "";
            txtGarantia.Text = "";
            txtPrimerMantenimiento.Text = "";
            txtEspecificaciones.Text = "";

            txtMarca.Enabled = true;
            txtModelo.Enabled = true;
            txtColor.Enabled = true;

            txtMarca.BackColor = Color.White;
            txtModelo.BackColor = Color.White;
            txtColor.BackColor = Color.White;

            btAgregar.Enabled = true;
            btActualizar.Enabled = false;
            btEliminar.Enabled = false;
            btLimpiarFormulario.Enabled = true;
        }

        public void cargarToolTips()
        {
            this.ttbtAgregar.SetToolTip(btAgregar, "Agregar vehículo nuevo");
            this.ttbtAgregar.IsBalloon = true;
            this.ttbtActualizar.SetToolTip(btActualizar, "Actualizar vehículo nuevo");
            this.ttbtActualizar.IsBalloon = true;
            this.ttbtEliminar.SetToolTip(btEliminar, "Eliminar vehículo nuevo");
            this.ttbtEliminar.IsBalloon = true;
            this.ttbtLimpiar.SetToolTip(btLimpiarFormulario, "Limpiar datos del formulario");
            this.ttbtLimpiar.IsBalloon = true;
            this.ttbtRefrescarFormulario.SetToolTip(btRefrescarFormulario, "Actualizar todo el formulario");
            this.ttbtRefrescarFormulario.IsBalloon = true;
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

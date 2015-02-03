using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;
using Objetos;

namespace CapaPresentacion
{
    public partial class frmVehiculoUsado : Form
    {
        public frmVehiculoUsado()
        {
            InitializeComponent();
        }

        private void frmVehiculoUsado_Load(object sender, EventArgs e)
        {
            cargarFormulario();
        }

        private void dgvListaVehiculosUsados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarCamposDelDataGridView();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            agregarVehiculoUsado();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            actualizarVehiculoUsado();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            eliminarVehiculoUsado();
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

        public void agregarVehiculoUsado()
        {
            objVehiculoUsado objVehiculosUsados = new objVehiculoUsado();
            cnVehiculoUsado cnVehiculosUsados = new cnVehiculoUsado();
            
            if (validarCamposLlenos())
            {
                objVehiculosUsados.Marca = txtMarca.Text;
                objVehiculosUsados.Modelo = txtModelo.Text;
                objVehiculosUsados.Color = txtColor.Text;
                objVehiculosUsados.Precio_Unitario = Convert.ToDouble(txtPrecioUnitario.Text);
                objVehiculosUsados.Garantia = txtGarantia.Text;
                objVehiculosUsados.Numero_Placa = txtNumeroPlaca.Text;
                objVehiculosUsados.Kilometraje = Convert.ToInt32(txtKilometraje.Text);
                objVehiculosUsados.Estado = txtEstado.Text;
                objVehiculosUsados.Especificaciones = txtEspecificaciones.Text;

                if (cnVehiculosUsados.insertarVehiculoUsado(objVehiculosUsados))
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
                    txtNumeroPlaca.BackColor = Color.Tomato;
                }
            }
            else
            {
                MessageBox.Show("Debe digitar los campos del formulario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void actualizarVehiculoUsado()
        {
            objVehiculoUsado objVehiculosUsados = new objVehiculoUsado();
            cnVehiculoUsado cnVehiculosUsados = new cnVehiculoUsado();

            if (validarCamposLlenos())
            {
                DialogResult eleccionActualizar = MessageBox.Show("¿Desea actualizar el vehículo seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eleccionActualizar == DialogResult.Yes)
                {
                    objVehiculosUsados.Cod_Vehiculo = txtCodigoVehiculo.Text;
                    objVehiculosUsados.Marca = txtMarca.Text;
                    objVehiculosUsados.Modelo = txtModelo.Text;
                    objVehiculosUsados.Color = txtColor.Text;
                    objVehiculosUsados.Precio_Unitario = Convert.ToDouble(txtPrecioUnitario.Text);
                    objVehiculosUsados.Garantia = txtGarantia.Text;
                    objVehiculosUsados.Numero_Placa = txtNumeroPlaca.Text;
                    objVehiculosUsados.Kilometraje = Convert.ToInt32(txtKilometraje.Text);
                    objVehiculosUsados.Estado = txtEstado.Text;
                    objVehiculosUsados.Especificaciones = txtEspecificaciones.Text;

                    cnVehiculosUsados.actualizarVehiculoUsado(objVehiculosUsados);

                    llenarDataGrigView();

                    txtNumeroPlaca.Enabled = true;

                    btAgregar.Enabled = true;
                    btActualizar.Enabled = false;
                    btEliminar.Enabled = false;

                    limpiarCamposFormulario();
                }
            }
            else
            {
                MessageBox.Show("Debe de cargar primero un vehículo de la lista de vehículos usados", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void eliminarVehiculoUsado()
        {
            objVehiculoUsado objVehiculosUsados = new objVehiculoUsado();
            cnVehiculoUsado cnVehiculosUsados = new cnVehiculoUsado();

            DialogResult eleccionBorrar = MessageBox.Show("¿Desea eliminar el vehículo seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (eleccionBorrar == DialogResult.Yes)
            {
                objVehiculosUsados.Cod_Vehiculo = dgvListaVehiculosUsados.CurrentRow.Cells[0].Value.ToString();
                cnVehiculosUsados.eliminarVehiculoUsado(objVehiculosUsados);

                llenarDataGrigView();

                txtNumeroPlaca.Enabled = true;

                btAgregar.Enabled = true;
                btActualizar.Enabled = false;
                btEliminar.Enabled = false;

                limpiarCamposFormulario();
            }
        }
        
        public void llenarDataGrigView()
        {
            cnVehiculoUsado cnVehiculosUsados = new cnVehiculoUsado();
            DataTable tablaVehiculos = new DataTable();
            
            dgvListaVehiculosUsados.Rows.Clear();

            dgvListaVehiculosUsados.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            
            tablaVehiculos = cnVehiculosUsados.consultarVehiculosUsados();
            
            for (int i = 0; i < tablaVehiculos.Rows.Count; i++)
            {
                dgvListaVehiculosUsados.Rows.Add(tablaVehiculos.Rows[i][0], tablaVehiculos.Rows[i][1], tablaVehiculos.Rows[i][2],
                                                 tablaVehiculos.Rows[i][3], tablaVehiculos.Rows[i][4], tablaVehiculos.Rows[i][5],
                                                 tablaVehiculos.Rows[i][6], tablaVehiculos.Rows[i][7], tablaVehiculos.Rows[i][8],
                                                 tablaVehiculos.Rows[i][9]);
            }
        }
        
        public void cargarCamposDelDataGridView()
        {
            if (dgvListaVehiculosUsados.CurrentRow.Cells[0].Value.ToString() != "")
            {
                DialogResult eleccionCargar = MessageBox.Show("¿Desea cargar el vehículo seleccionado al formulario?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eleccionCargar == DialogResult.Yes)
                {
                    txtCodigoVehiculo.Text = dgvListaVehiculosUsados.CurrentRow.Cells[0].Value.ToString();
                    txtMarca.Text = dgvListaVehiculosUsados.CurrentRow.Cells[1].Value.ToString();
                    txtModelo.Text = dgvListaVehiculosUsados.CurrentRow.Cells[2].Value.ToString();
                    txtColor.Text = dgvListaVehiculosUsados.CurrentRow.Cells[3].Value.ToString();
                    txtPrecioUnitario.Text = dgvListaVehiculosUsados.CurrentRow.Cells[4].Value.ToString();
                    txtGarantia.Text = dgvListaVehiculosUsados.CurrentRow.Cells[5].Value.ToString();
                    txtEstado.Text = dgvListaVehiculosUsados.CurrentRow.Cells[6].Value.ToString();
                    txtKilometraje.Text = dgvListaVehiculosUsados.CurrentRow.Cells[7].Value.ToString();
                    txtNumeroPlaca.Text = dgvListaVehiculosUsados.CurrentRow.Cells[8].Value.ToString();
                    txtEspecificaciones.Text = dgvListaVehiculosUsados.CurrentRow.Cells[9].Value.ToString();
                    
                    txtNumeroPlaca.Enabled = false;
                    
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
                txtGarantia.Text != "" && txtNumeroPlaca.Text != "" && txtKilometraje.Text != "" && txtEstado.Text != "" && txtEspecificaciones.Text != "")
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
            txtNumeroPlaca.Text = "";
            txtKilometraje.Text = "";
            txtEstado.Text = "";
            txtEspecificaciones.Text = "";
            
            txtNumeroPlaca.Enabled = true;

            txtNumeroPlaca.BackColor = Color.White;
            
            btAgregar.Enabled = true;
            btActualizar.Enabled = false;
            btEliminar.Enabled = false;
            btLimpiarFormulario.Enabled = true;
        }

        public void cargarToolTips()
        {
            this.ttbtAgregar.SetToolTip(btAgregar, "Agregar vehículo usado");
            this.ttbtAgregar.IsBalloon = true;
            this.ttbtActualizar.SetToolTip(btActualizar, "Actualizar vehículo usado");
            this.ttbtActualizar.IsBalloon = true;
            this.ttbtEliminar.SetToolTip(btEliminar, "Eliminar vehículo usado");
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
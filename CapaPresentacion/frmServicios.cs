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
    public partial class frmServicios : Form
    {
        public frmServicios()
        {
            InitializeComponent();
        }

        private void frmServicios_Load(object sender, EventArgs e)
        {
            cargarFormulario();
        }

        private void dgvListaServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarCamposDelDataGridView();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            agregarServicio();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            actualizarServicio();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            eliminarServicio();
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

            cargarComboBoxes();

            cargarToolTips();
        }

        public void agregarServicio()
        {
            objServicios objServicios = new objServicios();
            cnServicios cnServicios = new cnServicios();

            if (validarCamposLlenos())
            {
                objServicios.Cod_Empleado = Convert.ToInt32(cbMecanicos.SelectedValue.ToString());
                objServicios.Tipo = txtTipo.Text;
                objServicios.Precio = Convert.ToDouble(txtPrecio.Text);
                objServicios.Descripcion = txtDescripcion.Text;

                if (cnServicios.insertarServicio(objServicios))
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
                    txtTipo.BackColor = Color.Tomato;
                    txtPrecio.BackColor = Color.Tomato;
                    txtDescripcion.BackColor = Color.Tomato;
                }
            }
            else
            {
                MessageBox.Show("Debe digitar los campos del formulario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void actualizarServicio()
        {
            objServicios objServicios = new objServicios();
            cnServicios cnServicios = new cnServicios();

            if (validarCamposLlenos())
            {
                DialogResult eleccionActualizar = MessageBox.Show("¿Desea actualizar el servicio seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eleccionActualizar == DialogResult.Yes)
                {
                    objServicios.Cod_Servicio = txtCodigoServicio.Text;
                    objServicios.Cod_Empleado = Convert.ToInt32(cbMecanicos.SelectedValue);
                    objServicios.Tipo = txtTipo.Text;
                    objServicios.Precio = Convert.ToDouble(txtPrecio.Text);
                    objServicios.Descripcion = txtDescripcion.Text;

                    cnServicios.actualizarServicio(objServicios);

                    llenarDataGrigView();

                    btAgregar.Enabled = true;
                    btActualizar.Enabled = false;
                    btEliminar.Enabled = false;

                    limpiarCamposFormulario();
                }
            }
            else
            {
                MessageBox.Show("Debe de cargar primero un servicio de la lista de servicios", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void eliminarServicio()
        {
            objServicios objServicios = new objServicios();
            cnServicios cnServicios = new cnServicios();

            DialogResult eleccionBorrar = MessageBox.Show("¿Desea eliminar el servicio seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (eleccionBorrar == DialogResult.Yes)
            {
                objServicios.Cod_Servicio = Convert.ToString(dgvListaServicios.CurrentRow.Cells[0].Value);

                cnServicios.eliminarServicio(objServicios);

                llenarDataGrigView();

                btAgregar.Enabled = true;
                btActualizar.Enabled = false;
                btEliminar.Enabled = false;

                limpiarCamposFormulario();
            }
        }

        public void llenarDataGrigView()
        {
            cnServicios cnServicios = new cnServicios();
            DataTable tablaServicios = new DataTable();

            dgvListaServicios.Rows.Clear();

            dgvListaServicios.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            tablaServicios = cnServicios.consultarServicio();

            for (int i = 0; i < tablaServicios.Rows.Count; i++)
            {
                dgvListaServicios.Rows.Add(tablaServicios.Rows[i][0], tablaServicios.Rows[i][1], tablaServicios.Rows[i][2],
                                                 tablaServicios.Rows[i][3], tablaServicios.Rows[i][4]);
            }
        }

        public void cargarComboBoxes()
        {
            cnEmpleados cnEmpleado = new cnEmpleados();
            DataTable TablaEmpleados = new DataTable();

            if (cnEmpleado.consultarEmpleadosTaller().Rows.Count > 0)
            {
                cbMecanicos.DataSource = cnEmpleado.consultarEmpleadosTaller();
                cbMecanicos.DisplayMember = "nombre_empleado";
                cbMecanicos.ValueMember = "cod_empleado";
            }
            else
            {
                cbMecanicos.DataSource = null;
                cbMecanicos.DisplayMember = "";
                cbMecanicos.ValueMember = "";
            }
        }

        public void cargarCamposDelDataGridView()
        {
            if (dgvListaServicios.CurrentRow.Cells[0].Value.ToString() != "")
            {
                DialogResult eleccionCargar = MessageBox.Show("¿Desea cargar el servicio seleccionado al formulario?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eleccionCargar == DialogResult.Yes)
                {
                    txtCodigoServicio.Text = dgvListaServicios.CurrentRow.Cells[0].Value.ToString();
                    cbMecanicos.Text = dgvListaServicios.CurrentRow.Cells[1].Value.ToString();
                    txtTipo.Text = dgvListaServicios.CurrentRow.Cells[2].Value.ToString();
                    txtPrecio.Text = dgvListaServicios.CurrentRow.Cells[3].Value.ToString();
                    txtDescripcion.Text = dgvListaServicios.CurrentRow.Cells[4].Value.ToString();

                    txtTipo.Enabled = false;

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
            if (txtTipo.Text != "" && txtPrecio.Text != "" && txtDescripcion.Text != "" )
            {
                camposCompletados = true;
            }
            return camposCompletados;
        }

        public void limpiarCamposFormulario()
        {
            txtCodigoServicio.Text = "";
            txtTipo.Text = "";
            txtPrecio.Text = "";
            txtDescripcion.Text = "";

            txtTipo.Enabled = true;
            txtPrecio.Enabled = true;
            txtDescripcion.Enabled = true;

            btAgregar.Enabled = true;
            btActualizar.Enabled = false;
            btEliminar.Enabled = false;
            btLimpiarFormulario.Enabled = true;

            cargarComboBoxes();
        }

        public void cargarToolTips()
        {
            this.ttbtAgregar.SetToolTip(btAgregar, "Agregar servicios");
            this.ttbtAgregar.IsBalloon = true;
            this.ttbtActualizar.SetToolTip(btActualizar, "Actualizar servicios");
            this.ttbtActualizar.IsBalloon = true;
            this.ttbtEliminar.SetToolTip(btEliminar, "Eliminar servicios");
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

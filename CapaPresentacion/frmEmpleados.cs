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
using System.Text.RegularExpressions;

namespace CapaPresentacion
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            cargarFormulario();
        }

        private void dgvListaEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarCamposDelDataGridView();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            agregarEmpleado();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            actualizarEmpleado();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            eliminarEmpleado();
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

            rbEmpleadosActivos.Checked = true;

            llenarDataGrigView();

            cargarComboBoxes();

            txtFecha_Contrato.Text = DateTime.Now.ToString().Split(' ')[0].Trim();

            cargarToolTips();
        }

        public void agregarEmpleado()
        {
            objEmpleados objEmpleado = new objEmpleados();
            cnEmpleados cnEmpleado = new cnEmpleados();

            if (validarCamposLlenos())
            {
                objEmpleado.Cedula = txtCedula.Text;
                objEmpleado.Nombre = txtNombre.Text;
                objEmpleado.Apellidos = txtApellidos.Text;
                objEmpleado.Cod_Departamento = Convert.ToInt32(cbNombreDepartamento.SelectedValue.ToString());
                objEmpleado.Correo = txtCorreo.Text;
                objEmpleado.Telefono = Convert.ToInt32(txtTelefono.Text);
                objEmpleado.Salario = txtSalario.Text;
                objEmpleado.Fecha_Contrato = Convert.ToDateTime(txtFecha_Contrato.Text);

                if (validarEmailCorrecto(txtCorreo.Text))
                {
                    if (cnEmpleado.insertarEmpleado(objEmpleado))
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
                        txtCedula.BackColor = Color.Tomato;
                        txtCorreo.BackColor = Color.Tomato;
                    }
                }
                else
                {
                    MessageBox.Show("Debe digitar correctamente el correo electrónico", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCorreo.BackColor = Color.Tomato;
                }
            }
            else
            {
                MessageBox.Show("Debe digitar los campos del formulario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void actualizarEmpleado()
        {
            objEmpleados objEmpleado = new objEmpleados();
            cnEmpleados cnEmpleado = new cnEmpleados();

            if (validarCamposLlenos())
            {
                DialogResult eleccionActualizar = MessageBox.Show("¿Desea actualizar el vehículo seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eleccionActualizar == DialogResult.Yes)
                {
                    if (cbEstado.Text == "Activo")
                    {
                        objEmpleado.Cod_Empleado = Convert.ToInt32(txtCodigoEmpleado.Text);
                        objEmpleado.Nombre = txtNombre.Text;
                        objEmpleado.Apellidos = txtApellidos.Text;
                        objEmpleado.Cod_Departamento = Convert.ToInt32(cbNombreDepartamento.SelectedValue.ToString());
                        objEmpleado.Telefono = Convert.ToInt32(txtTelefono.Text);
                        objEmpleado.Salario = txtSalario.Text;
                        objEmpleado.Fecha_Contrato = Convert.ToDateTime(txtFecha_Contrato.Text);
                        objEmpleado.Estado = Convert.ToInt32(cbEstado.SelectedValue.ToString());
                    }
                    else
                    {
                        objEmpleado.Cod_Empleado = Convert.ToInt32(txtCodigoEmpleado.Text);
                        objEmpleado.Nombre = txtNombre.Text;
                        objEmpleado.Apellidos = txtApellidos.Text;
                        objEmpleado.Cod_Departamento = Convert.ToInt32(cbNombreDepartamento.SelectedValue.ToString());
                        objEmpleado.Telefono = Convert.ToInt32(txtTelefono.Text);
                        objEmpleado.Salario = txtSalario.Text;
                        objEmpleado.Fecha_Despido = Convert.ToDateTime(txtFecha_Despido.Text);
                        objEmpleado.Estado = Convert.ToInt32(cbEstado.SelectedValue.ToString());
                    }

                    cnEmpleado.actualizarEmpleado(objEmpleado);

                    llenarDataGrigView();

                    txtCedula.Enabled = true;
                    txtCorreo.Enabled = true;
                    txtFecha_Contrato.Enabled = false;

                    btAgregar.Enabled = true;
                    btActualizar.Enabled = false;
                    btEliminar.Enabled = false;

                    limpiarCamposFormulario();
                }
            }
        }

        public void eliminarEmpleado()
        {
            objEmpleados objEmpleado = new objEmpleados();
            cnEmpleados cnEmpleado = new cnEmpleados();

            DialogResult eleccionEliminar = MessageBox.Show("¿Desea eliminar el empleado seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (eleccionEliminar == DialogResult.Yes)
            {
                objEmpleado.Cod_Empleado = Convert.ToInt32(dgvListaEmpleados.CurrentRow.Cells[0].Value.ToString());
                
                cnEmpleado.eliminarEmpleado(objEmpleado);

                llenarDataGrigView();

                txtCedula.Enabled = true;
                txtCorreo.Enabled = true;
                txtFecha_Contrato.Enabled = false;

                btAgregar.Enabled = true;
                btActualizar.Enabled = false;
                btEliminar.Enabled = false;

                limpiarCamposFormulario();
            }
        }

        public void llenarDataGrigView()
        {
            cnEmpleados cnEmpleado = new cnEmpleados();
            DataTable TablaEmpleados = new DataTable();

            dgvListaEmpleados.Rows.Clear();

            dgvListaEmpleados.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            if (rbEmpleadosActivos.Checked)
            {
                TablaEmpleados = cnEmpleado.consultarEmpleados(1);
            }
            else if (rbEmpleadosInactivos.Checked)
            {
                TablaEmpleados = cnEmpleado.consultarEmpleados(2);
            }

            for (int i = 0; i < TablaEmpleados.Rows.Count; i++)
            {
                String solamenteFechaContrato = TablaEmpleados.Rows[i][8].ToString().Split(' ')[0].Trim();
                String solamenteFechaDespido = TablaEmpleados.Rows[i][9].ToString().Split(' ')[0].Trim();
                String estado = "Inactivo";

                if (Convert.ToInt32(TablaEmpleados.Rows[i][10].ToString()) == 1)
                {
                    estado = "Activo";
                }

                dgvListaEmpleados.Rows.Add(TablaEmpleados.Rows[i][0], TablaEmpleados.Rows[i][1], TablaEmpleados.Rows[i][2],
                                           TablaEmpleados.Rows[i][3], TablaEmpleados.Rows[i][4], TablaEmpleados.Rows[i][5],
                                           TablaEmpleados.Rows[i][6], TablaEmpleados.Rows[i][7], solamenteFechaContrato,
                                           solamenteFechaDespido, estado);
            }

            cbEstado.Enabled = false;

        }

        public void cargarComboBoxes()
        {
            cnDepartamentos cnDepartamento = new cnDepartamentos();
            cbNombreDepartamento.DataSource = cnDepartamento.consultarDepartamentos();
            cbNombreDepartamento.DisplayMember = "nombre";
            cbNombreDepartamento.ValueMember = "cod_departamento";

            cbEstado.DataSource = crearTablaComboBoxEstado();
            cbEstado.DisplayMember = "valor";
            cbEstado.ValueMember = "id";
        }

        public DataTable crearTablaComboBoxEstado()
        {
            DataTable TablaEstado = new DataTable();
            DataColumn columna1 = new DataColumn();
            DataColumn columna2 = new DataColumn();
            DataRow fila;

            columna1.ColumnName = "id";
            columna1.DataType = System.Type.GetType("System.Int32");
            TablaEstado.Columns.Add(columna1);
            columna2.ColumnName = "valor";
            columna2.DataType = Type.GetType("System.String");
            TablaEstado.Columns.Add(columna2);

            fila = TablaEstado.NewRow();
            fila["id"] = 1;
            fila["valor"] = "Activo";
            TablaEstado.Rows.Add(fila);
            fila = TablaEstado.NewRow();
            fila["id"] = 2;
            fila["valor"] = "Inactivo";
            TablaEstado.Rows.Add(fila);

            return TablaEstado;
        }

        private void cargarCamposDelDataGridView()
        {
            if (dgvListaEmpleados.CurrentRow.Cells[0].Value.ToString() != "")
            {
                DialogResult eleccionCargar = MessageBox.Show("¿Desea cargar el empleado seleccionado al formulario?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eleccionCargar == DialogResult.Yes)
                {
                    txtCodigoEmpleado.Text = dgvListaEmpleados.CurrentRow.Cells[0].Value.ToString();
                    txtCedula.Text = dgvListaEmpleados.CurrentRow.Cells[1].Value.ToString();
                    txtNombre.Text = dgvListaEmpleados.CurrentRow.Cells[2].Value.ToString();
                    txtApellidos.Text = dgvListaEmpleados.CurrentRow.Cells[3].Value.ToString();
                    cbNombreDepartamento.Text = dgvListaEmpleados.CurrentRow.Cells[4].Value.ToString();
                    txtTelefono.Text = dgvListaEmpleados.CurrentRow.Cells[5].Value.ToString();
                    txtCorreo.Text = dgvListaEmpleados.CurrentRow.Cells[6].Value.ToString();
                    txtSalario.Text = dgvListaEmpleados.CurrentRow.Cells[7].Value.ToString();
                    txtFecha_Contrato.Text = dgvListaEmpleados.CurrentRow.Cells[8].Value.ToString();
                    txtFecha_Despido.Text = dgvListaEmpleados.CurrentRow.Cells[9].Value.ToString();
                    cbEstado.Text = dgvListaEmpleados.CurrentRow.Cells[10].Value.ToString();
                    
                    txtCedula.Enabled = false;
                    txtCorreo.Enabled = false;
                    txtFecha_Contrato.Enabled = false;
                    cbEstado.Enabled = true;

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
            if (txtCedula.Text != "" && txtNombre.Text != "" && txtApellidos.Text != "" && txtCorreo.Text != "" && txtTelefono.Text != "" && txtSalario.Text != "")
            {
                camposCompletados = true;
            }
            return camposCompletados;
        }

        public void limpiarCamposFormulario()
        {
            txtCodigoEmpleado.Text = "";
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtSalario.Text = "";
            txtFecha_Contrato.Text = "";
            txtFecha_Despido.Text = "";
            cbEstado.Text = "";

            txtCedula.Enabled = true;
            txtCorreo.Enabled = true;
            txtFecha_Contrato.Enabled = false;

            txtCedula.BackColor = Color.White;
            txtCorreo.BackColor = Color.White;

            btAgregar.Enabled = true;
            btActualizar.Enabled = false;
            btEliminar.Enabled = false;
            btLimpiarFormulario.Enabled = true;

            cargarComboBoxes();

            txtFecha_Contrato.Text = DateTime.Now.ToString().Split(' ')[0].Trim();
        }

        public void cargarToolTips()
        {
            this.ttbtAgregar.SetToolTip(btAgregar, "Agregar empleado");
            this.ttbtAgregar.IsBalloon = true;
            this.ttbtActualizar.SetToolTip(btActualizar, "Actualizar empleado");
            this.ttbtActualizar.IsBalloon = true;
            this.ttbtEliminar.SetToolTip(btEliminar, "Eliminar empleado");
            this.ttbtEliminar.IsBalloon = true;
            this.ttbtLimpiar.SetToolTip(btLimpiarFormulario, "Limpiar datos del formulario");
            this.ttbtLimpiar.IsBalloon = true;
            this.ttrbActivos.SetToolTip(rbEmpleadosActivos, "Mostrar empleados activos");
            this.ttrbActivos.IsBalloon = true;
            this.ttrbInactivos.SetToolTip(rbEmpleadosInactivos, "Mostrar empleados inactivos");
            this.ttrbInactivos.IsBalloon = true;
            this.ttbtRefrescarFormulario.SetToolTip(btRefrescarFormulario, "Actualizar todo el formulario");
            this.ttbtRefrescarFormulario.IsBalloon = true;
        }

        private void cbEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            String fechaActual = DateTime.Now.ToString().Split(' ')[0].Trim();

            if (dgvListaEmpleados.Rows.Count > 0)
            {
                String fechaTemporalFechaContrato = dgvListaEmpleados.CurrentRow.Cells[8].Value.ToString();
                String fechaTemporalFechaDespido = dgvListaEmpleados.CurrentRow.Cells[9].Value.ToString();
                if (cbEstado.Text == "Inactivo")
                {
                    txtFecha_Despido.Text = fechaActual;
                    if (cbEstado.Text == dgvListaEmpleados.CurrentRow.Cells[10].Value.ToString())
                    {
                        txtFecha_Despido.Text = fechaTemporalFechaDespido;
                        txtFecha_Contrato.Text = fechaTemporalFechaContrato;
                    }
                }
                else if (cbEstado.Text == "Activo")
                {
                    txtFecha_Contrato.Text = fechaActual;
                    txtFecha_Despido.Text = "";
                    if (cbEstado.Text == dgvListaEmpleados.CurrentRow.Cells[10].Value.ToString())
                    {
                        txtFecha_Contrato.Text = fechaTemporalFechaContrato;
                        txtFecha_Despido.Text = "";
                    }
                }
            }
            else
            {

            }
        }

        private void rbEmpleadosActivos_Click(object sender, EventArgs e)
        {
            rbEmpleadosInactivos.Checked = false;
            llenarDataGrigView();
        }

        private void rbEmpleadosInactivos_Click(object sender, EventArgs e)
        {
            rbEmpleadosActivos.Checked = false;
            llenarDataGrigView();
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

        //Metodo para validar el correo electtronico
        private Boolean validarEmailCorrecto(String emailIngresado)
        {
            String expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(emailIngresado, expresion))
            {
                if (Regex.Replace(emailIngresado, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}

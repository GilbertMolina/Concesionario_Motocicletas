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
    public partial class frmDepartamentos : Form
    {
        public frmDepartamentos()
        {
            InitializeComponent();
        }

        private void frmDepartamentos_Load(object sender, EventArgs e)
        {
            cargarFormulario();
        }

        private void dgvListaDepartamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarCamposDelDataGridView();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            agregarDepartamento();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            actualizarDepartamento();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            eliminarDepartamento();
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

            txtCodAdministrador.Enabled = false;
            chbQuitarAdministrador.Enabled = false;

            llenarDataGrigView();

            cargarComboBoxes();

            cargarToolTips();
        }

        public void agregarDepartamento()
        {
            objDepartamentos objDepartamento = new objDepartamentos();
            objDepartamentos objDepartamentoAdministrador = new objDepartamentos();
            cnDepartamentos cnDepartamento = new cnDepartamentos();

            if (validarCamposLlenos())
            {
                if (txtCodAdministrador.Text == "")
                {
                    objDepartamento.Nombre = txtNombre.Text;
                    objDepartamentoAdministrador.Nombre = txtCodAdministrador.Text;
                }
                else
                {
                    objDepartamento.Nombre = txtNombre.Text;
                    objDepartamento.Cod_Administrador = Convert.ToInt32(txtCodAdministrador.Text);
                }
                
                if (cnDepartamento.insertarDepartamento(objDepartamento, objDepartamentoAdministrador))
                {
                    llenarDataGrigView();

                    cargarComboBoxes();

                    btAgregar.Enabled = true;
                    btActualizar.Enabled = false;
                    btEliminar.Enabled = false;
                    btLimpiarFormulario.Enabled = true;

                    limpiarCamposFormulario();
                }
                else
                {
                    txtNombre.BackColor = Color.Tomato;
                }
            }
            else
            {
                MessageBox.Show("Debe digitar los campos del formulario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void actualizarDepartamento()
        {
            objDepartamentos objDepartamento = new objDepartamentos();
            objDepartamentos objDepartamentoAdministrador = new objDepartamentos();
            cnDepartamentos cnDepartamento = new cnDepartamentos();

            if (validarCamposLlenos())
            {
                DialogResult eleccionActualizar = MessageBox.Show("¿Desea actualizar el departamento seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eleccionActualizar == DialogResult.Yes)
                {
                    if (txtCodAdministrador.Text == "")
                    {
                        objDepartamento.Cod_Departamento = Convert.ToInt32(txtCodigoDepartamento.Text);
                        objDepartamento.Nombre = txtNombre.Text;
                        objDepartamentoAdministrador.Nombre = txtCodAdministrador.Text;
                    }
                    else
                    {
                        objDepartamento.Cod_Departamento = Convert.ToInt32(txtCodigoDepartamento.Text);
                        objDepartamento.Nombre = txtNombre.Text;
                        objDepartamento.Cod_Administrador = Convert.ToInt32(txtCodAdministrador.Text);
                    }

                    cnDepartamento.actualizarDepartamento(objDepartamento, objDepartamentoAdministrador);

                    llenarDataGrigView();

                    cargarComboBoxes();

                    btAgregar.Enabled = true;
                    btActualizar.Enabled = false;
                    btEliminar.Enabled = false;
                    btLimpiarFormulario.Enabled = true;

                    chbQuitarAdministrador.Enabled = false;

                    limpiarCamposFormulario();
                }
            }
            else
            {
                MessageBox.Show("Debe de cargar primero un departamento de la lista de departamentos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void eliminarDepartamento()
        {
            objDepartamentos objDepartamento = new objDepartamentos();
            cnDepartamentos cnDepartamento = new cnDepartamentos();

            DialogResult eleccionBorrar = MessageBox.Show("¿Desea eliminar el departamento seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (eleccionBorrar == DialogResult.Yes)
            {
                objDepartamento.Cod_Departamento = Convert.ToInt32(dgvListaDepartamentos.CurrentRow.Cells[0].Value);
                cnDepartamento.eliminarDepartamento(objDepartamento);

                llenarDataGrigView();

                cargarComboBoxes();

                btAgregar.Enabled = true;
                btActualizar.Enabled = false;
                btEliminar.Enabled = false;
                btLimpiarFormulario.Enabled = true;

                chbQuitarAdministrador.Enabled = false;

                cargarCodigoAdministradorCorrecto();

                limpiarCamposFormulario();
            }
        }

        public void llenarDataGrigView()
        {
            cnDepartamentos cnDepartamento = new cnDepartamentos();
            DataTable tablaDepartamentos = new DataTable();

            dgvListaDepartamentos.Rows.Clear();

            dgvListaDepartamentos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            tablaDepartamentos = cnDepartamento.consultarDepartamentos();

            for (int i = 0; i < tablaDepartamentos.Rows.Count; i++)
            {
                if (tablaDepartamentos.Rows[i][2].ToString().Length == 0)
                {
                    dgvListaDepartamentos.Rows.Add(tablaDepartamentos.Rows[i][0], tablaDepartamentos.Rows[i][1],
                                                   "No asignado", "No asignado");
                }
                else
                {
                    dgvListaDepartamentos.Rows.Add(tablaDepartamentos.Rows[i][0], tablaDepartamentos.Rows[i][1],
                                                   tablaDepartamentos.Rows[i][2], tablaDepartamentos.Rows[i][3]);
                }
            }
        }

        public void cargarComboBoxes()
        {
            cnEmpleados cnEmpleado = new cnEmpleados();
            DataTable TablaEmpleados = new DataTable();

            if (cnEmpleado.consultarEmpleadosNoGerentes().Rows.Count > 0)
            {
                cbNombreAdministrador.DataSource = cnEmpleado.consultarEmpleadosNoGerentes();
                cbNombreAdministrador.DisplayMember = "nombre_empleado";
                cbNombreAdministrador.ValueMember = "cod_empleado";
                cargarCodigoAdministradorCorrecto();
            }
            else
            {
                cbNombreAdministrador.DataSource = null;
                cbNombreAdministrador.Text = "";
                txtCodAdministrador.Text = "";
            }
        }

        public void cargarCamposDelDataGridView()
        {
            if (dgvListaDepartamentos.CurrentRow.Cells[0].Value.ToString() != "")
            {
                DialogResult eleccionCargar = MessageBox.Show("¿Desea cargar el departamento seleccionado al formulario?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eleccionCargar == DialogResult.Yes)
                {
                    txtCodigoDepartamento.Text = dgvListaDepartamentos.CurrentRow.Cells[0].Value.ToString();
                    txtNombre.Text = dgvListaDepartamentos.CurrentRow.Cells[1].Value.ToString();
                    if (dgvListaDepartamentos.CurrentRow.Cells[2].Value.ToString() == "No asignado")
                    {
                        chbQuitarAdministrador.Enabled = false;
                    }
                    else
                    {
                        chbQuitarAdministrador.Enabled = true;
                    }

                    txtNombre.Enabled = false;
                    txtCodAdministrador.Enabled = true;

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
            if (txtNombre.Text != "")
            {
                camposCompletados = true;
            }
            return camposCompletados;
        }

        public void limpiarCamposFormulario()
        {
            txtCodigoDepartamento.Text = "";
            txtNombre.Text = "";

            chbQuitarAdministrador.Checked = false;
            txtNombre.Enabled = true;
            txtCodAdministrador.Enabled = false;

            txtNombre.BackColor = Color.White;

            btAgregar.Enabled = true;
            btActualizar.Enabled = false;
            btEliminar.Enabled = false;
            btLimpiarFormulario.Enabled = true;
        }

        public void cargarToolTips()
        {
            this.ttbtAgregar.SetToolTip(btAgregar, "Agregar departamento");
            this.ttbtAgregar.IsBalloon = true;
            this.ttbtActualizar.SetToolTip(btActualizar, "Actualizar departamento");
            this.ttbtActualizar.IsBalloon = true;
            this.ttbtEliminar.SetToolTip(btEliminar, "Eliminar departamento");
            this.ttbtEliminar.IsBalloon = true;
            this.ttbtLimpiar.SetToolTip(btLimpiarFormulario, "Limpiar datos del formulario");
            this.ttbtLimpiar.IsBalloon = true;
            this.ttbtRefrescarFormulario.SetToolTip(btRefrescarFormulario, "Actualizar todo el formulario");
            this.ttbtRefrescarFormulario.IsBalloon = true;
        }

        private void cbNombreAdministrador_SelectedValueChanged(object sender, EventArgs e)
        {
            cargarCodigoAdministradorCorrecto();
        }

        public void cargarCodigoAdministradorCorrecto()
        {
            if (cbNombreAdministrador.DataSource != null)
            {
                if (cbNombreAdministrador.SelectedValue.ToString() != "")
                {
                    txtCodAdministrador.Text = cbNombreAdministrador.SelectedValue.ToString();
                }
                else
                {
                    txtCodAdministrador.Text = "";
                }
                if (cbNombreAdministrador.Text == "")
                {
                    txtCodAdministrador.Text = "";
                }
            }
            else
            {
                cbNombreAdministrador.Text = "";
                txtCodAdministrador.Text = "";
            }
        }

        private void chbQuitarAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            cargarComboBoxes();
            if (chbQuitarAdministrador.Checked)
            {
                cbNombreAdministrador.Text = "";
                txtCodAdministrador.Text = "";
            }
        }

    }
}

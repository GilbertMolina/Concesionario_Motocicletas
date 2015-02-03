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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cargarFormulario();
        }

        private void dgvListaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarCamposDelDataGridView();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            agregarCliente();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            actualizarCliente();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            eliminarCliente();

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
            btLimpiarFormulario.Enabled = false;

            llenarDataGrigView();

            cargarToolTips();
        }

        public void agregarCliente()
        {
            objClientes objClientes = new objClientes();
            cnClientes cnClientes = new cnClientes();

            if (validarCamposLlenos())
            {
                objClientes.Cedula = txtCedula.Text;
                objClientes.Nombre = txtNombre.Text;
                objClientes.Apellidos = txtApellidos.Text;
                objClientes.Telefono = Convert.ToInt32(txtTelefono.Text);
                objClientes.Direccion = txtDireccion.Text;
                objClientes.Ciudad = txtCiudad.Text;

                if (cnClientes.insertarCliente(objClientes))
                {
                    llenarDataGrigView();

                    btAgregar.Enabled = true;
                    btActualizar.Enabled = false;
                    btEliminar.Enabled = false;
                    btLimpiarFormulario.Enabled = false;

                    limpiarCamposFormulario();
                }
                else
                {
                    txtCedula.BackColor = Color.Tomato;
                }
            }
            else
            {
                MessageBox.Show("Debe digitar los campos del formulario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void actualizarCliente()
        {
            objClientes objClientes = new objClientes();
            cnClientes cnClientes = new cnClientes();

            if (validarCamposLlenos())
            {
                DialogResult eleccionActualizar = MessageBox.Show("¿Desea actualizar el cliente seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eleccionActualizar == DialogResult.Yes)
                {
                    objClientes.Cod_Ciente = Convert.ToInt32(txtCodigoCliente.Text);
                    objClientes.Cedula = txtCedula.Text;
                    objClientes.Nombre = txtNombre.Text;
                    objClientes.Apellidos = txtApellidos.Text;
                    objClientes.Telefono = Convert.ToInt32(txtTelefono.Text);
                    objClientes.Direccion = txtDireccion.Text;
                    objClientes.Ciudad = txtCiudad.Text;

                    cnClientes.actualizarCliente(objClientes);

                    llenarDataGrigView();

                    txtCedula.Enabled = true;
                    txtNombre.Enabled = true;
                    txtApellidos.Enabled = true;
                    txtTelefono.Enabled = true;
                    txtDireccion.Enabled = true;
                    txtCiudad.Enabled = true;

                    btAgregar.Enabled = true;
                    btActualizar.Enabled = false;
                    btEliminar.Enabled = false;
                    btLimpiarFormulario.Enabled = false;

                    limpiarCamposFormulario();
                }
            }
            else
            {
                MessageBox.Show("Debe de cargar primero un cliente de la lista de clientes", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void eliminarCliente()
        {
            objClientes objClientes = new objClientes();
            cnClientes cnClientes = new cnClientes();


            DialogResult eleccionBorrar = MessageBox.Show("¿Desea eliminar el cliente seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (eleccionBorrar == DialogResult.Yes)
            {
                objClientes.Cod_Ciente = Convert.ToInt32(dgvListaClientes.CurrentRow.Cells[0].Value);
                cnClientes.eliminarCliente(objClientes);

                llenarDataGrigView();

                txtCedula.Enabled = true;
                txtNombre.Enabled = true;
                txtApellidos.Enabled = true;
                txtTelefono.Enabled = true;
                txtDireccion.Enabled = true;
                txtCiudad.Enabled = true;

                btAgregar.Enabled = true;
                btActualizar.Enabled = false;
                btEliminar.Enabled = false;
                btLimpiarFormulario.Enabled = false;

                limpiarCamposFormulario();
            }
        }

        public void llenarDataGrigView()
        {
            cnClientes cnClientes = new cnClientes();
            DataTable tablaClientes = new DataTable();

            dgvListaClientes.Rows.Clear();

            dgvListaClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            tablaClientes = cnClientes.consultarClientes();

            for (int i = 0; i < tablaClientes.Rows.Count; i++)
            {
                dgvListaClientes.Rows.Add(tablaClientes.Rows[i][0], tablaClientes.Rows[i][1], tablaClientes.Rows[i][2],
                                                 tablaClientes.Rows[i][3], tablaClientes.Rows[i][4], tablaClientes.Rows[i][5],
                                                 tablaClientes.Rows[i][6]);
            }
        }

        public void cargarCamposDelDataGridView()
        {
            if (dgvListaClientes.CurrentRow.Cells[0].Value.ToString() != "")
            {
                DialogResult eleccionCargar = MessageBox.Show("¿Desea cargar el cliente seleccionado al formulario?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eleccionCargar == DialogResult.Yes)
                {
                    txtCodigoCliente.Text = dgvListaClientes.CurrentRow.Cells[0].Value.ToString();
                    txtCedula.Text = dgvListaClientes.CurrentRow.Cells[1].Value.ToString();
                    txtNombre.Text = dgvListaClientes.CurrentRow.Cells[2].Value.ToString();
                    txtApellidos.Text = dgvListaClientes.CurrentRow.Cells[3].Value.ToString();
                    txtTelefono.Text = dgvListaClientes.CurrentRow.Cells[4].Value.ToString();
                    txtDireccion.Text = dgvListaClientes.CurrentRow.Cells[5].Value.ToString();
                    txtCiudad.Text = dgvListaClientes.CurrentRow.Cells[6].Value.ToString();

                    txtCedula.Enabled = false;

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
            if (txtCedula.Text != "" && txtNombre.Text != "" && txtApellidos.Text != "" && txtTelefono.Text != "" && txtDireccion.Text != "" && txtCiudad.Text != "")
            {
                camposCompletados = true;
            }
            return camposCompletados;
        }

        public void limpiarCamposFormulario()
        {
            txtCodigoCliente.Text = "";
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtCiudad.Text = "";

            txtCedula.Enabled = true;

            txtCedula.BackColor = Color.White;

            btAgregar.Enabled = true;
            btActualizar.Enabled = false;
            btEliminar.Enabled = false;
            btLimpiarFormulario.Enabled = false;
        }

        public void cargarToolTips()
        {
            this.ttbtAgregar.SetToolTip(btAgregar, "Agregar cliente");
            this.ttbtAgregar.IsBalloon = true;
            this.ttbtActualizar.SetToolTip(btActualizar, "Actualizar cliente");
            this.ttbtActualizar.IsBalloon = true;
            this.ttbtEliminar.SetToolTip(btEliminar, "Eliminar cliente");
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

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
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            cargarFormulario();
        }

        private void dgvListaProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarCamposDelDataGridView();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            agregarProveedor();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            actualizarProveedor();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            eliminarProveedor();
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

        public void agregarProveedor()
        {
            objProveedores objProveedores = new objProveedores();
            cnProveedores cnProveedores = new cnProveedores();

            if (validarCamposLlenos())
            {
                objProveedores.Cedula_Juridica = txtCedulaJuridica.Text;
                objProveedores.Nombre = txtNombre.Text;
                objProveedores.Razon_Social = txtRazonSocial.Text;
                objProveedores.Descripcion_Servicio = txtDescripcion.Text;

                if (cnProveedores.insertarProveedor(objProveedores))
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
                    txtCedulaJuridica.BackColor = Color.Tomato;
                }
            }
            else
            {
                MessageBox.Show("Debe digitar los campos del formulario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void actualizarProveedor()
        {
            objProveedores objProveedores = new objProveedores();
            cnProveedores cnProveedores = new cnProveedores();

            if (validarCamposLlenos())
            {
                DialogResult eleccionActualizar = MessageBox.Show("¿Desea actualizar el proveedor seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eleccionActualizar == DialogResult.Yes)
                {
                    objProveedores.Cod_Proveedor = Convert.ToInt32(txtCodigoProveedor.Text);
                    objProveedores.Cedula_Juridica = txtCedulaJuridica.Text;
                    objProveedores.Nombre = txtNombre.Text;
                    objProveedores.Razon_Social = txtRazonSocial.Text;
                    objProveedores.Descripcion_Servicio = txtDescripcion.Text;

                    cnProveedores.actualizarProveedor(objProveedores);

                    llenarDataGrigView();

                    txtCedulaJuridica.Enabled = true;
                    txtNombre.Enabled = true;
                    txtRazonSocial.Enabled = true;

                    btAgregar.Enabled = true;
                    btActualizar.Enabled = false;
                    btEliminar.Enabled = false;

                    limpiarCamposFormulario();
                }
            }
            else
            {
                MessageBox.Show("Debe de cargar primero un proveedor de la lista de proveedores", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void eliminarProveedor()
        {
            objProveedores objProveedores = new objProveedores();
            cnProveedores cnProveedores = new cnProveedores();

            DialogResult eleccionBorrar = MessageBox.Show("¿Desea eliminar el proveedor seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (eleccionBorrar == DialogResult.Yes)
            {
                objProveedores.Cod_Proveedor = Convert.ToInt32(dgvListaProveedores.CurrentRow.Cells[0].Value);

                cnProveedores.eliminarProveedor(objProveedores);

                llenarDataGrigView();

                txtCedulaJuridica.Enabled = true;
                txtNombre.Enabled = true;
                txtRazonSocial.Enabled = true;

                btAgregar.Enabled = true;
                btActualizar.Enabled = false;
                btEliminar.Enabled = false;

                limpiarCamposFormulario();
            }
        }

        public void llenarDataGrigView()
        {
            cnProveedores cnProveedores = new cnProveedores();
            DataTable tablaProveedores = new DataTable();

            dgvListaProveedores.Rows.Clear();

            dgvListaProveedores.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            tablaProveedores = cnProveedores.consultarProveedores();

            for (int i = 0; i < tablaProveedores.Rows.Count; i++)
            {
                dgvListaProveedores.Rows.Add(tablaProveedores.Rows[i][0], tablaProveedores.Rows[i][1], tablaProveedores.Rows[i][2],
                                             tablaProveedores.Rows[i][3], tablaProveedores.Rows[i][4]);
            }
        }

        public void cargarCamposDelDataGridView()
        {
            if (dgvListaProveedores.CurrentRow.Cells[0].Value.ToString() != "")
            {
                DialogResult eleccionCargar = MessageBox.Show("¿Desea cargar el proveedor seleccionado al formulario?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eleccionCargar == DialogResult.Yes)
                {
                    txtCodigoProveedor.Text = dgvListaProveedores.CurrentRow.Cells[0].Value.ToString();
                    txtCedulaJuridica.Text = dgvListaProveedores.CurrentRow.Cells[1].Value.ToString();
                    txtNombre.Text = dgvListaProveedores.CurrentRow.Cells[2].Value.ToString();
                    txtRazonSocial.Text = dgvListaProveedores.CurrentRow.Cells[3].Value.ToString();
                    txtDescripcion.Text = dgvListaProveedores.CurrentRow.Cells[4].Value.ToString();

                    txtCedulaJuridica.Enabled = false;

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
            if (txtCedulaJuridica.Text != "" && txtNombre.Text != "" && txtRazonSocial.Text != "" && txtDescripcion.Text != "")
            {
                camposCompletados = true;
            }
            return camposCompletados;
        }

        public void limpiarCamposFormulario()
        {
            txtCodigoProveedor.Text = "";
            txtCedulaJuridica.Text = "";
            txtNombre.Text = "";
            txtRazonSocial.Text = "";
            txtDescripcion.Text = "";

            txtCedulaJuridica.Enabled = true;
            txtNombre.Enabled = true;
            txtRazonSocial.Enabled = true;

            txtCedulaJuridica.BackColor = Color.White;

            btAgregar.Enabled = true;
            btActualizar.Enabled = false;
            btEliminar.Enabled = false;
            btLimpiarFormulario.Enabled = true;
        }

        public void cargarToolTips()
        {
            this.ttbtAgregar.SetToolTip(btAgregar, "Agregar proveedor");
            this.ttbtAgregar.IsBalloon = true;
            this.ttbtActualizar.SetToolTip(btActualizar, "Actualizar proveedor");
            this.ttbtActualizar.IsBalloon = true;
            this.ttbtEliminar.SetToolTip(btEliminar, "Eliminar proveedor");
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

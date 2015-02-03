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
    public partial class frmRepuestos : Form
    {
        public frmRepuestos()
        {
            InitializeComponent();
        }

        private void frmRepuestos_Load(object sender, EventArgs e)
        {
            cargarFormulario();
        }

        private void dgvListaRepuestos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarCamposDelDataGridView();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            agregarRepuesto();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            actualizarRepuesto();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            eliminarRepuesto();
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

        public void agregarRepuesto()
        {
            objRepuestos objRepuestos = new objRepuestos();
            cnRepuestos cnRepuestos = new cnRepuestos();

            if (validarCamposLlenos())
            {
                objRepuestos.Tipo = txtTipo.Text;
                objRepuestos.Precio = Convert.ToDouble(txtPrecio_Unitario.Text);
                objRepuestos.Descripcion = txtDescripcion.Text;

                if (cnRepuestos.insertarRepuesto(objRepuestos))
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
                    txtPrecio_Unitario.BackColor = Color.Tomato;
                    txtDescripcion.BackColor = Color.Tomato;
                }
            }
            else
            {
                MessageBox.Show("Debe digitar los campos del formulario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void actualizarRepuesto()
        {
            objRepuestos objRepuestos = new objRepuestos();
            cnRepuestos cnRepuestos = new cnRepuestos();

            if (validarCamposLlenos())
            {
                DialogResult eleccionActualizar = MessageBox.Show("¿Desea actualizar el repuesto seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eleccionActualizar == DialogResult.Yes)
                {
                    objRepuestos.Cod_Repuesto = txtCodigoRepuesto.Text;
                    objRepuestos.Tipo = txtTipo.Text;
                    objRepuestos.Precio = Convert.ToDouble(txtPrecio_Unitario.Text);
                    objRepuestos.Descripcion = txtDescripcion.Text;

                    cnRepuestos.actualizarRepuesto(objRepuestos);

                    llenarDataGrigView();

                    txtTipo.Enabled = true;
                    txtPrecio_Unitario.Enabled = true;
                    txtDescripcion.Enabled = true;

                    btAgregar.Enabled = true;
                    btActualizar.Enabled = false;
                    btEliminar.Enabled = false;

                    limpiarCamposFormulario();
                }
            }
            else
            {
                MessageBox.Show("Debe de cargar primero un repuesto de la lista de repuestos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void eliminarRepuesto()
        {
            objRepuestos objRepuestos = new objRepuestos();
            cnRepuestos cnRepuestos = new cnRepuestos();


            DialogResult eleccionBorrar = MessageBox.Show("¿Desea eliminar el repuesto seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (eleccionBorrar == DialogResult.Yes)
            {
                objRepuestos.Cod_Repuesto = dgvListaRepuestos.CurrentRow.Cells[0].Value.ToString();
                cnRepuestos.eliminarRepuesto(objRepuestos);

                llenarDataGrigView();

                txtTipo.Enabled = true;
                txtPrecio_Unitario.Enabled = true;
                txtDescripcion.Enabled = true;

                btAgregar.Enabled = true;
                btActualizar.Enabled = false;
                btEliminar.Enabled = false;

                limpiarCamposFormulario();
            }
        }

        public void llenarDataGrigView()
        {
            cnRepuestos cnRepuestos = new cnRepuestos();
            DataTable tablaRepuestos = new DataTable();

            dgvListaRepuestos.Rows.Clear();

            dgvListaRepuestos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            tablaRepuestos = cnRepuestos.consultarRepuestos();

            for (int i = 0; i < tablaRepuestos.Rows.Count; i++)
            {
                dgvListaRepuestos.Rows.Add(tablaRepuestos.Rows[i][0], tablaRepuestos.Rows[i][1], tablaRepuestos.Rows[i][2],
                                                 tablaRepuestos.Rows[i][3]);
            }
        }

        public void cargarCamposDelDataGridView()
        {
            if (dgvListaRepuestos.CurrentRow.Cells[0].Value.ToString() != "")
            {
                DialogResult eleccionCargar = MessageBox.Show("¿Desea cargar el repuesto seleccionado al formulario?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eleccionCargar == DialogResult.Yes)
                {
                    txtCodigoRepuesto.Text = dgvListaRepuestos.CurrentRow.Cells[0].Value.ToString();
                    txtTipo.Text = dgvListaRepuestos.CurrentRow.Cells[1].Value.ToString();
                    txtPrecio_Unitario.Text = dgvListaRepuestos.CurrentRow.Cells[2].Value.ToString();
                    txtDescripcion.Text = dgvListaRepuestos.CurrentRow.Cells[3].Value.ToString();


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
            if (txtTipo.Text != "" && txtPrecio_Unitario.Text != "" && txtDescripcion.Text != "")
            {
                camposCompletados = true;
            }
            return camposCompletados;
        }

        public void limpiarCamposFormulario()
        {
            txtCodigoRepuesto.Text = "";
            txtTipo.Text = "";
            txtPrecio_Unitario.Text = "";
            txtDescripcion.Text = "";

            txtTipo.Enabled = true;
            txtPrecio_Unitario.Enabled = true;
            txtDescripcion.Enabled = true;

            txtTipo.BackColor = Color.White;

            btAgregar.Enabled = true;
            btActualizar.Enabled = false;
            btEliminar.Enabled = false;
            btLimpiarFormulario.Enabled = true;
        }

        public void cargarToolTips()
        {
            this.ttbtAgregar.SetToolTip(btAgregar, "Agregar repuesto");
            this.ttbtAgregar.IsBalloon = true;
            this.ttbtActualizar.SetToolTip(btActualizar, "Actualizar repuesto");
            this.ttbtActualizar.IsBalloon = true;
            this.ttbtEliminar.SetToolTip(btEliminar, "Eliminar repuesto");
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

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
    public partial class frmProveedoresXAdquisiciones : Form
    {
        public frmProveedoresXAdquisiciones()
        {
            InitializeComponent();
        }

        private void frmProveedoresXAdquisiciones_Load(object sender, EventArgs e)
        {
            cargarFormulario();
        }

        private void dgvListaAdquisicionesProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarCamposDelDataGridViewListaAdquisicionesProveedores();
        }

        private void dgvListaAdquisiciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarCamposDelDataGridViewListaAdquisiciones();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            agregarProveedorAdquisicion();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            eliminarProveedorAdquisicion();
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

            llenarDataGrigViewListaAdquisicionesProveedores();

            llenarDataGrigViewAdquisiciones();

            cargarComboBoxes();

            cargarToolTips();
        }

        private void btRefrescarDataGrids_Click(object sender, EventArgs e)
        {
            llenarDataGrigViewAdquisiciones();
        }

        public void llenarDataGrigViewListaAdquisicionesProveedores()
        {
            cnProveedoresXAdquisiciones cnProveedorXAdquisicion = new cnProveedoresXAdquisiciones();
            DataTable tablaListaAdquisicionesProveedores = new DataTable();

            dgvListaAdquisicionesProveedores.Rows.Clear();

            dgvListaAdquisicionesProveedores.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            tablaListaAdquisicionesProveedores = cnProveedorXAdquisicion.consultarProveedoresAdquisiciones();

            for (int i = 0; i < tablaListaAdquisicionesProveedores.Rows.Count; i++)
            {
                String cod_vehiculo = "N/A";
                String cod_repuesto = "N/A";
                String solamenteFechaCompra = tablaListaAdquisicionesProveedores.Rows[i][7].ToString().Split(' ')[0].Trim();

                if (tablaListaAdquisicionesProveedores.Rows[i][3].ToString() != "")
                {
                    cod_vehiculo = tablaListaAdquisicionesProveedores.Rows[i][3].ToString();
                }
                else if (tablaListaAdquisicionesProveedores.Rows[i][4].ToString() != "")
                {
                    cod_repuesto = tablaListaAdquisicionesProveedores.Rows[i][4].ToString();
                }

                dgvListaAdquisicionesProveedores.Rows.Add(tablaListaAdquisicionesProveedores.Rows[i][0], tablaListaAdquisicionesProveedores.Rows[i][1],
                                                          tablaListaAdquisicionesProveedores.Rows[i][2], cod_vehiculo, cod_repuesto, 
                                                          tablaListaAdquisicionesProveedores.Rows[i][5], tablaListaAdquisicionesProveedores.Rows[i][6],
                                                          solamenteFechaCompra);
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

                dgvListaAdquisiciones.Rows.Add(tablaAdquisiciones.Rows[i][0], cod_vehiculo, cod_repuesto, tablaAdquisiciones.Rows[i][3], 
                                               tablaAdquisiciones.Rows[i][4], solamenteFechaCompra);
            }
        }

        public void cargarCamposDelDataGridViewListaAdquisicionesProveedores()
        {
            if (dgvListaAdquisicionesProveedores.CurrentRow.Cells[0].Value.ToString() != "")
            {
                DialogResult eleccionCargar = MessageBox.Show("¿Desea cargar el la adquisición del proveedor seleccionada al formulario?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eleccionCargar == DialogResult.Yes)
                {
                    txtCodProveedor.Text = dgvListaAdquisicionesProveedores.CurrentRow.Cells[0].Value.ToString();
                    cbNombreProveedor.Text = dgvListaAdquisicionesProveedores.CurrentRow.Cells[1].Value.ToString();
                    txtCodFacturaCompra.Text = dgvListaAdquisicionesProveedores.CurrentRow.Cells[2].Value.ToString();

                    btAgregar.Enabled = false;
                    btActualizar.Enabled = true;
                    btEliminar.Enabled = true;
                    btLimpiarFormulario.Enabled = true;
                }
            }
        }

        public void cargarCamposDelDataGridViewListaAdquisiciones()
        {
            if (dgvListaAdquisiciones.CurrentRow.Cells[0].Value.ToString() != "")
            {
                DialogResult eleccionCargar = MessageBox.Show("¿Desea cargar el producto seleccionado al formulario?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eleccionCargar == DialogResult.Yes)
                {
                    txtCodFacturaCompra.Text = dgvListaAdquisiciones.CurrentRow.Cells[0].Value.ToString();
                }
            }
        }

        public void agregarProveedorAdquisicion()
        {
            objProveedoresXAdquisiciones objProveedorXAdquisicion = new objProveedoresXAdquisiciones();
            cnProveedoresXAdquisiciones cnProveedorXAdquisicion = new cnProveedoresXAdquisiciones();

            if (validarCamposLlenos())
            {
                objProveedorXAdquisicion.Cod_Proveedor = Convert.ToInt32(txtCodProveedor.Text);
                objProveedorXAdquisicion.Cod_Fact_Compra = Convert.ToInt32(txtCodFacturaCompra.Text);

                if (cnProveedorXAdquisicion.insertarProveedorAdquisicion(objProveedorXAdquisicion))
                {
                    llenarDataGrigViewListaAdquisicionesProveedores();

                    btAgregar.Enabled = true;
                    btActualizar.Enabled = false;
                    btEliminar.Enabled = false;
                    btLimpiarFormulario.Enabled = true;

                    limpiarCamposFormulario();
                }
                else
                {
                    txtCodFacturaCompra.BackColor = Color.Tomato;
                }
            }
            else
            {
                MessageBox.Show("Debe digitar los campos del formulario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void eliminarProveedorAdquisicion()
        {
            objProveedoresXAdquisiciones objProveedorXAdquisicion = new objProveedoresXAdquisiciones();
            cnProveedoresXAdquisiciones cnProveedorXAdquisicion = new cnProveedoresXAdquisiciones();

            DialogResult eleccionEliminar = MessageBox.Show("¿Desea eliminar la adquisicón del proveedor seleccionado?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (eleccionEliminar == DialogResult.Yes)
            {
                objProveedorXAdquisicion.Cod_Proveedor = Convert.ToInt32(dgvListaAdquisicionesProveedores.CurrentRow.Cells[0].Value.ToString());
                objProveedorXAdquisicion.Cod_Fact_Compra = Convert.ToInt32(dgvListaAdquisicionesProveedores.CurrentRow.Cells[2].Value.ToString());

                cnProveedorXAdquisicion.eliminarProveedorAdquisicion(objProveedorXAdquisicion);

                llenarDataGrigViewListaAdquisicionesProveedores();

                btAgregar.Enabled = true;
                btActualizar.Enabled = false;
                btEliminar.Enabled = false;

                limpiarCamposFormulario();
            }
        }

        public void limpiarCamposFormulario()
        {
            txtCodFacturaCompra.Text = "";

            btAgregar.Enabled = true;
            btActualizar.Enabled = false;
            btEliminar.Enabled = false;
            btLimpiarFormulario.Enabled = true;

            txtCodFacturaCompra.BackColor = Color.White;

            cargarComboBoxes();
        }

        public Boolean validarCamposLlenos()
        {
            Boolean camposCompletados = false;
            if (txtCodFacturaCompra.Text != "")
            {
                camposCompletados = true;
            }
            return camposCompletados;
        }

        public void cargarComboBoxes()
        {
            cnProveedores cnProveedor = new cnProveedores();
            DataTable TablaProveedores = new DataTable();

            if (cnProveedor.consultarProveedores().Rows.Count > 0)
            {
                cbNombreProveedor.DataSource = cnProveedor.consultarProveedores();
                cbNombreProveedor.DisplayMember = "nombre";
                cbNombreProveedor.ValueMember = "cod_proveedor";
            }
            else
            {
                cbNombreProveedor.DataSource = null;
                cbNombreProveedor.DisplayMember = "";
                cbNombreProveedor.ValueMember = "";
            }
        }

        public void cargarToolTips()
        {
            this.ttbtAgregar.SetToolTip(btAgregar, "Agregar adquisición de proveedor");
            this.ttbtAgregar.IsBalloon = true;
            this.ttbtActualizar.SetToolTip(btActualizar, "Actualizar adquisición de proveedor");
            this.ttbtActualizar.IsBalloon = true;
            this.ttbtEliminar.SetToolTip(btEliminar, "Eliminar adquisición de proveedor");
            this.ttbtEliminar.IsBalloon = true;
            this.ttbtLimpiar.SetToolTip(btLimpiarFormulario, "Limpiar datos del formulario");
            this.ttbtLimpiar.IsBalloon = true;
            this.ttbtRefrescarListas.SetToolTip(btRefrescarDataGrids, "Refrescar lista adquisiciones");
            this.ttbtRefrescarListas.IsBalloon = true;
            this.ttbtRefrescarFormulario.SetToolTip(btRefrescarFormulario, "Actualizar todo el formulario");
            this.ttbtRefrescarFormulario.IsBalloon = true;
        }

        private void cbNombreProveedor_SelectedValueChanged(object sender, EventArgs e)
        {
            cargarCodigoProveedorCorrecto();
        }

        public void cargarCodigoProveedorCorrecto()
        {
            if (cbNombreProveedor.DataSource != null)
            {
                if (cbNombreProveedor.SelectedValue.ToString() != "")
                {
                    txtCodProveedor.Text = cbNombreProveedor.SelectedValue.ToString();
                }
                else
                {
                    txtCodProveedor.Text = "";
                }
                if (cbNombreProveedor.Text == "")
                {
                    txtCodProveedor.Text = "";
                }
            }
            else
            {
                cbNombreProveedor.Text = "";
                txtCodProveedor.Text = "";
            }
        }

    }
}

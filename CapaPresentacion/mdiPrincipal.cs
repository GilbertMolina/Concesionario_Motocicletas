using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaAccesoDatos;

namespace CapaPresentacion
{
    public partial class mdiPrincipal : Form
    {
        private int childFormNumber = 0;

        public mdiPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            this.Close();
            Application.Exit();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void mdiPrincipal_Load(object sender, EventArgs e)
        {
            //Metodo para que cambie el tamaño del background con forme al tamaño de la ventana
            pbBackground.Visible = false;
            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient)
                {
                    ctl.Paint += myMdiControlPaint;
                    ctl.SizeChanged += myMdiControlResize;
                    break;
                }
            }
        }

        //Metodo para que cambie el tamaño del background con forme al tamaño de la ventana
        private void myMdiControlPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(this.pbBackground.Image, 0, 0, this.Width, this.Height);
        }

        //Metodo para que cambie el tamaño del background con forme al tamaño de la ventana
        private void myMdiControlResize(object sender, EventArgs e)
        {
            ((MdiClient)sender).Invalidate();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcerca formularioAcerca = new frmAcerca();
            formularioAcerca.MdiParent = this;
            formularioAcerca.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVehiculoNuevo formularioVehiculoNuevo = new frmVehiculoNuevo();
            formularioVehiculoNuevo.MdiParent = this;
            formularioVehiculoNuevo.Show();
        }

        private void usadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVehiculoUsado formularioVehiculoUsado = new frmVehiculoUsado();
            formularioVehiculoUsado.MdiParent = this;
            formularioVehiculoUsado.Show();
        }

        private void repuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRepuestos formularioRespuestos = new frmRepuestos();
            formularioRespuestos.MdiParent = this;
            formularioRespuestos.Show();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServicios formularioServicios = new frmServicios();
            formularioServicios.MdiParent = this;
            formularioServicios.Show();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartamentos formularioDepartamentos = new frmDepartamentos();
            formularioDepartamentos.MdiParent = this;
            formularioDepartamentos.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleados formularioEmpleados = new frmEmpleados();
            formularioEmpleados.MdiParent = this;
            formularioEmpleados.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedores formularioProveedores = new frmProveedores();
            formularioProveedores.MdiParent = this;
            formularioProveedores.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes formularioClientes = new frmClientes();
            formularioClientes.MdiParent = this;
            formularioClientes.Show();
        }

        private void aquisicionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdquisiciones formularioAdquisiciones = new frmAdquisiciones();
            formularioAdquisiciones.MdiParent = this;
            formularioAdquisiciones.Show();
        }

        private void adquisicionesDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedoresXAdquisiciones formularioProveedoresXAdquisiciones = new frmProveedoresXAdquisiciones();
            formularioProveedoresXAdquisiciones.MdiParent = this;
            formularioProveedoresXAdquisiciones.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacturaVenta formularioFacturaVenta = new frmFacturaVenta();
            formularioFacturaVenta.MdiParent = this;
            formularioFacturaVenta.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventario formularioInventario = new frmInventario();
            formularioInventario.MdiParent = this;
            formularioInventario.Show();
        }

        public void comprobarEstadoBaseDeDatos(String usuarioConectado)
        {
            tsslBaseDeDatos.Text = "Usuario conectado: " + usuarioConectado;
        }

        private void adquisicionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdquisiciones formularioAdquisicion = new frmAdquisiciones();
            formularioAdquisicion.MdiParent = this;
            formularioAdquisicion.Show();
        }

        private void adquisicionesDeProveedoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmProveedoresXAdquisiciones formularioProveedoresXAdquisiciones = new frmProveedoresXAdquisiciones();
            formularioProveedoresXAdquisiciones.MdiParent = this;
            formularioProveedoresXAdquisiciones.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacturaVenta formularioFacturaVenta = new frmFacturaVenta();
            formularioFacturaVenta.MdiParent = this;
            formularioFacturaVenta.Show();
        }

        private void inventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmInventario formularioInventario = new frmInventario();
            formularioInventario.MdiParent = this;
            formularioInventario.Show();
        }

        private void reporte1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte_N1 formularioReporte_N1 = new frmReporte_N1();
            formularioReporte_N1.MdiParent = this;
            formularioReporte_N1.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte_N2 formularioReporte_N2 = new frmReporte_N2();
            formularioReporte_N2.MdiParent = this;
            formularioReporte_N2.Show();
        }

        private void reporteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReporte_N formularioReporte_N = new frmReporte_N();
            formularioReporte_N.MdiParent = this;
            formularioReporte_N.Show();
        }

    }
}

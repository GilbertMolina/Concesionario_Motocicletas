using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using CapaAccesoDatos;
using Objetos;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class cnProveedores
    {
        private cadProveedores cadProveedores;

        public Boolean insertarProveedor(objProveedores objProveedores)
        {
            Boolean proveedorEncontrado = false;

            objProveedores objProveedorConsultado = new objProveedores();

            objProveedorConsultado.Cedula_Juridica = objProveedores.Cedula_Juridica;

            proveedorEncontrado = this.cadProveedores.consultarProveedorCedulaJuridica(objProveedorConsultado);

            if (proveedorEncontrado == false)
            {
                this.cadProveedores.insertarProveedor(objProveedores);
                return true;
            }
            else
            {
                MessageBox.Show("Error: Ya existe un Proveedor con el mismo número de cédula jurídica en la base de datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        public void actualizarProveedor(objProveedores objProveedor)
        {
            this.cadProveedores.actualizarProveedor(objProveedor);
        }

        public DataTable consultarProveedores()
        {
            return this.cadProveedores.consultarProveedor();
        }

        public void eliminarProveedor(objProveedores objProveedor)
        {
            this.cadProveedores.eliminarProveedor(objProveedor);
        }

        public cnProveedores()
        {
            this.cadProveedores = new cadProveedores();
        }
    }
}

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
    public class cnProveedoresXAdquisiciones
    {
        private cadProveedoresXAdquisiciones cadProveedorXAdquisicion;

        public Boolean insertarProveedorAdquisicion(objProveedoresXAdquisiciones objProveedorXAdquisicion)
        {
            Boolean proveedorAdquisicionEncontrado = false;

            objProveedoresXAdquisiciones objProveedorAdquisicionConsultado = new objProveedoresXAdquisiciones();

            objProveedorAdquisicionConsultado.Cod_Proveedor = objProveedorXAdquisicion.Cod_Proveedor;
            objProveedorAdquisicionConsultado.Cod_Fact_Compra = objProveedorXAdquisicion.Cod_Fact_Compra;

            proveedorAdquisicionEncontrado = this.cadProveedorXAdquisicion.consultarAdquisicionDeProveedorCodigoProveedorCodigoFacturaCompra(objProveedorAdquisicionConsultado);

            if (proveedorAdquisicionEncontrado == false)
            {
                this.cadProveedorXAdquisicion.insertarAdquisicionDeProveedor(objProveedorXAdquisicion);
                return true;
            }
            else
            {
                MessageBox.Show("Error: Ya existe el mismo Proveedor con la misma Adquisición en la base de datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        public DataTable consultarProveedoresAdquisiciones()
        {
            return this.cadProveedorXAdquisicion.consultarAdquisicionesDeProveedores();
        }

        public void eliminarProveedorAdquisicion(objProveedoresXAdquisiciones objProveedorXAdquisicion)
        {
            this.cadProveedorXAdquisicion.eliminarAdquisicionDeProveedor(objProveedorXAdquisicion);
        }

        public cnProveedoresXAdquisiciones()
        {
            this.cadProveedorXAdquisicion = new cadProveedoresXAdquisiciones();
        }

    }
}

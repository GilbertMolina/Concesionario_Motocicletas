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
    public class cnRepuestos
    {
        private cadRepuestos cadRepuestos;

        public Boolean insertarRepuesto(objRepuestos objRepuestos)
        {
            Boolean repuestoEncontrado = false;

            objRepuestos objRepuestoConsultado = new objRepuestos();

            objRepuestoConsultado.Tipo = objRepuestos.Tipo;
            objRepuestoConsultado.Descripcion = objRepuestos.Descripcion;
            objRepuestoConsultado.Precio = objRepuestos.Precio;

            repuestoEncontrado = this.cadRepuestos.consultarRepuestoTipoPrecioDescripcion(objRepuestoConsultado);

            if (repuestoEncontrado == false)
            {
                this.cadRepuestos.insertarRepuesto(objRepuestos);
                return true;
            }
            else
            {
                MessageBox.Show("Error: Ya existe este repuesto con el mismo tipo, precio y descripcion en la base de datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        public void actualizarRepuesto(objRepuestos objRepuestos)
        {
            this.cadRepuestos.actualizarRepuesto(objRepuestos);
        }

        public DataTable consultarRepuestos()
        {
            return this.cadRepuestos.consultarRepuesto();
        }

        public void eliminarRepuesto(objRepuestos objRepuestos)
        {
            this.cadRepuestos.eliminarProveedor(objRepuestos);
        }

        public cnRepuestos()
        {
            this.cadRepuestos = new cadRepuestos();
        }
    }
}

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
    public class cnAdquisiciones
    {
        private cadAdquisiciones cadAdquisicion;

        public Boolean insertarAdquisicion(objAdquisiciones objAdquisicion, int opcion)
        {
            Boolean adquisicionEncontrada = false;

            objAdquisiciones objAdquisicionConsultada = new objAdquisiciones();

            objAdquisicionConsultada.Cod_Vehiculo = objAdquisicion.Cod_Vehiculo;
            objAdquisicionConsultada.Cod_Repuesto = objAdquisicion.Cod_Repuesto;
            objAdquisicionConsultada.Fecha_Compra = objAdquisicion.Fecha_Compra;

            adquisicionEncontrada = this.cadAdquisicion.consultarAdquisicionCodigoProductoFechaCompra(objAdquisicionConsultada, opcion);

            if (adquisicionEncontrada == false)
            {
                this.cadAdquisicion.insertarAdquisicion(objAdquisicion, opcion);
                return true;
            }
            else
            {
                MessageBox.Show("Error: Ya existe una Adquisición con el mismo código de producto y fecha de compra en la base de datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        public void actualizarAdquisicion(objAdquisiciones objAdquisicion)
        {
            this.cadAdquisicion.actualizarAdquisicion(objAdquisicion);
        }

        public DataTable consultarAdquisiciones()
        {
            return this.cadAdquisicion.consultarAdquisiciones();
        }

        public DataTable consultarProductos(int estado)
        {
            return this.cadAdquisicion.consultarProductos(estado);
        }

        public void eliminarAdquisicion(objAdquisiciones objAdquisicion)
        {
            this.cadAdquisicion.eliminarAdquisicion(objAdquisicion);
        }

        public cnAdquisiciones()
        {
            this.cadAdquisicion = new cadAdquisiciones();
        }

    }
}

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
    public class cnServicios
    {
        private cadServicios cadServicios;


        public Boolean insertarServicio(objServicios objServicios)
        {
            Boolean servicioEncontrado = false;

            objServicios objServicioConsultado = new objServicios();

            objServicioConsultado.Cod_Empleado = objServicios.Cod_Empleado;
            objServicioConsultado.Tipo = objServicios.Tipo;
            objServicioConsultado.Precio = objServicios.Precio;

            servicioEncontrado = this.cadServicios.consultarServiciosEmpleadoTipoPrecio(objServicioConsultado);

            if (servicioEncontrado == false)
            {
                this.cadServicios.insertarServicio(objServicios);
                return true;
            }
            else
            {
                MessageBox.Show("Error: Ya existe este servicio con el mismo código de empleado, tipo de servicio y precio en la base de datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        public void actualizarServicio(objServicios objServicio)
        {
            this.cadServicios.actualizarServicio(objServicio);
        }

        public DataTable consultarServicio()
        {
            return this.cadServicios.consultarServicio();
        }

        public void eliminarServicio(objServicios objServicio)
        {
            this.cadServicios.eliminarServicio(objServicio);
        }

        public cnServicios()
        {
            this.cadServicios = new cadServicios();
        }
    }
}

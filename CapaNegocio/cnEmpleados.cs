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
    public class cnEmpleados
    {
        private cadEmpleados cadEmpleado;

        public Boolean insertarEmpleado(objEmpleados objEmpleado)
        {
            Boolean empleadoEncontrado = false;

            objEmpleados objEmpleadoConsultado = new objEmpleados();

            objEmpleadoConsultado.Cedula = objEmpleado.Cedula;
            objEmpleadoConsultado.Correo = objEmpleado.Correo;

            empleadoEncontrado = this.cadEmpleado.consultarEmpleadoCedula(objEmpleadoConsultado);

            if (empleadoEncontrado == false)
            {
                this.cadEmpleado.insertarEmpleado(objEmpleado);
                return true;
            }
            else
            {
                MessageBox.Show("Error: Ya existe un Empleado con la misma cédula en la base de datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        public void actualizarEmpleado(objEmpleados objEmpleado)
        {
            this.cadEmpleado.actualizarEmpleado(objEmpleado);
        }

        public DataTable consultarEmpleados(int estado)
        {
            return this.cadEmpleado.consultarEmpleados(estado);
        }

        public DataTable consultarEmpleadosNoGerentes()
        {
            return this.cadEmpleado.consultarEmpleadosNoGerentes();
        }

        public DataTable consultarEmpleadosTaller()
        {
            return this.cadEmpleado.consultarEmpleadosTaller();
        }

        public void eliminarEmpleado(objEmpleados objEmpleado)
        {
            this.cadEmpleado.eliminarEmpleado(objEmpleado);
        }

        public cnEmpleados()
        {
            this.cadEmpleado = new cadEmpleados();
        }

    }
}

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
    public class cnDepartamentos
    {
        private cadDepartamentos cadDepartamento;

        public Boolean insertarDepartamento(objDepartamentos objDepartamento, objDepartamentos objDepartamentoAdministrador)
        {
            Boolean departamentoEncontrado = false;

            objDepartamentos objDepartamentoConsultado = new objDepartamentos();

            objDepartamentoConsultado.Nombre = objDepartamento.Nombre;

            departamentoEncontrado = this.cadDepartamento.consultarDepartamentoNombre(objDepartamentoConsultado);

            if (departamentoEncontrado == false)
            {
                this.cadDepartamento.insertarDepartamento(objDepartamento, objDepartamentoAdministrador);
                return true;
            }
            else
            {
                MessageBox.Show("Error: Ya existe un departamento con el mismo nombre en la base de datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        public void actualizarDepartamento(objDepartamentos objDepartamento, objDepartamentos objDepartamentoAdministrador)
        {
            this.cadDepartamento.actualizarDepartamento(objDepartamento, objDepartamentoAdministrador);
        }

        public DataTable consultarDepartamentos()
        {
            return this.cadDepartamento.consultarDepartamentos();
        }

        public void eliminarDepartamento(objDepartamentos objDepartamento)
        {
            this.cadDepartamento.eliminarDepartamento(objDepartamento);
        }

        public cnDepartamentos()
        {
            this.cadDepartamento = new cadDepartamentos();
        }

    }
}

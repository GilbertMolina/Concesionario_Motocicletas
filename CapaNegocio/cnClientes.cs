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
    public class cnClientes
    {

        private cadClientes cadClientes;

        public Boolean insertarCliente(objClientes objClientes)
        {
            Boolean clienteEncontrado = false;

            objClientes objClienteConsultado = new objClientes();

            objClienteConsultado.Cedula = objClientes.Cedula;

            clienteEncontrado = this.cadClientes.consultarClienteCedula(objClienteConsultado);

            if (clienteEncontrado == false)
            {
                this.cadClientes.insertarCliente(objClientes);
                return true;
            }
            else
            {
                MessageBox.Show("Error: Ya existe este cliente con la misma cédula en la base de datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        public void actualizarCliente(objClientes objCliente)
        {
            this.cadClientes.actualizarCliente(objCliente);
        }

        public DataTable consultarClientes()
        {
            return this.cadClientes.consultarCliente();
        }

        public void eliminarCliente(objClientes objCliente)
        {
            this.cadClientes.eliminarCliente(objCliente);
        }

        public cnClientes()
        {
            this.cadClientes = new cadClientes();
        }
    }
}

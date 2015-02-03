using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;
using Objetos;
using System.Windows.Forms;

namespace CapaAccesoDatos
{
    public class cadClientes
    {
        public DataTable consultarCliente()
        {
            DataTable tablaClientes = new DataTable();
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tclientes_mostrar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("c_clientes", OracleDbType.RefCursor, ParameterDirection.Output);

                OracleDataReader dataReader = conn.cmd.ExecuteReader();

                tablaClientes.Load(dataReader);

                conn.connection.Close();
                return tablaClientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al consultar Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tablaClientes;
            }
        }

        public Boolean consultarClienteCedula(objClientes objCliente)
        {
            Boolean clienteEncontrado = false;
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tclientes_existente", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_cedula", OracleDbType.Varchar2, objCliente.Cedula, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_encontrado", OracleDbType.Int32, ParameterDirection.Output);

                conn.cmd.ExecuteReader();

                int cedulaEncontradoDevuelto = Convert.ToInt32(conn.cmd.Parameters["v_encontrado"].Value.ToString());

                if (cedulaEncontradoDevuelto > 0)
                {
                    clienteEncontrado = true;
                }

                conn.cmd.Dispose();
                conn.connection.Close();
                return clienteEncontrado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al consultar Cliente con la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return clienteEncontrado;
            }
        }

        public void insertarCliente(objClientes objCliente)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tclientes_insertar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_cedula", OracleDbType.Varchar2, objCliente.Cedula, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_nombre", OracleDbType.Varchar2, objCliente.Nombre, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_apellidos", OracleDbType.Varchar2, objCliente.Apellidos, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_telefono", OracleDbType.Varchar2, objCliente.Telefono, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_direccion", OracleDbType.Varchar2, objCliente.Direccion, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_ciudad", OracleDbType.Varchar2, objCliente.Ciudad, ParameterDirection.Input);

                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al insertar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void actualizarCliente(objClientes objCliente)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tclientes_actualizar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_cliente_id", OracleDbType.Varchar2, objCliente.Cod_Ciente, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_nombre", OracleDbType.Varchar2, objCliente.Nombre, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_apellidos", OracleDbType.Varchar2, objCliente.Apellidos, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_telefono", OracleDbType.Varchar2, objCliente.Telefono, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_direccion", OracleDbType.Varchar2, objCliente.Direccion, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_ciudad", OracleDbType.Varchar2, objCliente.Ciudad, ParameterDirection.Input);

                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al actualizar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void eliminarCliente(objClientes objCliente)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tclientes_eliminar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_cliente_id", OracleDbType.Int32, objCliente.Cod_Ciente, ParameterDirection.Input);

                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

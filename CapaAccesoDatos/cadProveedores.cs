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
    public class cadProveedores
    {
        public DataTable consultarProveedor()
        {
            DataTable tablaProveedores = new DataTable();
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tproveedores_mostrar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("c_proveedores", OracleDbType.RefCursor, ParameterDirection.Output);

                OracleDataReader dataReader = conn.cmd.ExecuteReader();

                tablaProveedores.Load(dataReader);

                conn.connection.Close();
                return tablaProveedores;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al consultar Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tablaProveedores;
            }
        }

        public void insertarProveedor(objProveedores objProveedor)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tproveedores_insertar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_cedula_juridica", OracleDbType.Varchar2, objProveedor.Cedula_Juridica, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_nombre", OracleDbType.Varchar2, objProveedor.Nombre, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_razon_social", OracleDbType.Varchar2, objProveedor.Razon_Social, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_descripcion_servicio", OracleDbType.Varchar2, objProveedor.Descripcion_Servicio, ParameterDirection.Input);

                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al insertar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean consultarProveedorCedulaJuridica(objProveedores objProveedor)
        {
            Boolean proveedorEncontrado = false;
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tproveedores_existente", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_cedula_juridica", OracleDbType.Varchar2, objProveedor.Cedula_Juridica, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_encontrado", OracleDbType.Int32, ParameterDirection.Output);

                conn.cmd.ExecuteReader();

                int proveedorEncontradoDevuelto = Convert.ToInt32(conn.cmd.Parameters["v_encontrado"].Value.ToString());

                if (proveedorEncontradoDevuelto > 0)
                {
                    proveedorEncontrado = true;
                }

                conn.cmd.Dispose();
                conn.connection.Close();
                return proveedorEncontrado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al consultar Proveedor con la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return proveedorEncontrado;
            }
        }

        public void actualizarProveedor(objProveedores objProveedor)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tproveedores_actualizar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_cod_proveedor", OracleDbType.Varchar2, objProveedor.Cod_Proveedor, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_cedula_juridica", OracleDbType.Varchar2, objProveedor.Cedula_Juridica, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_nombre", OracleDbType.Varchar2, objProveedor.Nombre, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_razon_social", OracleDbType.Varchar2, objProveedor.Razon_Social, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_descripcion_servicio", OracleDbType.Varchar2, objProveedor.Descripcion_Servicio, ParameterDirection.Input);

                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al actualizar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void eliminarProveedor(objProveedores objProveedor)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tproveedores_eliminar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_cod_proveedor", OracleDbType.Int32, objProveedor.Cod_Proveedor, ParameterDirection.Input);

                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("ORA-02292"))
                {
                    MessageBox.Show("Error: El Proveedor tiene asignadas Adquisiciones, elimine primero la adquisición asignada al proveedor y luego proceda a eliminar el proveedor", "Error al eliminar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message, "Error al eliminar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

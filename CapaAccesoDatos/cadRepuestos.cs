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
    public class cadRepuestos
    {
        public DataTable consultarRepuesto()
        {
            DataTable tablaRepuestos = new DataTable();
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_trepuestos_mostrar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("c_repuestos", OracleDbType.RefCursor, ParameterDirection.Output);

                OracleDataReader dataReader = conn.cmd.ExecuteReader();

                tablaRepuestos.Load(dataReader);

                conn.connection.Close();
                return tablaRepuestos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al consultar Repuestos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tablaRepuestos;
            }
        }

        public void insertarRepuesto(objRepuestos objRepuestos)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_trepuestos_insertar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_descripcion", OracleDbType.Varchar2, objRepuestos.Descripcion, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_tipo", OracleDbType.Varchar2, objRepuestos.Tipo, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_precio_unitario", OracleDbType.Double, objRepuestos.Precio, ParameterDirection.Input);

                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al insertar Repuesto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean consultarRepuestoTipoPrecioDescripcion(objRepuestos objRepuestos)
        {
            Boolean repuestoEncontrado = false;
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_trepuestos_existente", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_descripcion", OracleDbType.Varchar2, objRepuestos.Descripcion, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_tipo", OracleDbType.Varchar2, objRepuestos.Tipo, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_precio_unitario", OracleDbType.Double, objRepuestos.Precio, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_encontrado", OracleDbType.Int32, ParameterDirection.Output);

                conn.cmd.ExecuteReader();

                int repuestoEncontradoDevuelto = Convert.ToInt32(conn.cmd.Parameters["v_encontrado"].Value.ToString());

                if (repuestoEncontradoDevuelto > 0)
                {
                    repuestoEncontrado = true;
                }

                conn.cmd.Dispose();
                conn.connection.Close();
                return repuestoEncontrado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al consultar Repuesto con la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return repuestoEncontrado;
            }
        }

        public void actualizarRepuesto(objRepuestos objRepuestos)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_trepuestos_actualizar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_cod_repuesto", OracleDbType.Varchar2, objRepuestos.Cod_Repuesto, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_descripcion", OracleDbType.Varchar2, objRepuestos.Descripcion, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_tipo", OracleDbType.Varchar2, objRepuestos.Tipo, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_precio_unitario", OracleDbType.Int32, objRepuestos.Precio, ParameterDirection.Input);
                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al actualizar Repuesto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void eliminarProveedor(objRepuestos objRepuestos)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_trepuestos_eliminar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_cod_repuesto", OracleDbType.Varchar2, objRepuestos.Cod_Repuesto, ParameterDirection.Input);

                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al eliminar Repuesto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

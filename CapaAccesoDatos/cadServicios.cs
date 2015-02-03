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
    public class cadServicios
    {
        public DataTable consultarServicio()
        {
            DataTable tablaServicios = new DataTable();
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tservicios_mostrar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("c_servicios", OracleDbType.RefCursor, ParameterDirection.Output);

                OracleDataReader dataReader = conn.cmd.ExecuteReader();

                tablaServicios.Load(dataReader);

                conn.connection.Close();
                return tablaServicios;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al consultar Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tablaServicios;
            }
        }

        public void insertarServicio(objServicios objServicios)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tservicios_insertar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_cod_empleado", OracleDbType.Int32, objServicios.Cod_Empleado, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_tipo", OracleDbType.Varchar2, objServicios.Tipo, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_precio", OracleDbType.Double, objServicios.Precio, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_descripcion", OracleDbType.Varchar2, objServicios.Descripcion, ParameterDirection.Input);

                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al insertar Servicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean consultarServiciosEmpleadoTipoPrecio(objServicios objServicios)
        {
            Boolean servicioEncontrado = false;
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tservicios_existente", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_cod_empleado", OracleDbType.Int32, objServicios.Cod_Empleado, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_tipo", OracleDbType.Varchar2, objServicios.Tipo, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_precio", OracleDbType.Double, objServicios.Precio, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_encontrado", OracleDbType.Int32, ParameterDirection.Output);

                conn.cmd.ExecuteReader();

                int proveedorEncontradoDevuelto = Convert.ToInt32(conn.cmd.Parameters["v_encontrado"].Value.ToString());

                if (proveedorEncontradoDevuelto > 0)
                {
                    servicioEncontrado = true;
                }

                conn.cmd.Dispose();
                conn.connection.Close();
                return servicioEncontrado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al consultar Servicio con la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return servicioEncontrado;
            }
        }

        public void actualizarServicio(objServicios objServicios)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tservicios_actualizar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_cod_servicio", OracleDbType.Varchar2, objServicios.Cod_Servicio, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_cod_empleado", OracleDbType.Int32, objServicios.Cod_Empleado, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_tipo", OracleDbType.Varchar2, objServicios.Tipo, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_precio", OracleDbType.Double, objServicios.Precio, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_descripcion", OracleDbType.Varchar2, objServicios.Descripcion, ParameterDirection.Input);

                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al actualizar Servicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void eliminarServicio(objServicios objServicios)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tservicios_eliminar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_cod_servicio", OracleDbType.Varchar2, objServicios.Cod_Servicio, ParameterDirection.Input);

                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al eliminar Servicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

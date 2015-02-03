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
    public class cadVehiculoUsado
    {
        public DataTable consultarVehiculosUsados()
        {
            DataTable tablaVehiculosUsados = new DataTable();
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tvehiculo_usado_mostrar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("c_vehiculos", OracleDbType.RefCursor, ParameterDirection.Output);

                OracleDataReader dataReader = conn.cmd.ExecuteReader();

                tablaVehiculosUsados.Load(dataReader);

                conn.connection.Close();
                return tablaVehiculosUsados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al consultar Vehículos Nuevos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tablaVehiculosUsados;
            }
        }

        public void insertarVehiculoUsado(objVehiculoUsado objVehiculoUsado)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tvehiculo_usado_insertar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_marca", OracleDbType.Varchar2, objVehiculoUsado.Marca, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_modelo", OracleDbType.Varchar2, objVehiculoUsado.Modelo, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_color", OracleDbType.Varchar2, objVehiculoUsado.Color, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_precio_unitario", OracleDbType.Double, objVehiculoUsado.Precio_Unitario, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_garantia", OracleDbType.Varchar2, objVehiculoUsado.Garantia, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_numero_placa", OracleDbType.Varchar2, objVehiculoUsado.Numero_Placa, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_kilometraje", OracleDbType.Int32, objVehiculoUsado.Kilometraje, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_estado", OracleDbType.Varchar2, objVehiculoUsado.Estado, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_especificaciones", OracleDbType.Varchar2, objVehiculoUsado.Especificaciones, ParameterDirection.Input);

                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al insertar Vehículo Usado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean consultarVehiculoNumeroPlaca(objVehiculoUsado objVehiculoUsado)
        {
            Boolean vehiculoUsadoEncontrado = false;
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tvehiculo_usado_existente", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_numero_placa", OracleDbType.Varchar2, objVehiculoUsado.Numero_Placa, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_encontrado", OracleDbType.Int32, ParameterDirection.Output);

                conn.cmd.ExecuteReader();

                int vehiculoEncontradoDevuelto = Convert.ToInt32(conn.cmd.Parameters["v_encontrado"].Value.ToString());

                if (vehiculoEncontradoDevuelto > 0)
                {
                    vehiculoUsadoEncontrado = true;
                }

                conn.cmd.Dispose();
                conn.connection.Close();
                return vehiculoUsadoEncontrado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al consultar Vehículo Usado con la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return vehiculoUsadoEncontrado;
            }
        }

        public void actualizarVehiculoUsado(objVehiculoUsado objVehiculoUsado)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tvehiculo_usado_actualizar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_cod_vehiculo", OracleDbType.Varchar2, objVehiculoUsado.Cod_Vehiculo, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_marca", OracleDbType.Varchar2, objVehiculoUsado.Marca, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_modelo", OracleDbType.Varchar2, objVehiculoUsado.Modelo, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_color", OracleDbType.Varchar2, objVehiculoUsado.Color, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_precio_unitario", OracleDbType.Double, objVehiculoUsado.Precio_Unitario, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_garantia", OracleDbType.Varchar2, objVehiculoUsado.Garantia, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_numero_placa", OracleDbType.Varchar2, objVehiculoUsado.Numero_Placa, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_kilometraje", OracleDbType.Int32, objVehiculoUsado.Kilometraje, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_estado", OracleDbType.Varchar2, objVehiculoUsado.Estado, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_especificaciones", OracleDbType.Varchar2, objVehiculoUsado.Especificaciones, ParameterDirection.Input);

                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al actualizar Vehículo Usado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void eliminarVehiculoUsado(objVehiculoUsado objVehiculoUsado)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tvehiculo_eliminar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_cod_vehiculo", OracleDbType.Varchar2, objVehiculoUsado.Cod_Vehiculo, ParameterDirection.Input);

                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al eliminar Vehículo Usado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

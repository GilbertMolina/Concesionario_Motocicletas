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
    public class cadVehiculoNuevo
    {

        public DataTable consultarVehiculosNuevos()
        {
            DataTable tablaVehiculosNuevos = new DataTable();
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tvehiculo_nuevo_mostrar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("c_vehiculos", OracleDbType.RefCursor, ParameterDirection.Output);

                OracleDataReader dataReader = conn.cmd.ExecuteReader();

                tablaVehiculosNuevos.Load(dataReader);

                conn.connection.Close();
                return tablaVehiculosNuevos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al consultar Vehículos Nuevos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tablaVehiculosNuevos;
            }
        }

        public void insertarVehiculoNuevo(objVehiculoNuevo objVehiculoNuevo)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tvehiculo_nuevo_insertar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_marca", OracleDbType.Varchar2, objVehiculoNuevo.Marca, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_modelo", OracleDbType.Varchar2, objVehiculoNuevo.Modelo, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_color", OracleDbType.Varchar2, objVehiculoNuevo.Color, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_precio_unitario", OracleDbType.Double, objVehiculoNuevo.Precio_Unitario, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_garantia", OracleDbType.Varchar2, objVehiculoNuevo.Garantia, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_primer_mantenimiento", OracleDbType.Varchar2, objVehiculoNuevo.Primer_Mantenimiento, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_especificaciones", OracleDbType.Varchar2, objVehiculoNuevo.Especificaciones, ParameterDirection.Input);

                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al insertar Vehículo Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean consultarVehiculoMarcaModeloColor(objVehiculoNuevo objVehiculoNuevo)
        {
            Boolean vehiculoNuevoEncontrado = false;
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tvehiculo_nuevo_existente", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_marca", OracleDbType.Varchar2, objVehiculoNuevo.Marca, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_modelo", OracleDbType.Varchar2, objVehiculoNuevo.Modelo, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_color", OracleDbType.Varchar2, objVehiculoNuevo.Color, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_encontrado", OracleDbType.Int32, ParameterDirection.Output);

                conn.cmd.ExecuteReader();

                int vehiculoEncontradoDevuelto = Convert.ToInt32(conn.cmd.Parameters["v_encontrado"].Value.ToString());

                if (vehiculoEncontradoDevuelto > 0)
                {
                    vehiculoNuevoEncontrado = true;
                }

                conn.cmd.Dispose();
                conn.connection.Close();
                return vehiculoNuevoEncontrado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al consultar Vehículo Nuevo con la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return vehiculoNuevoEncontrado;
            }
        }

        public void actualizarVehiculoNuevo(objVehiculoNuevo objVehiculoNuevo)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tvehiculo_nuevo_actualizar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_cod_vehiculo", OracleDbType.Varchar2, objVehiculoNuevo.Cod_Vehiculo, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_marca", OracleDbType.Varchar2, objVehiculoNuevo.Marca, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_modelo", OracleDbType.Varchar2, objVehiculoNuevo.Modelo, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_color", OracleDbType.Varchar2, objVehiculoNuevo.Color, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_precio_unitario", OracleDbType.Double, objVehiculoNuevo.Precio_Unitario, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_garantia", OracleDbType.Varchar2, objVehiculoNuevo.Garantia, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_primer_mantenimiento", OracleDbType.Varchar2, objVehiculoNuevo.Primer_Mantenimiento, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_especificaciones", OracleDbType.Varchar2, objVehiculoNuevo.Especificaciones, ParameterDirection.Input);

                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al actualizar Vehículo Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void eliminarVehiculoNuevo(objVehiculoNuevo objVehiculoNuevo)
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

                conn.cmd.Parameters.Add("v_cod_vehiculo", OracleDbType.Varchar2, objVehiculoNuevo.Cod_Vehiculo, ParameterDirection.Input);

                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al eliminar Vehículo Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

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
    public class cadAdquisiciones
    {

        public DataTable consultarAdquisiciones()
        {
            DataTable tablaAdquisiciones = new DataTable();
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tadquisiciones_mostrar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("c_adquisiciones", OracleDbType.RefCursor, ParameterDirection.Output);

                OracleDataReader dataReader = conn.cmd.ExecuteReader();

                tablaAdquisiciones.Load(dataReader);

                conn.connection.Close();
                return tablaAdquisiciones;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al consultar Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tablaAdquisiciones;
            }
        }

        public DataTable consultarProductos(int estado)
        {
            DataTable tablaProductos = new DataTable();
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                if (estado == 1)
                {
                    conn.cmd = new OracleCommand("sp_tvehiculo_nuevo_mostrar", conn.connection);
                    conn.cmd.CommandType = CommandType.StoredProcedure;
                    conn.cmd.Parameters.Add("c_vehiculos", OracleDbType.RefCursor, ParameterDirection.Output);
                }
                else if (estado == 2)
                {
                    conn.cmd = new OracleCommand("sp_tvehiculo_usado_mostrar", conn.connection);
                    conn.cmd.CommandType = CommandType.StoredProcedure;
                    conn.cmd.Parameters.Add("c_vehiculos", OracleDbType.RefCursor, ParameterDirection.Output);
                }
                else if (estado == 3)
                {
                    conn.cmd = new OracleCommand("sp_trepuestos_mostrar", conn.connection);
                    conn.cmd.CommandType = CommandType.StoredProcedure;
                    conn.cmd.Parameters.Add("c_repuestos", OracleDbType.RefCursor, ParameterDirection.Output);
                }

                OracleDataReader dataReader = conn.cmd.ExecuteReader();

                tablaProductos.Load(dataReader);

                conn.connection.Close();
                return tablaProductos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al consultar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tablaProductos;
            }
        }

        public void insertarAdquisicion(objAdquisiciones objAdquisicion, int opcion)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tadquisiciones_insertar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                if (opcion == 1)
                {
                    conn.cmd.Parameters.Add("v_cod_vehiculo", OracleDbType.Varchar2, objAdquisicion.Cod_Vehiculo, ParameterDirection.Input);
                    conn.cmd.Parameters.Add("v_cod_repuesto", OracleDbType.Varchar2, "", ParameterDirection.Input);
                    conn.cmd.Parameters.Add("v_cantidad_unidades", OracleDbType.Int32, objAdquisicion.Cantidad_Unidades, ParameterDirection.Input);
                    conn.cmd.Parameters.Add("v_fecha_compra", OracleDbType.Date, objAdquisicion.Fecha_Compra, ParameterDirection.Input);
                    conn.cmd.Parameters.Add("v_valor", OracleDbType.Double, objAdquisicion.Valor, ParameterDirection.Input);
                    conn.cmd.Parameters.Add("v_opcion", OracleDbType.Int32, opcion, ParameterDirection.Input);
                }
                else if (opcion == 2)
                {
                    conn.cmd.Parameters.Add("v_cod_vehiculo", OracleDbType.Varchar2, "", ParameterDirection.Input);
                    conn.cmd.Parameters.Add("v_cod_repuesto", OracleDbType.Varchar2, objAdquisicion.Cod_Repuesto, ParameterDirection.Input);
                    conn.cmd.Parameters.Add("v_cantidad_unidades", OracleDbType.Int32, objAdquisicion.Cantidad_Unidades, ParameterDirection.Input);
                    conn.cmd.Parameters.Add("v_fecha_compra", OracleDbType.Date, objAdquisicion.Fecha_Compra, ParameterDirection.Input);
                    conn.cmd.Parameters.Add("v_valor", OracleDbType.Double, objAdquisicion.Valor, ParameterDirection.Input);
                    conn.cmd.Parameters.Add("v_opcion", OracleDbType.Int32, opcion, ParameterDirection.Input);
                }

                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al insertar Adquisición", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean consultarAdquisicionCodigoProductoFechaCompra(objAdquisiciones objAdquisicion, int opcion)
        {
            Boolean adquisicionEncontrada = false;
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tadquisiciones_existente", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                if (opcion == 1)
                {
                    conn.cmd.Parameters.Add("v_cod_vehiculo", OracleDbType.Varchar2, objAdquisicion.Cod_Vehiculo, ParameterDirection.Input);
                    conn.cmd.Parameters.Add("v_cod_repuesto", OracleDbType.Varchar2, "", ParameterDirection.Input);
                    conn.cmd.Parameters.Add("v_fecha_compra", OracleDbType.Date, objAdquisicion.Fecha_Compra, ParameterDirection.Input);
                    conn.cmd.Parameters.Add("v_opcion", OracleDbType.Int32, opcion, ParameterDirection.Input);
                    conn.cmd.Parameters.Add("v_encontrado", OracleDbType.Int32, ParameterDirection.Output);
                }
                else if (opcion == 2)
                {
                    conn.cmd.Parameters.Add("v_cod_vehiculo", OracleDbType.Varchar2, "", ParameterDirection.Input);
                    conn.cmd.Parameters.Add("v_cod_repuesto", OracleDbType.Varchar2, objAdquisicion.Cod_Repuesto, ParameterDirection.Input);
                    conn.cmd.Parameters.Add("v_fecha_compra", OracleDbType.Date, objAdquisicion.Fecha_Compra, ParameterDirection.Input);
                    conn.cmd.Parameters.Add("v_opcion", OracleDbType.Int32, opcion, ParameterDirection.Input);
                    conn.cmd.Parameters.Add("v_encontrado", OracleDbType.Int32, ParameterDirection.Output);
                }

                conn.cmd.ExecuteReader();

                int adquisicionEncontradaDevuelta = Convert.ToInt32(conn.cmd.Parameters["v_encontrado"].Value.ToString());

                if (adquisicionEncontradaDevuelta > 0)
                {
                    adquisicionEncontrada = true;
                }

                conn.cmd.Dispose();
                conn.connection.Close();
                return adquisicionEncontrada;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al consultar Adquisición con la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return adquisicionEncontrada;
            }
        }

        public void actualizarAdquisicion(objAdquisiciones objAdquisicion)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tadquisiciones_actualizar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_cod_fact_compra", OracleDbType.Int32, objAdquisicion.Cod_Fact_Compra, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_cantidad_unidaddes", OracleDbType.Int32, objAdquisicion.Cantidad_Unidades, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_valor", OracleDbType.Double, objAdquisicion.Valor, ParameterDirection.Input);

                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al actualizar Adquisición", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void eliminarAdquisicion(objAdquisiciones objAdquisicion)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tadquisiciones_eliminar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_cod_fact_compra", OracleDbType.Int32, objAdquisicion.Cod_Fact_Compra, ParameterDirection.Input);

                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("ORA-02292"))
                {
                    MessageBox.Show("Error: La Adquisición esta asignada a un proveedor, elimine primero la adquisición asignada al proveedor y luego proceda a eliminar la adquisición", "Error al eliminar Adquisición", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message, "Error al eliminar Adquisición", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

    }
}

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
    public class cadFacturaVenta
    {
        public DataTable consultarFactura()
        {
            DataTable tablaFacturas = new DataTable();
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tfactura_venta_mostrar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("c_factura_venta", OracleDbType.RefCursor, ParameterDirection.Output);

                OracleDataReader dataReader = conn.cmd.ExecuteReader();

                tablaFacturas.Load(dataReader);

                conn.connection.Close();
                return tablaFacturas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al consultar Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tablaFacturas;
            }
        }


        //Cargas de cursores en combobox
        public DataTable consultarRepuestosFactura()
        {
            DataTable tabalRepuestos = new DataTable();
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("Sp_Trepuestos_Factura", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("c_repuestos_fact", OracleDbType.RefCursor, ParameterDirection.Output);

                OracleDataReader dataReader = conn.cmd.ExecuteReader();

                tabalRepuestos.Load(dataReader);

                conn.connection.Close();
                return tabalRepuestos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al consultar Repuestos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tabalRepuestos;
            }
        }

        public DataTable consultarVehiculoNuevo()
        {
            DataTable tablaVehiculos_Nuevos = new DataTable();
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("Sp_Tvehiculo_Nuevo", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("C_Vehiculo_Nuevo", OracleDbType.RefCursor, ParameterDirection.Output);

                OracleDataReader dataReader = conn.cmd.ExecuteReader();

                tablaVehiculos_Nuevos.Load(dataReader);

                conn.connection.Close();
                return tablaVehiculos_Nuevos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al consultar Vehiculos Nuevos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tablaVehiculos_Nuevos;
            }
        }

        public DataTable consultarVehiculoUsado()
        {
            DataTable tablaVehiculos_Usados = new DataTable();
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("Sp_Tvehiculo_Usado", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("c_vehiculo_usado", OracleDbType.RefCursor, ParameterDirection.Output);

                OracleDataReader dataReader = conn.cmd.ExecuteReader();

                tablaVehiculos_Usados.Load(dataReader);

                conn.connection.Close();
                return tablaVehiculos_Usados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al consultar Vehiculos Usados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tablaVehiculos_Usados;
            }
        }

        public void insertarFactura(objFacturaVenta objFacturaVenta, objDetalleVenta objDetalleVenta)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tfactura_venta_insertar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("V_COD_EMPLEADO", OracleDbType.Int32, objFacturaVenta.Cod_Empleado, ParameterDirection.Input);
                conn.cmd.Parameters.Add("V_COD_CLIENTE", OracleDbType.Int32, objFacturaVenta.Cod_Cliente, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_FECHA_VENTA", OracleDbType.Varchar2, objFacturaVenta.Fecha_Venta, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_TOTAL", OracleDbType.Varchar2, objFacturaVenta.Total, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_COD_PRODUCTO", OracleDbType.Varchar2, objDetalleVenta.Cod_Producto, ParameterDirection.Input);
                conn.cmd.Parameters.Add("V_Cantidad", OracleDbType.Varchar2, objDetalleVenta.Cantidad, ParameterDirection.Input);
                conn.cmd.Parameters.Add("V_Precio_Unitario", OracleDbType.Varchar2, objDetalleVenta.Precio_Unitario, ParameterDirection.Input);
                conn.cmd.Parameters.Add("V_SUBTOTAL", OracleDbType.Varchar2, objDetalleVenta.Subtotal, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_COMENTARIOS", OracleDbType.Varchar2, objDetalleVenta.Comentarios, ParameterDirection.Input);

                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al insertar Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void actualizarFactura(objFacturaVenta objFacturaVenta)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tfactura_venta_actualizar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_factura_venta_id", OracleDbType.Int32, objFacturaVenta.Cod_Fact_Venta, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_cod_empleado", OracleDbType.Int32, objFacturaVenta.Cod_Empleado, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_cod_cliente", OracleDbType.Int32, objFacturaVenta.Cod_Cliente, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_fecha_venta", OracleDbType.Date, objFacturaVenta.Fecha_Venta, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_total", OracleDbType.Int32, objFacturaVenta.Total, ParameterDirection.Input);

                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al actualizar Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void eliminarFactura(objFacturaVenta objFacturaVenta)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tfactura_venta_eliminar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_COD_FACT_VENTA", OracleDbType.Int32, objFacturaVenta.Cod_Fact_Venta, ParameterDirection.Input);

                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al eliminar Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

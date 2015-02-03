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
    public class cadProveedoresXAdquisiciones
    {
        public DataTable consultarAdquisicionesDeProveedores()
        {
            DataTable tablaAdquisicionesDeProveedores = new DataTable();
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tpro_tadqui_mostrar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("c_adquisiciones_proveedores", OracleDbType.RefCursor, ParameterDirection.Output);

                OracleDataReader dataReader = conn.cmd.ExecuteReader();

                tablaAdquisicionesDeProveedores.Load(dataReader);

                conn.connection.Close();
                return tablaAdquisicionesDeProveedores;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al consultar Adquisiciones de Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tablaAdquisicionesDeProveedores;
            }
        }

        public void insertarAdquisicionDeProveedor(objProveedoresXAdquisiciones objProveedorXAdquisicion)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tpro_tadqui_insertar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_cod_proveedor", OracleDbType.Int32, objProveedorXAdquisicion.Cod_Proveedor, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_cod_fact_compra", OracleDbType.Int32, objProveedorXAdquisicion.Cod_Fact_Compra, ParameterDirection.Input);

                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al insertar Adquisición de Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean consultarAdquisicionDeProveedorCodigoProveedorCodigoFacturaCompra(objProveedoresXAdquisiciones objProveedorXAdquisicion)
        {
            Boolean proveedorAdquisicionEncontrado = false;
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tpro_tadqui_existente", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_cod_proveedor", OracleDbType.Int32, objProveedorXAdquisicion.Cod_Proveedor, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_cod_fact_compra", OracleDbType.Int32, objProveedorXAdquisicion.Cod_Fact_Compra, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_encontrado", OracleDbType.Int32, ParameterDirection.Output);

                conn.cmd.ExecuteReader();

                int proveedorAdquisicionEncontradoDevuelto = Convert.ToInt32(conn.cmd.Parameters["v_encontrado"].Value.ToString());

                if (proveedorAdquisicionEncontradoDevuelto > 0)
                {
                    proveedorAdquisicionEncontrado = true;
                }

                conn.cmd.Dispose();
                conn.connection.Close();
                return proveedorAdquisicionEncontrado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al consultar Adquisición de Proveedor con la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return proveedorAdquisicionEncontrado;
            }
        }

        public void eliminarAdquisicionDeProveedor(objProveedoresXAdquisiciones objProveedorXAdquisicion)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tpro_tadqui_eliminar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_cod_proveedor", OracleDbType.Int32, objProveedorXAdquisicion.Cod_Proveedor, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_cod_fact_compra", OracleDbType.Int32, objProveedorXAdquisicion.Cod_Fact_Compra, ParameterDirection.Input);

                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al eliminar Adquisición de Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

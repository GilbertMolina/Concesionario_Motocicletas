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
    public class cadEmpleados
    {
        public DataTable consultarEmpleados(int estado)
        {
            DataTable tablaEmpleados = new DataTable();
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                if (estado == 1)
                {
                    conn.cmd = new OracleCommand("sp_templeados_activos_mostrar", conn.connection);
                }
                else if (estado == 2)
                {
                    conn.cmd = new OracleCommand("sp_templeados_nactivos_mostrar", conn.connection);
                }
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("c_empleados", OracleDbType.RefCursor, ParameterDirection.Output);

                OracleDataReader dataReader = conn.cmd.ExecuteReader();

                tablaEmpleados.Load(dataReader);

                conn.connection.Close();
                return tablaEmpleados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al consultar Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tablaEmpleados;
            }
        }

        public DataTable consultarEmpleadosNoGerentes()
        {
            DataTable tablaEmpleados = new DataTable();
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_templeados_no_gerentes", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("c_empleados", OracleDbType.RefCursor, ParameterDirection.Output);

                OracleDataReader dataReader = conn.cmd.ExecuteReader();

                tablaEmpleados.Load(dataReader);

                conn.connection.Close();
                return tablaEmpleados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al consultar Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tablaEmpleados;
            }
        }

        public DataTable consultarEmpleadosTaller()
        {
            DataTable tablaEmpleados = new DataTable();
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_templeados_taller", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("c_empleados", OracleDbType.RefCursor, ParameterDirection.Output);

                OracleDataReader dataReader = conn.cmd.ExecuteReader();

                tablaEmpleados.Load(dataReader);

                conn.connection.Close();
                return tablaEmpleados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al consultar Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tablaEmpleados;
            }
        }

        public void insertarEmpleado(objEmpleados objEmpleado)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_templeados_insertar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_cedula", OracleDbType.Varchar2, objEmpleado.Cedula, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_nombre", OracleDbType.Varchar2, objEmpleado.Nombre, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_apellidos", OracleDbType.Varchar2, objEmpleado.Apellidos, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_cod_departamento", OracleDbType.Int32, objEmpleado.Cod_Departamento, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_telefono", OracleDbType.Int32, objEmpleado.Telefono, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_correo", OracleDbType.Varchar2, objEmpleado.Correo, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_salario", OracleDbType.Double, objEmpleado.Salario, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_fecha_contrato", OracleDbType.Date, objEmpleado.Fecha_Contrato, ParameterDirection.Input);

                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al insertar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean consultarEmpleadoCedula(objEmpleados objEmpleado)
        {
            Boolean empleadoEncontrado = false;
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_templeados_existente", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_cedula", OracleDbType.Varchar2, objEmpleado.Cedula, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_correo", OracleDbType.Varchar2, objEmpleado.Correo, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_encontrado", OracleDbType.Int32, ParameterDirection.Output);

                conn.cmd.ExecuteReader();

                int empleadoEncontradoDevuelto = Convert.ToInt32(conn.cmd.Parameters["v_encontrado"].Value.ToString());

                if (empleadoEncontradoDevuelto > 0)
                {
                    empleadoEncontrado = true;
                }

                conn.cmd.Dispose();
                conn.connection.Close();
                return empleadoEncontrado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al consultar Empleado con la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return empleadoEncontrado;
            }
        }

        public void actualizarEmpleado(objEmpleados objEmpleado)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_templeados_actualizar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_cod_empleado", OracleDbType.Int32, objEmpleado.Cod_Empleado, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_nombre", OracleDbType.Varchar2, objEmpleado.Nombre, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_apellidos", OracleDbType.Varchar2, objEmpleado.Apellidos, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_cod_departamento", OracleDbType.Int32, objEmpleado.Cod_Departamento, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_telefono", OracleDbType.Int32, objEmpleado.Telefono, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_salario", OracleDbType.Double, objEmpleado.Salario, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_fecha_contrato", OracleDbType.Date, objEmpleado.Fecha_Contrato, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_fecha_despido", OracleDbType.Date, objEmpleado.Fecha_Despido, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_estado", OracleDbType.Int32, objEmpleado.Estado, ParameterDirection.Input);

                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al actualizar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void eliminarEmpleado(objEmpleados objEmpleado)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_templeados_eliminar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_cod_empleado", OracleDbType.Int32, objEmpleado.Cod_Empleado, ParameterDirection.Input);

                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                if(ex.Message.Contains("ORA-02292")){
                    MessageBox.Show("Error: El Empleado seleccionado es administrador de un Departamento actualmente, debe quitar el administrador del departamento y luego proceda a eliminar el empleado", "Error al eliminar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else{
                    MessageBox.Show("Error: " + ex.Message, "Error al eliminar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}

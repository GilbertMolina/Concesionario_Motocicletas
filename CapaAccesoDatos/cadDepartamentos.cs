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
    public class cadDepartamentos
    {
        public DataTable consultarDepartamentos()
        {
            DataTable tablaDepartamentos = new DataTable();
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tdepartamentos_mostrar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("c_departamentos", OracleDbType.RefCursor, ParameterDirection.Output);

                OracleDataReader dataReader = conn.cmd.ExecuteReader();

                tablaDepartamentos.Load(dataReader);

                conn.connection.Close();
                return tablaDepartamentos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al consultar Departamentos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tablaDepartamentos;
            }
        }

        public void insertarDepartamento(objDepartamentos objDepartamento, objDepartamentos objDepartamentoAdministrador)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tdepartamentos_insertar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;
                
                if (objDepartamentoAdministrador.Nombre == "")
                {
                    conn.cmd.Parameters.Add("v_nombre", OracleDbType.Varchar2, objDepartamento.Nombre, ParameterDirection.Input);
                    conn.cmd.Parameters.Add("v_cod_administrador", OracleDbType.Varchar2, objDepartamentoAdministrador.Nombre, ParameterDirection.Input);
                }
                else
                {
                    conn.cmd.Parameters.Add("v_nombre", OracleDbType.Varchar2, objDepartamento.Nombre, ParameterDirection.Input);
                    conn.cmd.Parameters.Add("v_cod_administrador", OracleDbType.Int32, objDepartamento.Cod_Administrador, ParameterDirection.Input);
                }
                
                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al insertar Departamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean consultarDepartamentoNombre(objDepartamentos objDepartamento)
        {
            Boolean departamentoEncontrado = false;
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tdepartamentos_existente", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_nombre", OracleDbType.Varchar2, objDepartamento.Nombre, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_encontrado", OracleDbType.Int32, ParameterDirection.Output);

                conn.cmd.ExecuteReader();

                int departamentoEncontradoDevuelto = Convert.ToInt32(conn.cmd.Parameters["v_encontrado"].Value.ToString());

                if (departamentoEncontradoDevuelto > 0)
                {
                    departamentoEncontrado = true;
                }

                conn.cmd.Dispose();
                conn.connection.Close();
                return departamentoEncontrado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al consultar Departamento con la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return departamentoEncontrado;
            }
        }

        public void actualizarDepartamento(objDepartamentos objDepartamento, objDepartamentos objDepartamentoAdministrador)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tdepartamentos_actualizar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                if (objDepartamentoAdministrador.Nombre == "")
                {
                    conn.cmd.Parameters.Add("v_departamento_id", OracleDbType.Int32, objDepartamento.Cod_Departamento, ParameterDirection.Input);
                    conn.cmd.Parameters.Add("v_nombre", OracleDbType.Varchar2, objDepartamento.Nombre, ParameterDirection.Input);
                    conn.cmd.Parameters.Add("v_administrador_id", OracleDbType.Varchar2, objDepartamentoAdministrador.Nombre, ParameterDirection.Input);
                }
                else
                {
                    conn.cmd.Parameters.Add("v_departamento_id", OracleDbType.Int32, objDepartamento.Cod_Departamento, ParameterDirection.Input);
                    conn.cmd.Parameters.Add("v_nombre", OracleDbType.Varchar2, objDepartamento.Nombre, ParameterDirection.Input);
                    conn.cmd.Parameters.Add("v_administrador_id", OracleDbType.Int32, objDepartamento.Cod_Administrador, ParameterDirection.Input);
                }

                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al actualizar Departamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void eliminarDepartamento(objDepartamentos objDepartamento)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tdepartamentos_eliminar", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_departamento_id", OracleDbType.Int32, objDepartamento.Cod_Departamento, ParameterDirection.Input);

                conn.cmd.ExecuteReader();

                conn.cmd.Dispose();
                conn.connection.Close();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("ORA-02292"))
                {
                    MessageBox.Show("Error: El Departamento seleccionado contiene Empleados, elimine los empleados o muevalos a otro departamento y luego proceda a eliminar el departamento", "Error al eliminar Departamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message, "Error al eliminar Departamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}

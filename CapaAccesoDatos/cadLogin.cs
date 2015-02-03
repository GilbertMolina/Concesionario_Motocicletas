using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Objetos;
using Oracle.DataAccess.Client;
using System.Windows.Forms;

namespace CapaAccesoDatos
{
    public class cadLogin
    {
        public objLogin consultarUsuarios(objLogin usuario)
        {
            try
            {
                OracleConexion conn = new OracleConexion();
                if (conn.connection.State == ConnectionState.Closed)
                {
                    conn.connection.Open();
                }
                conn.cmd = new OracleCommand("sp_tlogin_buscar_username", conn.connection);
                conn.cmd.CommandType = CommandType.StoredProcedure;

                conn.cmd.Parameters.Add("v_username", OracleDbType.Varchar2, usuario.Username, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_contrasena", OracleDbType.Varchar2, usuario.Contrasena, ParameterDirection.Input);
                conn.cmd.Parameters.Add("v_number_users", OracleDbType.Int32, ParameterDirection.Output);
                
                conn.cmd.ExecuteReader();

                int usuarioEncontrado = Convert.ToInt32(conn.cmd.Parameters["v_number_users"].Value.ToString());

                if (usuarioEncontrado > 0)
                {
                    usuario.Username = conn.cmd.Parameters["v_username"].Value.ToString();
                }
                else
                {
                    usuario.Username = "NULL";
                }

                conn.cmd.Dispose();
                conn.connection.Close();
                return usuario;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al consultar usuario con la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usuario.Username = "NULL";
                return usuario;
            }
        }

    }

}

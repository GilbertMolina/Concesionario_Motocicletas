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
    public class OracleConexion
    {
        private String conectionString_value;
        private OracleConnection conn_value;
        private OracleCommand cmd_value;

        public String conectionString
        {
            get
            {
                return conectionString_value;
            }
            set
            {
                conectionString_value = value;
            }
        }

        public OracleConnection connection
        {
            get
            {
                return conn_value;
            }
            set
            {
                conn_value = value;
            }
        }

        public OracleCommand cmd
        {
            get
            {
                return cmd_value;
            }
            set
            {
                cmd_value = value;
            }
        }

        public OracleConexion()
        {
            // Para pegarse a una base datos en otro servidor
            // this.conectionString = "Data Source=192.168.161.129;User Id=sysdba;Password=sysdba;";
            // ó
            // this.conectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.161.129)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));User Id=sysdba;Password=sysdba;";

            // El string de conexion que estaba antes, el problema es que no se le pasa a que base de datos tiene que pegarse
            // this.conectionString = "Data Source=localhost;User Id=sysdba;Password=sysdba;";

            // String de conexion mas completo
            this.conectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));User Id=sysdba;Password=sysdba;";
            this.connection = new OracleConnection(this.conectionString);
        }

    }

}

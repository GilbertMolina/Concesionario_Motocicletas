using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class objLogin
    {
        private String Username_value;
        private String Nombre_value;
        private String Apellidos_value;
        private String Contrasena_value;
        private int Estado_value;

        public String Username
        {
            get
            {
                return Username_value;
            }
            set
            {
                Username_value = value;
            }
        }

        public String Nombre
        {
            get
            {
                return Nombre_value;
            }
            set
            {
                Nombre_value = value;
            }
        }

        public String Apellidos
        {
            get
            {
                return Apellidos_value;
            }
            set
            {
                Apellidos_value = value;
            }
        }

        public String Contrasena
        {
            get
            {
                return Contrasena_value;
            }
            set
            {
                Contrasena_value = value;
            }
        }

        public int Estado
        {
            get
            {
                return Estado_value;
            }
            set
            {
                Estado_value = value;
            }
        }

        public objLogin()
        {
        }

        public objLogin(string p_Username, String p_Nombre, String p_Apellidos, String p_Contrasena, int p_Estado)
        {
            this.Username = p_Username;
            this.Nombre = p_Nombre;
            this.Apellidos = p_Apellidos;
            this.Contrasena = p_Contrasena;
            this.Estado = p_Estado;
        }

    }

}

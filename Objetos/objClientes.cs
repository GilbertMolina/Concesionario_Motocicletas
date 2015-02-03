using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class objClientes
    {
        private int Cod_Cliente_value;
        private String Cedula_value;
        private String Apellidos_value;
        private int Telefono_value;
        private String Direccion_value;
        private String Ciudad_value;
        private String Nombre_value;

        public int Cod_Ciente
        {
            get
            {
                return Cod_Cliente_value;
            }
            set
            {
                Cod_Cliente_value = value;
            }
        }

        public String Cedula
        {
            get
            {
                return Cedula_value;
            }
            set
            {
                Cedula_value = value;
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

        public int Telefono
        {
            get
            {
                return Telefono_value;
            }
            set
            {
                Telefono_value = value;
            }
        }

        public String Direccion
        {
            get
            {
                return Direccion_value;
            }
            set
            {
                Direccion_value = value;
            }
        }

        public String Ciudad
        {
            get
            {
                return Ciudad_value;
            }
            set
            {
                Ciudad_value = value;
            }
        }

        public objClientes()
        {
        }

        public objClientes(int p_Cod_Ciente, String p_Cedula, String p_Nombre, String p_Apellidos, int p_Telefono, String p_Direccion, String p_Ciudad)
        {
            this.Cod_Cliente_value = p_Cod_Ciente;
            this.Cedula = p_Cedula;
            this.Nombre = p_Nombre;
            this.Apellidos = p_Apellidos;
            this.Telefono = p_Telefono;
            this.Direccion = p_Direccion;
            this.Ciudad = p_Ciudad;

        }

    }
}

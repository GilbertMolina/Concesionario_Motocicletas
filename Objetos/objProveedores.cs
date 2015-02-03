using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class objProveedores
    {
        private int Cod_Proveedor_value;
        private String Cedula_Juridica_value;
        private String Nombre_value;
        private String Razon_Social_value;
        private String Descripcion_Servicio_value;

        public int Cod_Proveedor
        {
            get
            {
                return Cod_Proveedor_value;
            }
            set
            {
                Cod_Proveedor_value = value;
            }
        }

        public String Cedula_Juridica
        {
            get
            {
                return Cedula_Juridica_value;
            }
            set
            {
                Cedula_Juridica_value = value;
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

        public String Razon_Social
        {
            get
            {
                return Razon_Social_value;
            }
            set
            {
                Razon_Social_value = value;
            }
        }

        public String Descripcion_Servicio
        {
            get
            {
                return Descripcion_Servicio_value;
            }
            set
            {
                Descripcion_Servicio_value = value;
            }
        }

        public objProveedores()
        {
        }

        public objProveedores(int p_Cod_Proveedor, String p_Cedula_Juridica, String p_Nombre, String p_Razon_Social, String p_Descripcion_Servicio)
        {
            this.Cod_Proveedor = p_Cod_Proveedor;
            this.Cedula_Juridica = p_Cedula_Juridica;
            this.Nombre = p_Nombre;
            this.Razon_Social = p_Razon_Social;
            this.Descripcion_Servicio = p_Descripcion_Servicio;
        }

    }
}

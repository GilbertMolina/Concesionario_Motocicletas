using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class objServicios
    {
        private String Cod_Servicio_value;
        private int Cod_Empleado_value;
        private String Tipo_value;
        private double Precio_value;
        private String Descripcion_value;

        public String Cod_Servicio
        {
            get
            {
                return Cod_Servicio_value;
            }
            set
            {
                Cod_Servicio_value = value;
            }
        }

        public int Cod_Empleado
        {
            get
            {
                return Cod_Empleado_value;
            }
            set
            {
                Cod_Empleado_value = value;
            }
        }

        public String Tipo
        {
            get
            {
                return Tipo_value;
            }
            set
            {
                Tipo_value = value;
            }
        }

        public double Precio
        {
            get
            {
                return Precio_value;
            }
            set
            {
                Precio_value = value;
            }
        }

        public String Descripcion
        {
            get
            {
                return Descripcion_value;
            }
            set
            {
                Descripcion_value = value;
            }
        }

        public objServicios()
        {
        }

        public objServicios(String p_Cod_Servicio, int p_Cod_Empleado, String p_Tipo, double p_Precio, String p_Descripcion)
        {
            this.Cod_Servicio = p_Cod_Servicio;
            this.Cod_Empleado = p_Cod_Empleado;
            this.Tipo = p_Tipo;
            this.Precio = p_Precio;
            this.Descripcion = p_Descripcion;
        }

    }
}

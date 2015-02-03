using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class objRepuestos
    {
        private String Cod_Repuesto_value;
        private String Descripcion_value;
        private String Tipo_value;
        private double Precio_value;

        public String Cod_Repuesto
        {
            get
            {
                return Cod_Repuesto_value;
            }
            set
            {
                Cod_Repuesto_value = value;
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

        public objRepuestos()
        {
        }

        public objRepuestos(String p_Cod_Repuesto, String p_Descripcion, String p_Tipo, double p_Precio)
        {
            this.Cod_Repuesto = p_Cod_Repuesto;
            this.Descripcion = p_Descripcion;
            this.Tipo = p_Tipo;
            this.Precio = p_Precio;
        }

    }
}

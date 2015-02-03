using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class objVehiculoNuevo : objVehiculo
    {
        private String Primer_Mantenimiento_value;

        public String Primer_Mantenimiento
        {
            get
            {
                return Primer_Mantenimiento_value;
            }
            set
            {
                Primer_Mantenimiento_value = value;
            }
        }

        public objVehiculoNuevo()
        {
        }

        public objVehiculoNuevo(String p_Cod_Vehiculo, String p_Marca, String p_Modelo, String p_Color, double p_Precio_Unitario, String p_Garantia, String p_Especificaciones, String p_Primer_Mantenimiento)
            : base(p_Cod_Vehiculo, p_Marca, p_Modelo, p_Color, p_Precio_Unitario, p_Garantia, p_Especificaciones)
        {
            this.Primer_Mantenimiento = p_Primer_Mantenimiento;
        }

    }
}

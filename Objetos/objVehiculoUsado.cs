using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class objVehiculoUsado : objVehiculo
    {
        private string Numero_Placa_value;
        private int Kilometraje_value;
        private String Estado_value;

        public string Numero_Placa
        {
            get
            {
                return Numero_Placa_value;
            }
            set
            {
                Numero_Placa_value = value;
            }
        }

        public int Kilometraje
        {
            get
            {
                return Kilometraje_value;
            }
            set
            {
                Kilometraje_value = value;
            }
        }

        public String Estado
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

        public objVehiculoUsado()
        {
        }

        public objVehiculoUsado(String p_Cod_Vehiculo, String p_Marca, String p_Modelo, String p_Color, double p_Precio_Unitario, String p_Garantia, String p_Especificaciones, string p_Numero_Placa, int p_Kilometraje, String p_Estado) 
            :base(p_Cod_Vehiculo, p_Marca, p_Modelo, p_Color, p_Precio_Unitario, p_Garantia, p_Especificaciones)
        {
            this.Numero_Placa = p_Numero_Placa;
            this.Kilometraje = p_Kilometraje;
            this.Estado = p_Estado;
        }

    }
}

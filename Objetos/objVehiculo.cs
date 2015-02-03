using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class objVehiculo
    {
        private String Cod_Vehiculo_value;
        private String Marca_value;
        private String Modelo_value;
        private String Color_value;
        private double Precio_Unitario_value;
        private String Garantia_value;
        private String Especificaciones_value;

        public String Cod_Vehiculo
        {
            get
            {
                return Cod_Vehiculo_value;
            }
            set
            {
                Cod_Vehiculo_value = value;
            }
        }

        public String Marca
        {
            get
            {
                return Marca_value;
            }
            set
            {
                Marca_value = value;
            }
        }

        public String Modelo
        {
            get
            {
                return Modelo_value;
            }
            set
            {
                Modelo_value = value;
            }
        }

        public String Color
        {
            get
            {
                return Color_value;
            }
            set
            {
                Color_value = value;
            }
        }

        public double Precio_Unitario
        {
            get
            {
                return Precio_Unitario_value;
            }
            set
            {
                Precio_Unitario_value = value;
            }
        }

        public String Garantia
        {
            get
            {
                return Garantia_value;
            }
            set
            {
                Garantia_value = value;
            }
        }

        public String Especificaciones
        {
            get
            {
                return Especificaciones_value;
            }
            set
            {
                Especificaciones_value = value;
            }
        }

        public objVehiculo()
        {
        }

        public objVehiculo(String p_Cod_Vehiculo, String p_Marca, String p_Modelo, String p_Color, double p_Precio_Unitario, String p_Garantia, String p_Especificaciones)
        {
            this.Cod_Vehiculo = p_Cod_Vehiculo;
            this.Marca = p_Marca;
            this.Modelo = p_Modelo;
            this.Color = p_Color;
            this.Precio_Unitario = p_Precio_Unitario;
            this.Garantia = p_Garantia;
            this.Especificaciones = p_Especificaciones;
        }

    }
}

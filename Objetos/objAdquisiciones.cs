using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class objAdquisiciones
    {
        private int Cod_Fact_Compra_value;
        private String Cod_Vehiculo_value;
        private String Cod_Repuesto_value;
        private int Cantidad_Unidades_value;
        private double Valor_value;
        private DateTime Fecha_Compra_value;

        public int Cod_Fact_Compra
        {
            get
            {
                return Cod_Fact_Compra_value;
            }
            set
            {
                Cod_Fact_Compra_value = value;
            }
        }

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

        public int Cantidad_Unidades
        {
            get
            {
                return Cantidad_Unidades_value;
            }
            set
            {
                Cantidad_Unidades_value = value;
            }
        }

        public double Valor
        {
            get
            {
                return Valor_value;
            }
            set
            {
                Valor_value = value;
            }
        }

        public DateTime Fecha_Compra
        {
            get
            {
                return Fecha_Compra_value;
            }
            set
            {
                Fecha_Compra_value = value;
            }
        }

        public objAdquisiciones()
        {
        }

        public objAdquisiciones(int p_Cod_Fact_Compra, String p_Cod_Vehiculo, String p_Cod_Repuesto, int p_Cantidad_Unidades, double p_Valor, DateTime p_Fecha_Compra)
        {
            this.Cod_Fact_Compra = p_Cod_Fact_Compra;
            this.Cod_Vehiculo = p_Cod_Vehiculo;
            this.Cod_Repuesto = p_Cod_Repuesto;
            this.Cantidad_Unidades = p_Cantidad_Unidades;
            this.Valor = p_Valor;
            this.Fecha_Compra = p_Fecha_Compra;
        }
    }
}

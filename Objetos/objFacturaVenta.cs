using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class objFacturaVenta
    {
        private int Cod_Fact_Venta_value;
        private int Cod_Empleado_value;
        private int Cod_Cliente_value;
        private DateTime Fecha_Venta_value;
        private double Total_value;

        public int Cod_Fact_Venta
        {
            get
            {
                return Cod_Fact_Venta_value;
            }
            set
            {
                Cod_Fact_Venta_value = value;
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

        public int Cod_Cliente
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

        public DateTime Fecha_Venta
        {
            get
            {
                return Fecha_Venta_value;
            }
            set
            {
                Fecha_Venta_value = value;
            }
        }

        public double Total
        {
            get
            {
                return Total_value;
            }
            set
            {
                Total_value = value;
            }
        }

        public objFacturaVenta()
        {
        }

        public objFacturaVenta(int p_Cod_Fact_Venta, int vCod_Empleado, int p_Cod_Cliente, DateTime p_Fecha_Venta, double p_Total)
        {
            this.Cod_Fact_Venta = p_Cod_Fact_Venta;
            this.Cod_Cliente = p_Cod_Cliente;
            this.Fecha_Venta = p_Fecha_Venta;
            this.Total = p_Total;
        }

    }
}

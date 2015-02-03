using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class objDetalleVenta
    {
        private int Cod_Detalle_Venta_value;
        private int Cod_Fact_Venta_value;
        private String Cod_Producto_value;
        private int Cantidad_value;
        private double Precio_Unitario_value;
        private double Subtotal_value;
        private String Comentarios_value;

        public int Cod_Detalle_Venta
        {
            get
            {
                return Cod_Detalle_Venta_value;
            }
            set
            {
                Cod_Detalle_Venta_value = value;
            }
        }

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

        public String Cod_Producto
        {
            get
            {
                return Cod_Producto_value;
            }
            set
            {
                Cod_Producto_value = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return Cantidad_value;
            }
            set
            {
                Cantidad_value = value;
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

        public double Subtotal
        {
            get
            {
                return Subtotal_value;
            }
            set
            {
                Subtotal_value = value;
            }
        }

        public String Comentarios
        {
            get
            {
                return Comentarios_value;
            }
            set
            {
                Comentarios_value = value;
            }
        }

        public objDetalleVenta()
        {
        }

        public objDetalleVenta(int p_Cod_Detalle_Venta, int p_Cod_Fact_Venta, String p_Cod_Producto, int p_Cantidad, double p_Precio_Unitario, double p_Subtotal, String p_Comentarios)
        {
            this.Cod_Detalle_Venta = p_Cod_Detalle_Venta;
            this.Cod_Fact_Venta = p_Cod_Fact_Venta;
            this.Cod_Producto = p_Cod_Producto;
            this.Cantidad = p_Cantidad;
            this.Precio_Unitario = p_Precio_Unitario;
            this.Subtotal = p_Subtotal;
            this.Comentarios = p_Comentarios;
        }

    }
}

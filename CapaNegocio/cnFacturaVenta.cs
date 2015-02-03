using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using CapaAccesoDatos;
using Objetos;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class cnFacturaVenta
    {
        private cadFacturaVenta cadFacturaVenta;

        public Boolean insertarFactura(objFacturaVenta objFacturaVenta, objDetalleVenta objDetalleVenta)
        {
            this.cadFacturaVenta.insertarFactura(objFacturaVenta, objDetalleVenta);
                return true;
        }

        public void actualizarFactura(objFacturaVenta objFacturaVenta)
        {
            this.cadFacturaVenta.actualizarFactura(objFacturaVenta);
        }

        public DataTable consultarFacturas()
        {
            return this.cadFacturaVenta.consultarFactura();
        }

        public void eliminarFactura(objFacturaVenta objFacturaVenta)
        {
            this.cadFacturaVenta.eliminarFactura(objFacturaVenta);
        }

        public cnFacturaVenta()
        {
            this.cadFacturaVenta = new cadFacturaVenta();
        }

        public DataTable consultarRepuestosFactura()
        {
            return this.cadFacturaVenta.consultarRepuestosFactura();
        }

        public DataTable consultarVehiculoNuevo()
        {
            return this.cadFacturaVenta.consultarVehiculoNuevo();
        }

        public DataTable consultarVehiculoUsado()
        {
            return this.cadFacturaVenta.consultarVehiculoUsado();
        }
    }
}

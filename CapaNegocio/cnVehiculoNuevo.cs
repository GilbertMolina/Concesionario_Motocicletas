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
    public class cnVehiculoNuevo
    {
        private cadVehiculoNuevo cadVehiculosNuevos;

        public Boolean insertarVehiculoNuevo(objVehiculoNuevo objVehiculoNuevos)
        {
            Boolean vehiculoEncontrado = false;

            objVehiculoNuevo objVehiculoNuevoConsultado = new objVehiculoNuevo();

            objVehiculoNuevoConsultado.Marca = objVehiculoNuevos.Marca;
            objVehiculoNuevoConsultado.Modelo = objVehiculoNuevos.Modelo;
            objVehiculoNuevoConsultado.Color = objVehiculoNuevos.Color;

            vehiculoEncontrado = this.cadVehiculosNuevos.consultarVehiculoMarcaModeloColor(objVehiculoNuevoConsultado);

            if (vehiculoEncontrado == false)
            {
                this.cadVehiculosNuevos.insertarVehiculoNuevo(objVehiculoNuevos);
                return true;
            }
            else
            {
                MessageBox.Show("Error: Ya existe un lote de vehículos de la misma marca, modelo y color en la base de datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        public void actualizarVehiculoNuevo(objVehiculoNuevo objVehiculoNuevos)
        {
            this.cadVehiculosNuevos.actualizarVehiculoNuevo(objVehiculoNuevos);
        }

        public DataTable consultarVehiculosNuevos()
        {
            return this.cadVehiculosNuevos.consultarVehiculosNuevos();
        }

        public void eliminarVehiculoNuevo(objVehiculoNuevo objVehiculoNuevo)
        {
            this.cadVehiculosNuevos.eliminarVehiculoNuevo(objVehiculoNuevo);
        }

        public cnVehiculoNuevo()
        {
            this.cadVehiculosNuevos = new cadVehiculoNuevo();
        }

    }
}

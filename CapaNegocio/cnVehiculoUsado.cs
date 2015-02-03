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
    public class cnVehiculoUsado
    {
        private cadVehiculoUsado cadVehiculosUsados;

        public Boolean insertarVehiculoUsado(objVehiculoUsado objVehiculoUsados)
        {
            Boolean vehiculoEncontrado = false;

            objVehiculoUsado objVehiculoUsadoConsultado = new objVehiculoUsado();

            objVehiculoUsadoConsultado.Numero_Placa = objVehiculoUsados.Numero_Placa;

            vehiculoEncontrado = this.cadVehiculosUsados.consultarVehiculoNumeroPlaca(objVehiculoUsadoConsultado);

            if (vehiculoEncontrado == false)
            {
                this.cadVehiculosUsados.insertarVehiculoUsado(objVehiculoUsados);
                return true;
            }
            else
            {
                MessageBox.Show("Error: Ya existe un vehiculo con la misma placa en la base de datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        public void actualizarVehiculoUsado(objVehiculoUsado objVehiculoUsados)
        {
            this.cadVehiculosUsados.actualizarVehiculoUsado(objVehiculoUsados);
        }

        public DataTable consultarVehiculosUsados()
        {
            return this.cadVehiculosUsados.consultarVehiculosUsados();
        }

        public void eliminarVehiculoUsado(objVehiculoUsado objVehiculoUsados)
        {
            this.cadVehiculosUsados.eliminarVehiculoUsado(objVehiculoUsados);
        }

        public cnVehiculoUsado()
        {
            this.cadVehiculosUsados = new cadVehiculoUsado();
        }
    }
}

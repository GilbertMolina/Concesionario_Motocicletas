using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class objProveedoresXAdquisiciones
    {
        private int Cod_Proveedor_value;
        private int Cod_Fact_Compra_value;

        public int Cod_Proveedor
        {
            get
            {
                return Cod_Proveedor_value;
            }
            set
            {
                Cod_Proveedor_value = value;
            }
        }

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

        public objProveedoresXAdquisiciones()
        {
        }

        public objProveedoresXAdquisiciones(int p_Cod_Proveedor, int p_Cod_Fact_Compra)
        {
            this.Cod_Proveedor = p_Cod_Proveedor;
            this.Cod_Fact_Compra = p_Cod_Fact_Compra;
        }

    }
}

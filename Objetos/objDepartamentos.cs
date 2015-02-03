using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class objDepartamentos
    {
        private int Cod_Departamento_value;
        private String Nombre_value;
        private int Cod_Administrador_value;

        public int Cod_Departamento
        {
            get
            {
                return Cod_Departamento_value;
            }
            set
            {
                Cod_Departamento_value = value;
            }
        }

        public String Nombre
        {
            get
            {
                return Nombre_value;
            }
            set
            {
                Nombre_value = value;
            }
        }

        public int Cod_Administrador
        {
            get
            {
                return Cod_Administrador_value;
            }
            set
            {
                Cod_Administrador_value = value;
            }
        }

        public objDepartamentos()
        {
        }

        public objDepartamentos(int p_Cod_Departamento, String p_Nombre, int p_Cod_Administrador)
        {
            this.Cod_Departamento = p_Cod_Departamento;
            this.Nombre = p_Nombre;
            this.Cod_Administrador = p_Cod_Administrador;
        }

    }
}

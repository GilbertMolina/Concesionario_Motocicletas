using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class objEmpleados
    {
        private int Cod_Empleado_value;
        private String Cedula_value;
        private String Nombre_value;
        private String Apellidos_value;
        private int Cod_Departamento_value;
        private int Telefono_value;
        private String Correo_value;
        private String Salario_value;
        private DateTime Fecha_Contrato_value;
        private DateTime Fecha_Despido_value;
        private int Estado_value;

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

        public String Cedula
        {
            get
            {
                return Cedula_value;
            }
            set
            {
                Cedula_value = value;
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

        public String Apellidos
        {
            get
            {
                return Apellidos_value;
            }
            set
            {
                Apellidos_value = value;
            }
        }

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

        public int Telefono
        {
            get
            {
                return Telefono_value;
            }
            set
            {
                Telefono_value = value;
            }
        }

        public String Correo
        {
            get
            {
                return Correo_value;
            }
            set
            {
                Correo_value = value;
            }
        }

        public String Salario
        {
            get
            {
                return Salario_value;
            }
            set
            {
                Salario_value = value;
            }
        }

        public DateTime Fecha_Contrato
        {
            get
            {
                return Fecha_Contrato_value;
            }
            set
            {
                Fecha_Contrato_value = value;
            }
        }

        public DateTime Fecha_Despido
        {
            get
            {
                return Fecha_Despido_value;
            }
            set
            {
                Fecha_Despido_value = value;
            }
        }

        public int Estado
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

        public objEmpleados()
        {
        }

        public objEmpleados(int p_Cod_Empleado, String p_Cedula, String p_Nombre, String p_Apellidos, int p_Cod_Departamento, int p_Telefono, String p_Correo, String p_Salario, DateTime p_Fecha_Contrato, DateTime p_Fecha_Despido, int p_Estado)
        {
            this.Cod_Empleado = p_Cod_Empleado;
            this.Cedula = p_Cedula;
            this.Nombre = p_Nombre;
            this.Apellidos = p_Apellidos;
            this.Cod_Departamento = p_Cod_Departamento;
            this.Telefono = p_Telefono;
            this.Correo = p_Correo;
            this.Salario = p_Salario;
            this.Fecha_Contrato = p_Fecha_Contrato;
            this.Fecha_Despido = p_Fecha_Despido;
            this.Estado = p_Estado;
        }

    }
}

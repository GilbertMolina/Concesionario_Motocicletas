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
    public class cnLogin
    {

        private cadLogin cadUsuario;

        public objLogin consultarUsuario(objLogin usuario)
        {
            return cadUsuario.consultarUsuarios(usuario);
        }

        public cnLogin()
        {
            cadUsuario = new cadLogin();
        }

    }
}

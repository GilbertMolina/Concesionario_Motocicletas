using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;
using Objetos;
using Oracle.DataAccess.Client;

namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cargarToolTips();
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            objLogin usuario = new objLogin();
            objLogin usuarioConsultado = new objLogin();
            cnLogin cnUsuario = new cnLogin();

            if (txtUsername.Text != "" && txtContrasena.Text != "")
            {
                usuario.Username = txtUsername.Text;
                usuario.Contrasena = txtContrasena.Text;
                usuarioConsultado = cnUsuario.consultarUsuario(usuario);
                if (usuarioConsultado.Username != "NULL")
                {
                    mostrarMdiPrincipal(usuario.Username);
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña erronea, por favor intente nuevamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsername.BackColor = Color.Tomato;
                    txtContrasena.BackColor = Color.Tomato;
                }
            }
            else
            {
                MessageBox.Show("Debe digitar los campos del formulario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsername.BackColor = Color.Tomato;
                txtContrasena.BackColor = Color.Tomato;
            }
        }

        public void mostrarMdiPrincipal(String usuarioConectado)
        {
            mdiPrincipal miMdiPrincipal = new mdiPrincipal();
            miMdiPrincipal.comprobarEstadoBaseDeDatos(usuarioConectado);
            miMdiPrincipal.Show();
            this.Visible = false;
        }

        public void cargarToolTips()
        {
            this.tttxtUsername.SetToolTip(txtUsername, "Digite aquí su nombre de usuario");
            this.tttxtUsername.IsBalloon = true;
            this.tttxtContrasena.SetToolTip(txtContrasena, "Digite aquí su contraseña");
            this.tttxtContrasena.IsBalloon = true;
            this.ttbtIniciarSesion.SetToolTip(btIngresar, "Digite su nombre de usuario y contraseña y presione aquí para iniciar sesión");
            this.ttbtIniciarSesion.IsBalloon = true;
        }

    }

}
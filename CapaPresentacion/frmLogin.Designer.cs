namespace CapaPresentacion
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.grpBoxInicioSesion = new System.Windows.Forms.GroupBox();
            this.btIngresar = new System.Windows.Forms.Button();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbContrasenna = new System.Windows.Forms.Label();
            this.lbNombreUsuario = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tttxtUsername = new System.Windows.Forms.ToolTip(this.components);
            this.tttxtContrasena = new System.Windows.Forms.ToolTip(this.components);
            this.ttbtIniciarSesion = new System.Windows.Forms.ToolTip(this.components);
            this.grpBoxInicioSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxInicioSesion
            // 
            this.grpBoxInicioSesion.Controls.Add(this.btIngresar);
            this.grpBoxInicioSesion.Controls.Add(this.txtContrasena);
            this.grpBoxInicioSesion.Controls.Add(this.txtUsername);
            this.grpBoxInicioSesion.Controls.Add(this.lbContrasenna);
            this.grpBoxInicioSesion.Controls.Add(this.lbNombreUsuario);
            this.grpBoxInicioSesion.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxInicioSesion.Location = new System.Drawing.Point(174, 12);
            this.grpBoxInicioSesion.Name = "grpBoxInicioSesion";
            this.grpBoxInicioSesion.Size = new System.Drawing.Size(399, 172);
            this.grpBoxInicioSesion.TabIndex = 15;
            this.grpBoxInicioSesion.TabStop = false;
            this.grpBoxInicioSesion.Text = "Inicio de sesión";
            // 
            // btIngresar
            // 
            this.btIngresar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btIngresar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIngresar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btIngresar.Image = global::CapaPresentacion.Properties.Resources.login;
            this.btIngresar.Location = new System.Drawing.Point(233, 116);
            this.btIngresar.Name = "btIngresar";
            this.btIngresar.Size = new System.Drawing.Size(146, 41);
            this.btIngresar.TabIndex = 3;
            this.btIngresar.Text = "  Iniciar sesión";
            this.btIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btIngresar.UseVisualStyleBackColor = false;
            this.btIngresar.Click += new System.EventHandler(this.btIngresar_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(151, 78);
            this.txtContrasena.MaxLength = 15;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(228, 22);
            this.txtContrasena.TabIndex = 2;
            this.txtContrasena.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(151, 40);
            this.txtUsername.MaxLength = 9;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(228, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // lbContrasenna
            // 
            this.lbContrasenna.AutoSize = true;
            this.lbContrasenna.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContrasenna.Location = new System.Drawing.Point(68, 80);
            this.lbContrasenna.Name = "lbContrasenna";
            this.lbContrasenna.Size = new System.Drawing.Size(77, 17);
            this.lbContrasenna.TabIndex = 1;
            this.lbContrasenna.Text = "Contraseña:";
            // 
            // lbNombreUsuario
            // 
            this.lbNombreUsuario.AutoSize = true;
            this.lbNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreUsuario.Location = new System.Drawing.Point(19, 42);
            this.lbNombreUsuario.Name = "lbNombreUsuario";
            this.lbNombreUsuario.Size = new System.Drawing.Size(126, 17);
            this.lbNombreUsuario.TabIndex = 0;
            this.lbNombreUsuario.Text = "Nombre de usuario:";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::CapaPresentacion.Properties.Resources.UIA_Login;
            this.pbLogo.Location = new System.Drawing.Point(16, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(152, 172);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 16;
            this.pbLogo.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(585, 197);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.grpBoxInicioSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.grpBoxInicioSesion.ResumeLayout(false);
            this.grpBoxInicioSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox grpBoxInicioSesion;
        internal System.Windows.Forms.Button btIngresar;
        internal System.Windows.Forms.TextBox txtContrasena;
        internal System.Windows.Forms.TextBox txtUsername;
        internal System.Windows.Forms.Label lbContrasenna;
        internal System.Windows.Forms.Label lbNombreUsuario;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ToolTip tttxtUsername;
        private System.Windows.Forms.ToolTip tttxtContrasena;
        private System.Windows.Forms.ToolTip ttbtIniciarSesion;
    }
}


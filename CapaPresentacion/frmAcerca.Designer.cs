namespace CapaPresentacion
{
    partial class frmAcerca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcerca));
            this.lbDescripcion5 = new System.Windows.Forms.Label();
            this.lbDescripcion4 = new System.Windows.Forms.Label();
            this.lbDescripcion3 = new System.Windows.Forms.Label();
            this.lbDescripcion2 = new System.Windows.Forms.Label();
            this.lbDescripcion1 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDescripcion5
            // 
            this.lbDescripcion5.AutoSize = true;
            this.lbDescripcion5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion5.Location = new System.Drawing.Point(59, 294);
            this.lbDescripcion5.Name = "lbDescripcion5";
            this.lbDescripcion5.Size = new System.Drawing.Size(171, 30);
            this.lbDescripcion5.TabIndex = 11;
            this.lbDescripcion5.Text = "     Carlos Vega Romero\r\n  Gilberth Molina Castrillo";
            // 
            // lbDescripcion4
            // 
            this.lbDescripcion4.AutoSize = true;
            this.lbDescripcion4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion4.Location = new System.Drawing.Point(59, 267);
            this.lbDescripcion4.Name = "lbDescripcion4";
            this.lbDescripcion4.Size = new System.Drawing.Size(187, 15);
            this.lbDescripcion4.TabIndex = 10;
            this.lbDescripcion4.Text = "Aplicación desarrollada por:";
            // 
            // lbDescripcion3
            // 
            this.lbDescripcion3.AutoSize = true;
            this.lbDescripcion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion3.Location = new System.Drawing.Point(8, 240);
            this.lbDescripcion3.Name = "lbDescripcion3";
            this.lbDescripcion3.Size = new System.Drawing.Size(277, 15);
            this.lbDescripcion3.TabIndex = 9;
            this.lbDescripcion3.Text = "Universidad Internacional de las Américas";
            // 
            // lbDescripcion2
            // 
            this.lbDescripcion2.AutoSize = true;
            this.lbDescripcion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion2.Location = new System.Drawing.Point(50, 214);
            this.lbDescripcion2.Name = "lbDescripcion2";
            this.lbDescripcion2.Size = new System.Drawing.Size(198, 15);
            this.lbDescripcion2.TabIndex = 8;
            this.lbDescripcion2.Text = "Proyecto de Bases de Datos 2";
            // 
            // lbDescripcion1
            // 
            this.lbDescripcion1.AutoSize = true;
            this.lbDescripcion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion1.Location = new System.Drawing.Point(101, 188);
            this.lbDescripcion1.Name = "lbDescripcion1";
            this.lbDescripcion1.Size = new System.Drawing.Size(87, 15);
            this.lbDescripcion1.TabIndex = 6;
            this.lbDescripcion1.Text = "Descripción:";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::CapaPresentacion.Properties.Resources.UIA_Login;
            this.pbLogo.Location = new System.Drawing.Point(78, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(152, 172);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 17;
            this.pbLogo.TabStop = false;
            // 
            // btAceptar
            // 
            this.btAceptar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btAceptar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btAceptar.Location = new System.Drawing.Point(109, 332);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 31);
            this.btAceptar.TabIndex = 18;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = false;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // frmAcerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(294, 377);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lbDescripcion5);
            this.Controls.Add(this.lbDescripcion4);
            this.Controls.Add(this.lbDescripcion3);
            this.Controls.Add(this.lbDescripcion2);
            this.Controls.Add(this.lbDescripcion1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmAcerca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lbDescripcion5;
        internal System.Windows.Forms.Label lbDescripcion4;
        internal System.Windows.Forms.Label lbDescripcion3;
        internal System.Windows.Forms.Label lbDescripcion2;
        internal System.Windows.Forms.Label lbDescripcion1;
        private System.Windows.Forms.PictureBox pbLogo;
        internal System.Windows.Forms.Button btAceptar;
    }
}